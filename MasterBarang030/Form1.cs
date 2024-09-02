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

namespace MasterBarang030
{
    public partial class masterbarang : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CFKLQAHI\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;");
        public masterbarang()
        {
            InitializeComponent();
        }

        DataClasses1DataContext qdb = new DataClasses1DataContext();
        private void masterbarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);
            // TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);

        }

        private void clear()
        {
            //mengosongkan isian data
            txtNama.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtSupplier.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string barang = txtNama.Text;
            int harga = int.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            string supplier = txtSupplier.Text;
            var data = new tbl_barang
            {
                nama_barang = barang,
                harga = harga,
                stok = stok,
                nama_supplier = supplier
            };

            qdb.tbl_barangs.InsertOnSubmit(data);
            qdb.SubmitChanges();
            MessageBox.Show("Saved Successfully!");
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            txtSupplier.Clear();
            LoadData();
        }
        void LoadData()
        {
            var st = from tb in qdb.tbl_barangs select tb;
            dataGridView1.DataSource = st;
        }
    }
}
