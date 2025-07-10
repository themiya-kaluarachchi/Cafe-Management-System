namespace CafeManagementSystem
{
    partial class ItemForm
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
            this.guestLogin = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.EditItemBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.sellerName = new System.Windows.Forms.TextBox();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.ItemsList = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // guestLogin
            // 
            this.guestLogin.AutoSize = true;
            this.guestLogin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.guestLogin.Location = new System.Drawing.Point(-209, 570);
            this.guestLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestLogin.Name = "guestLogin";
            this.guestLogin.Size = new System.Drawing.Size(71, 24);
            this.guestLogin.TabIndex = 11;
            this.guestLogin.Text = "Logout";
            this.guestLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.closeBtn.Location = new System.Drawing.Point(1220, -5);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(44, 44);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.LogOut.Location = new System.Drawing.Point(45, 709);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(71, 24);
            this.LogOut.TabIndex = 14;
            this.LogOut.Text = "Logout";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.DeleteItemBtn);
            this.panel1.Controls.Add(this.EditItemBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.AddItemBtn);
            this.panel1.Controls.Add(this.sellerName);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.ItemsList);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(191, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 672);
            this.panel1.TabIndex = 12;
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.DeleteItemBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.DeleteItemBtn.Location = new System.Drawing.Point(236, 429);
            this.DeleteItemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(86, 49);
            this.DeleteItemBtn.TabIndex = 21;
            this.DeleteItemBtn.Text = "Delete";
            this.DeleteItemBtn.UseVisualStyleBackColor = false;
            // 
            // EditItemBtn
            // 
            this.EditItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.EditItemBtn.FlatAppearance.BorderSize = 0;
            this.EditItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItemBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.EditItemBtn.Location = new System.Drawing.Point(134, 429);
            this.EditItemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditItemBtn.Name = "EditItemBtn";
            this.EditItemBtn.Size = new System.Drawing.Size(86, 49);
            this.EditItemBtn.TabIndex = 20;
            this.EditItemBtn.Text = "Edit";
            this.EditItemBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(627, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "Items List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(10, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "ItemPrice :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(7, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "ItemName :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "ItemNum  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(167, 322);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(195, 30);
            this.quantity.TabIndex = 15;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.AddItemBtn.FlatAppearance.BorderSize = 0;
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.AddItemBtn.Location = new System.Drawing.Point(33, 429);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(86, 49);
            this.AddItemBtn.TabIndex = 11;
            this.AddItemBtn.Text = "Add";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            // 
            // sellerName
            // 
            this.sellerName.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerName.Location = new System.Drawing.Point(167, 211);
            this.sellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(195, 30);
            this.sellerName.TabIndex = 9;
            // 
            // orderNum
            // 
            this.orderNum.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNum.Location = new System.Drawing.Point(167, 154);
            this.orderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(195, 30);
            this.orderNum.TabIndex = 8;
            // 
            // ItemsList
            // 
            this.ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsList.Location = new System.Drawing.Point(399, 153);
            this.ItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.RowHeadersWidth = 51;
            this.ItemsList.Size = new System.Drawing.Size(612, 500);
            this.ItemsList.TabIndex = 7;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.category.Location = new System.Drawing.Point(202, 264);
            this.category.Margin = new System.Windows.Forms.Padding(4);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(160, 37);
            this.category.TabIndex = 6;
            this.category.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(431, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manage Items\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.OrderBtn.Location = new System.Drawing.Point(34, 56);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(135, 49);
            this.OrderBtn.TabIndex = 22;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.UserBtn.Location = new System.Drawing.Point(34, 139);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(135, 49);
            this.UserBtn.TabIndex = 23;
            this.UserBtn.Text = "Users";
            this.UserBtn.UseVisualStyleBackColor = false;
            this.UserBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1260, 752);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guestLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label guestLogin;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.TextBox sellerName;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.DataGridView ItemsList;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button EditItemBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button UserBtn;
    }
}