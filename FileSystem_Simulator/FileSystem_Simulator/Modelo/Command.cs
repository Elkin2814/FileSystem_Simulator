using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem_Simulator.Modelo
{
    internal class Command
    {
        public void executeCommand(string command)
        {
            string[] parts = command.Split(' ');

            string mainPart = parts[0].ToLower();

            switch (mainPart)
            {
                case "hola":
                    executeHola(parts);
                    break;
                case "adios":

                    break;
                default:

                    break;
            }

        }

        private void executeHola(string[] parts) 
        {
            MessageBox.Show(string.Join(" ", parts), "Imprimiendo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //return string.Join(" ", parts);
        }

    }
}
