//-----------------------------------------------------------------------
// <copyright file="FrmConometro.cs" company="Particular">
// <author>Emerson Barros</author>
// </copyright>
//-----------------------------------------------------------------------

namespace ConometroEmerson
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    /// <summary>
    /// Documentation for the first part of the class.
    /// </summary>
    internal partial class FrmCronometro : Form
    {
        /// <summary>
        /// Class that defines the stopwatch functions.
        /// </summary>
        private Stopwatch stopwatch;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCronometro"/> class.
        /// </summary>
        public FrmCronometro()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load the main form
        /// </summary>
        /// <param name="sender">as a first argument.</param>
        /// <param name="e"> as a second argument.</param>
        private void FrmCronometro_Load(object sender, EventArgs e)
        {
            this.stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Button to start the count.
        /// </summary>
        /// <param name="sender">as a first argument.</param>
        /// <param name="e"> as a second argument.</param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.stopwatch.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;
        }

        /// <summary>
        /// Button to stop the count.
        /// </summary>
        /// <param name="sender">as a first argument.</param>
        /// <param name="e"> as a second argument.</param>
        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.stopwatch.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        /// <summary>
        /// Button to rest the count.
        /// </summary>
        /// <param name="sender">as a first argument.</param>
        /// <param name="e"> as a second argument.</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.stopwatch.Reset();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnReset.Enabled = false;
        }

        /// <summary>
        /// Tick timer.
        /// </summary>
        /// <param name="sender">as a first argument.</param>
        /// <param name="e"> as a second argument.</param>
        private void TimerConometro_Tick(object sender, EventArgs e)
        {
            ////this.LblTimer.Text = stopwatch.Elapsed.ToString(); 
            ////Cannot use because the count of ms will be large.
            this.lblTimer.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", this.stopwatch.Elapsed);
        }
    }
}
