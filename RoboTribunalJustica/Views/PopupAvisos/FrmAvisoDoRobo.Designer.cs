
namespace RoboTribunalJustica.Views.PopupAvisos
{
    partial class FrmAvisoDoRobo
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
            this.BtnAviso = new FontAwesome.Sharp.IconButton();
            this.TxtAvisoMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "AVISO - IMPORTANTE";
            // 
            // BtnAviso
            // 
            this.BtnAviso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAviso.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAviso.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnAviso.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAviso.IconSize = 18;
            this.BtnAviso.Location = new System.Drawing.Point(211, 164);
            this.BtnAviso.Name = "BtnAviso";
            this.BtnAviso.Size = new System.Drawing.Size(110, 38);
            this.BtnAviso.TabIndex = 28;
            this.BtnAviso.Text = "OK";
            this.BtnAviso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAviso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAviso.UseVisualStyleBackColor = true;
            this.BtnAviso.Click += new System.EventHandler(this.BtnAviso_Click);
            // 
            // TxtAvisoMsg
            // 
            this.TxtAvisoMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.TxtAvisoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAvisoMsg.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TxtAvisoMsg.Location = new System.Drawing.Point(13, 49);
            this.TxtAvisoMsg.Multiline = true;
            this.TxtAvisoMsg.Name = "TxtAvisoMsg";
            this.TxtAvisoMsg.Size = new System.Drawing.Size(526, 94);
            this.TxtAvisoMsg.TabIndex = 30;
            // 
            // FrmAvisoDoRobo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(560, 214);
            this.Controls.Add(this.TxtAvisoMsg);
            this.Controls.Add(this.BtnAviso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAvisoDoRobo";
            this.Text = "FrmAvisoDoRobo";
            this.Load += new System.EventHandler(this.FrmAvisoDoRobo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnAviso;
        private System.Windows.Forms.TextBox TxtAvisoMsg;
    }
}