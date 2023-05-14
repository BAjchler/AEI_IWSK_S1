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

        private void tw�rcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                    Projekt AEI IWSK Katowice 2023r.
                    Komunikacja przez port znakowy.
                    ----------------------------------------------------------
                    Tw�rcy:
                    Bart�omiej Ajchler
                    �ukasz B�aszczyk
                    Sebastian Fija�kowski
                    Roman Gawenda
                    Micha� Kapu�ci�ski

                    """, "Tw�rcy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ustawienia po��czenia, menu kontekstowe z parametrami do wyboru.
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

        private void wyj�cieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Za�aduj obiekt po��czenia

        }
    }
}