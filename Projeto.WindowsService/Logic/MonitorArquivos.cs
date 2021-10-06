using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.WindowsService.Logic
{
    public class MonitorArquivos
    {
        const string ARQUIVOS = "D:\\Temp\\Arquivos";
        const string ARQUIVOS_PROCESSADOS = "D:\\Temp\\ArquivosProcessados";
        public MonitorArquivos()
        {
        }

        public void ExecutarCopia()
        {
            CopyRecursive(ARQUIVOS, ARQUIVOS_PROCESSADOS);

        }


        public void CopyRecursive(string path, string newLocation)
        {
            var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                File.Copy(file, Path.Combine(newLocation, Path.GetFileName(file)), overwrite: true);
                System.IO.File.Delete(file);
            }
        }
    }
}
