
namespace WinFormTest
{
    partial class frmGenerate
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLicenceType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textExperienceDays = new System.Windows.Forms.TextBox();
            this.textProductKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(605, 160);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(86, 29);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(114, 20);
            this.textProductID.Multiline = true;
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(588, 23);
            this.textProductID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Type:";
            // 
            // comboBoxLicenceType
            // 
            this.comboBoxLicenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLicenceType.FormattingEnabled = true;
            this.comboBoxLicenceType.Items.AddRange(new object[] {
            "Full",
            "Trial"});
            this.comboBoxLicenceType.Location = new System.Drawing.Point(114, 57);
            this.comboBoxLicenceType.Name = "comboBoxLicenceType";
            this.comboBoxLicenceType.Size = new System.Drawing.Size(119, 23);
            this.comboBoxLicenceType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experience Days:";
            // 
            // textExperienceDays
            // 
            this.textExperienceDays.Location = new System.Drawing.Point(114, 92);
            this.textExperienceDays.Multiline = true;
            this.textExperienceDays.Name = "textExperienceDays";
            this.textExperienceDays.Size = new System.Drawing.Size(119, 23);
            this.textExperienceDays.TabIndex = 6;
            // 
            // textProductKey
            // 
            this.textProductKey.Location = new System.Drawing.Point(114, 131);
            this.textProductKey.Multiline = true;
            this.textProductKey.Name = "textProductKey";
            this.textProductKey.ReadOnly = true;
            this.textProductKey.Size = new System.Drawing.Size(577, 23);
            this.textProductKey.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Key:";
            // 
            // frmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 211);
            this.Controls.Add(this.textProductKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textExperienceDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLicenceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.frmGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLicenceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textExperienceDays;
        private System.Windows.Forms.TextBox textProductKey;
        private System.Windows.Forms.Label label4;
    }
}