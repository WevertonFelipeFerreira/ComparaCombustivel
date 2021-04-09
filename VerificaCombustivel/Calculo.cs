using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaCombustivel
{
    public class Calculo : IMedia
    {
        public double media(string precoAlcool, string precoGasolina) 
        {
            double PrecoAlcool = Convert.ToDouble(precoAlcool);
            double PrecoGasolina = Convert.ToDouble(precoGasolina);
            double media = PrecoAlcool / PrecoGasolina;
            return media;
     }
}
}
