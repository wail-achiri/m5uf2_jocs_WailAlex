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
    public partial class FrmPenjat : Form
    {
        public event EventHandler emTanquen;

        char[] ParaulaAdivinada; int Oportunitats;
        char[] ParaulaSeleccionada;
        char[] Alfabet;
        String[] Paraula;

        public FrmPenjat()
        {
            InitializeComponent();
        }

        public void iniciarJoc()
        {
            flFichasDeJoc.Controls.Clear();
            flFichasDeJoc.Enabled = true;
            pbPenjat.Image = null;
            lbMensaje.Visible = false;
            Oportunitats = 0;
            btnStart.Visible = false;

            Paraula = new string[] { "DAM","ASIX","JAUME","Wail","Alex","Programar","Penjat"};
            Alfabet = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            //PARAULA ALEATORIA
            Random random = new Random();

            int IndexParaulaSeleccionada = random.Next(0, Paraula.Length);
            ParaulaSeleccionada = Paraula[IndexParaulaSeleccionada].ToUpper().ToCharArray();
            ParaulaAdivinada = ParaulaSeleccionada;

            foreach (char LletrasAlfabet in Alfabet)
            {
                Button btnLletra = new Button();
                btnLletra.Tag = "";
                btnLletra.Text = LletrasAlfabet.ToString();
                btnLletra.Click += compara;
                btnLletra.Width = 60;
                btnLletra.Height = 40;
                btnLletra.ForeColor = Color.White;
                btnLletra.Font = new Font(btnLletra.Font.Name, 15, FontStyle.Bold);
                btnLletra.BackgroundImageLayout = ImageLayout.Center;
                btnLletra.BackColor = Color.Black;
                btnLletra.Name = LletrasAlfabet.ToString();
                flFichasDeJoc.Controls.Add(btnLletra);
            }
            flParaula.Controls.Clear();

            for (int IndexValorLletra = 0; IndexValorLletra < ParaulaSeleccionada.Length; IndexValorLletra++)
            {
                Button Lletra = new Button();
                Lletra.Tag = ParaulaSeleccionada[IndexValorLletra].ToString();
                Lletra.Width = 46;
                Lletra.Height = 80;
                Lletra.ForeColor = Color.Blue;
                Lletra.Text = "_";
                Lletra.Font = new Font(Lletra.Font.Name, 32, FontStyle.Bold);
                Lletra.BackgroundImageLayout = ImageLayout.Center;
                Lletra.BackColor = Color.White;
                Lletra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Lletra.Name = "Adivinat" + IndexValorLletra.ToString();
                flParaula.Controls.Add(Lletra);
            }

        }

        void compara(object sender, EventArgs e)
        {
            bool trobat = false;
            ///QUAN EL BOTO ES PRESIONAT ES DESACTIVA
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for(int indexRevisar = 0; indexRevisar < ParaulaAdivinada.Length; indexRevisar++)
            {
                if(ParaulaAdivinada[indexRevisar] == char.Parse(btn.Text))
                {
                    //SI EXISTEIX LA LLETRA ACTUALITZA LA PARAULA AFEGINT EL VALOR CORRESPONENT
                    Button tbx = this.Controls.Find("Adivinat" + indexRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = ParaulaAdivinada[indexRevisar].ToString();
                    ParaulaAdivinada[indexRevisar] = '_';
                    trobat = true;
                }
            }

            //Verifica si totas las lletras de la paraula estan destapadas
            bool guanya = true;

            for(int indexComprovarGuanyador=0; indexComprovarGuanyador < ParaulaAdivinada.Length; indexComprovarGuanyador++)
            {
                ///Si el usuari te lletras pendents per destapar es cambia
                if (ParaulaAdivinada[indexComprovarGuanyador] != '_')
                {
                    guanya = false;
                }
            }

            if (guanya)
            {
                MessageBox.Show("Has guanyat","Molt bé",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnStart.Visible = true;
                btnStart.Text = "Torna a començar";
            }

            if (!trobat)
            {
                Oportunitats = Oportunitats + 1;
                pbPenjat.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunitats);

                ///Si las oportunitats ja s'han acabat mostrem la paraula

                if (Oportunitats == 8)
                {
                    lbMensaje.Visible = true;
                    MessageBox.Show("Has perdut!", "Torna a jugar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ///MOSTRAREM LA PARAULA QUE EL USUARI INTENTABA DESCUBRIR
                    for (int indexValorLletra =0; indexValorLletra < ParaulaSeleccionada.Length; indexValorLletra++)
                    {
                        Button btnlletra = this.Controls.Find("Adivinat" + indexValorLletra, true).FirstOrDefault() as Button;
                        btnlletra.Text = btnlletra.Tag.ToString();
                    }

                    //Desactivem las fichas i cambiem el boto de reiniciar
                    flFichasDeJoc.Enabled = false;
                    btnStart.Visible = true;
                    btnStart.Text = "Torna a començar";
                }
            }
        }

        private void FrmPenjat_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void FrmPenjat_Load(object sender, EventArgs e)
        {
            iniciarJoc();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            iniciarJoc();
        }
    }
}
