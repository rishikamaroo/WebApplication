namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.itemlistBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.PurchaseItem = new System.Windows.Forms.Button();
            this.ShoppingBoxListBoxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.PurchaseAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.BackColor = System.Drawing.Color.Transparent;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(16, 24);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(277, 25);
            this.HeaderText.TabIndex = 2;
            this.HeaderText.Text = "Consignment Shop Demo";
            this.HeaderText.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemlistBox
            // 
            this.itemlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemlistBox.FormattingEnabled = true;
            this.itemlistBox.ItemHeight = 16;
            this.itemlistBox.Location = new System.Drawing.Point(21, 102);
            this.itemlistBox.Name = "itemlistBox";
            this.itemlistBox.Size = new System.Drawing.Size(166, 148);
            this.itemlistBox.TabIndex = 3;
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(18, 65);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(90, 17);
            this.ItemsListBoxLabel.TabIndex = 1;
            this.ItemsListBoxLabel.Text = "Store Items";
            // 
            // PurchaseItem
            // 
            this.PurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.PurchaseItem.Location = new System.Drawing.Point(259, 154);
            this.PurchaseItem.Name = "PurchaseItem";
            this.PurchaseItem.Size = new System.Drawing.Size(148, 33);
            this.PurchaseItem.TabIndex = 0;
            this.PurchaseItem.Text = "Add To Cart -->";
            this.PurchaseItem.UseVisualStyleBackColor = true;
            this.PurchaseItem.Click += new System.EventHandler(this.AddToCart);
            // 
            // ShoppingBoxListBoxLabel
            // 
            this.ShoppingBoxListBoxLabel.AutoSize = true;
            this.ShoppingBoxListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ShoppingBoxListBoxLabel.Location = new System.Drawing.Point(416, 65);
            this.ShoppingBoxListBoxLabel.Name = "ShoppingBoxListBoxLabel";
            this.ShoppingBoxListBoxLabel.Size = new System.Drawing.Size(111, 17);
            this.ShoppingBoxListBoxLabel.TabIndex = 4;
            this.ShoppingBoxListBoxLabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.ShoppingCartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 16;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(465, 102);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(177, 148);
            this.ShoppingCartListBox.TabIndex = 5;
            // 
            // PurchaseAll
            // 
            this.PurchaseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.PurchaseAll.Location = new System.Drawing.Point(475, 275);
            this.PurchaseAll.Name = "PurchaseAll";
            this.PurchaseAll.Size = new System.Drawing.Size(167, 34);
            this.PurchaseAll.TabIndex = 6;
            this.PurchaseAll.Text = "Purchase";
            this.PurchaseAll.UseVisualStyleBackColor = true;
            this.PurchaseAll.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 16;
            this.vendorListBox.Location = new System.Drawing.Point(21, 395);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(166, 148);
            this.vendorListBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(341, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.storeProfitValue.Location = new System.Drawing.Point(462, 354);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(49, 17);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "0.00$";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 658);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseAll);
            this.Controls.Add(this.ShoppingBoxListBoxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.PurchaseItem);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.itemlistBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox itemlistBox;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.Button PurchaseItem;
        private System.Windows.Forms.Label ShoppingBoxListBoxLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button PurchaseAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label storeProfitValue;
    }
}