namespace GUIHelpers
{
    partial class TextfileViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextfileViewer));
            this.tbTextFile = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogFile
            // 
            this.tbTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextFile.Location = new System.Drawing.Point(12, 12);
            this.tbTextFile.Multiline = true;
            this.tbTextFile.Name = "tbTextFile";
            this.tbTextFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextFile.Size = new System.Drawing.Size(430, 397);
            this.tbTextFile.TabIndex = 0;
            this.tbTextFile.WordWrap = false;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOK.Location = new System.Drawing.Point(183, 427);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "O&K";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // LogfileViewer
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btOK;
            this.ClientSize = new System.Drawing.Size(454, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbTextFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "TextfileViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FileText = "Textfile Viewer";
            this.Load += new System.EventHandler(this.TextfileViewer_Load);
            this.SizeChanged += new System.EventHandler(this.TextfileViewer_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextFile;
        private System.Windows.Forms.Button btOK;
    }
}