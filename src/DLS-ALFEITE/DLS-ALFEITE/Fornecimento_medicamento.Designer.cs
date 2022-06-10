namespace DLS_ALFEITE
{
    partial class Fornecimento_medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecimento_medicamento));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_med = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_observacoes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            this.txb_principio_ativo = new System.Windows.Forms.TextBox();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_lote = new System.Windows.Forms.TextBox();
            this.txb_entidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_data_fornecimento = new System.Windows.Forms.DateTimePicker();
            this.dtp_data_prevista_entrega = new System.Windows.Forms.DateTimePicker();
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
            this.label_med.Size = new System.Drawing.Size(256, 20);
            this.label_med.TabIndex = 7;
            this.label_med.Text = "Fornecimento de Medicamento";
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
            this.btn_min.Location = new System.Drawing.Point(660, -3);
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
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(688, 501);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(58, 19);
            this.btn_cancelar.TabIndex = 46;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(628, 501);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(56, 19);
            this.btn_guardar.TabIndex = 45;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_observacoes
            // 
            this.txb_observacoes.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_observacoes.Location = new System.Drawing.Point(51, 332);
            this.txb_observacoes.Margin = new System.Windows.Forms.Padding(2);
            this.txb_observacoes.Multiline = true;
            this.txb_observacoes.Name = "txb_observacoes";
            this.txb_observacoes.Size = new System.Drawing.Size(659, 140);
            this.txb_observacoes.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(49, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "Observações:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(49, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(400, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Data prevista de entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de fornecimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(400, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Princípio/Ativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Denominação:";
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Enabled = false;
            this.txb_denominacao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_denominacao.Location = new System.Drawing.Point(52, 89);
            this.txb_denominacao.Margin = new System.Windows.Forms.Padding(2);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(307, 26);
            this.txb_denominacao.TabIndex = 47;
            // 
            // txb_principio_ativo
            // 
            this.txb_principio_ativo.Enabled = false;
            this.txb_principio_ativo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_principio_ativo.Location = new System.Drawing.Point(403, 89);
            this.txb_principio_ativo.Margin = new System.Windows.Forms.Padding(2);
            this.txb_principio_ativo.Name = "txb_principio_ativo";
            this.txb_principio_ativo.Size = new System.Drawing.Size(307, 26);
            this.txb_principio_ativo.TabIndex = 48;
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_quantidade.Location = new System.Drawing.Point(51, 253);
            this.txb_quantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(169, 26);
            this.txb_quantidade.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(538, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Lote:";
            // 
            // txb_lote
            // 
            this.txb_lote.Enabled = false;
            this.txb_lote.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_lote.Location = new System.Drawing.Point(541, 253);
            this.txb_lote.Margin = new System.Windows.Forms.Padding(2);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(169, 26);
            this.txb_lote.TabIndex = 52;
            // 
            // txb_entidade
            // 
            this.txb_entidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_entidade.Location = new System.Drawing.Point(296, 253);
            this.txb_entidade.Margin = new System.Windows.Forms.Padding(2);
            this.txb_entidade.Name = "txb_entidade";
            this.txb_entidade.Size = new System.Drawing.Size(169, 26);
            this.txb_entidade.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(293, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Entidade:";
            // 
            // dtp_data_fornecimento
            // 
            this.dtp_data_fornecimento.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_fornecimento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtp_data_fornecimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_fornecimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_fornecimento.Location = new System.Drawing.Point(51, 171);
            this.dtp_data_fornecimento.Name = "dtp_data_fornecimento";
            this.dtp_data_fornecimento.Size = new System.Drawing.Size(307, 26);
            this.dtp_data_fornecimento.TabIndex = 86;
            this.dtp_data_fornecimento.TabStop = false;
            this.dtp_data_fornecimento.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // dtp_data_prevista_entrega
            // 
            this.dtp_data_prevista_entrega.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_prevista_entrega.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtp_data_prevista_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_prevista_entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_prevista_entrega.Location = new System.Drawing.Point(402, 171);
            this.dtp_data_prevista_entrega.Name = "dtp_data_prevista_entrega";
            this.dtp_data_prevista_entrega.Size = new System.Drawing.Size(308, 26);
            this.dtp_data_prevista_entrega.TabIndex = 87;
            this.dtp_data_prevista_entrega.TabStop = false;
            this.dtp_data_prevista_entrega.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // Fornecimento_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 524);
            this.Controls.Add(this.dtp_data_prevista_entrega);
            this.Controls.Add(this.dtp_data_fornecimento);
            this.Controls.Add(this.txb_entidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_lote);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.txb_principio_ativo);
            this.Controls.Add(this.txb_denominacao);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txb_observacoes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fornecimento_medicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecimento_medicamento";
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txb_observacoes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_denominacao;
        private System.Windows.Forms.TextBox txb_principio_ativo;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_lote;
        private System.Windows.Forms.TextBox txb_entidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_data_fornecimento;
        private System.Windows.Forms.DateTimePicker dtp_data_prevista_entrega;
    }
}