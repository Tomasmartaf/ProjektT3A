namespace Projekt_PRG_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nadpis_Click(object sender, EventArgs e)
        {

        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHrat_Click(object sender, EventArgs e)
        {
            herniOkno herniForm = new herniOkno();

            this.Hide();

            herniForm.ShowDialog();

            this.Show();
        }

        private void btnPravidla_Click(object sender, EventArgs e)
        {
            this.Hide();

            napoveda napovedaOkno = new napoveda();

            napovedaOkno.ShowDialog();

            this.Show();

        }

        private void btnHrat_Enter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Enabled)
            {
                btn.Cursor = Cursors.Hand;
            }
        }
    }
}
