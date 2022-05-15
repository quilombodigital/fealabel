using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FeaLabel
{
    public class Labeler
    {

        private Properties.Settings settings { get { return Properties.Settings.Default; } }

        public Labeler()
        {

        }

        private XImage logoImage;
        private PdfPage page;
        private XGraphics gfx;
        private XFont labelFont;

        private XUnit toXunit(double value) => XUnit.FromMillimeter(value);

        public void generate(string[] labelCodes)
        {
            if (!File.Exists(settings.logoPath))
            {
                MessageBox.Show("Could not find Logo Image!");
                return;
            }

            logoImage = XImage.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), settings.logoPath));
            labelFont = new XFont("Arial", 4, XFontStyle.Regular);

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created by Aurora";

            int labelIndex = 0;
            do
            {
                page = document.AddPage();
                page.Width = toXunit(settings.pageWidth);
                page.Height = toXunit(settings.pageHeight);
                gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < ((int)settings.rows); row++)
                {
                    for (int column = 0; column < ((int)settings.columns); column++)
                    {
                        var labelCode = labelCodes[labelIndex].Trim();
                        if (!string.IsNullOrEmpty(labelCode))
                            drawLabel(column, row, labelCode);
                        labelIndex++;
                        if (labelIndex == labelCodes.Length)
                            break;
                    }
                    if (labelIndex == labelCodes.Length)
                        break;
                }

            } while (labelIndex < labelCodes.Length);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF file|*.pdf";
            saveFileDialog1.Title = "Save a PDF File";
            var now = DateTime.Now;
            saveFileDialog1.FileName = $"fealabel_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.pdf";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                try
                {
                    document.Save(saveFileDialog1.FileName);
                    if (settings.openPdfAfterSaving)
                        Process.Start(saveFileDialog1.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("COULD NOT SAVE FILE! Are you sure the file is not open in another application? Please close the application using it and retry.");
                }
            }


        }

        private void drawLabel(int column, int row, string value)
        {

            double xMM = settings.leftMagin + (settings.verticalSpace * (column - 1)) + (settings.labelWidth * column);
            double yMM = settings.topMargin + (settings.horizontalSpace * (row - 1)) + (settings.labelHeight * row);


            double xlabelCenterMM = xMM + (settings.labelWidth / 2);
            double ylabelCenterMM = yMM + (settings.labelHeight / 2);

            XRect labelRect = new XRect(toXunit(xMM), toXunit(yMM), toXunit(settings.labelWidth), toXunit(settings.labelHeight));

            if (settings.printLabelBorder)
            {
                XPen pen = new XPen(XColors.Black, 0.1);
                gfx.DrawRoundedRectangle(pen, labelRect, new XSize(XUnit.FromMillimeter(3), XUnit.FromMillimeter(3)));
            }

            double logoHeight = settings.labelHeight / 2;
            XRect logoRect = new XRect(toXunit(xlabelCenterMM - (logoHeight / 2) + 1),
                toXunit(yMM + 5),
                toXunit(logoHeight - 2),
                toXunit(logoHeight - 2)
                );

            gfx.DrawImage(logoImage, logoRect);

            XRect barcodeRect = new XRect(toXunit(xMM + 2),
                toXunit(ylabelCenterMM + 5),
                toXunit(settings.labelWidth - 4),
                toXunit(logoHeight - 10)
                );


            drawBarcode(value, barcodeRect);

            XPoint labelPoint = new XPoint(toXunit(xlabelCenterMM), toXunit(yMM + settings.labelHeight - 4));

            gfx.DrawString(value, labelFont, XBrushes.Black, labelPoint, XStringFormats.Center);

        }


        private void drawBarcode(string value, XRect rect)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, value, Color.Black, Color.White, 512, 256);
            MemoryStream strm = new MemoryStream();
            img.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
            XImage xfoto = XImage.FromStream(strm);
            gfx.DrawImage(xfoto, rect);
        }
    }
}
