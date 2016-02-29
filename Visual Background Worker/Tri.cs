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
    public partial class frmTri : Form
    {
        public double[] tableau { get; private set; }
        public frmTri(double[] pTableau)
        {
            InitializeComponent();
            tableau = pTableau;
        }

        private void frmTri_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = tableau.Length - 1;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Trier(e);
        }

        private void Trier(DoWorkEventArgs e)
        {
            int i, iRech, iMin;
            double tmp;
            int N = tableau.Length;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;
                if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }

                backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else { this.Close(); }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                btnAnnuler.Enabled = false;
                MessageBox.Show("Tri annulé");
            }
            else
            {
                MessageBox.Show("Tri effectué");
                btnOk.Enabled = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
