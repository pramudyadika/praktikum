using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apl_Penjualan.GUI
{
    public partial class FormTransaksi : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_kwitansi.Text = "";
            dateTimePicker_kwitansi.Value = DateTime.Now;
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_jumlah.Text = "0";
            textBox_kodebuku.Text = "";
            textBox_namabuku.Text = "";
            textBox_hargabuku.Text = "0";
            textBox_namapelanggan.Enabled = false;
            textBox_idpelanggan.Enabled = false;
            textBox_kodebuku.Enabled = false;
            textBox_namabuku.Enabled = false;
            textBox_hargabuku.Enabled = false;
            button_simpan.Enabled = false;
        }

        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_penjualan order by Kwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_penjualan";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_data.Enabled = false;
            }
        }

        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tabel_detailpenjualan values('" + textBox_kwitansi.Text + "','" + textBox_kodebuku.Text + "','" + textBox_jumlah.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_detail where Kwitansi= '" + textBox_kwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_detail";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void RefreshTransaksi()
        {
            refresh_penjualan();
            textBox_kodebuku.Clear();
            textBox_namabuku.Clear();
            textBox_hargabuku.Text = "0";
            textBox_jumlah.Focus();
        }

        public FormTransaksi()
        {
            InitializeComponent();
            awal();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_caripelanggan_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            textBox_idpelanggan.Text = plgn.ambil_id_pelanggan;
            textBox_namapelanggan.Text = plgn.ambil_nama_pelanggan;
        }

        private void button_caribuku_Click(object sender, EventArgs e)
        {
            DialogBuku brg = new DialogBuku();
            brg.ShowDialog();
            textBox_kodebuku.Text = brg.ambil_kode_buku;
            textBox_namabuku.Text = brg.ambil_nama_buku;
            textBox_hargabuku.Text = brg.ambil_harga;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            dateTimePicker_kwitansi.Focus();
            button_caripelanggan.Enabled = true;
        }

        private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
            textBox_kodebuku.Text = row.Cells["KodeBuku"].Value.ToString();
            textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
        }
    }
}

       