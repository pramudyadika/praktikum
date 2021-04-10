
namespace Apl_Penjualan.GUI
{
    partial class DialogBuku
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.dataGridView_buku = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buku)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_buku);
            this.groupBox1.Controls.Add(this.textBox_cari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "::Data Buku::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari buku (kode/nama)";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cari.Location = new System.Drawing.Point(271, 28);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(443, 30);
            this.textBox_cari.TabIndex = 1;
            // 
            // dataGridView_buku
            // 
            this.dataGridView_buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buku.Location = new System.Drawing.Point(16, 83);
            this.dataGridView_buku.Name = "dataGridView_buku";
            this.dataGridView_buku.RowHeadersWidth = 62;
            this.dataGridView_buku.RowTemplate.Height = 28;
            this.dataGridView_buku.Size = new System.Drawing.Size(707, 291);
            this.dataGridView_buku.TabIndex = 2;
            this.dataGridView_buku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_buku_CellContentClick);
            this.dataGridView_buku.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_buku_CellDoubleClick);
            // 
            // DialogBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Buku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_buku;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label1;
    }
}