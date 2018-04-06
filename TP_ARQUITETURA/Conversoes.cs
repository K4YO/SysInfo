using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ARQUITETURA
{
    public class Conversoes
    {
        public static string ConverterUnMedida(string Num) 
        {
            double numero = 0;

            if (Num != string.Empty)
            {
                numero = Convert.ToDouble(Num);
            }
            if (numero <= 1024)
            {
                return numero + " Bits";
            }
            else if (numero >= 1024 && numero < 1048576)
            {
                return (numero / 1024).ToString("0.00") + " KB";
            }
            else if (numero >= 1048576 && numero < 1073741824)
            {
                return (numero / 1048576).ToString("0.00") + " MB";
            }
            else if (numero >= 1073741824 && numero < 1099511627776)
            {
                return (numero / 1073741824).ToString("0.00") + " GB";
            }
            else if (numero >= 1099511627776 && numero <= 1125899906842624)
            {
                return (numero / 1099511627776).ToString("0.00") + " TB";
            }
            else
            {
                return numero.ToString();
            }
        }
    }
}
