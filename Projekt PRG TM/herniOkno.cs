namespace Projekt_PRG_TM
{
    public partial class herniOkno : Form
    {
        bool hraje = false;
        Random rnd = new Random();
        int slovoCislo;

        string[] slovaPole = {
        "jablko", "strom", "auto", "pes", "kočka",
        "škola", "program", "hra", "kniha", "mobil",
        "řeka", "hora", "město", "počítač", "slunce"
        };

        public herniOkno()
        {
            InitializeComponent();
        }

        private void btnKonecHerniOkno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hraje = true;
            slovoCislo = rnd.Next(0, slovaPole.Length);

            string vybraneSlovo = slovaPole[slovoCislo];
            string podtrzitka = string.Join(" ", vybraneSlovo.Select(c => '_'));

            hadaneSlovo.Text = podtrzitka;
        }
    
    }
}