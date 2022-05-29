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
    public partial class panel_mdi : Form
    {
        Equipamentos frm_equip;
        Medicamentos frm_med;
        Inflamáveis frm_infla;
        Notas frm_notas;
        public panel_mdi(string value)
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
            btn_aquisicao_medicamentos.Visible = true;
            btn_fornecimento_medicamento.Visible = true;
            btn_fornecimento_equipamentos.Visible = false;
            btn_aquisicao_equipamentos.Visible = false;
            btn_fornecimento_inflamaveis.Visible = false;
            btn_aquisicao_inflamaveis.Visible = false;
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
            if (btn_aquisicao_inflamaveis.Visible == true || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = false;
                btn_fornecimento_inflamaveis.Visible = false;
            }
            if (btn_aquisicao_medicamentos.Visible == true || btn_fornecimento_medicamento.Visible == true)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
            else if (btn_aquisicao_medicamentos.Visible == false)
            {
                btn_aquisicao_medicamentos.Visible = true;
                btn_fornecimento_medicamento.Visible = true;
            }
            if (btn_aquisicao_equipamentos.Visible == true || btn_fornecimento_equipamentos.Visible == true)
            {
                btn_aquisicao_equipamentos.Visible = false;
                btn_fornecimento_equipamentos.Visible = false;
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
            if (btn_aquisicao_inflamaveis.Visible == true || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = false;
                btn_fornecimento_inflamaveis.Visible = false;
            }
            if (btn_aquisicao_medicamentos.Visible == true || btn_fornecimento_medicamento.Visible == true)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
            if (btn_aquisicao_equipamentos.Visible == true || btn_fornecimento_equipamentos.Visible == true)
            {
                btn_aquisicao_equipamentos.Visible = false;
                btn_fornecimento_equipamentos.Visible = false;
            }
            else if (btn_aquisicao_equipamentos.Visible == false || btn_fornecimento_equipamentos.Visible == true) 
            {
                btn_aquisicao_equipamentos.Visible = true;
                btn_fornecimento_equipamentos.Visible = true;
            }
        }

        private void btn_inflamavel_Click(object sender, EventArgs e)
        {
            btnsetcolor(btn_inflamavel);
            try
            {
                if (frm_infla == null)
                {
                    frm_infla = new Inflamáveis();
                    frm_infla.MdiParent = this;
                    frm_infla.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla.Show();
                    frm_infla.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_infla.Close();
                    frm_infla = new Inflamáveis();
                    frm_infla.MdiParent = this;
                    frm_infla.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla.Show();
                    frm_infla.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (btn_aquisicao_inflamaveis.Visible == true || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = false;
                btn_fornecimento_inflamaveis.Visible = false;
            }
            else if (btn_aquisicao_inflamaveis.Visible == false || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = true;
                btn_fornecimento_inflamaveis.Visible = true;
            }
            if (btn_aquisicao_equipamentos.Visible == true || btn_fornecimento_equipamentos.Visible == true)
            {
                btn_aquisicao_equipamentos.Visible = false;
                btn_fornecimento_equipamentos.Visible = false;
            }
            if (btn_aquisicao_medicamentos.Visible == true || btn_fornecimento_medicamento.Visible == true)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Frm_login().Show();
            this.Hide();
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            btnsetcolor(btn_notas);
            try
            {
                if (frm_notas == null)
                {
                    frm_notas = new Notas();
                    frm_notas.MdiParent = this;
                    frm_notas.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_notas.Show();
                    frm_notas.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_notas.Close();
                    frm_notas = new Notas();
                    frm_notas.MdiParent = this;
                    frm_notas.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_notas.Show();
                    frm_notas.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_show();
        }

        private void btn_show()
        {
            if (btn_aquisicao_medicamentos.Visible == true || btn_fornecimento_medicamento.Visible == true)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
            if (btn_aquisicao_equipamentos.Visible == true || btn_fornecimento_equipamentos.Visible == true)
            {
                btn_aquisicao_equipamentos.Visible = false;
                btn_fornecimento_equipamentos.Visible = false;
            }
            if (btn_aquisicao_inflamaveis.Visible == true || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = false;
                btn_fornecimento_inflamaveis.Visible = false;
            }
        }
    }
}

