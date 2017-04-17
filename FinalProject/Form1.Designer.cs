namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(20, 173);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(90, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Calculate";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 225);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 18);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celsius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit:";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(85, 32);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(101, 20);
            this.textBoxC.TabIndex = 4;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(85, 75);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 20);
            this.textBoxF.TabIndex = 5;
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(85, 116);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(99, 20);
            this.resultbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Enabled = false;
            this.Cancelbutton.Location = new System.Drawing.Point(127, 174);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(88, 22);
            this.Cancelbutton.TabIndex = 8;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.onCancel);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnDoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoWork2);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DoWorkComp2);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(233, 174);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(84, 22);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 260);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Degree Converter App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancelbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Clearbutton;
    }
}

