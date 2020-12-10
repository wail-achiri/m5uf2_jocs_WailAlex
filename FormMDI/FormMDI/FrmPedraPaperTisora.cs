using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmPedraPaperTisora : Form
    {
        int puntsJugador = 0;
        int puntsRival = 0;
        public event EventHandler emTanquen;
        public FrmPedraPaperTisora()
        {
            InitializeComponent();
        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void rock_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);
            switch (option)
            {
                case 1:
                    bot.Text = "paper";
                    res.Text = " has perdut";
                    puntsRival++;
                    puntsMaquina.Text = Convert.ToString(puntsRival);
                    break;
                case 2:
                    bot.Text = "pedra";
                    res.Text = "empat";
                    break;
                case 3:
                    bot.Text = "tissores";
                    res.Text = " has guanyat";
                    puntsJugador++;
                    puntsPlayer.Text = Convert.ToString(puntsJugador);
                    break;
            }
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);
            switch (option)
            {
                case 1:
                    bot.Text = "paper";
                    res.Text = "empat";
                    break;
                case 2:
                    bot.Text = "pedra";
                    res.Text = "has guanyat";
                    puntsJugador++;
                    puntsPlayer.Text = Convert.ToString(puntsJugador);
                    break;
                case 3:
                    bot.Text = "tissores";
                    res.Text = " has perdut";
                    puntsRival++;
                    puntsMaquina.Text = Convert.ToString(puntsRival);
                    break;
            }
        }

        private void tissores_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);
            switch (option)
            {
                case 1:
                    bot.Text = "paper";
                    res.Text = "has guanyat";
                    puntsJugador++;
                    puntsPlayer.Text = Convert.ToString(puntsJugador);
                    break;
                case 2:
                    bot.Text = "pedra";
                    res.Text = "has perdut";
                    puntsRival++;
                    puntsMaquina.Text = Convert.ToString(puntsRival);
                    break;
                case 3:
                    bot.Text = "tissores";
                    res.Text = " empat";   
                    break;
            }
        }
    }
}
