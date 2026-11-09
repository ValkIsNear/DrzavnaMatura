using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRZAVNA_MATURA_NOVO
{
    public class Ucenik
    {
        public string Stepen { get; set; }        // III ili IV
        public string Broj { get; set; }          // 1, 2, 3, ...
        public string ImePrezime { get; set; }
        public string TipMature { get; set; }     // Opšta, Stručna, Umetnička
        public string JezikMature { get; set; }   // Srpski, Albanski, ...
        public string PrviPredmet { get; set; }   // Srpski jezik i književnost, ...
        public string DrugiPredmet { get; set; } = "Matematika"; // uvek matematika
        public string? TreciPredmet { get; set; }  // zavisi od tipa mature (može biti prazan)

        // Pomoćna metoda za prikaz u listi
        public override string ToString()
        {
            string TreciPredmetPrikaz = string.IsNullOrEmpty(TreciPredmet) ? "" : $" - {TreciPredmet}";
            return $"{Stepen}-{Broj} - {ImePrezime} - {TipMature} - {JezikMature} - {PrviPredmet} - {DrugiPredmet}{TreciPredmetPrikaz}";
        }
    }

    public static class UceniciManager
    {
        private static List<Ucenik> _ucenici = new List<Ucenik>();
        
        public static List<Ucenik> GetAllUcenici()
        {
            // Sortiraj učenike prvo po stepenu odeljenja, zatim po broju odeljenja, pa po imenu
            return _ucenici
                .OrderBy(u => u.Stepen)
                .ThenBy(u =>
                {
                    // Numeričko sortiranje broja odeljenja
                    if (int.TryParse(u.Broj, out int broj))
                        return broj;
                    return 0;
                })
                .ThenBy(u => u.ImePrezime)
                .ToList();
        }
        
        public static void AddUcenik(Ucenik ucenik)
        {
            _ucenici.Add(ucenik);
        }
        
        public static void RemoveUcenik(Ucenik ucenik)
        {
            _ucenici.Remove(ucenik);
        }
        
        public static void ClearAll()
        {
            _ucenici.Clear();
        }
        
        public static Ucenik? GetUcenikByOdeljenjeAndIme(string stepen, string broj, string imePrezime)
        {
            return _ucenici.FirstOrDefault(u => u.Stepen == stepen && 
                                                u.Broj == broj && 
                                                u.ImePrezime == imePrezime);
        }
        
        public static List<Ucenik> GetUceniciByOdeljenje(string stepen, string broj)
        {
            return _ucenici.Where(u => u.Stepen == stepen && u.Broj == broj).ToList();
        }
    }
}
