﻿
namespace DLS_ALFEITE
{
    partial class Login_Codigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Codigo));
            this.textBox_codigo_unico = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_username_confirmação = new System.Windows.Forms.TextBox();
            this.btn_login_codigounico = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_codigounico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_codigo_unico
            // 
            this.textBox_codigo_unico.BackColor = System.Drawing.Color.Azure;
            this.textBox_codigo_unico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_codigo_unico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigo_unico.Location = new System.Drawing.Point(168, 130);
            this.textBox_codigo_unico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_codigo_unico.Name = "textBox_codigo_unico";
            this.textBox_codigo_unico.Size = new System.Drawing.Size(150, 23);
            this.textBox_codigo_unico.TabIndex = 28;
            this.textBox_codigo_unico.Text = "Código Único";
            this.textBox_codigo_unico.Enter += new System.EventHandler(this.textBox_codigo_unico_Enter);
            this.textBox_codigo_unico.Leave += new System.EventHandler(this.textBox_codigo_unico_Leave);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(335, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 35);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_username_confirmação
            // 
            this.textBox_username_confirmação.BackColor = System.Drawing.Color.Azure;
            this.textBox_username_confirmação.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username_confirmação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username_confirmação.Location = new System.Drawing.Point(168, 82);
            this.textBox_username_confirmação.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_username_confirmação.Name = "textBox_username_confirmação";
            this.textBox_username_confirmação.Size = new System.Drawing.Size(150, 23);
            this.textBox_username_confirmação.TabIndex = 27;
            this.textBox_username_confirmação.Text = "Username";
            // 
            // btn_login_codigounico
            // 
            this.btn_login_codigounico.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_codigounico.Image")));
            this.btn_login_codigounico.Location = new System.Drawing.Point(192, 171);
            this.btn_login_codigounico.Name = "btn_login_codigounico";
            this.btn_login_codigounico.Size = new System.Drawing.Size(128, 57);
            this.btn_login_codigounico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_login_codigounico.TabIndex = 26;
            this.btn_login_codigounico.TabStop = false;
            this.btn_login_codigounico.Click += new System.EventHandler(this.btn_login_codigounico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(104, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "CONFIRMAÇÃO DE IDENTIDADE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(119, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(119, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(119, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 3);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(119, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 3);
            this.panel2.TabIndex = 25;
            // 
            // Login_Codigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login_codigounico);
            this.Controls.Add(this.textBox_username_confirmação);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_codigo_unico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Codigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Codigo";
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_codigounico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_codigo_unico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_username_confirmação;
        private System.Windows.Forms.PictureBox btn_login_codigounico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}