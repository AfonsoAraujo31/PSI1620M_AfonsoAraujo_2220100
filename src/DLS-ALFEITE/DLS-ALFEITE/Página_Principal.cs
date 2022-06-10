using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace DLS_ALFEITE
{
    public partial class panel_mdi : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Registo frm_registo;
        Equipamentos frm_equip;
        Medicamentos frm_med;
        Inflamáveis frm_infla;
        Aquisição_medicamento_menu frm_med_menu;
        Fornecimento_medicamento_menu frmm_med_menu_form;
        Aquisição_equipamento_menu frm_equip_menu_form;
        Fornecimento_equipamento_menu frm_equip_menu;
        Definições frm_definicoes;
        Aquisição_inflamavel_menu frm_infla_menu;
        Fornecimento_inflamavel_menu frm_infla_forn_menu;
        bool check = false;
        public panel_mdi(string value,bool value1)
        {
            InitializeComponent();
            Form_estilo();
            check = value1;
            label_username.Text = value;
            DateTime today = DateTime.Today;
            label_data.Text = today.ToString("dd/MM/yyyy");
            if (check == true)
            {
                btn_registo.Visible = true;
            }
            else
            {
                btn_registo.Visible = false;
            }
        }
        private void Form_estilo()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            btn_aquisicao_medicamentos.Visible = true;
            btn_fornecimento_medicamento.Visible = true;
            btn_fornecimento_equipamentos.Visible = false;
            btn_aquisicao_equipamentos.Visible = false;
            btn_fornecimento_inflamaveis.Visible = false;
            btn_aquisicao_inflamaveis.Visible = false;
            //panel_medicamentos
            frm_med = new Medicamentos();
            frm_med.MdiParent = this;
            frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
            frm_med.Show();
            frm_med.Dock = DockStyle.Fill;
            btn_cor(btn_medicamento);
        }
        private void btn_cor(Button btn)
        {
            btn_medicamento.BackColor = Color.Transparent;
            btn_medicamento.BackColor = Color.Transparent;
            btn_equipamento.BackColor = Color.Transparent;
            btn_inflamavel.BackColor = Color.Transparent;
            btn_aquisicao_medicamentos.BackColor = Color.Transparent;
            btn_fornecimento_medicamento.BackColor = Color.Transparent;
            btn_aquisicao_equipamentos.BackColor = Color.Transparent;
            btn_fornecimento_equipamentos.BackColor = Color.Transparent;
            btn_definicoes.BackColor = Color.Transparent;
            btn_aquisicao_inflamaveis.BackColor = Color.Transparent;
            btn_fornecimento_inflamaveis.BackColor = Color.Transparent;
            btn_registo.BackColor = Color.Transparent;
            btn.BackColor = Color.RosyBrown;
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
            btn_cor(btn_medicamento);
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
            btn_cor(btn_equipamento);
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
            
            btn_cor(btn_inflamavel);
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
            if (btn_aquisicao_medicamentos.Visible == true || btn_fornecimento_medicamento.Visible == true)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
            else if (btn_aquisicao_medicamentos.Visible == false)
            {
                btn_aquisicao_medicamentos.Visible = false;
                btn_fornecimento_medicamento.Visible = false;
            }
            if (btn_aquisicao_equipamentos.Visible == true || btn_fornecimento_equipamentos.Visible == true)
            {
                btn_aquisicao_equipamentos.Visible = false;
                btn_fornecimento_equipamentos.Visible = false;
            }
            if (btn_aquisicao_inflamaveis.Visible == false || btn_fornecimento_inflamaveis.Visible == true)
            {
                btn_aquisicao_inflamaveis.Visible = true;
                btn_fornecimento_inflamaveis.Visible = true;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Frm_login().Show();
            this.Hide();
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

        private void btn_aquisicao_medicamentos_Click(object sender, EventArgs e)
        {
            btn_cor(btn_aquisicao_medicamentos);
            try
            {
                if (frm_med_menu == null)
                {
                    frm_med_menu = new Aquisição_medicamento_menu(check);
                    frm_med_menu.MdiParent = this;
                    frm_med_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med_menu.Show();
                    frm_med_menu.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_med_menu.Close();
                    frm_med_menu = new Aquisição_medicamento_menu(check);
                    frm_med_menu.MdiParent = this;
                    frm_med_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med_menu.Show();
                    frm_med_menu.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_fornecimento_medicamento_Click(object sender, EventArgs e)
        {
            btn_cor(btn_fornecimento_medicamento);
            try
            {
                if (frmm_med_menu_form == null)
                {
                    frmm_med_menu_form = new Fornecimento_medicamento_menu(check);
                    frmm_med_menu_form.MdiParent = this;
                    frmm_med_menu_form.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frmm_med_menu_form.Show();
                    frmm_med_menu_form.Dock = DockStyle.Fill;
                }
                else
                {
                    frmm_med_menu_form.Close();
                    frmm_med_menu_form = new Fornecimento_medicamento_menu(check);
                    frmm_med_menu_form.MdiParent = this;
                    frmm_med_menu_form.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frmm_med_menu_form.Show();
                    frmm_med_menu_form.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_aquisicao_equipamentos_Click(object sender, EventArgs e)
        {
            btn_cor(btn_aquisicao_equipamentos);
            try
            {
                if (frm_equip_menu_form == null)
                {
                    frm_equip_menu_form = new Aquisição_equipamento_menu(check);
                    frm_equip_menu_form.MdiParent = this;
                    frm_equip_menu_form.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip_menu_form.Show();
                    frm_equip_menu_form.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_equip_menu_form.Close();
                    frm_equip_menu_form = new Aquisição_equipamento_menu(check);
                    frm_equip_menu_form.MdiParent = this;
                    frm_equip_menu_form.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip_menu_form.Show();
                    frm_equip_menu_form.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_fornecimento_equipamentos_Click(object sender, EventArgs e)
        {
            btn_cor(btn_fornecimento_equipamentos);
            try
            {
                if (frm_equip_menu == null)
                {
                    frm_equip_menu = new Fornecimento_equipamento_menu(check);
                    frm_equip_menu.MdiParent = this;
                    frm_equip_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip_menu.Show();
                    frm_equip_menu.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_equip_menu.Close();
                    frm_equip_menu = new Fornecimento_equipamento_menu(check);
                    frm_equip_menu.MdiParent = this;
                    frm_equip_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_equip_menu.Show();
                    frm_equip_menu.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_definicoes_Click(object sender, EventArgs e)
        {
            btn_cor(btn_definicoes);
            try
            {
                if (frm_definicoes == null)
                {
                    frm_definicoes = new Definições(label_username.Text);
                    frm_definicoes.MdiParent = this;
                    frm_definicoes.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_definicoes.Show();
                    frm_definicoes.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_definicoes.Close();
                    frm_definicoes = new Definições(label_username.Text);
                    frm_definicoes.MdiParent = this;
                    frm_definicoes.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_definicoes.Show();
                    frm_definicoes.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_show();
        }

        private void btn_aquisicao_inflamaveis_Click(object sender, EventArgs e)
        {
            btn_cor(btn_aquisicao_inflamaveis);
            try
            {
                if (frm_infla_menu == null)
                {
                    frm_infla_menu = new Aquisição_inflamavel_menu(check);
                    frm_infla_menu.MdiParent = this;
                    frm_infla_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla_menu.Show();
                    frm_infla_menu.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_infla_menu.Close();
                    frm_infla_menu = new Aquisição_inflamavel_menu(check);
                    frm_infla_menu.MdiParent = this;
                    frm_infla_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla_menu.Show();
                    frm_infla_menu.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_fornecimento_inflamaveis_Click(object sender, EventArgs e)
        {
            btn_cor(btn_fornecimento_inflamaveis);
            try
            {
                if (frm_infla_forn_menu == null)
                {
                    frm_infla_forn_menu = new Fornecimento_inflamavel_menu(check);
                    frm_infla_forn_menu.MdiParent = this;
                    frm_infla_forn_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla_forn_menu.Show();
                    frm_infla_forn_menu.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_infla_forn_menu.Close();
                    frm_infla_forn_menu = new Fornecimento_inflamavel_menu(check);
                    frm_infla_forn_menu.MdiParent = this;
                    frm_infla_forn_menu.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_infla_forn_menu.Show();
                    frm_infla_forn_menu.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void top_bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_registo_Click(object sender, EventArgs e)
        {
            btn_cor(btn_registo);
            try
            {
                if (frm_registo == null)
                {
                    frm_registo = new Registo();
                    frm_registo.MdiParent = this;
                    frm_registo.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_registo.Show();
                    frm_registo.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_registo.Close();
                    frm_registo = new Registo();
                    frm_registo.MdiParent = this;
                    frm_registo.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_registo.Show();
                    frm_registo.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_show();
        }
    }
}

