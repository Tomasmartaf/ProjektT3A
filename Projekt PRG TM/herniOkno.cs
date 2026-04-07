using System;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_PRG_TM
{
    public partial class herniOkno : Form
    {
        bool hraje = false;
        Random rnd = new Random();

        string vybraneSlovo;
        char[] hadaneZnaky;
        int randomSlovo;

        string[] slovaPole =
        {
            "jablko", "strom", "auto", "pes", "kočka",
            "škola", "program", "hra", "kniha", "mobil",
            "řeka", "hora", "město", "počítač", "slunce"
        };

        public herniOkno()
        {
            InitializeComponent();
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