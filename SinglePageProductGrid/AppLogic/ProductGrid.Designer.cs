namespace SinglePageProductGrid
{
    partial class ProductGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGrid));
            this.addProduct = new System.Windows.Forms.Button();
            this.productComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.ComboBox();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.PictureBox();
            this.titleGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(284, 345);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(93, 23);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // productComboBox1
            // 
            this.productComboBox1.FormattingEnabled = true;
            this.productComboBox1.Items.AddRange(new object[] {
            "Seatcraft Home Theater Loveseat",
            "Lena Loveseat",
            "Parker Recliner",
            "Steamer Bar Cabinet",
            "Henjes Coffee Table"});
            this.productComboBox1.Location = new System.Drawing.Point(16, 323);
            this.productComboBox1.Name = "productComboBox1";
            this.productComboBox1.Size = new System.Drawing.Size(209, 21);
            this.productComboBox1.TabIndex = 0;
            this.productComboBox1.Text = "Seatcraft Home Theater Loveseat";
            this.productComboBox1.SelectedIndexChanged += new System.EventHandler(this.productComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 374);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(364, 81);
            this.description.TabIndex = 3;
            this.description.TabStop = false;
            this.description.Text = "A chair worthy of its own audience, we welcome you to enjoy one of our most luxur" +
    "ious sectionals ever, built with one of our most exceptional leathers.";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.title.Location = new System.Drawing.Point(12, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(288, 24);
            this.title.TabIndex = 6;
            this.title.Text = "Seatcraft Home Theater Loveseat";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.price.Location = new System.Drawing.Point(12, 281);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(85, 24);
            this.price.TabIndex = 7;
            this.price.Text = "$1799.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(299, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.FormattingEnabled = true;
            this.quantity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantity.Location = new System.Drawing.Point(303, 318);
            this.quantity.Name = "quantity";
            this.quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity.Size = new System.Drawing.Size(74, 21);
            this.quantity.TabIndex = 9;
            this.quantity.Text = "0";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToOrderColumns = true;
            this.productsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleGrid,
            this.quantityGrid,
            this.priceGrid,
            this.descriptionGrid});
            this.productsGrid.GridColor = System.Drawing.SystemColors.Highlight;
            this.productsGrid.Location = new System.Drawing.Point(396, 12);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.Size = new System.Drawing.Size(664, 443);
            this.productsGrid.TabIndex = 3;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.ImageLocation = "";
            this.image.InitialImage = ((System.Drawing.Image)(resources.GetObject("image.InitialImage")));
            this.image.Location = new System.Drawing.Point(12, 39);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(365, 239);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // titleGrid
            // 
            this.titleGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleGrid.HeaderText = "Title";
            this.titleGrid.Name = "titleGrid";
            this.titleGrid.ReadOnly = true;
            // 
            // quantityGrid
            // 
            this.quantityGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGrid.HeaderText = "Quantity";
            this.quantityGrid.Name = "quantityGrid";
            this.quantityGrid.ReadOnly = true;
            // 
            // priceGrid
            // 
            this.priceGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceGrid.HeaderText = "Price";
            this.priceGrid.Name = "priceGrid";
            this.priceGrid.ReadOnly = true;
            // 
            // descriptionGrid
            // 
            this.descriptionGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionGrid.HeaderText = "Description";
            this.descriptionGrid.Name = "descriptionGrid";
            this.descriptionGrid.ReadOnly = true;
            // 
            // ProductGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1072, 467);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.title);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productComboBox1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.addProduct);
            this.MaximumSize = new System.Drawing.Size(1088, 506);
            this.MinimumSize = new System.Drawing.Size(1088, 506);
            this.Name = "ProductGrid";
            this.Text = "Product Grid";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ComboBox productComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quantity;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionGrid;
    }
}

