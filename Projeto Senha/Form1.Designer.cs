namespace Projeto_Senha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnPreferencial = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(65, 31);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(122, 66);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            // 
            // btnPreferencial
            // 
            this.btnPreferencial.Location = new System.Drawing.Point(65, 150);
            this.btnPreferencial.Name = "btnPreferencial";
            this.btnPreferencial.Size = new System.Drawing.Size(122, 66);
            this.btnPreferencial.TabIndex = 1;
            this.btnPreferencial.Text = "Preferencial";
            this.btnPreferencial.UseVisualStyleBackColor = true;
            // 
            // lbSenha
            // 
            this.lbSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSenha.Location = new System.Drawing.Point(449, 31);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(212, 185);
            this.lbSenha.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btnPreferencial);
            this.Controls.Add(this.btnNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNormal;
        private Button btnPreferencial;
        private Label lbSenha;
    }
}