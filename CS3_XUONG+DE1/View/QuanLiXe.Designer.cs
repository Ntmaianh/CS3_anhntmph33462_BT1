namespace CS3_XUONG_DE1.View
{
    partial class QuanLiXe
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
            groupBox1 = new GroupBox();
            txtSl = new TextBox();
            txtGiaNhap = new TextBox();
            txtMoTa = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvXeMay = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnXoaForm = new Button();
            txtHienThi = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSl);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // txtSl
            // 
            txtSl.Location = new Point(66, 198);
            txtSl.Name = "txtSl";
            txtSl.Size = new Size(172, 23);
            txtSl.TabIndex = 6;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(66, 146);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(172, 23);
            txtGiaNhap.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(66, 89);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(172, 23);
            txtMoTa.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(66, 28);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(172, 23);
            txtTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 206);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Gía nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvXeMay);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(611, 232);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị ";
            // 
            // dgvXeMay
            // 
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeMay.Location = new Point(6, 76);
            dgvXeMay.Name = "dgvXeMay";
            dgvXeMay.RowTemplate.Height = 25;
            dgvXeMay.Size = new Size(599, 150);
            dgvXeMay.TabIndex = 2;
            dgvXeMay.CellMouseClick += dgvXeMay_CellMouseClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(138, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(398, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 35);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaForm);
            groupBox3.Controls.Add(txtHienThi);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(346, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 242);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(17, 188);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(212, 33);
            btnXoaForm.TabIndex = 3;
            btnXoaForm.Text = "Xóa form ";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(17, 136);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(212, 33);
            txtHienThi.TabIndex = 2;
            txtHienThi.Text = "Hiển thị";
            txtHienThi.UseVisualStyleBackColor = true;
            txtHienThi.Click += txtHienThi_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(17, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(212, 33);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 33);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // QuanLiXe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 569);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLiXe";
            Text = "QuanLiXe";
            Load += QuanLiXe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSl;
        private TextBox txtGiaNhap;
        private TextBox txtMoTa;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private GroupBox groupBox3;
        private Button btnXoaForm;
        private Button txtHienThi;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvXeMay;
        private TextBox txtTimKiem;
    }
}