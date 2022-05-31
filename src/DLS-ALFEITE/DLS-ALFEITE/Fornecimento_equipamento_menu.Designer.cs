
namespace DLS_ALFEITE
{
    partial class Fornecimento_equipamento_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecimento_equipamento_menu));
            this.textbox_searchbar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_observacoes = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_data_limite_rececao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_entidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_contacto_fabricante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_fabricante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_lote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_numero_serie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_searchbar
            // 
            this.textbox_searchbar.BackColor = System.Drawing.Color.White;
            this.textbox_searchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_searchbar.CausesValidation = false;
            this.textbox_searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textbox_searchbar.Location = new System.Drawing.Point(219, 28);
            this.textbox_searchbar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_searchbar.Name = "textbox_searchbar";
            this.textbox_searchbar.Size = new System.Drawing.Size(939, 24);
            this.textbox_searchbar.TabIndex = 4;
            this.textbox_searchbar.Text = "Search...";
            this.textbox_searchbar.TextChanged += new System.EventHandler(this.textbox_searchbar_TextChanged);
            this.textbox_searchbar.Enter += new System.EventHandler(this.textbox_searchbar_Enter);
            this.textbox_searchbar.Leave += new System.EventHandler(this.textbox_searchbar_Leave);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.ColumnHeadersHeight = 22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(219, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 980);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_observacoes);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtp_data_limite_rececao);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txb_entidade);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txb_contacto_fabricante);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txb_fabricante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_quantidade);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txb_lote);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_numero_serie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_denominacao);
            this.panel1.Location = new System.Drawing.Point(1180, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 980);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(70, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Observações:";
            // 
            // txb_observacoes
            // 
            this.txb_observacoes.Enabled = false;
            this.txb_observacoes.Location = new System.Drawing.Point(73, 548);
            this.txb_observacoes.Multiline = true;
            this.txb_observacoes.Name = "txb_observacoes";
            this.txb_observacoes.Size = new System.Drawing.Size(566, 153);
            this.txb_observacoes.TabIndex = 92;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(254, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(208, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 31);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_data_limite_rececao
            // 
            this.dtp_data_limite_rececao.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_limite_rececao.Enabled = false;
            this.dtp_data_limite_rececao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_limite_rececao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_limite_rececao.Location = new System.Drawing.Point(73, 464);
            this.dtp_data_limite_rececao.Name = "dtp_data_limite_rececao";
            this.dtp_data_limite_rececao.Size = new System.Drawing.Size(249, 20);
            this.dtp_data_limite_rececao.TabIndex = 87;
            this.dtp_data_limite_rececao.TabStop = false;
            this.dtp_data_limite_rececao.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(387, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Entidade:";
            // 
            // txb_entidade
            // 
            this.txb_entidade.Enabled = false;
            this.txb_entidade.Location = new System.Drawing.Point(390, 464);
            this.txb_entidade.Name = "txb_entidade";
            this.txb_entidade.Size = new System.Drawing.Size(249, 20);
            this.txb_entidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(70, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data limite de receção:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(387, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contacto do fabricante:";
            // 
            // txb_contacto_fabricante
            // 
            this.txb_contacto_fabricante.Enabled = false;
            this.txb_contacto_fabricante.Location = new System.Drawing.Point(390, 361);
            this.txb_contacto_fabricante.Name = "txb_contacto_fabricante";
            this.txb_contacto_fabricante.Size = new System.Drawing.Size(249, 20);
            this.txb_contacto_fabricante.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(70, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fabricante:";
            // 
            // txb_fabricante
            // 
            this.txb_fabricante.Enabled = false;
            this.txb_fabricante.Location = new System.Drawing.Point(73, 361);
            this.txb_fabricante.Name = "txb_fabricante";
            this.txb_fabricante.Size = new System.Drawing.Size(249, 20);
            this.txb_fabricante.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(387, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade a fornecer:";
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Enabled = false;
            this.txb_quantidade.Location = new System.Drawing.Point(390, 270);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(249, 20);
            this.txb_quantidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(70, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lote:";
            // 
            // txb_lote
            // 
            this.txb_lote.Enabled = false;
            this.txb_lote.Location = new System.Drawing.Point(73, 270);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(249, 20);
            this.txb_lote.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(387, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de série:";
            // 
            // txb_numero_serie
            // 
            this.txb_numero_serie.Enabled = false;
            this.txb_numero_serie.Location = new System.Drawing.Point(390, 178);
            this.txb_numero_serie.Name = "txb_numero_serie";
            this.txb_numero_serie.Size = new System.Drawing.Size(249, 20);
            this.txb_numero_serie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(70, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denominação:";
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Enabled = false;
            this.txb_denominacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_denominacao.Location = new System.Drawing.Point(73, 178);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(249, 21);
            this.txb_denominacao.TabIndex = 0;
            // 
            // Fornecimento_equipamento_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1894, 1069);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbox_searchbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fornecimento_equipamento_menu";
            this.Text = "Fornecimento_equipamento_menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_searchbar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_observacoes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_data_limite_rececao;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_numero_serie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_denominacao;
    }
}