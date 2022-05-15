
namespace FeaLabel
{
    partial class FEALabelerForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.barcodesField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pageSizeCombobox = new System.Windows.Forms.ComboBox();
            this.topmarginField = new System.Windows.Forms.NumericUpDown();
            this.leftmarginField = new System.Windows.Forms.NumericUpDown();
            this.labelWidthField = new System.Windows.Forms.NumericUpDown();
            this.labelheightField = new System.Windows.Forms.NumericUpDown();
            this.columnsField = new System.Windows.Forms.NumericUpDown();
            this.rowsField = new System.Windows.Forms.NumericUpDown();
            this.verspaceField = new System.Windows.Forms.NumericUpDown();
            this.horSpaceField = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.printBorderField = new System.Windows.Forms.CheckBox();
            this.openaftersaveField = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topmarginField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftmarginField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelWidthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelheightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verspaceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horSpaceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barcodesField
            // 
            this.barcodesField.Location = new System.Drawing.Point(219, 33);
            this.barcodesField.Multiline = true;
            this.barcodesField.Name = "barcodesField";
            this.barcodesField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.barcodesField.Size = new System.Drawing.Size(430, 336);
            this.barcodesField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAGE SIZE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOP MARGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LEFT MARGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "LABEL WIDTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "LABEL HEIGHT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ROWS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "COLUMNS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "VER. SPACE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "HOR. SPACE";
            // 
            // pageSizeCombobox
            // 
            this.pageSizeCombobox.FormattingEnabled = true;
            this.pageSizeCombobox.Items.AddRange(new object[] {
            "A5",
            "A4"});
            this.pageSizeCombobox.Location = new System.Drawing.Point(123, 6);
            this.pageSizeCombobox.Name = "pageSizeCombobox";
            this.pageSizeCombobox.Size = new System.Drawing.Size(60, 21);
            this.pageSizeCombobox.TabIndex = 11;
            this.pageSizeCombobox.SelectedIndexChanged += new System.EventHandler(this.pageSizeCombobox_SelectedIndexChanged);
            // 
            // topmarginField
            // 
            this.topmarginField.Location = new System.Drawing.Point(123, 33);
            this.topmarginField.Name = "topmarginField";
            this.topmarginField.Size = new System.Drawing.Size(60, 20);
            this.topmarginField.TabIndex = 12;
            this.topmarginField.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.topmarginField.ValueChanged += new System.EventHandler(this.topmarginField_ValueChanged);
            // 
            // leftmarginField
            // 
            this.leftmarginField.Location = new System.Drawing.Point(123, 59);
            this.leftmarginField.Name = "leftmarginField";
            this.leftmarginField.Size = new System.Drawing.Size(60, 20);
            this.leftmarginField.TabIndex = 13;
            this.leftmarginField.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.leftmarginField.ValueChanged += new System.EventHandler(this.leftmarginField_ValueChanged);
            // 
            // labelWidthField
            // 
            this.labelWidthField.Location = new System.Drawing.Point(123, 86);
            this.labelWidthField.Name = "labelWidthField";
            this.labelWidthField.Size = new System.Drawing.Size(60, 20);
            this.labelWidthField.TabIndex = 14;
            this.labelWidthField.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.labelWidthField.ValueChanged += new System.EventHandler(this.labelWidthField_ValueChanged);
            // 
            // labelheightField
            // 
            this.labelheightField.Location = new System.Drawing.Point(123, 112);
            this.labelheightField.Name = "labelheightField";
            this.labelheightField.Size = new System.Drawing.Size(60, 20);
            this.labelheightField.TabIndex = 15;
            this.labelheightField.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
            this.labelheightField.ValueChanged += new System.EventHandler(this.labelheightField_ValueChanged);
            // 
            // columnsField
            // 
            this.columnsField.Location = new System.Drawing.Point(123, 138);
            this.columnsField.Name = "columnsField";
            this.columnsField.Size = new System.Drawing.Size(60, 20);
            this.columnsField.TabIndex = 16;
            this.columnsField.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnsField.ValueChanged += new System.EventHandler(this.columnsField_ValueChanged);
            // 
            // rowsField
            // 
            this.rowsField.Location = new System.Drawing.Point(123, 164);
            this.rowsField.Name = "rowsField";
            this.rowsField.Size = new System.Drawing.Size(60, 20);
            this.rowsField.TabIndex = 17;
            this.rowsField.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rowsField.ValueChanged += new System.EventHandler(this.rowsField_ValueChanged);
            // 
            // verspaceField
            // 
            this.verspaceField.Location = new System.Drawing.Point(123, 190);
            this.verspaceField.Name = "verspaceField";
            this.verspaceField.Size = new System.Drawing.Size(60, 20);
            this.verspaceField.TabIndex = 18;
            this.verspaceField.ValueChanged += new System.EventHandler(this.verspaceField_ValueChanged);
            // 
            // horSpaceField
            // 
            this.horSpaceField.Location = new System.Drawing.Point(123, 216);
            this.horSpaceField.Name = "horSpaceField";
            this.horSpaceField.Size = new System.Drawing.Size(60, 20);
            this.horSpaceField.TabIndex = 19;
            this.horSpaceField.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.horSpaceField.ValueChanged += new System.EventHandler(this.horSpaceField_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Insert here a comma separated list of barcodes:";
            // 
            // printBorderField
            // 
            this.printBorderField.AutoSize = true;
            this.printBorderField.Location = new System.Drawing.Point(219, 396);
            this.printBorderField.Name = "printBorderField";
            this.printBorderField.Size = new System.Drawing.Size(110, 17);
            this.printBorderField.TabIndex = 22;
            this.printBorderField.Text = "Print Label Border";
            this.printBorderField.UseVisualStyleBackColor = true;
            this.printBorderField.CheckedChanged += new System.EventHandler(this.printBorderField_CheckedChanged);
            // 
            // openaftersaveField
            // 
            this.openaftersaveField.AutoSize = true;
            this.openaftersaveField.Checked = true;
            this.openaftersaveField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openaftersaveField.Location = new System.Drawing.Point(219, 419);
            this.openaftersaveField.Name = "openaftersaveField";
            this.openaftersaveField.Size = new System.Drawing.Size(134, 17);
            this.openaftersaveField.TabIndex = 23;
            this.openaftersaveField.Text = "Open PDF after saving";
            this.openaftersaveField.UseVisualStyleBackColor = true;
            this.openaftersaveField.CheckedChanged += new System.EventHandler(this.openaftersaveField_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "CHANGE LOGO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FEALabelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openaftersaveField);
            this.Controls.Add(this.printBorderField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.horSpaceField);
            this.Controls.Add(this.verspaceField);
            this.Controls.Add(this.rowsField);
            this.Controls.Add(this.columnsField);
            this.Controls.Add(this.labelheightField);
            this.Controls.Add(this.labelWidthField);
            this.Controls.Add(this.leftmarginField);
            this.Controls.Add(this.topmarginField);
            this.Controls.Add(this.pageSizeCombobox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodesField);
            this.Controls.Add(this.button1);
            this.Name = "FEALabelerForm";
            this.Text = "FEA Label Generator 1.0.3";
            ((System.ComponentModel.ISupportInitialize)(this.topmarginField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftmarginField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelWidthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelheightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verspaceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horSpaceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox barcodesField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox pageSizeCombobox;
        private System.Windows.Forms.NumericUpDown topmarginField;
        private System.Windows.Forms.NumericUpDown leftmarginField;
        private System.Windows.Forms.NumericUpDown labelWidthField;
        private System.Windows.Forms.NumericUpDown labelheightField;
        private System.Windows.Forms.NumericUpDown columnsField;
        private System.Windows.Forms.NumericUpDown rowsField;
        private System.Windows.Forms.NumericUpDown verspaceField;
        private System.Windows.Forms.NumericUpDown horSpaceField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox printBorderField;
        private System.Windows.Forms.CheckBox openaftersaveField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

