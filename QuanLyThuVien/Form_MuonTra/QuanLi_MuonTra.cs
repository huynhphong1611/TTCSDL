﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_MuonTra
{
    public partial class QuanLi_MuonTra : UserControl
    {
        public QuanLi_MuonTra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_MuonSach temp = new Form_MuonSach();
            temp.Show();
        }

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChiTietMuonTra temp = new Form_ChiTietMuonTra();
            temp.Show();
        }
    }
}
