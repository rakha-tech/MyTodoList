using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTugas.CurrentRow == null || dgvTugas.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Silahkan pilih tugas yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaTugas = dgvTugas.CurrentRow.Cells["colTugas"].Value.ToString();

            // Konfirmasi sebelum menghapus
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus tugas '{namaTugas}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                dgvTugas.Rows.Remove(dgvTugas.CurrentRow);
                MessageBox.Show("Tugas berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Menambah Tugas Baru dengan Validasi
        private void btnTambah_Click(object sender, EventArgs e)
        {
            string namaTugas = txtTugas.Text.Trim();

            // Validasi 1: Nama tugas tidak boleh kosong
            if (string.IsNullOrEmpty(namaTugas))
            {
                MessageBox.Show("Nama tugas tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTugas.Focus();
                return;
            }

            // Validasi 2: Nama tugas tidak boleh duplikat
            foreach (DataGridViewRow row in dgvTugas.Rows)
            {
                if (row.Cells["colTugas"].Value != null && row.Cells["colTugas"].Value.ToString().Equals(namaTugas, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Tugas '{namaTugas}' sudah ada di dalam daftar!", "Validasi Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTugas.SelectAll();
                    txtTugas.Focus();
                    return;
                }
            }

            // Menambahkan tugas ke DataGridView
            dgvTugas.Rows.Add(namaTugas, false);
            MessageBox.Show("Tugas berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTugas.Clear();
            txtTugas.Focus();
        }

        // Memperbarui status dengan validasi
        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // Validasi 1: Belum memilih tugas
            if (dgvTugas.CurrentRow == null || dgvTugas.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Silahkan pilih tugas yang ingin diubah statusnya terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvTugas.CurrentRow;
            bool currentStatus = Convert.ToBoolean(selectedRow.Cells["colSelesai"].Value);

            // Membalikkan status tugas
            selectedRow.Cells["colSelesai"].Value = !currentStatus;

            string statusText = !currentStatus ? "Selesai" : "Belum Selesai";
            MessageBox.Show($"Status tugas '{selectedRow.Cells["colTugas"].Value}' berhasil diubah menjadi: {statusText}.", "Informasi Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
