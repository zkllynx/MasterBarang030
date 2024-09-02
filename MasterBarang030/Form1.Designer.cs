namespace MasterBarang030
{
    partial class masterbarang
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
            this.components = new System.ComponentModel.Container();
            this.txtJudul = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblRp = new System.Windows.Forms.Label();
            this.lblPcs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quizMahasiswaDataSet = new MasterBarang030.QuizMahasiswaDataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new MasterBarang030.QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJudul
            // 
            this.txtJudul.AutoSize = true;
            this.txtJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudul.Location = new System.Drawing.Point(218, 43);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(149, 18);
            this.txtJudul.TabIndex = 0;
            this.txtJudul.Text = "MASTER BARANG";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(70, 89);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(72, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Barang";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(70, 130);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Harga";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(70, 171);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(29, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(70, 212);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(76, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Nama Supplier";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(196, 89);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(171, 20);
            this.txtNama.TabIndex = 7;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(220, 130);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(147, 20);
            this.txtHarga.TabIndex = 8;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(196, 171);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(134, 20);
            this.txtStok.TabIndex = 9;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(196, 212);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(171, 20);
            this.txtSupplier.TabIndex = 10;
            // 
            // lblRp
            // 
            this.lblRp.AutoSize = true;
            this.lblRp.Location = new System.Drawing.Point(193, 133);
            this.lblRp.Name = "lblRp";
            this.lblRp.Size = new System.Drawing.Size(21, 13);
            this.lblRp.TabIndex = 11;
            this.lblRp.Text = "Rp";
            // 
            // lblPcs
            // 
            this.lblPcs.AutoSize = true;
            this.lblPcs.Location = new System.Drawing.Point(336, 174);
            this.lblPcs.Name = "lblPcs";
            this.lblPcs.Size = new System.Drawing.Size(31, 13);
            this.lblPcs.TabIndex = 12;
            this.lblPcs.Text = "buah";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(473, 141);
            this.dataGridView1.TabIndex = 13;
            // 
            // quizMahasiswaDataSet
            // 
            this.quizMahasiswaDataSet.DataSetName = "QuizMahasiswaDataSet";
            this.quizMahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.quizMahasiswaDataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            // 
            // masterbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPcs);
            this.Controls.Add(this.lblRp);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtJudul);
            this.Name = "masterbarang";
            this.Text = "Master Barang";
            this.Load += new System.EventHandler(this.masterbarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtJudul;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblRp;
        private System.Windows.Forms.Label lblPcs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuizMahasiswaDataSet quizMahasiswaDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
    }
}

