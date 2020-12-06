namespace FormMDI
{
    partial class FrmPenjat
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
            this.flFichasDeJoc = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPenjat = new System.Windows.Forms.PictureBox();
            this.flParaula = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenjat)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJoc
            // 
            this.flFichasDeJoc.Location = new System.Drawing.Point(22, 55);
            this.flFichasDeJoc.Name = "flFichasDeJoc";
            this.flFichasDeJoc.Size = new System.Drawing.Size(354, 316);
            this.flFichasDeJoc.TabIndex = 0;
            // 
            // pbPenjat
            // 
            this.pbPenjat.Location = new System.Drawing.Point(399, 45);
            this.pbPenjat.Name = "pbPenjat";
            this.pbPenjat.Size = new System.Drawing.Size(246, 326);
            this.pbPenjat.TabIndex = 1;
            this.pbPenjat.TabStop = false;
            // 
            // flParaula
            // 
            this.flParaula.Location = new System.Drawing.Point(73, 388);
            this.flParaula.Name = "flParaula";
            this.flParaula.Size = new System.Drawing.Size(572, 88);
            this.flParaula.TabIndex = 2;
            // 
            // lbMensaje
            // 
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.Red;
            this.lbMensaje.Location = new System.Drawing.Point(382, 305);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(259, 35);
            this.lbMensaje.TabIndex = 3;
            this.lbMensaje.Text = "EL NINOT HA MORT";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(109, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Empieza";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(386, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "EL PENJAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPenjat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(657, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.flParaula);
            this.Controls.Add(this.pbPenjat);
            this.Controls.Add(this.flFichasDeJoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPenjat";
            this.Text = "El Penjat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPenjat_FormClosing);
            this.Load += new System.EventHandler(this.FrmPenjat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPenjat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJoc;
        private System.Windows.Forms.PictureBox pbPenjat;
        private System.Windows.Forms.FlowLayoutPanel flParaula;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
    }
}