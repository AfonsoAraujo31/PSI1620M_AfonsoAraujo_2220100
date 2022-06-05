namespace DLS_ALFEITE
{
    partial class Aquisição_medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aquisição_medicamento));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_med = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_motivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_entidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_lote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_principio_ativo = new System.Windows.Forms.TextBox();
            this.txb_denominacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_data_rececao = new System.Windows.Forms.DateTimePicker();
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
            this.panel5.TabIndex = 8;
            // 
            // label_med
            // 
            this.label_med.AutoSize = true;
            this.label_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_med.ForeColor = System.Drawing.Color.Transparent;
            this.label_med.Location = new System.Drawing.Point(2, 4);
            this.label_med.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_med.Name = "label_med";
            this.label_med.Size = new System.Drawing.Size(224, 20);
            this.label_med.TabIndex = 7;
            this.label_med.Text = "Aquisição de Medicamento";
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
            this.btn_cancelar.Location = new System.Drawing.Point(688, 500);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(57, 19);
            this.btn_cancelar.TabIndex = 66;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(628, 500);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(56, 19);
            this.btn_guardar.TabIndex = 65;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_motivo
            // 
            this.txb_motivo.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_motivo.Location = new System.Drawing.Point(51, 294);
            this.txb_motivo.Margin = new System.Windows.Forms.Padding(2);
            this.txb_motivo.Multiline = true;
            this.txb_motivo.Name = "txb_motivo";
            this.txb_motivo.Size = new System.Drawing.Size(659, 140);
            this.txb_motivo.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(49, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 63;
            this.label10.Text = "Motivo:";
            // 
            // txb_entidade
            // 
            this.txb_entidade.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_entidade.Location = new System.Drawing.Point(541, 204);
            this.txb_entidade.Margin = new System.Windows.Forms.Padding(2);
            this.txb_entidade.Name = "txb_entidade";
            this.txb_entidade.Size = new System.Drawing.Size(169, 25);
            this.txb_entidade.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(538, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Entidade:";
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_quantidade.Location = new System.Drawing.Point(303, 204);
            this.txb_quantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(169, 25);
            this.txb_quantidade.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(301, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Quantidade:";
            // 
            // txb_lote
            // 
            this.txb_lote.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_lote.Location = new System.Drawing.Point(541, 124);
            this.txb_lote.Margin = new System.Windows.Forms.Padding(2);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(169, 25);
            this.txb_lote.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Data de receção:";
            // 
            // txb_principio_ativo
            // 
            this.txb_principio_ativo.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_principio_ativo.Location = new System.Drawing.Point(303, 122);
            this.txb_principio_ativo.Margin = new System.Windows.Forms.Padding(2);
            this.txb_principio_ativo.Name = "txb_principio_ativo";
            this.txb_principio_ativo.Size = new System.Drawing.Size(169, 25);
            this.txb_principio_ativo.TabIndex = 51;
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.txb_denominacao.Location = new System.Drawing.Point(51, 122);
            this.txb_denominacao.Margin = new System.Windows.Forms.Padding(2);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(169, 25);
            this.txb_denominacao.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(538, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(301, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Princípio/Ativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Denominação:";
            // 
            // dtp_data_rececao
            // 
            this.dtp_data_rececao.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_rececao.Font = new System.Drawing.Font("Berlin Sans FB", 12.25F);
            this.dtp_data_rececao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_rececao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_rececao.Location = new System.Drawing.Point(51, 204);
            this.dtp_data_rececao.Name = "dtp_data_rececao";
            this.dtp_data_rececao.Size = new System.Drawing.Size(169, 25);
            this.dtp_data_rececao.TabIndex = 67;
            this.dtp_data_rececao.TabStop = false;
            this.dtp_data_rececao.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // Aquisição_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(750, 524);
            this.Controls.Add(this.dtp_data_rececao);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txb_motivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_entidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_lote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_principio_ativo);
            this.Controls.Add(this.txb_denominacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aquisição_medicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquisição_medicamento";
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
        private System.Windows.Forms.TextBox txb_motivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_entidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_lote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_principio_ativo;
        private System.Windows.Forms.TextBox txb_denominacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_data_rececao;
    }
}