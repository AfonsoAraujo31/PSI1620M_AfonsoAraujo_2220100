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
            
        }
        private void btn_medicamentos_Enter(object sender, EventArgs e)
        {
            btn_medicamentos.BackColor = Color.FromArgb(0, 127, 255);
        }

        private void btn_medicamentos_Leave(object sender, EventArgs e)
        {
            btn_medicamentos.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btn_equipamentos_Enter(object sender, EventArgs e)
        {
            btn_equipamentos.BackColor = Color.FromArgb(0, 127, 255);
        }

        private void btn_equipamentos_Leave(object sender, EventArgs e)
        {
            btn_equipamentos.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btn_inflamáveis_Enter(object sender, EventArgs e)
        {
            btn_inflamáveis.BackColor = Color.FromArgb(0, 127, 255);
        }

        private void btn_inflamáveis_Leave(object sender, EventArgs e)
        {
            btn_inflamáveis.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btn_main_Enter(object sender, EventArgs e)
        {
            btn_main.BackColor = Color.FromArgb(0, 127, 255);
        }

        private void btn_main_Leave(object sender, EventArgs e)
        {
            btn_main.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            Medicamentos frm_medicamentos = new Medicamentos();
            frm_medicamentos.ShowDialog();
        }
    }
}
