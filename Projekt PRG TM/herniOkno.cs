using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PRG_TM
{
    public partial class herniOkno : Form
    {
        public herniOkno()
        {
            InitializeComponent();
        }

        private void btnKonecHerniOkno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
