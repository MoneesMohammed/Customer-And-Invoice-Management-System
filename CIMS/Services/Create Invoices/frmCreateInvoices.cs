using CIMS.Global_Classes;
using CIMS.Services.Products;
using CIMS.UserControls.CtrlPerson;
using CIMS_BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIMS.Services.Create_Invoices
{
    public partial class frmCreateInvoices : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _SelectedCustomerID = -1;

        private int _InvoiceID = -1;
        private clsInvoice _Invoice;

        private clsInvoiceDetail _InvoiceDetail;

        private DataTable _dtProductsAdded = new DataTable();
        

        public frmCreateInvoices()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmCreateInvoices(int InvoiceID)
        {
            InitializeComponent();
            _InvoiceID = InvoiceID;
            _Mode = enMode.Update;
        }

        private void _GoToTabCreateInvoice()
        {
            tabControl1.Selecting -= tabControl1_Selecting;  // Temporarily unblock
            tabControl1.SelectedTab = tabInvoiceInfo;           // or any other tab
            tabControl1.Selecting += tabControl1_Selecting;  // Reblock

            //btnSave.Enabled = true;
        }

        private void _GoToTabAddProductToInvoice()
        {
            tabControl1.Selecting -= tabControl1_Selecting;    // Temporarily unblock
            tabControl1.SelectedTab = tabAddProductToInvoice;  // or any other tab
            tabControl1.Selecting += tabControl1_Selecting;    // Reblock

            btnSave.Enabled = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedTab != tabCustomerInfo)
                e.Cancel = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _GoToTabCreateInvoice();
                return;
            }

            if (ctrlFilterCustomer1.CustomerID == -1)
            {
                MessageBox.Show($"There is no Customer.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _GoToTabCreateInvoice();
            lblCustomerID.Text = _SelectedCustomerID.ToString("0");
        }

        private void btnNextToAdd_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _GoToTabAddProductToInvoice();
                return;
            }

            if (_InvoiceID == -1)
            {
                MessageBox.Show($"No invoice was created.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _GoToTabAddProductToInvoice();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateInvoices_Load(object sender, EventArgs e)
        {
            _ResetDefualtValue();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetDefualtValue()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Create New Invoice";
                this.Text = "Create New Invoice";
                _Invoice = new clsInvoice();
                _InvoiceDetail = new clsInvoiceDetail();
                //ucFilterPerson1.FilterFocus();
                //tabApplicationInfo.Enabled = false;
                //lblCustomerID.Text = _SelectedCustomerID.ToString("0"); 
                lblInvoiceStatus.Text = "Unpaid";
                lblTotalAmount.Text = "0";
                lblInvoiceDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblMode.Text = "Update Invoice";
                this.Text = "Update Invoice";

                tabControl1.Enabled = true;
                btnSave.Enabled = true;

            }

        }

        private void _LoadData()
        {
            ctrlFilterCustomer1.FilterEnabled = false;
            _Invoice = clsInvoice.Find(_InvoiceID);

            if (_Invoice == null)
            {
                MessageBox.Show($"No Invoice With ID = {_InvoiceID}", "No Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlFilterCustomer1.LoadCustomerInfo(_Invoice.CustomerID);
            lblCustomerID.Text = _Invoice.CustomerID.ToString("0");
            lblInvoiceID.Text = _InvoiceID.ToString();
            lblInvoiceDate.Text = _Invoice.InvoiceDate.ToString("MM/dd/yyyy");
            lblInvoiceStatus.Text = _Invoice.StatusText;
            lblTotalAmount.Text = _Invoice.TotalAmount.ToString();
            lblTotalAmount_1.Text = _Invoice.TotalAmount.ToString();
            lblCreatedBy.Text = clsUser.Find(_Invoice.CreatedByUserID).UserName;

            btnCreate.Enabled = false;
            btnNextToAdd.Enabled = true;

            
            _dtProductsAdded = clsInvoiceDetail.GetAllInvoiceDetails(_InvoiceID);

            

            _RefreshProductsList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                //استعادة مخزون الفاتورة القديمة
                RevertOldInvoiceStock();
                clsInvoiceDetail.DeleteAllInvoiceDetails(_InvoiceID);
            }
                
            
            _Invoice.SetTotalAmount(Convert.ToSingle(lblTotalAmount.Text));

            foreach (DataRow row in _dtProductsAdded.Rows)
            {
                _InvoiceDetail = new clsInvoiceDetail();

                _InvoiceDetail.InvoiceID = _InvoiceID;

                _InvoiceDetail.ProductID = Convert.ToInt32(row["ProductID"]);
                _InvoiceDetail.Quantity  = Convert.ToInt32(row["Quantity"]);
                _InvoiceDetail.UnitPrice = Convert.ToSingle(row["UnitPrice"]);
                _InvoiceDetail.SubTotal  = Convert.ToSingle(row["SubTotal"]);

                if (_InvoiceDetail.Save())
                {
                    clsProduct.Find(_InvoiceDetail.ProductID).DecreaseStock(_InvoiceDetail.Quantity);
                }
                else
                {
                    MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            MessageBox.Show("Invoice Detail was successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            this.Close();

        }

        //تحقق من حذف المنتج وتغيير الكمية.
        private void CheckProductDeletedAndQuantityChanged() 
        {
            DataTable dtNew = _dtProductsAdded;  // المنتجات الجديدة
            DataTable dtOld = clsInvoiceDetail.GetAllInvoiceDetails(_InvoiceID);  // المنتجات القديمة

            foreach (DataRow rowOld in dtOld.Rows)
            {
                int oldProductID = Convert.ToInt32(rowOld["ProductID"]);
                int oldQuantity = Convert.ToInt32(rowOld["Quantity"]);

                // ابحث عن نفس المنتج في البيانات الجديدة
                var newRow = dtNew.AsEnumerable()
                                  .FirstOrDefault(r => Convert.ToInt32(r["ProductID"]) == oldProductID);

                // لو newRow == null → المنتج تم حذفه
                if (newRow == null)
                {

                    MessageBox.Show($"Deleted Product: {oldProductID} , Old Quantity = {oldQuantity}");
                    continue;
                }

                // الآن قارن الكمية فقط لنفس المنتج
                int newQuantity = Convert.ToInt32(newRow["Quantity"]);

                if (newQuantity != oldQuantity)
                {
                    MessageBox.Show(
                        $"Changed Product: {oldProductID} , Old Qty: {oldQuantity} , New Qty: {newQuantity}"
                    );
                }
            }

        }

        private void RevertOldInvoiceStock()
        {

            DataTable dtOld = clsInvoiceDetail.GetAllInvoiceDetails(_InvoiceID);  // المنتجات القديمة

            foreach (DataRow rowOld in dtOld.Rows)
            {
                int oldProductID = Convert.ToInt32(rowOld["ProductID"]);
                int oldQuantity = Convert.ToInt32(rowOld["Quantity"]);

                clsProduct.Find(oldProductID).IncreaseStock(oldQuantity);

            }

        }

        private void ReverseStockOldInvoice()
        {

            DataTable dtOld = clsInvoiceDetail.GetAllInvoiceDetails(_InvoiceID);  // المنتجات القديمة

            foreach (DataRow rowOld in dtOld.Rows)
            {
                int oldProductID = Convert.ToInt32(rowOld["ProductID"]);
                int oldQuantity = Convert.ToInt32(rowOld["Quantity"]);

                clsProduct.Find(oldProductID).DecreaseStock(oldQuantity);

            }

        }

        private void ctrlFilterCustomer1_OnCustomerSelected(int obj)
        {
            _SelectedCustomerID = obj;
        }

        private void frmCreateInvoices_Activated(object sender, EventArgs e)
        {
            ctrlFilterCustomer1.FilterFocus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            _Invoice.CustomerID = _SelectedCustomerID;
            _Invoice.InvoiceDate = DateTime.Now;
            _Invoice.InvoiceStatus = clsInvoice.enInvoiceStatus.Unpaid;
            _Invoice.TotalAmount = 0;
            _Invoice.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Invoice.Save())
            {
                _InvoiceID = _Invoice.InvoiceID;

                lblInvoiceID.Text = _InvoiceID.ToString();
                lblMode.Text = "Update Invoice";
                _Mode = enMode.Update;

                btnCreate.Enabled = false;
                btnNextToAdd.Enabled = true;

                ctrlFilterCustomer1.FilterEnabled = false;

                MessageBox.Show("Invoice was successfully created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            frmAddProductToInvoice frm = new frmAddProductToInvoice(_dtProductsAdded);
            frm.DataBackProductsAdded += AddProductToInvoice_DataBackProductsAdded;
            frm.ShowDialog();
        }

        private void AddProductToInvoice_DataBackProductsAdded(object sender, DataTable dtProductsAdded)
        {
            _dtProductsAdded.Merge(dtProductsAdded);

            _RefreshProductsList();

        }

       


        private void _RefreshProductsList()
        {
            dgvAllProducts.DataSource = _dtProductsAdded;


            if (dgvAllProducts.Rows.Count > 0)
            {
                dgvAllProducts.Columns[0].Width = 100;
                dgvAllProducts.Columns[1].Width = 450;
                dgvAllProducts.Columns[2].Width = 120;
                dgvAllProducts.Columns[3].Width = 150;
                dgvAllProducts.Columns[4].Width = 150;
            }


            _RefreshTotalAmount();
        }

        private void _RefreshTotalAmount()
        {
            float TotalAmount = 0;

            foreach (DataRow row in _dtProductsAdded.Rows)
            {
                float SubTotal = Convert.ToSingle(row["SubTotal"]);

                TotalAmount += SubTotal;
            }

            lblTotalAmount.Text = TotalAmount.ToString();
            lblTotalAmount_1.Text = TotalAmount.ToString();

        }


        private void btnBackTabAddProduct_Click(object sender, EventArgs e)
        {
            _GoToTabCreateInvoice();
        }

        private void btnBackTabCreateInvoice_Click(object sender, EventArgs e)
        {
            tabControl1.Selecting -= tabControl1_Selecting;  // Temporarily unblock
            tabControl1.SelectedTab = tabCustomerInfo;           // or any other tab
            tabControl1.Selecting += tabControl1_Selecting;  // Reblock

        }

        private void btnDeleteAllProduct_Click(object sender, EventArgs e)
        {
            _dtProductsAdded = new DataTable();
            lblTotalAmount.Text = "0";
            lblTotalAmount_1.Text = lblTotalAmount.Text;

            dgvAllProducts.DataSource = _dtProductsAdded;

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int ProductID = (int)dgvAllProducts.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to delete the Product by ProductID: {ProductID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (_DeleteProductAdded(ProductID))
                {

                    MessageBox.Show("Product has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllProducts.DataSource = _dtProductsAdded;
                    _RefreshTotalAmount();
                }
                else
                {
                    MessageBox.Show("Product was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private bool _DeleteProductAdded(int ProductID)
        {
            DataTable dt = _dtProductsAdded.Clone();

            foreach (DataRow row in _dtProductsAdded.Rows)
            {
                int productID = Convert.ToInt32(row["ProductID"]);


                if (productID != ProductID)
                {
                    dt.ImportRow(row);
                }
               
            }

            _dtProductsAdded = dt; 

            return true;

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int ProductID = (int)dgvAllProducts.CurrentRow.Cells[0].Value;

            frmAddProductToInvoiceInDetail frm = new frmAddProductToInvoiceInDetail(ProductID, (int)dgvAllProducts.CurrentRow.Cells[2].Value);
            frm.DataBack += EditProductToInvoiceInDetail_DataBack;

            frm.ShowDialog();


        }

        private void EditProductToInvoiceInDetail_DataBack(object sender, int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            _EditProductAdded(ProductID, Quantity, UnitPrice, SubTotal);

            dgvAllProducts.DataSource = _dtProductsAdded;
            _RefreshTotalAmount();
        }

        private bool _EditProductAdded(int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            DataTable dt = _dtProductsAdded.Clone();

            foreach (DataRow row in _dtProductsAdded.Rows)
            {
                int productID = Convert.ToInt32(row["ProductID"]);


                if (productID == ProductID)
                {
                    dt.Rows.Add(ProductID, clsProduct.Find(ProductID).Name , Quantity, UnitPrice, SubTotal);
                }
                else
                {
                    dt.ImportRow(row);
                }

               
            }

            _dtProductsAdded = dt;

            return true;

        }

        private void tsmReadMore_Click(object sender, EventArgs e)
        {
            int ProductID = (int)dgvAllProducts.CurrentRow.Cells[0].Value;

            frmShowProductInfo frmShowProductInfo = new frmShowProductInfo(ProductID);
            frmShowProductInfo.ShowDialog();
        }

        private void frmCreateInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                           "exit",
                                           MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                e.Cancel = true; // منع الإغلاق

        }




        //ctrlFilterCustomer1
    }
}
