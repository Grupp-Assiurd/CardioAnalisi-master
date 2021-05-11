using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static double CalorieBruciate(string genere, int f, float p, int a, double t)
        {
            double calcoloTempo = t * 4.184;
            double c;
            if (genere.ToLower() == "uomo")
            {
                c = ((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * calcoloTempo;
            }
            else if (genere.ToLower() == "donna")
            {
                c = ((a * 0.074) + (p * 0.126) + (f * 0.4472) - 29.4022) * calcoloTempo;
            }
            else
            {
                throw new Exception("Errore: genere non valido");
            }
            return Math.Round(c, 2);

        }

    }
}
