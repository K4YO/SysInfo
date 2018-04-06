using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace TP_ARQUITETURA
{
    public class Memoria
    {
        private PerformanceCounter memoryAvailable = new PerformanceCounter("Memory", "Available Bytes");
        private PerformanceCounter memoryInUse = new PerformanceCounter("Memory", "% Committed Bytes In Use"); //porcentagem

        //VARIAVEIS COM GETSET
        public string Nome { get; set; }
        public string CapacidadeTotal { get; set; } 
        public string Frequecia { get; set; }
        public string FrequeciaClock { get; set; }
        public string TipoMemoria { get; set; }
        public string MaxVoltage { get; set; }
        
        private double BitsTotal;

      
        //CONSTRUTOR
        public Memoria()
        { 
        this.IniciaMemoria(); 
        }

        private void IniciaMemoria()
        {
            double aux;
            ManagementObjectSearcher InfoMemory = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject memory in InfoMemory.Get()) 
            { 
                this.Nome = memory["Name"].ToString();
                this.BitsTotal = Convert.ToDouble(memory["Capacity"]);
                aux = Convert.ToDouble(memory["MaxVoltage"]) / 1000;
                if (aux == 0)  this.MaxVoltage = "Desconhecido";
                else this.MaxVoltage = string.Format("{0:0.0} Volts", Convert.ToDouble(memory["MaxVoltage"]) / 1000);
                this.TipoMemoria = VerificaTipoMemoria(Convert.ToInt32(memory["MemoryType"]), Convert.ToInt32(memory["MaxVoltage"]));
                this.Frequecia = string.Format("{0} MHz", memory["Speed"]);
                this.FrequeciaClock = string.Format("{0} MHz", memory["ConfiguredClockSpeed"]);
            } 
            this.CapacidadeTotal = Conversoes.ConverterUnMedida(BitsTotal.ToString());  
        }
      
        public float PercentUso() { return memoryInUse.NextValue(); }
        public string CapacidadeLivre() { return Conversoes.ConverterUnMedida(memoryAvailable.NextValue().ToString()); }
        public string CapacidadeUtilizada() { return Conversoes.ConverterUnMedida((this.BitsTotal - memoryAvailable.NextValue()).ToString()); }


       public string VerificaTipoMemoria(int MemoryType, int MaxVoltage)
        {
            switch (MemoryType)
            {
                case 20:

                    return "DDR";
                 

                case 21:

                    return "DDR2";

                case 22:

                    return "DDR2 FB-DIMM";

                case 24:
                    return "DDR3";
                    
                default:

                    if (MemoryType == 0 || MemoryType > 24 || MaxVoltage > 1200)
                    {
                      return "DDR4";                       
                    }

                    else
                    {
                        return "OUTRO";
                    }
                   
            } 
        } 
 
    }
}
