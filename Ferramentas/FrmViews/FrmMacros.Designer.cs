﻿
namespace Ferramentas.FrmViews
{
    partial class FrmMacros
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
            this.BtnSalvar = new FontAwesome.Sharp.IconButton();
            this.BtnContinuar = new FontAwesome.Sharp.IconButton();
            this.lblY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnSalvar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalvar.IconSize = 18;
            this.BtnSalvar.Location = new System.Drawing.Point(330, 106);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(110, 38);
            this.BtnSalvar.TabIndex = 31;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnContinuar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnContinuar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnContinuar.IconSize = 18;
            this.BtnContinuar.Location = new System.Drawing.Point(214, 106);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(110, 38);
            this.BtnContinuar.TabIndex = 32;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.Color.Cyan;
            this.lblY.Location = new System.Drawing.Point(111, 89);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 13);
            this.lblY.TabIndex = 40;
            this.lblY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Posição Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Cyan;
            this.lblX.Location = new System.Drawing.Point(111, 63);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 13);
            this.lblX.TabIndex = 38;
            this.lblX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Posição X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "POSIÇÃO DO MOUSE SALVA COM SUCESSO!";
            // 
            // FrmMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(452, 156);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.BtnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMacros";
            this.Text = "FrmMacros";
            this.Load += new System.EventHandler(this.FrmMacros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnSalvar;
        private FontAwesome.Sharp.IconButton BtnContinuar;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}