using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace infoGym.Classes.BD
{
    class BancoBackup
    {
        List<String> diretoriosSistema;
        String appPath;
        public BancoBackup()
        {
            appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            diretoriosSistema = new List<String>();
            diretoriosSistema.Add(@"\fotosAlunos");
            diretoriosSistema.Add(@"\anamnese");
            diretoriosSistema.Add(@"\fotosFuncionarios");
            diretoriosSistema.Add(@"\termos");
        }

        public bool restauraBackup(String origem, bool dadosFotos)
        {
            String cmd = "-c -U postgres -d infoGym " + "\""+ origem + "\"";
            if (dadosFotos)
            {
                /*
                 * 1) pega pasta que arquivo .backup está localizado
                 * 2) copia para a pasta onde se encontra o .exe do infoGym
                 *  todos os diretórios da lista de diretórios
                 *      
                 */

                /*-----------1) Begin-------------------------------------------------------------------*/
                String[] aux = origem.Split('\\');
                origem = "";
                for (int i = 0; i < aux.Length - 1; i++)
                {
                    origem += aux[i];
                    if (i < aux.Length - 1)
                        origem += "\\";
                }
                /*-----------1) Fim----------------------------------------------------------------------*/

                /*------------2) Begin-------------------------------------------------------------------*/
                foreach (String dir in diretoriosSistema)
                {
                    ExecuteCommand(@"C:\WINDOWS\system32\xcopy.exe", origem + dir + " " + appPath + dir + " /E /I /Y");
                }
                /*------------2) End-------------------------------------------------------------------*/
                
            }
            return ExecuteCommand("C:\\Program Files\\PostgreSQL\\9.2\\bin\\pg_restore.exe", cmd);
        }

        public bool realizarBackup(String destino, bool dadosFotos)
        {
            bool result = false;
            String cmd = "";
            if (dadosFotos)
            {
                /*
                 * Se for salvar dados + fotos precisa:
                 * - 1) a partir do destino criar pasta com a data de hj
                 * - 2) jogar backup dados nela
                 * - 3) copiar pastas do sistema para ela
                 *      percorre list copiando para o diretorio de bckp
                 */

                /*----------------------------1) Begin---------------------------*/
                String[] aux = destino.Split('\\');
                destino = "";
                for (int i = 0; i < aux.Length - 1; i++)
                    destino += aux[i] + "\\";
                String nomeDir = "infoGym_backup_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" +
                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second;
                destino += nomeDir;
                Directory.CreateDirectory(destino);
                /*----------------------------1) End------------------------------*/

                /*----------------------------3) Begin------------------------------*/
                foreach (String dir in diretoriosSistema)
                {
                    result = ExecuteCommand(@"C:\WINDOWS\system32\xcopy.exe", appPath + dir + " " + destino + dir + " /E /I /Y");
                }
                /*-----------------------------3) End--------------------------------------*/

            /*--------------------------2) Begin----------------------------------------*/
                destino += "\\" + aux[aux.Length - 1];
            }
            cmd = "-U postgres -F c -f " + '\u0022' + destino + '\u0022' + " infoGym";
            result = ExecuteCommand("C:\\Program Files\\PostgreSQL\\9.2\\bin\\pg_dump.exe", cmd);
            /*--------------------------2) End----------------------------------------*/
            return result;
        }

        /*
        *      Comandos pg_dump:
              -p, –port=PORT database server port number
              -i, –ignore-version proceed even when server version mismatches
              -h, –host=HOSTNAME database server host or socket directory
              -U, –username=NAME connect as specified database user
              -W, –password force password prompt (should happen automatically)
              -d, –dbname=NAME connect to database name
              -v, –verbose verbose mode
              -F, –format=c|t|p output file format (custom, tar, plain text)
              -c, –clean clean (drop) schema prior to create
              -b, –blobs include large objects in dump
              -v, –verbose verbose mode
              -f, –file=FILENAME output file name 
        */

        /*
         *      Comandos xcopy:
         *      /E = copy all subdirectories
         *      /I = that if the destination doesn't exist, create a directory with the name
         *      /Y = evita pergunta se deseja substituir arquivos com mesmo nome
         *      
         */
        private bool ExecuteCommand(String program, String parameters)
        {
            try
            {
                var proc = new Process();
                //   proc.StartInfo.CreateNoWindow = true;
                //  proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = program;
                proc.StartInfo.Arguments = parameters;
                proc.Start();
                //proc.WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
    }
}
