
namespace RoboTribunalJustica.Views.PopupAvisos
{
    partial class FrmPeticionamentoEsaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTipoPeticionamento1Grau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnPeticionar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCofre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(218, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtSenha.Location = new System.Drawing.Point(274, 135);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(139, 20);
            this.TxtSenha.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtLogin.Location = new System.Drawing.Point(71, 135);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(116, 20);
            this.TxtLogin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(270, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identificar-se";
            // 
            // CbxTipoPeticionamento1Grau
            // 
            this.CbxTipoPeticionamento1Grau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.CbxTipoPeticionamento1Grau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxTipoPeticionamento1Grau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoPeticionamento1Grau.ForeColor = System.Drawing.Color.Aquamarine;
            this.CbxTipoPeticionamento1Grau.FormattingEnabled = true;
            this.CbxTipoPeticionamento1Grau.Items.AddRange(new object[] {
            "Petição Inicial de 1º Grau",
            "Petição Intermediária de 1º Grau"});
            this.CbxTipoPeticionamento1Grau.Location = new System.Drawing.Point(29, 205);
            this.CbxTipoPeticionamento1Grau.Name = "CbxTipoPeticionamento1Grau";
            this.CbxTipoPeticionamento1Grau.Size = new System.Drawing.Size(593, 28);
            this.CbxTipoPeticionamento1Grau.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peticionamento Eletrônico";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancelar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 16;
            this.BtnCancelar.Location = new System.Drawing.Point(379, 296);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnPeticionar
            // 
            this.BtnPeticionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPeticionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeticionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeticionar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPeticionar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnPeticionar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnPeticionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPeticionar.IconSize = 16;
            this.BtnPeticionar.Location = new System.Drawing.Point(158, 296);
            this.BtnPeticionar.Name = "BtnPeticionar";
            this.BtnPeticionar.Size = new System.Drawing.Size(168, 38);
            this.BtnPeticionar.TabIndex = 16;
            this.BtnPeticionar.Text = "Peticionar";
            this.BtnPeticionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPeticionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPeticionar.UseVisualStyleBackColor = true;
            this.BtnPeticionar.Click += new System.EventHandler(this.BtnPeticionar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 66;
            this.iconPictureBox1.Location = new System.Drawing.Point(290, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(71, 66);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(446, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cofre";
            // 
            // txtCofre
            // 
            this.txtCofre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtCofre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCofre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCofre.Location = new System.Drawing.Point(502, 135);
            this.txtCofre.Name = "txtCofre";
            this.txtCofre.PasswordChar = '*';
            this.txtCofre.Size = new System.Drawing.Size(139, 20);
            this.txtCofre.TabIndex = 18;
            // 
            // FrmPeticionamentoEsaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(677, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCofre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnPeticionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxTipoPeticionamento1Grau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeticionamentoEsaj";
            this.Text = "FrmPeticionamentoEsaj";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox CbxTipoPeticionamento1Grau;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnPeticionar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCofre;
    }
}