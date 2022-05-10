
namespace DLS_ALFEITE
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            this.btn_medicamentos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inflamaveis = new System.Windows.Forms.Button();
            this.btn_equipamentos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_medicamentos
            // 
            this.btn_medicamentos.FlatAppearance.BorderSize = 0;
            this.btn_medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicamentos.ForeColor = System.Drawing.Color.White;
            this.btn_medicamentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_medicamentos.Image")));
            this.btn_medicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medicamentos.Location = new System.Drawing.Point(-1, 76);
            this.btn_medicamentos.Name = "btn_medicamentos";
            this.btn_medicamentos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_medicamentos.Size = new System.Drawing.Size(240, 56);
            this.btn_medicamentos.TabIndex = 0;
            this.btn_medicamentos.Text = " MEDICAMENTOS";
            this.btn_medicamentos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_inflamaveis);
            this.panel2.Controls.Add(this.btn_equipamentos);
            this.panel2.Controls.Add(this.btn_medicamentos);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 589);
            this.panel2.TabIndex = 2;
            // 
            // btn_inflamaveis
            // 
            this.btn_inflamaveis.FlatAppearance.BorderSize = 0;
            this.btn_inflamaveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inflamaveis.ForeColor = System.Drawing.Color.White;
            this.btn_inflamaveis.Image = ((System.Drawing.Image)(resources.GetObject("btn_inflamaveis.Image")));
            this.btn_inflamaveis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inflamaveis.Location = new System.Drawing.Point(-1, 204);
            this.btn_inflamaveis.Name = "btn_inflamaveis";
            this.btn_inflamaveis.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_inflamaveis.Size = new System.Drawing.Size(240, 56);
            this.btn_inflamaveis.TabIndex = 5;
            this.btn_inflamaveis.Text = "INFLAMÁVEIS";
            this.btn_inflamaveis.UseVisualStyleBackColor = true;
            // 
            // btn_equipamentos
            // 
            this.btn_equipamentos.FlatAppearance.BorderSize = 0;
            this.btn_equipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equipamentos.ForeColor = System.Drawing.Color.White;
            this.btn_equipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_equipamentos.Image")));
            this.btn_equipamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_equipamentos.Location = new System.Drawing.Point(-1, 142);
            this.btn_equipamentos.Name = "btn_equipamentos";
            this.btn_equipamentos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_equipamentos.Size = new System.Drawing.Size(240, 56);
            this.btn_equipamentos.TabIndex = 4;
            this.btn_equipamentos.Text = "EQUIPAMENTOS";
            this.btn_equipamentos.UseVisualStyleBackColor = true;
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1042, 586);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Medicamentos";
            this.Text = "Medicamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_medicamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_equipamentos;
        private System.Windows.Forms.Button btn_inflamaveis;
    }
}