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
    public partial class napoveda : Form
    {
        public napoveda()
        {
            InitializeComponent();
            lblPravidla.Text = "PRAVIDLA HRY ŠIBENICE\n\n" +
           "Cílem hry je uhodnout skryté slovo po jednotlivých písmenech.\n\n" +
           "Na začátku hry je náhodně vybráno slovo, které je zobrazeno pomocí podtržítek, " +
           "přičemž každé podtržítko představuje jedno písmeno.\n\n" +
           "Hráč postupně vybírá jednotlivá písmena. Pokud se zvolené písmeno nachází ve slově, " +
           "odkryjí se všechny jeho výskyty na odpovídajících pozicích.\n\n" +
           "V případě, že se zvolené písmeno ve slově nenachází, dojde ke zvýšení počtu chybných pokusů " +
           "a postupnému vykreslování postavy oběšence.\n\n" +
           "Maximální počet chybných pokusů je omezen. Po jeho dosažení hráč prohrává a zobrazí se správné slovo.\n\n" +
           "Hráč vyhrává v okamžiku, kdy se mu podaří správně uhodnout celé slovo dříve, než dojde k úplnému vykreslení oběšence.\n\n" +
           "Po ukončení hry je možné zahájit novou hru stisknutím tlačítka Start.";
        }

        private void napoveda_Load(object sender, EventArgs e)
        {

        }
    }
}
