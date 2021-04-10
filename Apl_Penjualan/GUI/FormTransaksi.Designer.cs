
namespace Apl_Penjualan.GUI
{
    partial class FormTransaksi
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
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_caripelanggan = new System.Windows.Forms.Button();
            this.dateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.textBox_kwitansi = new System.Windows.Forms.TextBox();
            this.groupBox_buku = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_caribuku = new System.Windows.Forms.Button();
            this.textBox_jumlah = new System.Windows.Forms.TextBox();
            this.textBox_hargabuku = new System.Windows.Forms.TextBox();
            this.textBox_kodebuku = new System.Windows.Forms.TextBox();
            this.textBox_namabuku = new System.Windows.Forms.TextBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.label_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_buku.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.pictureBox1);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Controls.Add(this.button_caripelanggan);
            this.groupBox_form.Controls.Add(this.dateTimePicker_kwitansi);
            this.groupBox_form.Controls.Add(this.textBox_idpelanggan);
            this.groupBox_form.Controls.Add(this.textBox_namapelanggan);
            this.groupBox_form.Controls.Add(this.textBox_kwitansi);
            this.groupBox_form.Location = new System.Drawing.Point(23, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(565, 297);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "::Transaksi::";
            this.groupBox_form.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apl_Penjualan.Properties.Resources.transaction__1_;
            this.pictureBox1.Location = new System.Drawing.Point(56, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "No Kwitansi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_caripelanggan
            // 
            this.button_caripelanggan.Image = global::Apl_Penjualan.Properties.Resources.magnifying_glass__1_;
            this.button_caripelanggan.Location = new System.Drawing.Point(192, 239);
            this.button_caripelanggan.Name = "button_caripelanggan";
            this.button_caripelanggan.Size = new System.Drawing.Size(68, 39);
            this.button_caripelanggan.TabIndex = 5;
            this.button_caripelanggan.Text = "\r\n";
            this.button_caripelanggan.UseVisualStyleBackColor = true;
            this.button_caripelanggan.Click += new System.EventHandler(this.button_caripelanggan_Click);
            // 
            // dateTimePicker_kwitansi
            // 
            this.dateTimePicker_kwitansi.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_kwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_kwitansi.Location = new System.Drawing.Point(319, 120);
            this.dateTimePicker_kwitansi.Name = "dateTimePicker_kwitansi";
            this.dateTimePicker_kwitansi.Size = new System.Drawing.Size(224, 39);
            this.dateTimePicker_kwitansi.TabIndex = 4;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(30, 239);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(156, 39);
            this.textBox_idpelanggan.TabIndex = 3;
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(317, 239);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(226, 39);
            this.textBox_namapelanggan.TabIndex = 2;
            // 
            // textBox_kwitansi
            // 
            this.textBox_kwitansi.Location = new System.Drawing.Point(319, 51);
            this.textBox_kwitansi.Name = "textBox_kwitansi";
            this.textBox_kwitansi.Size = new System.Drawing.Size(224, 39);
            this.textBox_kwitansi.TabIndex = 1;
            // 
            // groupBox_buku
            // 
            this.groupBox_buku.Controls.Add(this.label8);
            this.groupBox_buku.Controls.Add(this.label7);
            this.groupBox_buku.Controls.Add(this.label6);
            this.groupBox_buku.Controls.Add(this.label5);
            this.groupBox_buku.Controls.Add(this.button_caribuku);
            this.groupBox_buku.Controls.Add(this.textBox_jumlah);
            this.groupBox_buku.Controls.Add(this.textBox_hargabuku);
            this.groupBox_buku.Controls.Add(this.textBox_kodebuku);
            this.groupBox_buku.Controls.Add(this.textBox_namabuku);
            this.groupBox_buku.Location = new System.Drawing.Point(23, 315);
            this.groupBox_buku.Name = "groupBox_buku";
            this.groupBox_buku.Size = new System.Drawing.Size(565, 257);
            this.groupBox_buku.TabIndex = 1;
            this.groupBox_buku.TabStop = false;
            this.groupBox_buku.Text = "::Input Buku::";
            this.groupBox_buku.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nama Buku";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kode Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga Buku";
            // 
            // button_caribuku
            // 
            this.button_caribuku.Image = global::Apl_Penjualan.Properties.Resources.magnifying_glass__1_;
            this.button_caribuku.Location = new System.Drawing.Point(214, 86);
            this.button_caribuku.Name = "button_caribuku";
            this.button_caribuku.Size = new System.Drawing.Size(65, 39);
            this.button_caribuku.TabIndex = 6;
            this.button_caribuku.Text = "\r\n";
            this.button_caribuku.UseVisualStyleBackColor = true;
            this.button_caribuku.Click += new System.EventHandler(this.button_caribuku_Click);
            // 
            // textBox_jumlah
            // 
            this.textBox_jumlah.Location = new System.Drawing.Point(325, 192);
            this.textBox_jumlah.Name = "textBox_jumlah";
            this.textBox_jumlah.Size = new System.Drawing.Size(218, 39);
            this.textBox_jumlah.TabIndex = 3;
            // 
            // textBox_hargabuku
            // 
            this.textBox_hargabuku.Location = new System.Drawing.Point(16, 192);
            this.textBox_hargabuku.Name = "textBox_hargabuku";
            this.textBox_hargabuku.Size = new System.Drawing.Size(192, 39);
            this.textBox_hargabuku.TabIndex = 2;
            // 
            // textBox_kodebuku
            // 
            this.textBox_kodebuku.Location = new System.Drawing.Point(15, 86);
            this.textBox_kodebuku.Name = "textBox_kodebuku";
            this.textBox_kodebuku.Size = new System.Drawing.Size(193, 39);
            this.textBox_kodebuku.TabIndex = 1;
            // 
            // textBox_namabuku
            // 
            this.textBox_namabuku.Location = new System.Drawing.Point(325, 86);
            this.textBox_namabuku.Name = "textBox_namabuku";
            this.textBox_namabuku.Size = new System.Drawing.Size(218, 39);
            this.textBox_namabuku.TabIndex = 0;
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.label_total);
            this.groupBox_data.Controls.Add(this.label9);
            this.groupBox_data.Location = new System.Drawing.Point(610, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(708, 648);
            this.groupBox_data.TabIndex = 2;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "::Data Transaksi::";
            this.groupBox_data.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(438, 752);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(23, 28);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Seluruhnya Rp.";
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(636, 83);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.RowHeadersWidth = 62;
            this.dataGridView_transaksi.RowTemplate.Height = 28;
            this.dataGridView_transaksi.Size = new System.Drawing.Size(664, 536);
            this.dataGridView_transaksi.TabIndex = 0;
            this.dataGridView_transaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksi_CellDoubleClick);
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(424, 593);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(164, 67);
            this.button_simpan.TabIndex = 3;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Location = new System.Drawing.Point(23, 593);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(164, 67);
            this.button_baru.TabIndex = 4;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 682);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.dataGridView_transaksi);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_buku);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_buku.ResumeLayout(false);
            this.groupBox_buku.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_buku;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_kwitansi;
        private System.Windows.Forms.TextBox textBox_jumlah;
        private System.Windows.Forms.TextBox textBox_hargabuku;
        private System.Windows.Forms.TextBox textBox_kodebuku;
        private System.Windows.Forms.TextBox textBox_namabuku;
        private System.Windows.Forms.Button button_caripelanggan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kwitansi;
        private System.Windows.Forms.Button button_caribuku;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_baru;
    }
}