﻿namespace DLS_ALFEITE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbox_searchbar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_data_limite_rececao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_motivo = new System.Windows.Forms.TextBox();
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
            this.txb_princpio_ativo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 980);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textbox_searchbar
            // 
            this.textbox_searchbar.BackColor = System.Drawing.Color.White;
            this.textbox_searchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_searchbar.CausesValidation = false;
            this.textbox_searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_searchbar.Location = new System.Drawing.Point(219, 28);
            this.textbox_searchbar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_searchbar.Name = "textbox_searchbar";
            this.textbox_searchbar.Size = new System.Drawing.Size(939, 24);
            this.textbox_searchbar.TabIndex = 3;
            this.textbox_searchbar.Text = "Search...";
            this.textbox_searchbar.TextChanged += new System.EventHandler(this.textbox_searchbar_TextChanged);
            this.textbox_searchbar.Enter += new System.EventHandler(this.textbox_searchbar_Enter);
            this.textbox_searchbar.Leave += new System.EventHandler(this.textbox_searchbar_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtp_data_limite_rececao);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txb_motivo);
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
            this.panel1.Controls.Add(this.txb_princpio_ativo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_denominacao);
            this.panel1.Location = new System.Drawing.Point(1180, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 980);
            this.panel1.TabIndex = 4;
            // 
            // dtp_data_limite_rececao
            // 
            this.dtp_data_limite_rececao.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_limite_rececao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_limite_rececao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_limite_rececao.Location = new System.Drawing.Point(67, 376);
            this.dtp_data_limite_rececao.Name = "dtp_data_limite_rececao";
            this.dtp_data_limite_rececao.Size = new System.Drawing.Size(249, 20);
            this.dtp_data_limite_rececao.TabIndex = 87;
            this.dtp_data_limite_rececao.TabStop = false;
            this.dtp_data_limite_rececao.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Motivo:";
            // 
            // txb_motivo
            // 
            this.txb_motivo.Location = new System.Drawing.Point(67, 456);
            this.txb_motivo.Multiline = true;
            this.txb_motivo.Name = "txb_motivo";
            this.txb_motivo.Size = new System.Drawing.Size(566, 153);
            this.txb_motivo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Entidade:";
            // 
            // txb_entidade
            // 
            this.txb_entidade.Location = new System.Drawing.Point(384, 376);
            this.txb_entidade.Name = "txb_entidade";
            this.txb_entidade.Size = new System.Drawing.Size(249, 20);
            this.txb_entidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data limite de receção:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contacto do fabricante:";
            // 
            // txb_contacto_fabricante
            // 
            this.txb_contacto_fabricante.Location = new System.Drawing.Point(384, 273);
            this.txb_contacto_fabricante.Name = "txb_contacto_fabricante";
            this.txb_contacto_fabricante.Size = new System.Drawing.Size(249, 20);
            this.txb_contacto_fabricante.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fabricante:";
            // 
            // txb_fabricante
            // 
            this.txb_fabricante.Location = new System.Drawing.Point(67, 273);
            this.txb_fabricante.Name = "txb_fabricante";
            this.txb_fabricante.Size = new System.Drawing.Size(249, 20);
            this.txb_fabricante.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade a adquirir:";
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Location = new System.Drawing.Point(384, 182);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(249, 20);
            this.txb_quantidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lote:";
            // 
            // txb_lote
            // 
            this.txb_lote.Location = new System.Drawing.Point(67, 182);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(249, 20);
            this.txb_lote.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Princípio/Ativo:";
            // 
            // txb_princpio_ativo
            // 
            this.txb_princpio_ativo.Location = new System.Drawing.Point(384, 90);
            this.txb_princpio_ativo.Name = "txb_princpio_ativo";
            this.txb_princpio_ativo.Size = new System.Drawing.Size(249, 20);
            this.txb_princpio_ativo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denominação:";
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Location = new System.Drawing.Point(67, 90);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(249, 20);
            this.txb_denominacao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1176, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registo do pedido de aquisição:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Aquisição_medicamento_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1894, 1069);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox_searchbar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aquisição_medicamento_menu";
            this.Text = "Aquisição_medicamento_menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbox_searchbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_princpio_ativo;
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
    }
}