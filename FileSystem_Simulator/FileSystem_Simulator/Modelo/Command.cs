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
                case "print":
                    executePrint(parts);

                    break;

                case "mkdir":
                    //crear directorio
                    break;

                case "pwd":
                    //mostrar directorio actual
                    break;

                case "ls":
                    //mostrar contenido del directorio
                    break;

                case "cd":
                    //dirigirse a un directorio o a raíz
                    break;

                case "cat":
                    //crear o visualizar el contenido de un txt (necesita extensión .txt)
                    break;

                case "mv":
                    //renombrar archivo o directorio
                    break;

                case "rm":
                    //eliminar archivo o directorio
                    break;

                case "chmod":
                    // permisos
                    break;

                case "format":
                    //formatear todo
                    break;

                case "cls":
                    //borrar pantalla
                    break;

                case "history":
                    //registrar un historial
                    break;

                default:
                    executeDefaultCase();
                    break;
            }

        }

        private string executeDefaultCase() 
        {
            return "command not found";
        }

        private string executePrint(string[] parts) 
        {
            return string.Join(" ", parts);
        }

    }
}
