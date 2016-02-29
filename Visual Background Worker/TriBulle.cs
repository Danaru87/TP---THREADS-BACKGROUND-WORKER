using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Background_Worker
{
    public partial class TriBulle : Form
    {
        double[] tableau;
        public TriBulle()
        {
            InitializeComponent();
        }

        private void bntInitialiser_Click(object sender, EventArgs e)
        {
            int taille;
            if(int.TryParse(txtTaille.Text, out taille))
            {
                tableau = new double[taille];
                Initialiser(tableau);
                Afficher(tableau, lstValeursNonTriees);
            }
            else
            { 
                //TODO: MessageBox with Error
            }
        }

        private void Afficher(double[] tableau, ListView lstValeursNonTriees)
        {
            lstValeursNonTriees.Clear();
            lstValeursTriees.Clear();
            foreach(double value in tableau)
            {
                lstValeursNonTriees.Items.Add(new ListViewItem(Convert.ToString(value)));
            }
        }

        private void Initialiser(double[] pTableau)
        {
            Random r = new Random();
            for (int i = 0; i < pTableau.Length-1; i++)
            {
                tableau[i] = r.NextDouble() * tableau.Length;
            }
        }

        private void btnTrier_Click(object sender, EventArgs e)
        {
            frmTri f = new frmTri(tableau);
            if(f.ShowDialog() == DialogResult.OK)
            {
                Afficher(f.tableau, lstValeursTriees);
            }     
        }
    }
}
