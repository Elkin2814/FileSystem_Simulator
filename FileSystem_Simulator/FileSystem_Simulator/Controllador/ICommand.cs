using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem_Simulator.Controllador
{
    internal interface ICommand
    {
        void execute(FileSystem fileSystem, string[] args);
    }
}
