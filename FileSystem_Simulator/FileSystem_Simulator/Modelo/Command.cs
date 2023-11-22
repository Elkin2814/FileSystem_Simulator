using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem_Simulator.Modelo
{
    internal class Command
    {
        private List<string> historyList = new List<string>();

        public string executeCommand(string command)
        {
            string[] commandParts = command.Split(' ');
            string mainCommand = commandParts[0].ToLower();

            historyList.Add(command);

            switch (mainCommand)
            {
                case "echo":
                    return executeEcho(commandParts);

                case "mkdir":
                    //crear directorio
                    return "";

                case "pwd":
                    //mostrar directorio actual
                    return "";
                    ;
                case "ls":
                    //mostrar contenido del directorio
                    return "";

                case "cd":
                    //dirigirse a un directorio o a raíz
                    return "";

                case "cat":
                    //crear o visualizar el contenido de un txt (necesita extensión .txt)
                    return "";

                case "mv":
                    //renombrar archivo o directorio
                    return "";

                case "rm":
                    //eliminar archivo o directorio
                    return "";

                case "chmod":
                    // permisos
                    return "";

                case "format":
                    //formatear todo
                    return "";

                case "cls":
                    //borrar pantalla

                    return "";

                case "history":
                    return executeHistory();

                default:
                    return "command not found";
            }

        }

        private string executeEcho(string[] parts) 
        {
            string[] arrAux = new string[parts.Length - 1];
            
            Array.Copy(parts, 1, arrAux, 0, arrAux.Length);

            Debug.WriteLine(string.Join(" ", arrAux));

            return string.Join(" ", arrAux);
        }

        private void executeCls() 
        {

        }

        private string executeHistory()
        {
            Debug.WriteLine(string.Join("\n", historyList));

            return string.Join("\n", historyList);
        }

    }
}
