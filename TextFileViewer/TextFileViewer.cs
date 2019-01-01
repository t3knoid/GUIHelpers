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
    public partial class TextfileViewer : Form
    {
        public string FileText;

        public TextfileViewer()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextfileViewer_Load(object sender, EventArgs e)
        {
            tbTextFile.Text = FileText;
            btOK.Left = (this.ClientSize.Width - btOK.Width) / 2; // Horizontally Center OK button
        }

        private void TextfileViewer_SizeChanged(object sender, EventArgs e)
        {
            btOK.Left = (this.ClientSize.Width - btOK.Width) / 2; // Horizontally Center OK button
        }
    }
}
