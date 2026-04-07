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

        string[] slovaPole =    // Pole se slovy pro hru
        {
            "jablko", "strom", "auto", "pes", "kočka",
            "škola", "program", "hra", "kniha", "mobil",
            "řeka", "hora", "město", "počítač", "slunce"
        };

        public herniOkno()
        {
            InitializeComponent();

            foreach (Control ctrl in flowLayoutPanel1.Controls) // za kazdy button v flowLayoutPanel1 prida event handler pro kliknuti
            {
                if (ctrl is Button)                 //kontrola, jestli je objekt button
                    ctrl.Click += Pismeno_Click;    //zavola event handler pro kliknuti
            }
        }

        private void btnStart_Click(object sender, EventArgs e) // Kliknutí na tlačítko start v herním okně
        {
            hraje = true;
            pocetPokusu = 0;

            vybraneSlovo = slovaPole[rnd.Next(slovaPole.Length)].ToLower(); // Výběr náhodného slova z pole se slovy a převede na malá písmena

            hadaneZnaky = new char[vybraneSlovo.Length];    // Pole pro počet znaků ve vybraném slově
            for (int i = 0; i < hadaneZnaky.Length; i++)    // Naplní pole podtžítky pro každý znak ve slově
                hadaneZnaky[i] = '_';

            hadaneSlovo.Text = string.Join(" ", hadaneZnaky); // Nastaví text po startu hry

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                    ctrl.Enabled = true;
            }

            obesenecKresleni.Invalidate();
        }

        private void Pismeno_Click(object sender, EventArgs e)
        {
            if (!hraje) return; // Kontrola jestli hra běží

            bool nalezenoPismeno = false;

            Button btn = sender as Button;  // určení objektu co vyvolava udalost na tlačítko
            char hadanePismeno = btn.Text.ToLower()[0]; // získá písmeno z textu tlačítka a převede na malá písmena
            btn.Enabled = false; // Vypne tlačítko aby nebylo možne kliknout znovu na stejné písmeno

            for (int i = 0; i < vybraneSlovo.Length; i++)
            {
                if (vybraneSlovo[i] == hadanePismeno)
                {
                    hadaneZnaky[i] = hadanePismeno;
                    nalezenoPismeno = true;
                }
            }

            if (!nalezenoPismeno)
            {
                pocetPokusu++;
                obesenecKresleni.Invalidate();
            }

            hadaneSlovo.Text = string.Join(" ", hadaneZnaky);

            if (hadaneSlovo.Text.Contains("_"))
            {
                //Pokračuje ve hře
            }
            else
            {
                MessageBox.Show("Gratulujeme! Vyhráli jste!");
                hraje = false;
            }

            if (pocetPokusu >= 10)
            {
                MessageBox.Show($"Prohráli jste! Správné slovo bylo: {vybraneSlovo}");
                hraje = false;
            }
        }

        private void obesenecKresleni_Paint(object sender, PaintEventArgs e)
        {
            // Kreslení oběšence podle počtu pokusů
            Graphics g = e.Graphics;
            Pen pero = new Pen(System.Drawing.Color.White, 3);

            if (pocetPokusu >= 1) g.DrawLine(pero, 50, 250, 200, 250);
            if (pocetPokusu >= 2) g.DrawLine(pero, 125, 250, 125, 50);
            if (pocetPokusu >= 3) g.DrawLine(pero, 125, 50, 200, 50);
            if (pocetPokusu >= 4) g.DrawLine(pero, 200, 50, 200, 80);
            if (pocetPokusu >= 5) g.DrawEllipse(pero, 180, 80, 40, 40);
            if (pocetPokusu >= 6) g.DrawLine(pero, 200, 120, 200, 180);
            if (pocetPokusu >= 7) g.DrawLine(pero, 200, 140, 170, 160);
            if (pocetPokusu >= 8) g.DrawLine(pero, 200, 140, 230, 160);
            if (pocetPokusu >= 9) g.DrawLine(pero, 200, 180, 170, 210);
            if (pocetPokusu >= 10) g.DrawLine(pero, 200, 180, 230, 210);
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