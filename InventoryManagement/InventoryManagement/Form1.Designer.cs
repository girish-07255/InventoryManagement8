namespace InventoryManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblID = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            txtID1 = new System.Windows.Forms.TextBox();
            txtName1 = new System.Windows.Forms.TextBox();
            txtCategory1 = new System.Windows.Forms.TextBox();
            txtQuantity1 = new System.Windows.Forms.TextBox();
            txtPrice1 = new System.Windows.Forms.TextBox();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            btnAdd1 = new System.Windows.Forms.Button();
            btnView1 = new System.Windows.Forms.Button();
            btnUpdate1 = new System.Windows.Forms.Button();
            btnDelete1 = new System.Windows.Forms.Button();
            btnClear1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(30, 33);
            lblID.Name = "lblID";
            lblID.Text = "Product ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(30, 73);
            lblName.Name = "lblName";
            lblName.Text = "Product Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(30, 113);
            lblCategory.Name = "lblCategory";
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(30, 153);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(30, 193);
            lblPrice.Name = "lblPrice";
            lblPrice.Text = "Price";
            // 
            // txtID1
            // 
            txtID1.Location = new System.Drawing.Point(140, 30);
            txtID1.Name = "txtID1";
            txtID1.Size = new System.Drawing.Size(150, 27);
            txtID1.TabIndex = 0;
            // 
            // txtName1
            // 
            txtName1.Location = new System.Drawing.Point(140, 70);
            txtName1.Name = "txtName1";
            txtName1.Size = new System.Drawing.Size(150, 27);
            txtName1.TabIndex = 1;
            // 
            // txtCategory1
            // 
            txtCategory1.Location = new System.Drawing.Point(140, 110);
            txtCategory1.Name = "txtCategory1";
            txtCategory1.Size = new System.Drawing.Size(150, 27);
            txtCategory1.TabIndex = 2;
            // 
            // txtQuantity1
            // 
            txtQuantity1.Location = new System.Drawing.Point(140, 150);
            txtQuantity1.Name = "txtQuantity1";
            txtQuantity1.Size = new System.Drawing.Size(150, 27);
            txtQuantity1.TabIndex = 3;
            // 
            // txtPrice1
            // 
            txtPrice1.Location = new System.Drawing.Point(140, 190);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new System.Drawing.Size(150, 27);
            txtPrice1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(320, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new System.Drawing.Size(520, 260);
            dataGridView2.TabIndex = 5;
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new System.Drawing.Point(30, 320);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new System.Drawing.Size(90, 35);
            btnAdd1.TabIndex = 6;
            btnAdd1.Text = "Add";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // btnView1
            // 
            btnView1.Location = new System.Drawing.Point(140, 320);
            btnView1.Name = "btnView1";
            btnView1.Size = new System.Drawing.Size(90, 35);
            btnView1.TabIndex = 7;
            btnView1.Text = "View";
            btnView1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate1
            // 
            btnUpdate1.Location = new System.Drawing.Point(250, 320);
            btnUpdate1.Name = "btnUpdate1";
            btnUpdate1.Size = new System.Drawing.Size(90, 35);
            btnUpdate1.TabIndex = 8;
            btnUpdate1.Text = "Update";
            btnUpdate1.UseVisualStyleBackColor = true;
            // 
            // btnDelete1
            // 
            btnDelete1.Location = new System.Drawing.Point(360, 320);
            btnDelete1.Name = "btnDelete1";
            btnDelete1.Size = new System.Drawing.Size(90, 35);
            btnDelete1.TabIndex = 9;
            btnDelete1.Text = "Delete";
            btnDelete1.UseVisualStyleBackColor = true;
            // 
            // btnClear1
            // 
            btnClear1.Location = new System.Drawing.Point(470, 320);
            btnClear1.Name = "btnClear1";
            btnClear1.Size = new System.Drawing.Size(90, 35);
            btnClear1.TabIndex = 10;
            btnClear1.Text = "Clear";
            btnClear1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 400);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblCategory);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(txtID1);
            Controls.Add(txtName1);
            Controls.Add(txtCategory1);
            Controls.Add(txtQuantity1);
            Controls.Add(txtPrice1);
            Controls.Add(dataGridView2);
            Controls.Add(btnAdd1);
            Controls.Add(btnView1);
            Controls.Add(btnUpdate1);
            Controls.Add(btnDelete1);
            Controls.Add(btnClear1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtCategory1;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnView1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnClear1;
    }
}
