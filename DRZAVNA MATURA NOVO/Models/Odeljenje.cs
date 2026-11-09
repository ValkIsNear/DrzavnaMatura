using System;
using System.Collections.Generic;
using System.Linq;

namespace DRZAVNA_MATURA_NOVO
{
    public class Odeljenje
    {
        public string Stepen { get; set; }        // III ili IV
        public string Broj { get; set; }          // 1, 2, 3, ...
        public string TipMature { get; set; }     // Opšta, Stručna, Umetnička
        public string JezikMature { get; set; }   // Srpski, Albanski, ...
        public string PrviPredmet { get; set; }   // Srpski jezik i književnost, ...
        public string DrugiPredmet { get; set; } = "Matematika"; // uvek matematika
        public string? TreciPredmet { get; set; }  // zavisi od tipa mature (može biti prazan)
        
        // Pomoćna metoda za prikaz u listi
        public override string ToString()
        {
            string TreciPredmetPrikaz = string.IsNullOrEmpty(TreciPredmet) ? "" : $" - {TreciPredmet}";
            return $"{Stepen}-{Broj} - {TipMature} - {JezikMature} - {PrviPredmet} - {DrugiPredmet}{TreciPredmetPrikaz}";
        }
    }
    
    public static class OdeljenjaManager
    {
        private static List<Odeljenje> _odeljenja = new List<Odeljenje>();
        
        public static List<Odeljenje> GetAllOdeljenja()
        {
            // Sortiraj odeljenja po stepenu, a zatim po broju
            return _odeljenja.OrderBy(o => o.Stepen)
                           .ThenBy(u =>
                           {
                               // Numeričko sortiranje broja odeljenja
                               if (int.TryParse(u.Broj, out int broj))
                                   return broj;
                               return 0;
                           })
                           .ToList();
        }
        
        public static void AddOdeljenje(Odeljenje odeljenje)
        {
            _odeljenja.Add(odeljenje);
        }
        
        public static void RemoveOdeljenje(Odeljenje odeljenje)
        {
            _odeljenja.Remove(odeljenje);
        }
        
        public static void ClearAll()
        {
            _odeljenja.Clear();
        }
        
        public static Odeljenje GetOdeljenjeByStepenAndBroj(string stepen, string broj)
        {
            return _odeljenja.FirstOrDefault(o => o.Stepen == stepen && o.Broj == broj);
        }
    }
}