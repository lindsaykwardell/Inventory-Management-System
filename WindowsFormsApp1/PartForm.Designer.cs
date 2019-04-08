namespace WindowsFormsApp1
{
    partial class PartForm
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
            this.partFormLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.specialTextBox = new System.Windows.Forms.TextBox();
            this.specialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partFormLabel
            // 
            this.partFormLabel.AutoSize = true;
            this.partFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partFormLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partFormLabel.Location = new System.Drawing.Point(12, 9);
            this.partFormLabel.Name = "partFormLabel";
            this.partFormLabel.Size = new System.Drawing.Size(88, 25);
            this.partFormLabel.TabIndex = 10;
            this.partFormLabel.Text = "Add Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price/Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(133, 86);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 18;
            this.IDTextBox.Text = "Auto Gen - Disabled";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(133, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Location = new System.Drawing.Point(133, 190);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(133, 245);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(133, 295);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(61, 20);
            this.maxTextBox.TabIndex = 5;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(284, 295);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(61, 20);
            this.minTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(85, 384);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 384);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Checked = true;
            this.inHouseRadio.Location = new System.Drawing.Point(108, 46);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadio.TabIndex = 0;
            this.inHouseRadio.TabStop = true;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.UseVisualStyleBackColor = true;
            this.inHouseRadio.CheckedChanged += new System.EventHandler(this.inHouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(197, 46);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadio.TabIndex = 1;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // specialTextBox
            // 
            this.specialTextBox.Location = new System.Drawing.Point(133, 347);
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialTextBox.TabIndex = 7;
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(29, 353);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(62, 13);
            this.specialLabel.TabIndex = 17;
            this.specialLabel.Text = "Machine ID";
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.specialTextBox);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inStockTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partFormLabel);
            this.Name = "PartForm";
            this.Text = "AddPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partFormLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton inHouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.TextBox specialTextBox;
        private System.Windows.Forms.Label specialLabel;
    }
}