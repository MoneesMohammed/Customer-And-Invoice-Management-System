using CIMS.Properties;
using CIMS_BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Ocsp;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CIMS.Global_Classes
{
    public class clsPDF
    {
        public static void ExportInvoiceToPDF()
        {
            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            // إنشاء المستند
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

            doc.Open();

            // عنوان الفاتورة
            Paragraph title = new Paragraph("Sales invoice",
                new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            doc.Add(new Paragraph("\n"));

            // مثال معلومات الفاتورة
            doc.Add(new Paragraph("Invoice number: 123"));
            doc.Add(new Paragraph("the date: " + DateTime.Now.ToShortDateString()));
            doc.Add(new Paragraph("Customer name: Ahmed"));
            doc.Add(new Paragraph("\n"));

            // جدول البيانات (مثل DataGridView)
            PdfPTable table = new PdfPTable(3); // عدد الأعمدة
            table.AddCell("Product");
            table.AddCell("Quantity");
            table.AddCell("the price");

            // مثال: تعبئة جدول من DataGridView
            //foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
            //{
            //    table.AddCell(row.Cells["ProductName"].Value.ToString());
            //    table.AddCell(row.Cells["Quantity"].Value.ToString());
            //    table.AddCell(row.Cells["Price"].Value.ToString());
            //}

            doc.Add(table);

            // المجموع
            doc.Add(new Paragraph("\nthe total: 200$"));

            doc.Close();

            MessageBox.Show("The invoice has been successfully exported to PDF!");
        }



    public static void GenerateInvoicePDF(
    int invoiceID,
    string customerName,
    DateTime dateInvoice,
    string customerID,
    DataTable itemsTable,
    float totalAmount)
    {
            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";
            saveDialog.FileName = $"Invoice_{invoiceID}.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document(PageSize.A4, 30, 30, 40, 30);
            PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
            doc.Open();

            // ================= COLOR ================
            BaseColor blue = new BaseColor(0, 153, 255); // نفس الأزرق تقريباً
            BaseColor red = new BaseColor(255, 0, 0);
            BaseColor black = new BaseColor(0, 0, 0);
            // ================= LOGO =================
            // iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Resources.pfizer);
            // @"C:\Users\nuwmo\OneDrive\Pictures\New folder (3)\Icons\New folder\pfizer.png");

            MemoryStream ms = new MemoryStream();
            Resources.pfizer.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

            logo.ScaleAbsolute(90, 90);
            logo.Alignment = Element.ALIGN_LEFT;

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 1f, 1f });

            headerTable.AddCell(new PdfPCell(logo)
            {
                Border = Rectangle.NO_BORDER,
                Padding = 5
            });

            // عنوان INVOICE
            PdfPCell invoiceTitle = new PdfPCell(new Phrase("INVOICE",
                new Font(Font.FontFamily.HELVETICA, 26, Font.BOLD, blue)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = Rectangle.NO_BORDER,
                PaddingTop = 25
            };
            headerTable.AddCell(invoiceTitle);

            doc.Add(headerTable);
            doc.Add(new Paragraph("\n"));

            // ================= CUSTOMER INFO =================
            PdfPTable infoTable = new PdfPTable(2);
            infoTable.WidthPercentage = 100;
            infoTable.SetWidths(new float[] { 1f, 1f });

            PdfPCell cell = new PdfPCell();
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;

            // النص الأول الأسود
            Phrase p1 = new Phrase("Invoice To:\n", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, black));
            cell.AddElement(p1);

            // الاسم الأحمر
            Phrase p2 = new Phrase(customerName, new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, red));
            cell.AddElement(p2);

            infoTable.AddCell(cell);

            infoTable.AddCell(MakeInfoCell(
                $"Invoice ID  {invoiceID}\n" +
                $"Customer ID  {customerID}\n" +
                $"Date  {dateInvoice:dd MMM yyyy}", true , black));

            doc.Add(infoTable);
            doc.Add(new Paragraph("\n\n"));

            
            // ================= TABLE HEADER =================
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 10, 40, 15, 15, 20 });

            table.AddCell(MakeHeaderCell("SL", blue));
            table.AddCell(MakeHeaderCell("ITEM", blue));
            table.AddCell(MakeHeaderCell("PRICE", blue));
            table.AddCell(MakeHeaderCell("QTY", blue));
            table.AddCell(MakeHeaderCell("TOTAL", blue));

            // ================= TABLE ROWS =================
            int sl = 1;
            foreach (DataRow row in itemsTable.Rows)
            {
                table.AddCell(MakeCell(sl.ToString()));
                table.AddCell(MakeCell(row["Name"].ToString()));
                table.AddCell(MakeCell(row["UnitPrice"].ToString()));
                table.AddCell(MakeCell(row["Quantity"].ToString()));
                table.AddCell(MakeCell(row["SubTotal"].ToString()));
                sl++;
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));

            // ================= TOTALS =================
            PdfPTable totalsTable = new PdfPTable(2);
            totalsTable.WidthPercentage = 40;//40
            totalsTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            // ================= InvoiceStatus =================
            clsInvoice Invoice = clsInvoice.Find(invoiceID);
            if (Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
            {
                string TotalPaid = clsPayment.GetTotalPaidByInvoiceID(invoiceID).ToString("0.00");
                string RemainingAmount = (Invoice.TotalAmount - Convert.ToSingle(TotalPaid)).ToString("0.00");

                totalsTable.AddCell(MakeTotalCell("TOTAL", totalAmount.ToString("0.00"), true));
                totalsTable.AddCell(MakeInfoCell($"Paid {TotalPaid}\n\nRemaining Amount {RemainingAmount}", false, black));

            }
            else
            { 
                totalsTable.AddCell(MakeTotalCell("", "", true));
                totalsTable.AddCell(MakeTotalCell("TOTAL", totalAmount.ToString("0.00"), true));
            }

            doc.Add(totalsTable);
            doc.Add(new Paragraph("\n\n"));


            // ================= SIGNATURE =================
            Paragraph sign = new Paragraph("___________________________\n   Signature",
                new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL));
            sign.Alignment = Element.ALIGN_RIGHT;
            doc.Add(sign);

            doc.Close();

            MessageBox.Show($"PDF It Was Successfully Created :\n{saveDialog.FileName}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(saveDialog.FileName);
        }

        // =========== Helper Methods ===========

        public static PdfPCell MakeHeaderCell(string text, BaseColor color)
        {
            return new PdfPCell(new Phrase(text,
                new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, color)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = new BaseColor(235, 235, 235),
                Padding = 8
            };
        }

        public static PdfPCell MakeCell(string text)
        {
            return new PdfPCell(new Phrase(text,
                new Font(Font.FontFamily.HELVETICA, 11)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 6
            };
        }

        public static PdfPCell MakeInfoCell(string text, bool alignRight, BaseColor color )
        {
            Font font = new Font(Font.FontFamily.HELVETICA, 12 ,Font.NORMAL, color);

            return new PdfPCell(new Phrase(text, font))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = alignRight ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT
            };
        }

        public static PdfPCell MakeTotalCell(string label, string value, bool bold = false)
        {
            Font f = new Font(Font.FontFamily.HELVETICA, 12, bold ? Font.BOLD : Font.NORMAL);

            PdfPTable inner = new PdfPTable(2);
            inner.WidthPercentage = 100;
            inner.SetWidths(new float[] { 50, 50 });

            inner.AddCell(new PdfPCell(new Phrase(label, f))
            {
                Border = Rectangle.NO_BORDER
            });

            inner.AddCell(new PdfPCell(new Phrase(value, f))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });

            PdfPCell wrapper = new PdfPCell(inner)
            {
                Border = Rectangle.NO_BORDER,
                Padding = 5
            };

            return wrapper;
        }


        



       




    }
}
