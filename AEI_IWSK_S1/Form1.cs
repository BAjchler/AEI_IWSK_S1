using System.Windows.Forms;

namespace AEI_IWSK_S1
{
    public partial class Form1 : Form
    {
        ConnectionForm connectionForm = new ConnectionForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void twórcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                    Projekt AEI IWSK Katowice 2023r.
                    Komunikacja przez port znakowy.
                    ----------------------------------------------------------
                    Twórcy:
                    Bart³omiej Ajchler
                    £ukasz B³aszczyk
                    Sebastian Fija³kowski
                    Roman Gawenda
                    Micha³ Kapuœciñski

                    """, "Twórcy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ustawienia po³¹czenia, menu kontekstowe z parametrami do wyboru.
            if (connectionForm.IsDisposed)
            {
                connectionForm = new ConnectionForm();
                connectionForm.Show();
            }
            else if(!connectionForm.Visible)
            {
                connectionForm.Show();
            }
        }

        private void wyjœcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Za³aduj obiekt po³¹czenia

        }
    }
}