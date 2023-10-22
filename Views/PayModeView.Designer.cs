namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 78);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 372);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgPayMode);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PagePayModeList";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(TxtPayModeId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(11, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(385, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(423, 10);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(46, 45);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(11, 59);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(529, 277);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(546, 73);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(226, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(546, 124);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(226, 45);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(546, 175);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(226, 45);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(546, 226);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(226, 45);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(20, 39);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(100, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(19, 107);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(100, 23);
            TxtPayModeName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 81);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Pay Mode Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 156);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(17, 187);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(203, 88);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(26, 281);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 45);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(131, 281);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 45);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPage2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Label label4;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}