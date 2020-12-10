namespace FormMDI
{
    partial class FrmPedraPaperTisora
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
            this.rock = new System.Windows.Forms.Button();
            this.bot = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.puntsPlayer = new System.Windows.Forms.Label();
            this.puntsMaquina = new System.Windows.Forms.Label();
            this.paper = new System.Windows.Forms.Button();
            this.tissores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(38, 81);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 23);
            this.rock.TabIndex = 0;
            this.rock.Text = "rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // bot
            // 
            this.bot.AutoSize = true;
            this.bot.Location = new System.Drawing.Point(464, 86);
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(47, 13);
            this.bot.TabIndex = 1;
            this.bot.Text = "maquina";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(261, 86);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(41, 13);
            this.res.TabIndex = 2;
            this.res.Text = "resultat";
            // 
            // puntsPlayer
            // 
            this.puntsPlayer.AutoSize = true;
            this.puntsPlayer.Location = new System.Drawing.Point(35, 28);
            this.puntsPlayer.Name = "puntsPlayer";
            this.puntsPlayer.Size = new System.Drawing.Size(71, 13);
            this.puntsPlayer.TabIndex = 3;
            this.puntsPlayer.Text = "punts jugador";
            // 
            // puntsMaquina
            // 
            this.puntsMaquina.AutoSize = true;
            this.puntsMaquina.Location = new System.Drawing.Point(464, 28);
            this.puntsMaquina.Name = "puntsMaquina";
            this.puntsMaquina.Size = new System.Drawing.Size(76, 13);
            this.puntsMaquina.TabIndex = 4;
            this.puntsMaquina.Text = "punts maquina";
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(38, 158);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(75, 23);
            this.paper.TabIndex = 5;
            this.paper.Text = "paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // tissores
            // 
            this.tissores.Location = new System.Drawing.Point(38, 242);
            this.tissores.Name = "tissores";
            this.tissores.Size = new System.Drawing.Size(75, 23);
            this.tissores.TabIndex = 6;
            this.tissores.Text = "tissores";
            this.tissores.UseVisualStyleBackColor = true;
            this.tissores.Click += new System.EventHandler(this.tissores_Click);
            // 
            // FrmPedraPaperTisora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tissores);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.puntsMaquina);
            this.Controls.Add(this.puntsPlayer);
            this.Controls.Add(this.res);
            this.Controls.Add(this.bot);
            this.Controls.Add(this.rock);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPedraPaperTisora";
            this.Text = "Pedra - Paper - Tisora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedraPaperTisora_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Label bot;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label puntsPlayer;
        private System.Windows.Forms.Label puntsMaquina;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button tissores;
    }
}