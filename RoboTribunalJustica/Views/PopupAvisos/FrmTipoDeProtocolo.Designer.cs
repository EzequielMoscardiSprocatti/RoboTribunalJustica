
namespace RoboTribunalJustica.Views.PopupAvisos
{
    partial class FrmTipoDeProtocolo
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnPeticionar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtCaminhoDocIguais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAbrirPastaDocumentosIguais = new FontAwesome.Sharp.IconButton();
            this.BtnPastaComDocumentosDiferentes = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentosDiferentes = new System.Windows.Forms.TextBox();
            this.chkPeticaoSemDocumentos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(210, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "TIPO DE PROTOCOLO";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancelar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCancelar.IconSize = 16;
            this.BtnCancelar.Location = new System.Drawing.Point(310, 332);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.BtnCancelar.TabIndex = 28;
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
            this.BtnPeticionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPeticionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeticionar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPeticionar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.BtnPeticionar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnPeticionar.IconSize = 18;
            this.BtnPeticionar.Location = new System.Drawing.Point(89, 332);
            this.BtnPeticionar.Name = "BtnPeticionar";
            this.BtnPeticionar.Rotation = 0D;
            this.BtnPeticionar.Size = new System.Drawing.Size(168, 38);
            this.BtnPeticionar.TabIndex = 27;
            this.BtnPeticionar.Text = "Iniciar Protocolo";
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
            this.iconPictureBox1.IconSize = 66;
            this.iconPictureBox1.Location = new System.Drawing.Point(262, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(71, 66);
            this.iconPictureBox1.TabIndex = 18;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtCaminhoDocIguais
            // 
            this.txtCaminhoDocIguais.Location = new System.Drawing.Point(89, 167);
            this.txtCaminhoDocIguais.Name = "txtCaminhoDocIguais";
            this.txtCaminhoDocIguais.Size = new System.Drawing.Size(478, 20);
            this.txtCaminhoDocIguais.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Petição com \"Documentos Iguais\". Insira o caminho dos arquivos.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnAbrirPastaDocumentosIguais
            // 
            this.BtnAbrirPastaDocumentosIguais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAbrirPastaDocumentosIguais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirPastaDocumentosIguais.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAbrirPastaDocumentosIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirPastaDocumentosIguais.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAbrirPastaDocumentosIguais.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.BtnAbrirPastaDocumentosIguais.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAbrirPastaDocumentosIguais.IconSize = 16;
            this.BtnAbrirPastaDocumentosIguais.Location = new System.Drawing.Point(7, 164);
            this.BtnAbrirPastaDocumentosIguais.Name = "BtnAbrirPastaDocumentosIguais";
            this.BtnAbrirPastaDocumentosIguais.Rotation = 0D;
            this.BtnAbrirPastaDocumentosIguais.Size = new System.Drawing.Size(76, 26);
            this.BtnAbrirPastaDocumentosIguais.TabIndex = 31;
            this.BtnAbrirPastaDocumentosIguais.Text = "Abrir";
            this.BtnAbrirPastaDocumentosIguais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrirPastaDocumentosIguais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAbrirPastaDocumentosIguais.UseVisualStyleBackColor = true;
            this.BtnAbrirPastaDocumentosIguais.Click += new System.EventHandler(this.BtnAbrirPastaDocumentosIguais_Click);
            // 
            // BtnPastaComDocumentosDiferentes
            // 
            this.BtnPastaComDocumentosDiferentes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPastaComDocumentosDiferentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPastaComDocumentosDiferentes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPastaComDocumentosDiferentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPastaComDocumentosDiferentes.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPastaComDocumentosDiferentes.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.BtnPastaComDocumentosDiferentes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnPastaComDocumentosDiferentes.IconSize = 16;
            this.BtnPastaComDocumentosDiferentes.Location = new System.Drawing.Point(7, 232);
            this.BtnPastaComDocumentosDiferentes.Name = "BtnPastaComDocumentosDiferentes";
            this.BtnPastaComDocumentosDiferentes.Rotation = 0D;
            this.BtnPastaComDocumentosDiferentes.Size = new System.Drawing.Size(76, 26);
            this.BtnPastaComDocumentosDiferentes.TabIndex = 34;
            this.BtnPastaComDocumentosDiferentes.Text = "Abrir";
            this.BtnPastaComDocumentosDiferentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPastaComDocumentosDiferentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPastaComDocumentosDiferentes.UseVisualStyleBackColor = true;
            this.BtnPastaComDocumentosDiferentes.Click += new System.EventHandler(this.BtnPastaComDocumentosDiferentes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(9, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Petição com \"Documentos Diferentes\". Insira o caminho dos arquivos.";
            // 
            // txtDocumentosDiferentes
            // 
            this.txtDocumentosDiferentes.Location = new System.Drawing.Point(89, 235);
            this.txtDocumentosDiferentes.Name = "txtDocumentosDiferentes";
            this.txtDocumentosDiferentes.Size = new System.Drawing.Size(478, 20);
            this.txtDocumentosDiferentes.TabIndex = 32;
            // 
            // chkPeticaoSemDocumentos
            // 
            this.chkPeticaoSemDocumentos.AutoSize = true;
            this.chkPeticaoSemDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeticaoSemDocumentos.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.chkPeticaoSemDocumentos.Location = new System.Drawing.Point(188, 287);
            this.chkPeticaoSemDocumentos.Name = "chkPeticaoSemDocumentos";
            this.chkPeticaoSemDocumentos.Size = new System.Drawing.Size(200, 22);
            this.chkPeticaoSemDocumentos.TabIndex = 37;
            this.chkPeticaoSemDocumentos.Text = "Petiçao sem Documentos";
            this.chkPeticaoSemDocumentos.UseVisualStyleBackColor = true;
            // 
            // FrmTipoDeProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(595, 397);
            this.Controls.Add(this.chkPeticaoSemDocumentos);
            this.Controls.Add(this.BtnPastaComDocumentosDiferentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumentosDiferentes);
            this.Controls.Add(this.BtnAbrirPastaDocumentosIguais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminhoDocIguais);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnPeticionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoDeProtocolo";
            this.Text = "FrmTipoDeProtocolo";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnPeticionar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtCaminhoDocIguais;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnAbrirPastaDocumentosIguais;
        private FontAwesome.Sharp.IconButton BtnPastaComDocumentosDiferentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentosDiferentes;
        private System.Windows.Forms.CheckBox chkPeticaoSemDocumentos;
    }
}