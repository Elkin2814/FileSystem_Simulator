using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem_Simulator
{
    public partial class Terminal : Form
    {
        private string prompt = "usuario@ubuntu:-$ ";
        public Terminal()
        {
            InitializeComponent();
            rtbTerminal.AppendText(prompt);

        }

        private void rtbTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtbTerminal.GetLineFromCharIndex(rtbTerminal.SelectionStart) < rtbTerminal.Text.LastIndexOf(Environment.NewLine))
            {
                e.Handled = true;
            }
        }

        private void rtbTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (rtbTerminal.SelectionStart < rtbTerminal.Text.LastIndexOf(Environment.NewLine))
                {
                    rtbTerminal.SelectionStart = rtbTerminal.Text.Length;
                    rtbTerminal.SelectionLength = 0;
                }
                else
                {
                    rtbTerminal.AppendText(Environment.NewLine + prompt);
                }
            }
        }

        private void rtbTerminal_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void rtbTerminal_SelectionChanged(object sender, EventArgs e)
        {
            rtbTerminal.SelectionStart = rtbTerminal.Text.Length;
            rtbTerminal.SelectionLength = 0;
        }
    }
}
