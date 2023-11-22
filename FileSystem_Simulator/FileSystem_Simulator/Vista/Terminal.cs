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
        private string directory = "/";
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
            int promptLength = prompt.Length;

            if (e.KeyCode == Keys.Enter)
            {
                rtbTerminal.AppendText(Environment.NewLine + prompt);
                string command = rtbTerminal.Lines.Last().Substring(promptLength).Trim();
                e.SuppressKeyPress = true;

                commandManipulate(command);

            }
            if (e.KeyCode == Keys.Back)
            {
                int currentPosition = rtbTerminal.SelectionStart;

                int currentLineIndex = rtbTerminal.GetLineFromCharIndex(currentPosition);
                int currentLineStart = rtbTerminal.GetFirstCharIndexFromLine(currentLineIndex);

                if (currentPosition > currentLineStart && currentPosition <= (currentLineStart + prompt.Length))
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }
            if (rtbTerminal.SelectionStart < rtbTerminal.Text.Length)
            {
                rtbTerminal.SelectionStart = rtbTerminal.Text.Length;
                rtbTerminal.SelectionLength = 0;
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

        private void commandManipulate(string command)
        {
            if (command.StartsWith("cd "))
            {
                string newDirectory = command.Substring(3);

                rtbTerminal.AppendText(Environment.NewLine + "Nuevo directorio: " + newDirectory + Environment.NewLine + prompt);
            }
        }
    }
}
