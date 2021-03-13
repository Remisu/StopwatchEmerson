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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerConometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //// 
            //// lblTimer
            //// 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(12, 22);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(585, 128);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00.000";
            //// 
            //// btnStart
            //// 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(63, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            //// 
            //// btnStop
            //// 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(224, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 70);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            //// 
            //// btnReset
            //// 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(385, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 70);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            //// 
            //// timerConometro
            //// 
            this.timerConometro.Enabled = true;
            this.timerConometro.Tick += new System.EventHandler(this.TimerConometro_Tick);
            //// 
            ////FrmCronometro
            //// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 277);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Name = "FrmCronometro";
            this.Text = "Conometro do Emerson";
            this.Load += new System.EventHandler(this.FrmCronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}