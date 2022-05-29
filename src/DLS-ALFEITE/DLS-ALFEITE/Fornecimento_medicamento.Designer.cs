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
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label_med);
            this.panel5.Controls.Add(this.btn_min);
            this.panel5.Controls.Add(this.btnclose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 36);
            this.panel5.TabIndex = 9;
            // 
            // label_med
            // 
            this.label_med.AutoSize = true;
            this.label_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_med.ForeColor = System.Drawing.Color.Transparent;
            this.label_med.Location = new System.Drawing.Point(3, 5);
            this.label_med.Name = "label_med";
            this.label_med.Size = new System.Drawing.Size(256, 20);
            this.label_med.TabIndex = 7;
            this.label_med.Text = "Fornecimento de Medicamento";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(883, -4);
            this.btn_min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(67, 41);
            this.btn_min.TabIndex = 8;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(936, -4);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(67, 41);
            this.btnclose.TabIndex = 6;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 617);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(837, 617);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 45;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_observacoes
            // 
            this.txb_observacoes.Location = new System.Drawing.Point(68, 409);
            this.txb_observacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_observacoes.Multiline = true;
            this.txb_observacoes.Name = "txb_observacoes";
            this.txb_observacoes.Size = new System.Drawing.Size(877, 171);
            this.txb_observacoes.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(65, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Observações:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(65, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(533, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Data prevista de entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de fornecimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(533, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Princípio/Ativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Denominação:";
            // 
            // txb_denominacao
            // 
            this.txb_denominacao.Location = new System.Drawing.Point(69, 110);
            this.txb_denominacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_denominacao.Name = "txb_denominacao";
            this.txb_denominacao.Size = new System.Drawing.Size(408, 22);
            this.txb_denominacao.TabIndex = 47;
            // 
            // txb_principio_ativo
            // 
            this.txb_principio_ativo.Location = new System.Drawing.Point(537, 110);
            this.txb_principio_ativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_principio_ativo.Name = "txb_principio_ativo";
            this.txb_principio_ativo.Size = new System.Drawing.Size(408, 22);
            this.txb_principio_ativo.TabIndex = 48;
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Location = new System.Drawing.Point(68, 311);
            this.txb_quantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(224, 22);
            this.txb_quantidade.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(717, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Lote:";
            // 
            // txb_lote
            // 
            this.txb_lote.Location = new System.Drawing.Point(721, 311);
            this.txb_lote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_lote.Name = "txb_lote";
            this.txb_lote.Size = new System.Drawing.Size(224, 22);
            this.txb_lote.TabIndex = 52;
            // 
            // txb_entidade
            // 
            this.txb_entidade.Location = new System.Drawing.Point(395, 311);
            this.txb_entidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_entidade.Name = "txb_entidade";
            this.txb_entidade.Size = new System.Drawing.Size(224, 22);
            this.txb_entidade.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(391, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Entidade:";
            // 
            // dtp_data_fornecimento
            // 
            this.dtp_data_fornecimento.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_fornecimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_fornecimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_fornecimento.Location = new System.Drawing.Point(68, 210);
            this.dtp_data_fornecimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_data_fornecimento.Name = "dtp_data_fornecimento";
            this.dtp_data_fornecimento.Size = new System.Drawing.Size(408, 22);
            this.dtp_data_fornecimento.TabIndex = 86;
            this.dtp_data_fornecimento.TabStop = false;
            this.dtp_data_fornecimento.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // dtp_data_prevista_entrega
            // 
            this.dtp_data_prevista_entrega.CustomFormat = "dd/MM/yyyy";
            this.dtp_data_prevista_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_data_prevista_entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data_prevista_entrega.Location = new System.Drawing.Point(536, 210);
            this.dtp_data_prevista_entrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_data_prevista_entrega.Name = "dtp_data_prevista_entrega";
            this.dtp_data_prevista_entrega.Size = new System.Drawing.Size(409, 22);
            this.dtp_data_prevista_entrega.TabIndex = 87;
            this.dtp_data_prevista_entrega.TabStop = false;
            this.dtp_data_prevista_entrega.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // Fornecimento_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.dtp_data_prevista_entrega);
            this.Controls.Add(this.dtp_data_fornecimento);
            this.Controls.Add(this.txb_entidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_lote);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.txb_principio_ativo);
            this.Controls.Add(this.txb_denominacao);
            this.Controls.Add(this.button2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button2;
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