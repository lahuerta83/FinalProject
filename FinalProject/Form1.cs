using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct CaldataC
        {
            public int C;
            

            public CaldataC(int c)
            {
                this.C = c;
                
            }
        }

        public struct CaldataF
        {
            public int F;

            public CaldataF(int f)
            {
                this.F = f;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            this.startbutton.Enabled = false;
            this.resultbox.Text = String.Empty;
            this.Cancelbutton.Enabled = true;
            this.progressBar1.Value = 0;
            if (textBoxF.Text == String.Empty)
            {
                backgroundWorker1.RunWorkerAsync(new CaldataC(int.Parse(this.textBoxC.Text)));
            }
            else
                backgroundWorker2.RunWorkerAsync(new CaldataF(int.Parse(this.textBoxF.Text)));
        }

        private void onCancel(object sender, EventArgs e)
        {
            if (textBoxF.Text == String.Empty)
                backgroundWorker1.CancelAsync();
            else
                backgroundWorker2.CancelAsync();
        }

        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            CaldataC input = (CaldataC)e.Argument;
            

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                backgroundWorker1.ReportProgress(i * 10);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
            
            
                e.Result = (input.C * 9) / 5 + 32;
           
                
            
            
            

        }

        private void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                this.resultbox.Text = "Cancelled";
            }
            else
            {
                this.resultbox.Text = e.Result.ToString() + " F";
            }

            this.startbutton.Enabled = true;
            this.Cancelbutton.Enabled = false;
            this.progressBar1.Value = 100;

        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void DoWork2(object sender, DoWorkEventArgs e)
        {
            CaldataF inp = (CaldataF)e.Argument;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                backgroundWorker2.ReportProgress(i * 10);
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            e.Result = (inp.F - 32) * 5 / 9;
        }

        private void DoWorkComp2(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.resultbox.Text = "Cancelled";
            }
            else
            {
                this.resultbox.Text = e.Result.ToString() + " C";
            }

            this.startbutton.Enabled = true;
            this.Cancelbutton.Enabled = false;
            this.progressBar1.Value = 100;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            this.textBoxF.Clear();
            this.textBoxC.Clear();
            this.resultbox.Clear();
        }
    }
}
