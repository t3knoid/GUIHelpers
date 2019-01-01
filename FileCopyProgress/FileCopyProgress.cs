using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHelpers
{
    /// <summary>
    /// Shows a progress bar while copying a file. It uses the FileCopy
    /// class to perform the actual copy. This dialog closes automatically
    /// after the file copy has completed
    /// </summary>
    public partial class FileCopyProgress : Form
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string TitleText { get; set; }
        System.Threading.Thread filecopyThread;
        
        public FileCopyProgress()
        {
            InitializeComponent();
        }
        private void FileCopyProgress_Load(object sender, EventArgs e)
        {
            this.Text = String.IsNullOrEmpty(TitleText) ? "Copying" : TitleText;
            FileCopy filecopy = new FileCopy(Source, Destination); // Instantiate the FileCopy class
            filecopyThread = new System.Threading.Thread(filecopy.Copy); // Runs the copy process in a separate thread
            filecopy.OnProgressChanged += UpdateProgress; // Subscribe to the OnProgressChanged event of the copy process
            filecopy.OnComplete += FileCopyComplete; // Subscribe to the OnComplete event of the copy process
            try
            {
                filecopyThread.Start();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        /// <summary>
        /// This is a handler to the OnComplete event of FileCopy. It
        /// runs a separated thread, CloseWindow, to close this window.
        /// </summary>
        private void FileCopyComplete()
        {
            System.Threading.Thread closeWindowThread = new System.Threading.Thread(CloseWindow);
            closeWindowThread.Start();
        }
        /// <summary>
        /// This will be executed as a separate thread that will close this window.
        /// It checks to make sure that the filecopyThread is not active before closing.
        /// </summary>
        private void CloseWindow()
        {
            while (filecopyThread.IsAlive) { };
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                this.Close();
            }            
        }
        /// <summary>
        /// Updates the progress bar
        /// </summary>
        /// <param name="Percentage"></param>
        /// <param name="Cancel"></param>
        private void UpdateProgress(double Percentage, ref bool Cancel)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    progressBar1.Value = (int)Percentage;
                }));
            }
            else
            {
                progressBar1.Value = (int)Percentage;
            }            
        }
    }
}
