using Projeto.ModelData.Logic.Northwind.Model;
using Projeto.WindowsService.Architecture;
using Projeto.WindowsService.Logic;
using Projeto.WindowsService.Logic.NorthWind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Projeto.WindowsService
{
    public partial class ServiceNorthWind : ServiceBase
    {
        private Thread mThread;
        private static int _EsperaInicial;
        private static string _Periodo = string.Empty;
        private static int _Intervalo;
        //private MonitorArquivos monitor;
        private ServiceNorth serviceNorthWind;
        public ServiceNorthWind()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.iniciar_Ambiente();
            this.WriteToFile("Projeto Service started {0}");
            this.preparar_Thread();
        }

        protected override void OnStop()
        {
            this.WriteToFile("Projeto Service stopped {0}");
            this.mThread.Abort();
        }

        protected void iniciar_Ambiente()
        {
            _EsperaInicial = (Convert.ToInt32(ConfigurationManager.AppSettings["ESPERAINICIAL_SEGUNDOS"]) * 1000);
            _Periodo = ConfigurationManager.AppSettings["PERIODO"].ToString();
            _Intervalo = (Convert.ToInt32(ConfigurationManager.AppSettings["INTERVALOMINUTO"]) * 60000);
            this.WriteToFile("Projeto Service Ambiente Started {0}");
        }
        private void preparar_Thread()
        {
            Thread.Sleep(_EsperaInicial);
            ThreadStart job = new ThreadStart(executar_Tarefa);
            this.mThread = new Thread(job);
            this.mThread.Start();
        }


        private void executar_Tarefa()
        {
            while (true)
            {
                Boolean AplicarIntervalo = false;
                try
                {
                    if (Servico.PossoExecutarServico(_Periodo))
                    {
                        NorthwindEntities contexto = new NorthwindEntities();
                        serviceNorthWind = new ServiceNorth(contexto);
                        serviceNorthWind.ProcessarServico();
                        //monitor = new MonitorArquivos();
                        //monitor.ExecutarCopia();
                    }
                }
                catch (Exception ex)
                {
                    this.WriteToFile("Projeto Service Error on: {0} " + ex.Message + ex.StackTrace);
                    AplicarIntervalo = true;
                }
                finally
                {
                    if (AplicarIntervalo)
                    {
                        Thread.Sleep(_Intervalo);
                    }
                }
            }
        }

        private void WriteToFile(string text)
        {
            string path = "D:\\Temp\\ProjetoServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }
    }
}
