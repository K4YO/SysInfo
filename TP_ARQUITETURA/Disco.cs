using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

//using System.Management.ManagementObject;
//using System.Diagnostics.PerformanceCounter;

namespace TP_ARQUITETURA
{
    public class Disco
    {
        

        //VARIAVEIS COM GETSET
        public string NomeUnidade { get; set; }
        public string DeviceID { get; set; }
        public string Nome { get; set; }
        public string Rotulo { get; set; }
        public string CapacidadeTotal { get; set; }
        public string CapacidadeLivre { get; set; }
        public string CapacidadeUtilizada { get; set; }
        public string TipoParticao { get; set; }
        public string TipoDisco{ get; set; }


        //CONSTRUTOR
        public Disco()
        {
            
        }

        public void GetInfoDisk(ref List<Disco> Disks)
        {
            ManagementObjectSearcher InfoDisk = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");

            foreach (ManagementObject Disk in InfoDisk.Get())
            {
                foreach (PropertyData Propriedade in Disk.Properties)
                {
                    if (Propriedade.Name.Length > 4 && Propriedade.Name == "Access" && Disk["DeviceID"] != null)
                    {
                                Disco novoDisco = new Disco();
                                novoDisco.Nome = Disk["Name"].ToString();                               
                                novoDisco.DeviceID = Disk["DeviceID"].ToString();
                        try
                        {
                            novoDisco.Rotulo = Disk["Label"].ToString();
                        }
                        catch (NullReferenceException)
                        {
                            novoDisco.Rotulo = "null";
                        }
                                
                        try
                        {
                            
                            novoDisco.NomeUnidade = Disk["Caption"].ToString();
                            novoDisco.CapacidadeTotal = Conversoes.ConverterUnMedida(Disk["Capacity"].ToString());
                            novoDisco.CapacidadeLivre = Conversoes.ConverterUnMedida(Disk["FreeSpace"].ToString());
                            novoDisco.CapacidadeUtilizada = Conversoes.ConverterUnMedida((Convert.ToDouble(Disk["Capacity"]) - Convert.ToDouble(Disk["FreeSpace"])).ToString());
                            novoDisco.TipoParticao = Disk["FileSystem"].ToString();
                        }
                        catch (NullReferenceException)
                        {
                            
                            novoDisco.NomeUnidade = "null";
                            novoDisco.CapacidadeTotal = "null";
                            novoDisco.CapacidadeLivre = "null";
                            novoDisco.CapacidadeUtilizada = "null";
                            novoDisco.TipoParticao = "null";
                        }

                        switch (Convert.ToInt32(Disk["DriveType"]))
                        {
                            case 1:
                                novoDisco.TipoDisco = "Nenhum diretório raiz";
                                break;
                            case 2:
                                novoDisco.TipoDisco = "Disco removível";
                                break;
                            case 3:
                                novoDisco.TipoDisco = "Disco local";
                                break;
                            case 4:
                                novoDisco.TipoDisco = "Unidade de rede";
                                break;
                            case 5:
                                novoDisco.TipoDisco = "Disco compacto";
                                break;
                            case 6:
                                novoDisco.TipoDisco = "Disco RAM";
                                break;

                            default:
                                novoDisco.TipoDisco = "Desconhecido";
                                break;
                        }
                            
                                Disks.Add(novoDisco);
                    }
                }
            }
        }

        public string GetProperties(string query)
        {
            switch (query)
            {
                case "DeviceID":
                    return this.DeviceID;

                case "Nome":
                    return this.Nome;

                case "NomeUnidade":
                    return this.NomeUnidade;

                case "Rotulo":
                    return this.Rotulo;

                case "TipoParticao":
                    return this.TipoParticao;

                case "TipoDisco":
                    return this.TipoDisco;

                case "CapacidadeTotal":
                    return this.CapacidadeTotal;

                case "CapacidadeUilizada":
                    return this.CapacidadeUtilizada;

                case "CapacidadeLivre":
                    return this.CapacidadeLivre;

                default:
                    return "No Information Available";
            }
        }
    }
}
