using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Statistiche
{
    public class Statistiche
    {
        int numeroValori;
        int numeroValoriConPeso;
        double sommaValori;
        double sommaValoriPerPeso;
        double sommaPesi;
        public Statistiche()
        {
            numeroValoriConPeso = 0;
            numeroValori = 0;
            sommaValori = 0;
            sommaValoriPerPeso = 0;
            sommaPesi = 0;
        }
        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        {
            sommaValori = sommaValori + valore;
            numeroValori++;
        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            sommaPesi = sommaPesi + peso;
            sommaValoriPerPeso = sommaValoriPerPeso + (valore * peso);
            numeroValoriConPeso++;
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            return sommaValori/numeroValori;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            return sommaValoriPerPeso/numeroValoriConPeso;
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {

        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {

        }

    }
}
