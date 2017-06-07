namespace Barcodec
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBoxBarcodeChecksum = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonChecksum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBarcodeTypes = new System.Windows.Forms.ComboBox();
            this.buttonGenerateBarcode = new System.Windows.Forms.Button();
            this.groupBoxBarcodeChecksum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBarcodeChecksum
            // 
            this.groupBoxBarcodeChecksum.Controls.Add(this.comboBoxBarcodeTypes);
            this.groupBoxBarcodeChecksum.Controls.Add(this.buttonGenerateBarcode);
            this.groupBoxBarcodeChecksum.Controls.Add(this.buttonChecksum);
            this.groupBoxBarcodeChecksum.Controls.Add(this.label2);
            this.groupBoxBarcodeChecksum.Controls.Add(this.label1);
            this.groupBoxBarcodeChecksum.Controls.Add(this.textBox1);
            this.groupBoxBarcodeChecksum.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBarcodeChecksum.Location = new System.Drawing.Point(17, 18);
            this.groupBoxBarcodeChecksum.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxBarcodeChecksum.Name = "groupBoxBarcodeChecksum";
            this.groupBoxBarcodeChecksum.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxBarcodeChecksum.Size = new System.Drawing.Size(451, 90);
            this.groupBoxBarcodeChecksum.TabIndex = 0;
            this.groupBoxBarcodeChecksum.TabStop = false;
            this.groupBoxBarcodeChecksum.Text = "Barcode Checksum";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(130, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonChecksum
            // 
            this.buttonChecksum.Location = new System.Drawing.Point(271, 46);
            this.buttonChecksum.Name = "buttonChecksum";
            this.buttonChecksum.Size = new System.Drawing.Size(81, 23);
            this.buttonChecksum.TabIndex = 2;
            this.buttonChecksum.Text = "Checksum";
            this.buttonChecksum.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxBarcodeTypes
            // 
            this.comboBoxBarcodeTypes.FormattingEnabled = true;
            this.comboBoxBarcodeTypes.Items.AddRange(new object[] {
            "EAN CODE",
            "CODABAR",
            "CODE 128",
            "CODE 93"});
            this.comboBoxBarcodeTypes.Location = new System.Drawing.Point(8, 46);
            this.comboBoxBarcodeTypes.Name = "comboBoxBarcodeTypes";
            this.comboBoxBarcodeTypes.Size = new System.Drawing.Size(111, 24);
            this.comboBoxBarcodeTypes.TabIndex = 3;
            // 
            // buttonGenerateBarcode
            // 
            this.buttonGenerateBarcode.Location = new System.Drawing.Point(358, 47);
            this.buttonGenerateBarcode.Name = "buttonGenerateBarcode";
            this.buttonGenerateBarcode.Size = new System.Drawing.Size(81, 23);
            this.buttonGenerateBarcode.TabIndex = 2;
            this.buttonGenerateBarcode.Text = "Generate";
            this.buttonGenerateBarcode.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 338);
            this.Controls.Add(this.groupBoxBarcodeChecksum);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(17, 18, 17, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcodec";
            this.groupBoxBarcodeChecksum.ResumeLayout(false);
            this.groupBoxBarcodeChecksum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBarcodeChecksum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxBarcodeTypes;
        private System.Windows.Forms.Button buttonGenerateBarcode;
        private System.Windows.Forms.Button buttonChecksum;
        private System.Windows.Forms.Label label2;
    }
}

