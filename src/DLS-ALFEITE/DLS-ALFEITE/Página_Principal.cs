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
        Equipamentos frm_equip;
        Medicamentos frm_med;
        public Página_Principal(string value)
        {
            InitializeComponent();
            label_username.Text = value;
            DateTime today = DateTime.Today;
            label_data.Text = today.ToString("dd/MM/yyyy");
            frm_med = new Medicamentos();
            frm_med.MdiParent = this;
            frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
            frm_med.Show();
            frm_med.Dock = DockStyle.Fill;
            btnsetcolor(btn_medicamento);
        }

        private void btnsetcolor(Button btn)
        {
            btn_medicamento.BackColor = Color.Transparent;
            btn_medicamento.BackColor = Color.Transparent;
            btn_equipamento.BackColor = Color.Transparent;
            btn_inflamavel.BackColor = Color.Transparent;
            btn.BackColor = Color.Yellow;
        }

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
            btnsetcolor(btn_medicamento);
            try
            {
                if (frm_med == null)
                {
                    frm_med = new Medicamentos();
                    frm_med.MdiParent = this;
                    frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med.Show();
                    frm_med.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_med.Close();
                    frm_med = new Medicamentos();
                    frm_med.MdiParent = this;
                    frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med.Show();
                    frm_med.Dock = DockStyle.Fill;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void frm_medFormClosed(object sender, FormClosedEventArgs e)
        {
            frm_med = null;
        }

        private void btn_equipamento_Click(object sender, EventArgs e)
        {
            btnsetcolor(btn_equipamento);
            try
            {
                if (frm_equip == null)
                {
                    frm_equip = new Equipamentos();
                    frm_equip.MdiParent = this;
                    frm_equip.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip.Show();
                    frm_equip.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_equip.Close();
                    frm_equip = new Equipamentos();
                    frm_equip.MdiParent = this;
                    frm_equip.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip.Show();
                    frm_equip.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_inflamavel_Click(object sender, EventArgs e)
        {

        }
    }
}

