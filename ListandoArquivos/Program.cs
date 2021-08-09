using System;
using System.IO;

namespace ListandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marca o diretório a ser listado
            DirectoryInfo diretorio = new DirectoryInfo(@"C:\Projects\MOD01-EnvioDeE-mail\fila\");
            //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                Console.WriteLine(fileinfo.Name); 
                //Response.Write(fileinfo.Name);
            }
            
        }
    }
}
