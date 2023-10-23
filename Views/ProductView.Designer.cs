namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgProduct = new DataGridView();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPageProductDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductObservation = new TextBox();
            label4 = new Label();
            TxtProductName = new TextBox();
            label3 = new Label();
            TxtProductId = new TextBox();
            label2 = new Label();
            TxtProductPrice = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.Control;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(127, 23);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 332);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label1);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(717, 304);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            tabPageProductList.Click += tabPageProductList_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(512, 230);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(199, 59);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(512, 154);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(199, 64);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(512, 88);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(199, 62);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(512, 20);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(199, 65);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(466, 10);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 44);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(13, 62);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(426, 225);
            DgProduct.TabIndex = 4;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(11, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(428, 23);
            TxtSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 2;
            label1.Text = "SEARCH PRODUCTS";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductObservation);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label2);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(717, 304);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(489, 155);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 45);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(344, 155);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 45);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(12, 167);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.PlaceholderText = "Product Observation";
            TxtProductObservation.Size = new Size(226, 98);
            TxtProductObservation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 6;
            label4.Text = "PRODUCTS OBSERVATION\r\n";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(12, 107);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "ProductsName";
            TxtProductName.Size = new Size(193, 23);
            TxtProductName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 4;
            label3.Text = "PRODUCTS NAME";
            label3.Click += label3_Click;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(12, 43);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(193, 23);
            TxtProductId.TabIndex = 3;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 2;
            label2.Text = "PRODUCTS ID";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(253, 43);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Enter price";
            TxtProductPrice.Size = new Size(193, 23);
            TxtProductPrice.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(253, 19);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 11;
            label5.Text = "PRODUCTS PRICE";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private TextBox TxtSearch;
        private Label label1;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductName;
        private Label label3;
        private TextBox TxtProductId;
        private Label label2;
        private TextBox TxtProductObservation;
        private Label label4;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtProductPrice;
        private Label label5;
    }
}