using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLS_ALFEITE
{
    public partial class Página_Principal : Form
    {
        public Página_Principal(string value)
        {
            InitializeComponent();
            label_username.Text = value;
            DateTime today = DateTime.Today;
            label_data.Text = today.ToString("dd/MM/yyyy");

        }
        Medicamentos frm_med;
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            if (frm_med == null)
            {
                frm_med = new Medicamentos();
                frm_med.MdiParent = this;
                frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                frm_med.Show();
            }
            else
            {
                frm_med = new Medicamentos();
                frm_med.Focus();
            }
        }
        void frm_medFormClosed(object sender, FormClosedEventArgs e)
        {
            frm_med = null;
            //throw new NotImplementedException();
        }


    }
}

