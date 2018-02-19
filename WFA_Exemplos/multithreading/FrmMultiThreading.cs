using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFA_Exemplos.multithreading
{
    public partial class FrmMultiThreading : Form
    {
        public FrmMultiThreading()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
                MessageBox.Show("Finished counting words.");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Words.CurrentState state = (Words.CurrentState)e.UserState;
            this.txtBxLinhasContadas.Text = state.LinesCounted.ToString();
            this.txtBxPalavrasContadas.Text = state.WordsMatched.ToString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;

            // Get the Words object and call the main method.
            Words WC = (Words)e.Argument;
            WC.CountWords(worker, e);
        }

        private void StartThread()
        {
            // This method runs on the main thread.
            this.txtBxPalavrasContadas.Text = "0";

            // Initialize the object that the background worker calls.
            Words WC = new Words();
            WC.CompareString = this.txtBxComparaString.Text;
            WC.SourceFile = this.txtBxArquivoFonte.Text;

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(WC);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            StartThread();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }
    }
}
