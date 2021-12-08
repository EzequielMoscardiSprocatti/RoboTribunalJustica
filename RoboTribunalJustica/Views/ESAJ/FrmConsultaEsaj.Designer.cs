namespace RoboTribunalJustica.Views.ESAJ
{
    partial class FrmConsultaEsaj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPeticionamento = new FontAwesome.Sharp.IconButton();
            this.BtnPeticionar = new FontAwesome.Sharp.IconButton();
            this.Cbxtjsaj = new System.Windows.Forms.ComboBox();
            this.BtnExportar = new FontAwesome.Sharp.IconButton();
            this.BtnConsultar = new FontAwesome.Sharp.IconButton();
            this.BtnImporta = new FontAwesome.Sharp.IconButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DgvBase = new System.Windows.Forms.DataGridView();
            this.lblCarregado = new System.Windows.Forms.Label();
            this.lblProcessado = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.IconeCarregado = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(53)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.BtnPeticionamento);
            this.panel1.Controls.Add(this.BtnPeticionar);
            this.panel1.Controls.Add(this.Cbxtjsaj);
            this.panel1.Controls.Add(this.BtnExportar);
            this.panel1.Controls.Add(this.BtnConsultar);
            this.panel1.Controls.Add(this.BtnImporta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 54);
            this.panel1.TabIndex = 0;
            // 
            // BtnPeticionamento
            // 
            this.BtnPeticionamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeticionamento.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPeticionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeticionamento.ForeColor = System.Drawing.Color.Turquoise;
            this.BtnPeticionamento.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnPeticionamento.IconColor = System.Drawing.Color.Silver;
            this.BtnPeticionamento.IconSize = 20;
            this.BtnPeticionamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPeticionamento.Location = new System.Drawing.Point(518, 12);
            this.BtnPeticionamento.Name = "BtnPeticionamento";
            this.BtnPeticionamento.Rotation = 0D;
            this.BtnPeticionamento.Size = new System.Drawing.Size(146, 31);
            this.BtnPeticionamento.TabIndex = 15;
            this.BtnPeticionamento.Text = "Iniciar Petição";
            this.BtnPeticionamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPeticionamento.UseVisualStyleBackColor = true;
            this.BtnPeticionamento.Click += new System.EventHandler(this.BtnPeticionamento_Click);
            // 
            // BtnPeticionar
            // 
            this.BtnPeticionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeticionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPeticionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeticionar.ForeColor = System.Drawing.Color.Turquoise;
            this.BtnPeticionar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnPeticionar.IconColor = System.Drawing.Color.Silver;
            this.BtnPeticionar.IconSize = 20;
            this.BtnPeticionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPeticionar.Location = new System.Drawing.Point(371, 12);
            this.BtnPeticionar.Name = "BtnPeticionar";
            this.BtnPeticionar.Rotation = 0D;
            this.BtnPeticionar.Size = new System.Drawing.Size(141, 31);
            this.BtnPeticionar.TabIndex = 14;
            this.BtnPeticionar.Text = "Peticionamento ";
            this.BtnPeticionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPeticionar.UseVisualStyleBackColor = true;
            this.BtnPeticionar.Click += new System.EventHandler(this.BtnPeticionar_Click);
            // 
            // Cbxtjsaj
            // 
            this.Cbxtjsaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(53)))), ((int)(((byte)(115)))));
            this.Cbxtjsaj.DisplayMember = "UF";
            this.Cbxtjsaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbxtjsaj.ForeColor = System.Drawing.Color.Turquoise;
            this.Cbxtjsaj.FormattingEnabled = true;
            this.Cbxtjsaj.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "BA",
            "CE",
            "MS",
            "RN",
            "SC",
            "SP"});
            this.Cbxtjsaj.Location = new System.Drawing.Point(675, 16);
            this.Cbxtjsaj.Name = "Cbxtjsaj";
            this.Cbxtjsaj.Size = new System.Drawing.Size(121, 24);
            this.Cbxtjsaj.TabIndex = 13;
            this.Cbxtjsaj.Text = "UF";
            this.Cbxtjsaj.ValueMember = "UF";
            // 
            // BtnExportar
            // 
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.Turquoise;
            this.BtnExportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.BtnExportar.IconColor = System.Drawing.Color.Silver;
            this.BtnExportar.IconSize = 20;
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportar.Location = new System.Drawing.Point(250, 12);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Rotation = 0D;
            this.BtnExportar.Size = new System.Drawing.Size(115, 31);
            this.BtnExportar.TabIndex = 8;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.Turquoise;
            this.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BtnConsultar.IconColor = System.Drawing.Color.Silver;
            this.BtnConsultar.IconSize = 20;
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Location = new System.Drawing.Point(130, 12);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Rotation = 0D;
            this.BtnConsultar.Size = new System.Drawing.Size(115, 31);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnImporta
            // 
            this.BtnImporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImporta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnImporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImporta.ForeColor = System.Drawing.Color.Turquoise;
            this.BtnImporta.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnImporta.IconColor = System.Drawing.Color.Silver;
            this.BtnImporta.IconSize = 20;
            this.BtnImporta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImporta.Location = new System.Drawing.Point(9, 12);
            this.BtnImporta.Name = "BtnImporta";
            this.BtnImporta.Rotation = 0D;
            this.BtnImporta.Size = new System.Drawing.Size(115, 31);
            this.BtnImporta.TabIndex = 6;
            this.BtnImporta.Text = "Importar";
            this.BtnImporta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImporta.UseVisualStyleBackColor = true;
            this.BtnImporta.Click += new System.EventHandler(this.BtnImporta_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(857, 26);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // DgvBase
            // 
            this.DgvBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.DgvBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBase.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBase.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBase.EnableHeadersVisualStyles = false;
            this.DgvBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.DgvBase.Location = new System.Drawing.Point(-3, 64);
            this.DgvBase.Name = "DgvBase";
            this.DgvBase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBase.Size = new System.Drawing.Size(865, 359);
            this.DgvBase.TabIndex = 7;
            // 
            // lblCarregado
            // 
            this.lblCarregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarregado.AutoSize = true;
            this.lblCarregado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarregado.Location = new System.Drawing.Point(654, 431);
            this.lblCarregado.Name = "lblCarregado";
            this.lblCarregado.Size = new System.Drawing.Size(13, 13);
            this.lblCarregado.TabIndex = 13;
            this.lblCarregado.Text = "0";
            // 
            // lblProcessado
            // 
            this.lblProcessado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcessado.AutoSize = true;
            this.lblProcessado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProcessado.Location = new System.Drawing.Point(799, 432);
            this.lblProcessado.Name = "lblProcessado";
            this.lblProcessado.Size = new System.Drawing.Size(13, 13);
            this.lblProcessado.TabIndex = 14;
            this.lblProcessado.Text = "0";
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.Color.Silver;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton3.IconColor = System.Drawing.Color.Silver;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(709, 426);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(114, 23);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.Text = "  Processado:";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // IconeCarregado
            // 
            this.IconeCarregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IconeCarregado.FlatAppearance.BorderSize = 0;
            this.IconeCarregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconeCarregado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconeCarregado.ForeColor = System.Drawing.Color.Silver;
            this.IconeCarregado.IconChar = FontAwesome.Sharp.IconChar.List;
            this.IconeCarregado.IconColor = System.Drawing.Color.Silver;
            this.IconeCarregado.IconSize = 25;
            this.IconeCarregado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconeCarregado.Location = new System.Drawing.Point(566, 426);
            this.IconeCarregado.Name = "IconeCarregado";
            this.IconeCarregado.Rotation = 0D;
            this.IconeCarregado.Size = new System.Drawing.Size(114, 23);
            this.IconeCarregado.TabIndex = 11;
            this.IconeCarregado.Text = "  Carregado:";
            this.IconeCarregado.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaEsaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(53)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.lblProcessado);
            this.Controls.Add(this.lblCarregado);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.IconeCarregado);
            this.Controls.Add(this.DgvBase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmConsultaEsaj";
            this.Text = "Bot Consulta TJ E-SAJ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView DgvBase;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton IconeCarregado;
        private FontAwesome.Sharp.IconButton BtnExportar;
        private FontAwesome.Sharp.IconButton BtnConsultar;
        private FontAwesome.Sharp.IconButton BtnImporta;
        private System.Windows.Forms.Label lblCarregado;
        private System.Windows.Forms.Label lblProcessado;
        private System.Windows.Forms.ComboBox Cbxtjsaj;
        private FontAwesome.Sharp.IconButton BtnPeticionar;
        private FontAwesome.Sharp.IconButton BtnPeticionamento;
    }
}