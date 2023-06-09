﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YangHongWei0323Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_Ready = new Icon(SystemIcons.Information,40,40);

        public frmCreative()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSource.Text = "D:\\Creative\\Source\\";
            txtProcessedFile.Text = "D:\\Creative\\Processed\\";
            txtDest.Text = "D:\\Creative\\Destination\\";
            opsGeneratelog.Checked = true;
        }

        private void tabSource_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "Invalid Source Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtSource, "");

            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "Invalid Processed File Directory");
                txtProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtProcessedFile, "");

            if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "Invalid Source Directory");
                txtDest.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtDest, "");

            WatchDir.EnableRaisingEvents = true;
            WatchDir.Path = txtSource.Text;

            mnuNotify.Icon = m_Ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtSource.Text))
            {

                txtSource.BackColor= Color.White;
             }
            else
            {
                txtSource.BackColor = Color.Pink;
            }

           

          
        }

        private void txtProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtProcessedFile.Text))
            {

                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }
        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtDest.Text))
            {

                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }
        }

        private void mnuConfigure_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNotify_DoubleClick(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }
    }
}
