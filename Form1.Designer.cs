namespace MyTodoList
{
    partial class Form1
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvTugas = new System.Windows.Forms.DataGridView();
            this.colTugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Location = new System.Drawing.Point(13, 357);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtTugas
            // 
            this.txtTugas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTugas.Location = new System.Drawing.Point(94, 360);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(693, 20);
            this.txtTugas.TabIndex = 2;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelesai.Location = new System.Drawing.Point(12, 386);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(775, 23);
            this.btnSelesai.TabIndex = 3;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.Location = new System.Drawing.Point(13, 415);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(775, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvTugas
            // 
            this.dgvTugas.AllowUserToAddRows = false;
            this.dgvTugas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTugas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTugas,
            this.colSelesai});
            this.dgvTugas.Location = new System.Drawing.Point(12, 13);
            this.dgvTugas.Name = "dgvTugas";
            this.dgvTugas.Size = new System.Drawing.Size(775, 338);
            this.dgvTugas.TabIndex = 5;
            // 
            // colTugas
            // 
            this.colTugas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTugas.HeaderText = "Tugas";
            this.colTugas.Name = "colTugas";
            this.colTugas.ReadOnly = true;
            // 
            // colSelesai
            // 
            this.colSelesai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSelesai.HeaderText = "Selesai";
            this.colSelesai.Name = "colSelesai";
            this.colSelesai.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTugas);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.btnTambah);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Tugas Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvTugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTugas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelesai;
    }
}

