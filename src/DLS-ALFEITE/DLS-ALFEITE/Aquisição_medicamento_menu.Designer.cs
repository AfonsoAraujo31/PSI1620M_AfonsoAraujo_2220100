namespace DLS_ALFEITE
{
    partial class Aquisição_medicamento_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aquisição_medicamento_menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbox_searchbar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_rejeitar = new System.Windows.Forms.Button();
            this.txb_motivo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_data_limite_rececao = new System.Windows.Forms.DateTimePicker();
            this.txb_entidade = new System.Windows.Forms.TextBox();
            this.txb_contacto_fabricante = new System.Windows.Forms.TextBox();
            this.txb_fabricante = new System.Windows.Forms.TextBox();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.txb_lote = new System.Windows.Forms.TextBox();
            this.txb_principio_ativo = new System.Windows.Forms.TextBox();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aprovar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // textbox_searchbar
            // 
            resources.ApplyResources(this.textbox_searchbar, "textbox_searchbar");
            this.textbox_searchbar.BackColor = System.Drawing.Color.White;
            this.textbox_searchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_searchbar.CausesValidation = false;
            this.textbox_searchbar.Name = "textbox_searchbar";
            this.textbox_searchbar.TextChanged += new System.EventHandler(this.textbox_searchbar_TextChanged);
            this.textbox_searchbar.Enter += new System.EventHandler(this.textbox_searchbar_Enter);
            this.textbox_searchbar.Leave += new System.EventHandler(this.textbox_searchbar_Leave);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btn_pedido);
            this.panel1.Controls.Add(this.btn_rejeitar);
            this.panel1.Controls.Add(this.txb_motivo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtp_data_limite_rececao);
            this.panel1.Controls.Add(this.txb_entidade);
            this.panel1.Controls.Add(this.txb_contacto_fabricante);
            this.panel1.Controls.Add(this.txb_fabricante);
            this.panel1.Controls.Add(this.txb_quantidade);
            this.panel1.Controls.Add(this.txb_lote);
            this.panel1.Controls.Add(this.txb_principio_ativo);
            this.panel1.Controls.Add(this.txb_denominacao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_aprovar);
            this.panel1.Name = "panel1";
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_pedido.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_pedido, "btn_pedido");
            this.btn_pedido.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // btn_rejeitar
            // 
            this.btn_rejeitar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_rejeitar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_rejeitar, "btn_rejeitar");
            this.btn_rejeitar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_rejeitar.Name = "btn_rejeitar";
            this.btn_rejeitar.UseVisualStyleBackColor = false;
            this.btn_rejeitar.Click += new System.EventHandler(this.btn_rejeitar_Click);
            // 
            // txb_motivo
            // 
            resources.ApplyResources(this.txb_motivo, "txb_motivo");
            this.txb_motivo.Name = "txb_motivo";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dtp_data_limite_rececao
            // 
            resources.ApplyResources(this.dtp_data_limite_rececao, "dtp_data_limite_rececao");
            this.dtp_data_limite_rececao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_limite_rececao.Name = "dtp_data_limite_rececao";
            this.dtp_data_limite_rececao.TabStop = false;
            this.dtp_data_limite_rececao.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // txb_entidade
            // 
            resources.ApplyResources(this.txb_entidade, "txb_entidade");
            this.txb_entidade.Name = "txb_entidade";
            // 
            // txb_contacto_fabricante
            // 
            resources.ApplyResources(this.txb_contacto_fabricante, "txb_contacto_fabricante");
            this.txb_contacto_fabricante.Name = "txb_contacto_fabricante";
            // 
            // txb_fabricante
            // 
            resources.ApplyResources(this.txb_fabricante, "txb_fabricante");
            this.txb_fabricante.Name = "txb_fabricante";
            // 
            // txb_quantidade
            // 
            resources.ApplyResources(this.txb_quantidade, "txb_quantidade");
            this.txb_quantidade.Name = "txb_quantidade";
            // 
            // txb_lote
            // 
            resources.ApplyResources(this.txb_lote, "txb_lote");
            this.txb_lote.Name = "txb_lote";
            // 
            // txb_principio_ativo
            // 
            resources.ApplyResources(this.txb_principio_ativo, "txb_principio_ativo");
            this.txb_principio_ativo.Name = "txb_principio_ativo";
            // 
            // txb_denominacao
            // 
            resources.ApplyResources(this.txb_denominacao, "txb_denominacao");
            this.txb_denominacao.Name = "txb_denominacao";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // btn_aprovar
            // 
            this.btn_aprovar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_aprovar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_aprovar, "btn_aprovar");
            this.btn_aprovar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_aprovar.Name = "btn_aprovar";
            this.btn_aprovar.UseVisualStyleBackColor = false;
            this.btn_aprovar.Click += new System.EventHandler(this.btn_aprovar_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Aquisição_medicamento_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textbox_searchbar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aquisição_medicamento_menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_principio_ativo;
        private System.Windows.Forms.TextBox txb_denominacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_motivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_entidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_contacto_fabricante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_fabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_lote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_data_limite_rececao;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textbox_searchbar;
        private System.Windows.Forms.Button btn_aprovar;
        private System.Windows.Forms.Button btn_rejeitar;
        private System.Windows.Forms.Button btn_pedido;
    }
}