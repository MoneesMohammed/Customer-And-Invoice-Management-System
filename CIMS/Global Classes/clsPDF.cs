using CIMS.Properties;
using CIMS_BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Ocsp;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CIMS.Global_Classes
{
    public class clsPDF
    {
        public static void GenerateSalesReportPDF(DataTable dtSalesReport)
        {
            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";
            saveDialog.FileName = $"Sales_Report_(1).pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document(PageSize.A4, 30, 30, 40, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
            doc.Open();

            // ================= COLOR ================
            BaseColor blue = new BaseColor(0, 153, 255); // نفس الأزرق تقريباً
            BaseColor red = new BaseColor(255, 0, 0);
            BaseColor black = new BaseColor(0, 0, 0);
            BaseColor green = new BaseColor(0, 153, 0);

            // ================= LOGO =================
            
            MemoryStream ms = new MemoryStream();
            Resources.pfizer.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

            logo.ScaleAbsolute(90, 90);
            logo.Alignment = Element.ALIGN_LEFT;

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 1f, 1f });

            headerTable.AddCell(MakeCompanyNameCell(logo, "Company Name"));

            // عنوان Report
            PdfPCell reportTitle = new PdfPCell(new Phrase("Report", new Font(Font.FontFamily.HELVETICA, 26, Font.BOLD, blue)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = Rectangle.NO_BORDER,
                PaddingTop = 25
            };
            headerTable.AddCell(reportTitle);


            doc.Add(headerTable);
            doc.Add(new Paragraph("\n\n"));
            // ================= Sales Report =================
            
            MemoryStream msT = new MemoryStream();
            Resources.forecast.Save(msT, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logoSales = iTextSharp.text.Image.GetInstance(msT.ToArray());

            logoSales.ScaleAbsolute(42, 42);
            logoSales.Alignment = Element.ALIGN_RIGHT;


            PdfPTable SalesTitleTable = new PdfPTable(1);
            SalesTitleTable.WidthPercentage = 100;
            SalesTitleTable.SetWidths(new float[] { 1f });
            SalesTitleTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
            


            SalesTitleTable.AddCell(MakeReportsTitleCell(logoSales, "Sales Report"));

            doc.Add(SalesTitleTable);
            doc.Add(new Paragraph("\n"));

            // ================= TABLE HEADER =================
            PdfPTable SalesReportTable = CreateSalesReportTable(blue);

            SalesReportTable.HeaderRows = 1;

            // ================= TABLE ROWS =================
            foreach (DataRow row in dtSalesReport.Rows)
            {
                SalesReportTable.AddCell(MakeCell(Convert.ToDateTime(row["Sale Date"]).ToString("MM/dd/yyyy")));
                SalesReportTable.AddCell(MakeCell(row["Total Sales"].ToString()));

            }

            doc.Add(SalesReportTable);
            //doc.Add(new Paragraph("\n\n"));
     
            doc.Close();

            MessageBox.Show($"The Report has been successfully exported to PDF ! :\n{saveDialog.FileName}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(saveDialog.FileName);

        }


        public static void GenerateTopProductsReportPDF(DataTable dtTopProductsReport)
        {
            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";
            saveDialog.FileName = $"Top_Products_Report_(1).pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document(PageSize.A4, 30, 30, 40, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
            doc.Open();

            // ================= COLOR ================
            BaseColor blue = new BaseColor(0, 153, 255); // نفس الأزرق تقريباً
            BaseColor red = new BaseColor(255, 0, 0);
            BaseColor black = new BaseColor(0, 0, 0);
            BaseColor green = new BaseColor(0, 153, 0);

            // ================= LOGO =================

            MemoryStream ms = new MemoryStream();
            Resources.pfizer.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

            logo.ScaleAbsolute(90, 90);
            logo.Alignment = Element.ALIGN_LEFT;

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 1f, 1f });

            headerTable.AddCell(MakeCompanyNameCell(logo, "Company Name"));

            // عنوان Report
            PdfPCell reportTitle = new PdfPCell(new Phrase("Report", new Font(Font.FontFamily.HELVETICA, 26, Font.BOLD, blue)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = Rectangle.NO_BORDER,
                PaddingTop = 25
            };
            headerTable.AddCell(reportTitle);


            doc.Add(headerTable);
            doc.Add(new Paragraph("\n\n"));
            // ================= Top Products Report =================

            MemoryStream msT = new MemoryStream();
            Resources.sales.Save(msT, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logoSales = iTextSharp.text.Image.GetInstance(msT.ToArray());

            logoSales.ScaleAbsolute(42, 42);
            logoSales.Alignment = Element.ALIGN_RIGHT;


            PdfPTable SalesTitleTable = new PdfPTable(1);
            SalesTitleTable.WidthPercentage = 100;
            SalesTitleTable.SetWidths(new float[] { 1f });
            SalesTitleTable.HorizontalAlignment = Element.ALIGN_MIDDLE;



            SalesTitleTable.AddCell(MakeReportsTitleCell(logoSales, "Top Products Report"));

            doc.Add(SalesTitleTable);
            doc.Add(new Paragraph("\n"));

            // ================= TABLE HEADER =================
            PdfPTable TopProductsReportTable = CreateTopProductsReportTable(blue);

            TopProductsReportTable.HeaderRows = 1;

            // ================= TABLE ROWS =================
            foreach (DataRow row in dtTopProductsReport.Rows)
            {
                TopProductsReportTable.AddCell(MakeCell(row["Name"].ToString()));
                TopProductsReportTable.AddCell(MakeCell(row["Total Sold"].ToString()));

            }

            doc.Add(TopProductsReportTable);
            //doc.Add(new Paragraph("\n\n"));
           

            doc.Close();

            MessageBox.Show($"The Report has been successfully exported to PDF ! :\n{saveDialog.FileName}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(saveDialog.FileName);

        }

        public static void GenerateCustomersReportPDF(DataTable dtCustomersReport)
        {
            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";
            saveDialog.FileName = $"Customers_Report_(1).pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document(PageSize.A4, 30, 30, 40, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
            doc.Open();

            // ================= COLOR ================
            BaseColor blue = new BaseColor(0, 153, 255); // نفس الأزرق تقريباً
            BaseColor red = new BaseColor(255, 0, 0);
            BaseColor black = new BaseColor(0, 0, 0);
            BaseColor green = new BaseColor(0, 153, 0);

            // ================= LOGO =================

            MemoryStream ms = new MemoryStream();
            Resources.pfizer.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

            logo.ScaleAbsolute(90, 90);
            logo.Alignment = Element.ALIGN_LEFT;

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 1f, 1f });

            headerTable.AddCell(MakeCompanyNameCell(logo, "Company Name"));

            // عنوان Report
            PdfPCell reportTitle = new PdfPCell(new Phrase("Report", new Font(Font.FontFamily.HELVETICA, 26, Font.BOLD, blue)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = Rectangle.NO_BORDER,
                PaddingTop = 25
            };
            headerTable.AddCell(reportTitle);


            doc.Add(headerTable);
            doc.Add(new Paragraph("\n\n"));
            // ================= Customers Report =================

            MemoryStream msT = new MemoryStream();
            Resources.analystics.Save(msT, System.Drawing.Imaging.ImageFormat.Png);

            iTextSharp.text.Image logoSales = iTextSharp.text.Image.GetInstance(msT.ToArray());

            logoSales.ScaleAbsolute(42, 42);
            logoSales.Alignment = Element.ALIGN_RIGHT;


            PdfPTable SalesTitleTable = new PdfPTable(1);
            SalesTitleTable.WidthPercentage = 100;
            SalesTitleTable.SetWidths(new float[] { 1f });
            SalesTitleTable.HorizontalAlignment = Element.ALIGN_MIDDLE;



            SalesTitleTable.AddCell(MakeReportsTitleCell(logoSales, "Customers Report"));

            doc.Add(SalesTitleTable);
            doc.Add(new Paragraph("\n"));

            // ================= TABLE HEADER =================
            PdfPTable CustomersReportTable = CreateCustomersReportTable(blue);

            CustomersReportTable.HeaderRows = 1;

            // ================= TABLE ROWS =================
            foreach (DataRow row in dtCustomersReport.Rows)
            {
                CustomersReportTable.AddCell(MakeCell(row["Customer ID"].ToString()));
                CustomersReportTable.AddCell(MakeCell(row["Customer Name"].ToString()));
                CustomersReportTable.AddCell(MakeCell(row["Total Invoices"].ToString()));
                CustomersReportTable.AddCell(MakeCell(row["Total Spent"].ToString()));

            }

            doc.Add(CustomersReportTable);
            //doc.Add(new Paragraph("\n\n"));
            


            doc.Close();

            MessageBox.Show($"The Report has been successfully exported to PDF ! :\n{saveDialog.FileName}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(saveDialog.FileName);

        }

        public static void GenerateInvoicePDF(int InvoiceID)
        {
            clsInvoice Invoice = clsInvoice.Find(InvoiceID);

            if (Invoice == null)
            {
                MessageBox.Show($"No Invoice With ID {InvoiceID}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                return;
            }
                

            string customerName = Invoice.CustomerInfo.FullName;
            DateTime dateInvoice = Invoice.InvoiceDate;
            string customerID = Invoice.CustomerID.ToString();
            DataTable itemsTable = clsInvoiceDetail.GetAllInvoiceDetails(InvoiceID);
            float totalAmount = Invoice.TotalAmount;



            // تحديد مكان حفظ الملف
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file|*.pdf";
            saveDialog.Title = "Save Invoice as PDF";
            saveDialog.FileName = $"Invoice_{InvoiceID}.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Document doc = new Document(PageSize.A4, 30, 30, 40, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

            // writer.PageEvent = new WatermarkPageEvent("CONFIDENTIAL");

            MemoryStream lw = new MemoryStream();
            Resources.logo_of_Watermark_6.Save(lw, System.Drawing.Imaging.ImageFormat.Jpeg);

            iTextSharp.text.Image watermarkLogo = iTextSharp.text.Image.GetInstance(lw.ToArray());
            writer.PageEvent = new ImageWatermarkEvent(watermarkLogo);


            doc.Open();

            // ================= COLOR ================
            BaseColor blue = new BaseColor(0, 153, 255); // نفس الأزرق تقريباً
            BaseColor red = new BaseColor(255, 0, 0);
            BaseColor black = new BaseColor(0, 0, 0);
            BaseColor green = new BaseColor(0, 153, 0);
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

            //headerTable.AddCell(new PdfPCell(logo)
            //{
            //    Border = Rectangle.NO_BORDER,
            //    Padding = 5
            //});

            headerTable.AddCell(MakeCompanyNameCell(logo , "Company Name"));

            // عنوان INVOICE
            PdfPCell invoiceTitle = new PdfPCell(new Phrase("INVOICE", new Font(Font.FontFamily.HELVETICA, 26, Font.BOLD, blue)))
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
            infoTable.SetWidths(new float[] { 1f , 1f});

            PdfPCell cell_1 = new PdfPCell();
            cell_1.Border = Rectangle.NO_BORDER;
            cell_1.HorizontalAlignment = Element.ALIGN_LEFT;

            
            Phrase p1 = new Phrase("Invoice To:\n", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, black));
            cell_1.AddElement(p1);

           
            Phrase p2 = new Phrase(customerName, new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, red));
            cell_1.AddElement(p2);

            infoTable.AddCell(cell_1);

            PdfPCell cell_2 = new PdfPCell();
            cell_2.Border = Rectangle.NO_BORDER;
            cell_2.HorizontalAlignment = Element.ALIGN_RIGHT;

            Font font = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);

            Paragraph p3 = new Paragraph($"Invoice  ID      {InvoiceID}", font);
            Paragraph p4 = new Paragraph($"Customer ID      {customerID}", font);
            Paragraph p5 = new Paragraph($"Date          {dateInvoice:dd MMM yyyy}", font);

            p3.Alignment = Element.ALIGN_RIGHT;
            p4.Alignment = p3.Alignment;
            p5.Alignment = p4.Alignment;


            cell_2.AddElement(p3);
            cell_2.AddElement(p4);
            cell_2.AddElement(p5);

            infoTable.AddCell(cell_2);


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
            totalsTable.WidthPercentage = 50;//40
            totalsTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            totalsTable.AddCell(MakeTotalCell("", ""));
            totalsTable.AddCell(MakeTotalCell("TOTAL", totalAmount.ToString("0.00"), true));

            doc.Add(totalsTable);
            doc.Add(new Paragraph("\n"));

            PdfPTable StatusTable = new PdfPTable(1);
            StatusTable.WidthPercentage = 50;//40
            StatusTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            // ================= InvoiceStatus =================

            if (Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
            {
                string TotalPaid = clsPayment.GetTotalPaidByInvoiceID(InvoiceID).ToString("0.00");
                string RemainingAmount = (Invoice.TotalAmount - Convert.ToSingle(TotalPaid)).ToString("0.00");

                StatusTable.AddCell(MakePaidRemainingCell("Paid", TotalPaid , "Remaining Amount" , RemainingAmount));

                doc.Add(StatusTable);
                doc.Add(new Paragraph("\n\n"));

            }
            else if(Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Paid)
            {
                PdfPCell IsPaidCell = new PdfPCell(new Phrase("The Invoice Has Been Paid .", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, green)))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Border = Rectangle.NO_BORDER,
                    PaddingTop = 10,
                    PaddingBottom = 5
                };

                StatusTable.AddCell(IsPaidCell);


                doc.Add(StatusTable);
                doc.Add(new Paragraph("\n\n"));

            }
            else if (Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Cancelled)
            {
                PdfPCell IsPaidCell = new PdfPCell(new Phrase("The Invoice Has Been Cancelled .", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, red)))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Border = Rectangle.NO_BORDER,
                    PaddingTop = 10,
                    PaddingBottom = 5
                };

                StatusTable.AddCell(IsPaidCell);


                doc.Add(StatusTable);
                doc.Add(new Paragraph("\n\n"));

            }
            else
            {
                doc.Add(new Paragraph("\n"));
                
            }


            // ================= SIGNATURE =================
            Paragraph sign = new Paragraph("___________________________\n   Signature",
                new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL));
            sign.Alignment = Element.ALIGN_RIGHT;
            doc.Add(sign);

            doc.Close();

            MessageBox.Show($"The Invoice has been successfully exported to PDF ! :\n{saveDialog.FileName}", "Success",
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
            inner.SetWidths(new float[] { 50f , 50f });

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

        public static PdfPCell MakePaidRemainingCell(string paidLabel,string paidValue,string remainingLabel,string remainingValue)
        {
            Font labelFont = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);
            Font valueFont = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);

            PdfPTable inner = new PdfPTable(4);
            inner.WidthPercentage = 100;

            // التحكم بالمسافات بين كل كلمة
            inner.SetWidths(new float[] { 15f, 20f, 40f, 18f });

            inner.AddCell(CreateCell(paidLabel, labelFont, Element.ALIGN_LEFT));
            inner.AddCell(CreateCell(paidValue, valueFont, Element.ALIGN_LEFT));
            inner.AddCell(CreateCell(remainingLabel, labelFont, Element.ALIGN_LEFT));
            inner.AddCell(CreateCell(remainingValue, valueFont, Element.ALIGN_RIGHT));

            PdfPCell wrapper = new PdfPCell(inner)
            {
                Border = Rectangle.NO_BORDER,
                PaddingTop = 10,
                PaddingBottom = 5
            };

            return wrapper;
        }

        private static PdfPCell CreateCell(string text, Font font, int alignment)
        {
            return new PdfPCell(new Phrase(text, font))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = alignment,
                Padding = 3
            };
        }

        public static PdfPCell MakeCompanyNameCell(iTextSharp.text.Image logo ,string companyName)
        {
            Font Font = new Font(Font.FontFamily.HELVETICA, 22, Font.BOLD);

            PdfPTable inner = new PdfPTable(2);
            inner.WidthPercentage = 100;

            inner.SetWidths(new float[] { 1f, 1f });

            inner.AddCell(new PdfPCell(logo) { Border = Rectangle.NO_BORDER , Padding = 5 , PaddingTop = -20 });
                 
            inner.AddCell(CreateCell(companyName, Font, Element.ALIGN_LEFT));
          

            PdfPCell wrapper = new PdfPCell(inner)
            {
                Border = Rectangle.NO_BORDER,
                Padding = 5
            };

            return wrapper;
        }


        public static PdfPCell MakeReportsTitleCell(iTextSharp.text.Image logo, string Title)
        {
            Font Font = new Font(Font.FontFamily.HELVETICA, 22, Font.BOLD);

            PdfPTable inner = new PdfPTable(2);
            inner.WidthPercentage = 100;

            inner.SetWidths(new float[] { 14, 10 });

            PdfPCell CellTitle = new PdfPCell(new Phrase(Title, Font))
            {   Border = Rectangle.NO_BORDER,
                Padding = 3, 
                HorizontalAlignment = Element.ALIGN_RIGHT
                //PaddingLeft = 100
            };

            //inner.AddCell(CreateCell(Title, Font, Element.ALIGN_RIGHT));

            inner.AddCell(CellTitle);
            inner.AddCell(new PdfPCell(logo) { Border = Rectangle.NO_BORDER, Padding = 5 , PaddingTop = -8 , PaddingBottom = 10 });

            PdfPCell wrapper = new PdfPCell(inner)
            {
                Border = Rectangle.NO_BORDER,
                Padding = 5
            };

            return wrapper;
        }


        public static PdfPTable CreateSalesReportTable(BaseColor Color)
        {
            PdfPTable SalesReportTable = new PdfPTable(2);
            SalesReportTable.WidthPercentage = 100;
            SalesReportTable.SetWidths(new float[] { 10, 10 });

            SalesReportTable.AddCell(MakeHeaderCell("Sale Date", Color));
            SalesReportTable.AddCell(MakeHeaderCell("Total Sales", Color));

            return SalesReportTable;

        }

        public static PdfPTable CreateTopProductsReportTable(BaseColor Color)
        {
            PdfPTable SalesReportTable = new PdfPTable(2);
            SalesReportTable.WidthPercentage = 100;
            SalesReportTable.SetWidths(new float[] { 10, 10 });

            SalesReportTable.AddCell(MakeHeaderCell("Product Name", Color));
            SalesReportTable.AddCell(MakeHeaderCell("Total Sold", Color));

            return SalesReportTable;

        }


        public static PdfPTable CreateCustomersReportTable(BaseColor Color)
        {
            PdfPTable SalesReportTable = new PdfPTable(4);
            SalesReportTable.WidthPercentage = 100;
            SalesReportTable.SetWidths(new float[] { 10, 25 ,10 ,10 });
            
            SalesReportTable.AddCell(MakeHeaderCell("Customer ID", Color));
            SalesReportTable.AddCell(MakeHeaderCell("Customer Name", Color));
            SalesReportTable.AddCell(MakeHeaderCell("Total Invoices", Color));
            SalesReportTable.AddCell(MakeHeaderCell("Total Spent", Color));

            return SalesReportTable;

        }


        class WatermarkPageEvent : PdfPageEventHelper
        {
            private readonly string _watermarkText;
            private readonly Font _font;

            public WatermarkPageEvent(string watermarkText)
            {
                _watermarkText = watermarkText;

                _font = new Font(Font.FontFamily.HELVETICA, 80, Font.BOLD,
                    new BaseColor(200, 200, 200)); // رمادي فاتح
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                PdfContentByte canvas = writer.DirectContentUnder;

                Phrase watermark = new Phrase(_watermarkText, _font);

                ColumnText.ShowTextAligned(
                    canvas,
                    Element.ALIGN_CENTER,
                    watermark,
                    document.PageSize.Width / 2,
                    document.PageSize.Height / 2,
                    45  // زاوية الميل
                );
            }
        }

        class ImageWatermarkEvent : PdfPageEventHelper
        {
            private iTextSharp.text.Image _image;

            public ImageWatermarkEvent(iTextSharp.text.Image image)
            {
                _image = image;
                _image.ScaleAbsolute(512, 512);
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                PdfContentByte canvas = writer.DirectContentUnder;

                PdfGState gs = new PdfGState();
                gs.FillOpacity = 0.18f;   
                canvas.SetGState(gs);

                _image.SetAbsolutePosition(
                    (document.PageSize.Width - _image.ScaledWidth) / 2,
                    (document.PageSize.Height - _image.ScaledHeight) / 2
                );

                canvas.AddImage(_image);
            }
        }




    }
}
