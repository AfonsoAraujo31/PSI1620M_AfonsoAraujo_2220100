﻿namespace DLS_ALFEITE
{
    partial class Aquisição_equipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aquisição_equipamento));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_med = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txb_motivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_lote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_numero_serie = new System.Windows.Forms.TextBox();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_data_rececao = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label_motivo = new System.Windows.Forms.Label();
            this.label_entidade = new System.Windows.Forms.Label();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.cb_entidade = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel5.Controls.Add(this.label_med);
            this.panel5.Controls.Add(this.btn_min);
            this.panel5.Controls.Add(this.btnclose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 29);
            this.panel5.TabIndex = 9;
            // 
            // label_med
            // 
            this.label_med.AutoSize = true;
            this.label_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_med.ForeColor = System.Drawing.Color.Transparent;
            this.label_med.Location = new System.Drawing.Point(2, 4);
            this.label_med.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_med.Name = "label_med";
            this.label_med.Size = new System.Drawing.Size(223, 20);
            this.label_med.TabIndex = 7;
            this.label_med.Text = "Aquisição de Equipamento";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(661, -4);
            this.btn_min.Margin = new System.Windows.Forms.Padding(2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 33);
            this.btn_min.TabIndex = 8;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(702, -3);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 33);
            this.btnclose.TabIndex = 6;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txb_motivo
            // 
            this.txb_motivo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_motivo.Location = new System.Drawing.Point(52, 297);
            this.txb_motivo.Margin = new System.Windows.Forms.Padding(2);
            this.txb_motivo.Multiline = true;
            this.txb_motivo.Name = "txb_motivo";
            this.txb_motivo.Size = new System.Drawing.Size(659, 140);
            this.txb_motivo.TabIndex = 80;
            this.txb_motivo.TextChanged += new System.EventHandler(this.txb_motivo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(50, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 79;
            this.label10.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(538, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Entidade:";
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_quantidade.Location = new System.Drawing.Point(304, 206);
            this.txb_quantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(169, 26);
            this.txb_quantidade.TabIndex = 76;
            this.txb_quantidade.TextChanged += new System.EventHandler(this.txb_quantidade_TextChanged);
            this.txb_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_quantidade_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(302, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Quantidade:";
            // 
            // txb_lote
            // 
            this.txb_lote.Enabled = false;
            this.txb_lote.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_lote.Location = new System.Drawing.Point(542, 127);
            this.txb_lote.Margin = new System.Windows.Forms.Padding(2);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(169, 26);
            this.txb_lote.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Data de receção:";
            // 
            // txb_numero_serie
            // 
            this.txb_numero_serie.Enabled = false;
            this.txb_numero_serie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_numero_serie.Location = new System.Drawing.Point(304, 124);
            this.txb_numero_serie.Margin = new System.Windows.Forms.Padding(2);
            this.txb_numero_serie.Name = "txb_numero_serie";
            this.txb_numero_serie.Size = new System.Drawing.Size(169, 26);
            this.txb_numero_serie.TabIndex = 72;
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Enabled = false;
            this.txb_denominacao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_denominacao.Location = new System.Drawing.Point(52, 124);
            this.txb_denominacao.Margin = new System.Windows.Forms.Padding(2);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(169, 26);
            this.txb_denominacao.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(538, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(302, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Número de série:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Denominação:";
            // 
            // dtp_data_rececao
            // 
            this.dtp_data_rececao.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_rececao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtp_data_rececao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_rececao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_rececao.Location = new System.Drawing.Point(52, 206);
            this.dtp_data_rececao.Name = "dtp_data_rececao";
            this.dtp_data_rececao.Size = new System.Drawing.Size(169, 26);
            this.dtp_data_rececao.TabIndex = 83;
            this.dtp_data_rececao.TabStop = false;
            this.dtp_data_rececao.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Berlin Sans FB", 9F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(670, 496);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(71, 19);
            this.btn_cancelar.TabIndex = 85;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Location = new System.Drawing.Point(606, 496);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 19);
            this.btn_guardar.TabIndex = 84;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label_motivo
            // 
            this.label_motivo.AutoSize = true;
            this.label_motivo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motivo.ForeColor = System.Drawing.Color.DarkRed;
            this.label_motivo.Location = new System.Drawing.Point(51, 438);
            this.label_motivo.Name = "label_motivo";
            this.label_motivo.Size = new System.Drawing.Size(44, 18);
            this.label_motivo.TabIndex = 122;
            this.label_motivo.Text = "label1";
            this.label_motivo.Visible = false;
            // 
            // label_entidade
            // 
            this.label_entidade.AutoSize = true;
            this.label_entidade.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entidade.ForeColor = System.Drawing.Color.DarkRed;
            this.label_entidade.Location = new System.Drawing.Point(539, 234);
            this.label_entidade.Name = "label_entidade";
            this.label_entidade.Size = new System.Drawing.Size(44, 18);
            this.label_entidade.TabIndex = 121;
            this.label_entidade.Text = "label1";
            this.label_entidade.Visible = false;
            // 
            // label_quantidade
            // 
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade.ForeColor = System.Drawing.Color.DarkRed;
            this.label_quantidade.Location = new System.Drawing.Point(303, 234);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(44, 18);
            this.label_quantidade.TabIndex = 120;
            this.label_quantidade.Text = "label1";
            this.label_quantidade.Visible = false;
            // 
            // cb_entidade
            // 
            this.cb_entidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_entidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cb_entidade.FormattingEnabled = true;
            this.cb_entidade.Items.AddRange(new object[] {
            "Sporthealth",
            "Littmann",
            "Garcia Hostal",
            "Bloc",
            "WED",
            "Samsung ",
            "HealthCare",
            "Econom",
            "DisplayMedical",
            "Alihop"});
            this.cb_entidade.Location = new System.Drawing.Point(542, 206);
            this.cb_entidade.Name = "cb_entidade";
            this.cb_entidade.Size = new System.Drawing.Size(169, 28);
            this.cb_entidade.TabIndex = 123;
            this.cb_entidade.SelectedIndexChanged += new System.EventHandler(this.cb_entidade_SelectedIndexChanged);
            // 
            // Aquisição_equipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 524);
            this.Controls.Add(this.cb_entidade);
            this.Controls.Add(this.label_motivo);
            this.Controls.Add(this.label_entidade);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dtp_data_rececao);
            this.Controls.Add(this.txb_motivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_lote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_numero_serie);
            this.Controls.Add(this.txb_denominacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aquisição_equipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquisição_equipamento";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_med;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txb_motivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_lote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_numero_serie;
        private System.Windows.Forms.TextBox txb_denominacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_data_rececao;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label_motivo;
        private System.Windows.Forms.Label label_entidade;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.ComboBox cb_entidade;
    }
}