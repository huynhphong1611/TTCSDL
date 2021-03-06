﻿using QuanLyThuVien.Form_DocGia;
using QuanLyThuVien.Form_MuonTra;
using QuanLyThuVien.Form_Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        int PanelWith;
        bool ThuNhoMenu;
        //Khoi tao để dungchung tranh new nhieu lan 
        private QuanLi_Sach quanLiSach;
        private QuanLi_MuonTra quanLiMuonTra;
        private QuanLyDocGia quanLyDocGia;
        public Form1()
        {
            InitializeComponent();
            PanelWith = panelLeft.Width;
            ThuNhoMenu = false;
            PanelWith = panelLeft.Width;
            ThuNhoMenu = false;
            quanLiSach = new QuanLi_Sach();
            quanLiMuonTra = new QuanLi_MuonTra();
            quanLyDocGia = new QuanLyDocGia();
            AddControlsToPanel(quanLiSach);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            AddControlsToPanel(quanLiSach);
        }


        

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMuonTra_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnMuonTra);
            
            AddControlsToPanel(quanLiMuonTra);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {            
                if (ThuNhoMenu)
                {
                    panelLeft.Width += 12;
                    if (panelLeft.Width >= PanelWith)
                    {
                        timer1.Stop();
                        ThuNhoMenu = false;
                        this.Refresh();
                    }
                }
                else
                {
                    panelLeft.Width -= 12;
                    if (panelLeft.Width <= 83)
                    {
                        timer1.Stop();
                        ThuNhoMenu = true;
                        this.Refresh();
                    }
                }            
        }

        private void btnDocGia_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnDocGia);
            AddControlsToPanel(quanLyDocGia);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnThongKe);
        }

        
    }
}
