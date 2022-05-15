using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FeaLabel
{
    public partial class FEALabelerForm : Form
    {
        public FEALabelerForm()
        {
            InitializeComponent();

            labeler = new Labeler();

            pageSizeCombobox.SelectedItem = settings.pageSize;
            topmarginField.Value = (decimal)settings.topMargin;
            leftmarginField.Value = (decimal)settings.leftMagin;
            rowsField.Value = (decimal)settings.rows;
            columnsField.Value = (decimal)settings.columns;
            labelWidthField.Value = (decimal)settings.labelWidth;
            labelheightField.Value = (decimal)settings.labelHeight;
            horSpaceField.Value = (decimal)settings.horizontalSpace;
            verspaceField.Value = (decimal)settings.verticalSpace;
            printBorderField.Checked = settings.printLabelBorder;
            openaftersaveField.Checked = settings.openPdfAfterSaving;

            tryToLoadImage();
        }

        private void tryToLoadImage()
        {
            bool succeeded = false;
            if (File.Exists(settings.logoPath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(settings.logoPath);
                    succeeded = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not load logo, will use default image");
                }
            }
            if (!succeeded)
            {
                MessageBox.Show("Could not find previous logo, will use default image");
                settings.logoPath = "images/logo.png";
                settings.Save();
                pictureBox1.Image = Image.FromFile(settings.logoPath);
            }
        }

        private Properties.Settings settings { get { return Properties.Settings.Default; } }

        Labeler labeler;

        private void button1_Click(object sender, EventArgs e)
        {

            string[] codes = barcodesField.Text.Trim().Split(',');

            if (string.IsNullOrEmpty(barcodesField.Text.Trim()) || codes.Length == 0)
            {
                MessageBox.Show("Please type some barcodes separated by commas");
                return;
            }

            labeler.generate(codes);
        }

        private void topmarginField_ValueChanged(object sender, EventArgs e)
        {
            settings.topMargin = Decimal.ToDouble(topmarginField.Value);
            settings.Save();
        }

        private void leftmarginField_ValueChanged(object sender, EventArgs e)
        {
            settings.leftMagin = Decimal.ToDouble(leftmarginField.Value);
            settings.Save();
        }

        private void labelWidthField_ValueChanged(object sender, EventArgs e)
        {
            settings.labelWidth = Decimal.ToDouble(labelWidthField.Value);
            settings.Save();
        }

        private void labelheightField_ValueChanged(object sender, EventArgs e)
        {
            settings.labelHeight = Decimal.ToDouble(labelheightField.Value);
            settings.Save();
        }

        private void columnsField_ValueChanged(object sender, EventArgs e)
        {
            settings.columns = Decimal.ToDouble(columnsField.Value);
            settings.Save();
        }

        private void rowsField_ValueChanged(object sender, EventArgs e)
        {
            settings.rows = Decimal.ToDouble(rowsField.Value);
            settings.Save();
        }

        private void verspaceField_ValueChanged(object sender, EventArgs e)
        {
            settings.verticalSpace = Decimal.ToDouble(verspaceField.Value);
            settings.Save();
        }

        private void horSpaceField_ValueChanged(object sender, EventArgs e)
        {
            settings.horizontalSpace = Decimal.ToDouble(horSpaceField.Value);
            settings.Save();
        }

        private void printBorderField_CheckedChanged(object sender, EventArgs e)
        {
            settings.printLabelBorder = printBorderField.Checked;
            settings.Save();
        }

        private void openaftersaveField_CheckedChanged(object sender, EventArgs e)
        {
            settings.openPdfAfterSaving = openaftersaveField.Checked;
            settings.Save();
        }

        private void pageSizeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pageSizeCombobox.SelectedItem.ToString() == "A5")
            {
                settings.pageSize = "A5";
                settings.pageWidth = 148;
                settings.pageHeight = 210;
            }
            else if (pageSizeCombobox.SelectedItem.ToString() == "A4")
            {
                settings.pageSize = "A4";
                settings.pageWidth = 210;
                settings.pageHeight = 297;
            }
            settings.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif";
            openFileDialog.Title = "Open Logo Image";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        settings.logoPath = openFileDialog.FileName;
                        settings.Save();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Failed to load image");
                    }
                }
            }
        }
    }
}
