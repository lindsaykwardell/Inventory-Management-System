namespace WindowsFormsApp1
{
    partial class ProductForm
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
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPartsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productFormLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductPanel.Controls.Add(this.IDTextBox);
            this.addProductPanel.Controls.Add(this.label1);
            this.addProductPanel.Controls.Add(this.cancelButton);
            this.addProductPanel.Controls.Add(this.deletePartButton);
            this.addProductPanel.Controls.Add(this.minTextBox);
            this.addProductPanel.Controls.Add(this.maxTextBox);
            this.addProductPanel.Controls.Add(this.label6);
            this.addProductPanel.Controls.Add(this.label5);
            this.addProductPanel.Controls.Add(this.addPartButton);
            this.addProductPanel.Controls.Add(this.partsTable);
            this.addProductPanel.Controls.Add(this.allPartsTable);
            this.addProductPanel.Controls.Add(this.partSearchBox);
            this.addProductPanel.Controls.Add(this.saveButton);
            this.addProductPanel.Controls.Add(this.searchPartsButton);
            this.addProductPanel.Controls.Add(this.priceTextBox);
            this.addProductPanel.Controls.Add(this.inStockTextBox);
            this.addProductPanel.Controls.Add(this.nameTextBox);
            this.addProductPanel.Controls.Add(this.priceLabel);
            this.addProductPanel.Controls.Add(this.inStockLabel);
            this.addProductPanel.Controls.Add(this.nameLabel);
            this.addProductPanel.Controls.Add(this.productFormLabel);
            this.addProductPanel.Location = new System.Drawing.Point(25, 28);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(753, 410);
            this.addProductPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(599, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(599, 316);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 9;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(158, 295);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(79, 20);
            this.minTextBox.TabIndex = 4;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(43, 295);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(79, 20);
            this.maxTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Min";
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(599, 167);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 8;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToAddRows = false;
            this.partsTable.AllowUserToDeleteRows = false;
            this.partsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.partsTable.GridColor = System.Drawing.SystemColors.Window;
            this.partsTable.Location = new System.Drawing.Point(250, 202);
            this.partsTable.MultiSelect = false;
            this.partsTable.Name = "partsTable";
            this.partsTable.ReadOnly = true;
            this.partsTable.RowHeadersVisible = false;
            this.partsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsTable.Size = new System.Drawing.Size(498, 108);
            this.partsTable.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Price/Cost Per Item";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // allPartsTable
            // 
            this.allPartsTable.AllowUserToAddRows = false;
            this.allPartsTable.AllowUserToDeleteRows = false;
            this.allPartsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.allPartsTable.GridColor = System.Drawing.SystemColors.Window;
            this.allPartsTable.Location = new System.Drawing.Point(250, 53);
            this.allPartsTable.MultiSelect = false;
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.ReadOnly = true;
            this.allPartsTable.RowHeadersVisible = false;
            this.allPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsTable.Size = new System.Drawing.Size(498, 108);
            this.allPartsTable.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price/Cost Per Item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(540, 15);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(190, 20);
            this.partSearchBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(500, 369);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Location = new System.Drawing.Point(459, 15);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartsButton.TabIndex = 7;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(62, 235);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Location = new System.Drawing.Point(62, 174);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(9, 242);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price";
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Location = new System.Drawing.Point(9, 181);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(22, 13);
            this.inStockLabel.TabIndex = 13;
            this.inStockLabel.Text = "Inv";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // productFormLabel
            // 
            this.productFormLabel.AutoSize = true;
            this.productFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFormLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.productFormLabel.Location = new System.Drawing.Point(36, 22);
            this.productFormLabel.Name = "productFormLabel";
            this.productFormLabel.Size = new System.Drawing.Size(120, 25);
            this.productFormLabel.TabIndex = 17;
            this.productFormLabel.Text = "Add Product";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(62, 64);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 20;
            this.IDTextBox.Text = "Auto Gen - Disabled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProductPanel);
            this.Name = "ProductForm";
            this.Text = "Add Product";
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.Label productFormLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView partsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView allPartsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
    }
}