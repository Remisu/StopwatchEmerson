//-----------------------------------------------------------------------
// <copyright file="FrmConometro.Designer.cs" company="Particular">
// <author>Emerson Barros</author>
// </copyright>
//-----------------------------------------------------------------------
namespace ConometroEmerson
{
    /// <summary>
    ///  Internal Partial Class of Stopwatch
    /// </summary>
    internal partial class FrmCronometro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Timer that will interact following the Button commands.
        /// </summary>
        private System.Windows.Forms.Label lblTimer;

        /// <summary>
        /// Button to start the count.
        /// </summary>
        private System.Windows.Forms.Button btnStart;

        /// <summary>
        /// Button to stop the count.
        /// </summary>
        private System.Windows.Forms.Button btnStop;

        /// <summary>
        /// Button to rest the count.
        /// </summary>
        private System.Windows.Forms.Button btnReset;

        /// <summary>
        /// Tick timer.
        /// </summary>
        private System.Windows.Forms.Timer timerConometro;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCronometro));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerConometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            resources.ApplyResources(this.lblTimer, "lblTimer");
            this.lblTimer.Name = "lblTimer";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // timerConometro
            // 
            this.timerConometro.Enabled = true;
            this.timerConometro.Tick += new System.EventHandler(this.TimerConometro_Tick);
            // 
            // FrmCronometro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCronometro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmCronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}