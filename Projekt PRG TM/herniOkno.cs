using System;
using System.Windows.Forms;

namespace Projekt_PRG_TM
{
    public partial class herniOkno : Form
    {
        bool hraje = false;
        Random rnd = new Random();

        string vybraneSlovo;
        char[] hadaneZnaky;
        int pocetPokusu = 0;

        string[] slovaPole =
        {
            "jablko", "strom", "auto", "pes", "kočka",
            "škola", "program", "hra", "kniha", "mobil",
            "řeka", "hora", "město", "počítač", "slunce"
        };

        public herniOkno()
        {
            InitializeComponent();

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Click += Pismeno_Click;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hraje = true;
            

            int randomSlovo = rnd.Next(slovaPole.Length);
            vybraneSlovo = slovaPole[randomSlovo];

            hadaneZnaky = new char[vybraneSlovo.Length];
            for (int i = 0; i < hadaneZnaky.Length; i++)
            {
                hadaneZnaky[i] = '_';
            }

            hadaneSlovo.Text = string.Join(" ", hadaneZnaky);

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                    ctrl.Enabled = true;
            }
        }

        private void Pismeno_Click(object sender, EventArgs e)
        {
            if (!hraje) return;

            pocetPokusu++;

            Button btn = sender as Button;

            char hadanePismeno = btn.Text.ToLower()[0];
            btn.Enabled = false;

            for (int i = 0; i < vybraneSlovo.Length; i++)
            {
                if (vybraneSlovo[i] == hadanePismeno)
                {
                    hadaneZnaky[i] = hadanePismeno;
                }
            }

            hadaneSlovo.Text = string.Join(" ", hadaneZnaky);

            if (hadaneSlovo.Text.Contains("_"))
            {
                // Hráč ještě nevyhrál
            }
            else
            {
                MessageBox.Show("Gratulujeme! Vyhráli jste!");
                hraje = false;
            }

            if (pocetPokusu >= 9)
            {
                MessageBox.Show($"Prohráli jste! Správné slovo bylo: {vybraneSlovo}");
                hraje = false;
            }
        }

        private void btnKonecHerniOkno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}