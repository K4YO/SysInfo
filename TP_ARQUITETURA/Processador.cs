using System;
using System.Collections.Generic; 
using System.Diagnostics;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Management;


namespace TP_ARQUITETURA
{
    public class Processador
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private ManagementObjectSearcher InfoProcess = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
        private ManagementObjectSearcher InfoCache = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CacheMemory");

        // VARIAVEIS COM GETSET
        public string Nome { get; set; }
        public string Nucleos { get; set; }
        public string ProcessadoresLogicos { get; set; }
        public string FrequeciaMaxima { get; set; }
        public string Arquitetura { get; set; }
        public string L1Cache { get; set; }
        public string L2Cache { get; set; }
        public string L3Cache { get; set; }

    
        //CONSTRUTOR
        public Processador()
        {
            this.InfoProcessador();

        }

        private void InfoProcessador()
        {
            
            foreach (ManagementObject processador in InfoProcess.Get())
            {
                this.Nome = processador["Name"].ToString();
                this.Nucleos = processador["NumberOfCores"].ToString();
                this.ProcessadoresLogicos = processador["NumberOfLogicalProcessors"].ToString();

                this.L2Cache = string.Format("{0} KB",processador["L2CacheSize"]);
                this.L3Cache = string.Format("{0:0.0} MB", Convert.ToDouble(processador["L3CacheSize"])/1024);
                this.FrequeciaMaxima = string.Format("{0:0.0} GHz", Convert.ToDouble(processador["CurrentClockSpeed"])/1000);

                switch (Convert.ToInt32(processador["Architecture"]))
                {
                    case 0:
                        this.Arquitetura = "x86";
                        break;
                    case 9:
                        this.Arquitetura = "x64";
                        break;
						
					default:
                        this.Arquitetura = "Desconhecido";
						break;
                }

            }

            foreach(ManagementObject cache in InfoCache.Get())
            {
                if (Convert.ToString(cache["Purpose"]).Contains("L1"))
                {
                    this.L1Cache = string.Format("{0} x {1} KB", this.Nucleos ,cache["InstalledSize"]);
                } 
                
            }

        }

        public float PercentUso() { return cpuCounter.NextValue(); }
    }
}
