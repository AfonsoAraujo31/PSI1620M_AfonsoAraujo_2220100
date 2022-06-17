
namespace DLS_ALFEITE
{
    partial class Registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_numero_telemovel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_username = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.btn_alterar);
            this.panel2.Controls.Add(this.cb_genero);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.txb_numero_telemovel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txb_email);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txb_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txb_nome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txb_username);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_tel);
            this.panel2.Controls.Add(this.label_email);
            this.panel2.Controls.Add(this.label_genero);
            this.panel2.Controls.Add(this.label_password);
            this.panel2.Controls.Add(this.label_nome);
            this.panel2.Controls.Add(this.label_username);
            this.panel2.Location = new System.Drawing.Point(654, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 723);
            this.panel2.TabIndex = 2;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.btn_alterar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_alterar.Location = new System.Drawing.Point(260, 611);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(95, 32);
            this.btn_alterar.TabIndex = 111;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // cb_genero
            // 
            this.cb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_genero.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_genero.Location = new System.Drawing.Point(75, 420);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(249, 28);
            this.cb_genero.TabIndex = 110;
            this.cb_genero.SelectedIndexChanged += new System.EventHandler(this.cb_genero_SelectedIndexChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.btn_guardar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Location = new System.Drawing.Point(159, 611);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(95, 32);
            this.btn_guardar.TabIndex = 108;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_numero_telemovel
            // 
            this.txb_numero_telemovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_numero_telemovel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_numero_telemovel.ForeColor = System.Drawing.Color.Black;
            this.txb_numero_telemovel.Location = new System.Drawing.Point(75, 567);
            this.txb_numero_telemovel.Name = "txb_numero_telemovel";
            this.txb_numero_telemovel.Size = new System.Drawing.Size(249, 26);
            this.txb_numero_telemovel.TabIndex = 106;
            this.txb_numero_telemovel.TextChanged += new System.EventHandler(this.txb_numero_telemovel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(71, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 107;
            this.label4.Text = "Número de telemóvel:";
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_email.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_email.ForeColor = System.Drawing.Color.Black;
            this.txb_email.Location = new System.Drawing.Point(75, 493);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(249, 26);
            this.txb_email.TabIndex = 104;
            this.txb_email.TextChanged += new System.EventHandler(this.txb_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(71, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 105;
            this.label5.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(71, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 103;
            this.label2.Text = "Género:";
            // 
            // txb_password
            // 
            this.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_password.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_password.ForeColor = System.Drawing.Color.Black;
            this.txb_password.Location = new System.Drawing.Point(75, 346);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(249, 26);
            this.txb_password.TabIndex = 100;
            this.txb_password.TextChanged += new System.EventHandler(this.txb_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(71, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 101;
            this.label3.Text = "Password:";
            // 
            // txb_nome
            // 
            this.txb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_nome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_nome.ForeColor = System.Drawing.Color.Black;
            this.txb_nome.Location = new System.Drawing.Point(75, 273);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(249, 26);
            this.txb_nome.TabIndex = 98;
            this.txb_nome.TextChanged += new System.EventHandler(this.txb_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(71, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "Nome:";
            // 
            // txb_username
            // 
            this.txb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_username.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txb_username.ForeColor = System.Drawing.Color.Black;
            this.txb_username.Location = new System.Drawing.Point(75, 199);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(249, 26);
            this.txb_username.TabIndex = 96;
            this.txb_username.TextChanged += new System.EventHandler(this.txb_username_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(71, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 97;
            this.label11.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(47, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1094, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(370, 389);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.DarkRed;
            this.label_username.Location = new System.Drawing.Point(72, 223);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(44, 18);
            this.label_username.TabIndex = 130;
            this.label_username.Text = "label1";
            this.label_username.Visible = false;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.DarkRed;
            this.label_nome.Location = new System.Drawing.Point(72, 297);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(44, 18);
            this.label_nome.TabIndex = 131;
            this.label_nome.Text = "label1";
            this.label_nome.Visible = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.DarkRed;
            this.label_password.Location = new System.Drawing.Point(72, 370);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(44, 18);
            this.label_password.TabIndex = 132;
            this.label_password.Text = "label1";
            this.label_password.Visible = false;
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genero.ForeColor = System.Drawing.Color.DarkRed;
            this.label_genero.Location = new System.Drawing.Point(72, 446);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(44, 18);
            this.label_genero.TabIndex = 133;
            this.label_genero.Text = "label1";
            this.label_genero.Visible = false;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.DarkRed;
            this.label_email.Location = new System.Drawing.Point(72, 517);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(44, 18);
            this.label_email.TabIndex = 134;
            this.label_email.Text = "label1";
            this.label_email.Visible = false;
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tel.ForeColor = System.Drawing.Color.DarkRed;
            this.label_tel.Location = new System.Drawing.Point(72, 591);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(44, 18);
            this.label_tel.TabIndex = 135;
            this.label_tel.Text = "label1";
            this.label_tel.Visible = false;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1894, 994);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registo";
            this.Text = "Registo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txb_numero_telemovel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_username;
    }
}