namespace TTB
{
    partial class frmDanhgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhgia));
            this.phanloai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phutrach = new System.Windows.Forms.TextBox();
            this.chucdanh = new System.Windows.Forms.TextBox();
            this.daotao = new System.Windows.Forms.TextBox();
            this.coquan = new System.Windows.Forms.TextBox();
            this.quyetdinh = new System.Windows.Forms.TextBox();
            this.ngay = new MaskedBox.MaskedBox();
            this.tinhhinh = new System.Windows.Forms.TextBox();
            this.khauhao = new System.Windows.Forms.TextBox();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tuoitho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.baotri = new System.Windows.Forms.NumericUpDown();
            this.tailieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baotri)).BeginInit();
            this.SuspendLayout();
            // 
            // phanloai
            // 
            this.phanloai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phanloai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phanloai.Location = new System.Drawing.Point(71, 4);
            this.phanloai.Name = "phanloai";
            this.phanloai.Size = new System.Drawing.Size(442, 21);
            this.phanloai.TabIndex = 1;
            this.phanloai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phanloai_KeyDown);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phân loại :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người được giao trách nhiệm sử dụng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức danh :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đã được đào tạo, bồi dưỡng về sử dụng thiết bị :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cơ quan đào tạo, bồi dưỡng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số Quyết định giao trách nhiệm sử dụng :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(368, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sử dụng ngày :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tình hình thiết bị và phụ tùng kèm theo :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Khấu hao tài sản hàng năm :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phutrach
            // 
            this.phutrach.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phutrach.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phutrach.Location = new System.Drawing.Point(202, 27);
            this.phutrach.Name = "phutrach";
            this.phutrach.Size = new System.Drawing.Size(311, 21);
            this.phutrach.TabIndex = 3;
            this.phutrach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // chucdanh
            // 
            this.chucdanh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chucdanh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucdanh.Location = new System.Drawing.Point(76, 49);
            this.chucdanh.Name = "chucdanh";
            this.chucdanh.Size = new System.Drawing.Size(437, 21);
            this.chucdanh.TabIndex = 5;
            this.chucdanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // daotao
            // 
            this.daotao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.daotao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daotao.Location = new System.Drawing.Point(246, 72);
            this.daotao.Name = "daotao";
            this.daotao.Size = new System.Drawing.Size(267, 21);
            this.daotao.TabIndex = 7;
            this.daotao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // coquan
            // 
            this.coquan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.coquan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coquan.Location = new System.Drawing.Point(162, 96);
            this.coquan.Name = "coquan";
            this.coquan.Size = new System.Drawing.Size(351, 21);
            this.coquan.TabIndex = 9;
            this.coquan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // quyetdinh
            // 
            this.quyetdinh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.quyetdinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyetdinh.Location = new System.Drawing.Point(216, 142);
            this.quyetdinh.Name = "quyetdinh";
            this.quyetdinh.Size = new System.Drawing.Size(146, 21);
            this.quyetdinh.TabIndex = 13;
            this.quyetdinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // ngay
            // 
            this.ngay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Location = new System.Drawing.Point(449, 142);
            this.ngay.Mask = "##/##/####";
            this.ngay.MaxLength = 10;
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(64, 21);
            this.ngay.TabIndex = 15;
            this.ngay.Text = "  /  /    ";
            this.ngay.Validated += new System.EventHandler(this.ngay_Validated);
            // 
            // tinhhinh
            // 
            this.tinhhinh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tinhhinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhhinh.Location = new System.Drawing.Point(71, 209);
            this.tinhhinh.Multiline = true;
            this.tinhhinh.Name = "tinhhinh";
            this.tinhhinh.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tinhhinh.Size = new System.Drawing.Size(442, 82);
            this.tinhhinh.TabIndex = 21;
            // 
            // khauhao
            // 
            this.khauhao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.khauhao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khauhao.Location = new System.Drawing.Point(71, 310);
            this.khauhao.Multiline = true;
            this.khauhao.Name = "khauhao";
            this.khauhao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.khauhao.Size = new System.Drawing.Size(442, 80);
            this.khauhao.TabIndex = 23;
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(201, 396);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 26);
            this.butLuu.TabIndex = 24;
            this.butLuu.Text = "&Lưu";
            this.butLuu.UseVisualStyleBackColor = true;
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Location = new System.Drawing.Point(263, 396);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 26);
            this.butBoqua.TabIndex = 25;
            this.butBoqua.Text = "&Bỏ qua";
            this.butBoqua.UseVisualStyleBackColor = true;
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tuổi thọ :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tuoitho
            // 
            this.tuoitho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tuoitho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuoitho.Location = new System.Drawing.Point(71, 165);
            this.tuoitho.Name = "tuoitho";
            this.tuoitho.Size = new System.Drawing.Size(291, 21);
            this.tuoitho.TabIndex = 17;
            this.tuoitho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(363, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Thời hạn bảo trì :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baotri
            // 
            this.baotri.BackColor = System.Drawing.SystemColors.HighlightText;
            this.baotri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baotri.Location = new System.Drawing.Point(449, 165);
            this.baotri.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.baotri.Name = "baotri";
            this.baotri.Size = new System.Drawing.Size(63, 21);
            this.baotri.TabIndex = 19;
            this.baotri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // tailieu
            // 
            this.tailieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tailieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailieu.Location = new System.Drawing.Point(162, 119);
            this.tailieu.Name = "tailieu";
            this.tailieu.Size = new System.Drawing.Size(351, 21);
            this.tailieu.TabIndex = 11;
            this.tailieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phutrach_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tài liệu và phụ kiện kèm theo :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDanhgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 429);
            this.Controls.Add(this.coquan);
            this.Controls.Add(this.tailieu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.baotri);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tuoitho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.khauhao);
            this.Controls.Add(this.tinhhinh);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.quyetdinh);
            this.Controls.Add(this.daotao);
            this.Controls.Add(this.chucdanh);
            this.Controls.Add(this.phutrach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phanloai);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá tài sản";
            this.Load += new System.EventHandler(this.frmDanhgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baotri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox phanloai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phutrach;
        private System.Windows.Forms.TextBox chucdanh;
        private System.Windows.Forms.TextBox daotao;
        private System.Windows.Forms.TextBox coquan;
        private System.Windows.Forms.TextBox quyetdinh;
        private MaskedBox.MaskedBox ngay;
        private System.Windows.Forms.TextBox tinhhinh;
        private System.Windows.Forms.TextBox khauhao;
        private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butBoqua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tuoitho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown baotri;
        private System.Windows.Forms.TextBox tailieu;
        private System.Windows.Forms.Label label12;
    }
}