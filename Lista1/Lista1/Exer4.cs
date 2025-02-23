using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class DataClasss
    {
        public DateTime DataEvento { get; set; }

        public DataClasss(DateTime dataEvento)
        {
            DataEvento = dataEvento;
        }

        public string dataConfigurar(int tipoFormato)
        {
            string resultadoFormatacao = null;

            switch (tipoFormato)
            {
                case 1:
                    resultadoFormatacao = Convert.ToString(DataEvento);
                    break;

                case 2:
                    resultadoFormatacao = string.Format("{0:dd-MM-yyyy}", DataEvento);
                    break;

                case 3:
                    resultadoFormatacao = DataEvento.ToLongDateString();
                    break;

                case 4:
                    resultadoFormatacao = string.Format("{0:dd-MM-yyyy HH:mm:ss}", DataEvento);
                    break;

                case 5:
                    resultadoFormatacao = DataEvento.ToString("R");
                    break;
            }

            return resultadoFormatacao;
        }
    }
}
