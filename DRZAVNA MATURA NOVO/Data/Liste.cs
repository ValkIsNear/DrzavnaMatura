using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Liste
{
    public static List<string> StepenOdeljenja = new List<string>
    {
        "III",
        "IV"
    };

    public static List<string> BrojOdeljenja = new List<string>
    {
        "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"
    };

    public static List<string> TipMature = new List<string>
    {
        "Opšta matura",
        "Stručna matura",
        "Umetnička matura"
    };

    // Jezik Mature
    public static List<string> Jezici = new List<string>
    {
        "Srpski jezik",
        "Albanski jezik",
        "Bosanski jezik",
        "Bugarski jezik",
        "Mađarski jezik",
        "Rumunski jezik",
        "Rusinski jezik",
        "Slovački jezik",
        "Hrvatski jezik"
    };

    // Prvi predmet za maturu
    public static List<string> PrviPredmet = new List<string>
    {
        "Srpski jezik i književnost",
        "Albanski jezik i književnost",
        "Bosanski jezik i književnost",
        "Bugarski jezik i književnost",
        "Mađarski jezik i književnost",
        "Rumunski jezik i književnost",
        "Rusinski jezik i književnost",
        "Slovački jezik i književnost",
        "Hrvatski jezik i književnost"
    };

    // Drugi predmet za maturu
    public static List<string> DrugiPredmet = new List<string>
    {
        "Matematika"
    };

    // Treci predmet za opštu maturu
    public static List<string> OpstaTreciPredmet = new List<string>
    {
        "Biologija",
        "Geografija",
        "Istorija",
        "Fizika",
        "Hemija",
        "Srpski kao nematernji jezik",
        "Italijanski jezik",
        "Engleski jezik",
        "Nemački jezik",
        "Ruski jezik",
        "Francuski jezik",
        "Španski jezik"
    };

    // Stručni predmeti za stručnu maturu (spisak iz teksta zadatka)
    public static List<string> StrucnaTreciPredmet = new List<string>
    {
        "Zootehničar", "Tehničar za biotehnologiju", "Tehničar poljoprivredne tehnike",
        "Tehničar hortikulture", "Tehničar za pejzažnu arhitekturu", "Šumarski tehničar",
        "Geološki tehničar za geotehniku i hidrogeologiju", "Geološki tehničar za istraživanje mineralnih sirovina",
        "Rudarski tehničar", "Rudarski tehničar za pripremu mineralnih sirovina",
        "Brodomašinski tehničar", "Mašinski tehničar za kompjutersko konstruisanje",
        "Mašinski tehničar merne i regulacione tehnike", "Mašinski tehničar motornih vozila",
        "Tehničar grejanja i klimatizacije", "Tehničar za kompjutersko upravljanje (CNC) mašina",
        "Tehničar za robotiku", "Tehničar mašinske energetike", "Tehničar optike",
        "Elektrotehničar automatike", "Elektrotehničar elektromotornih pogona",
        "Elektrotehničar elektronike", "Elektrotehničar energetike",
        "Elektrotehničar za termičke i rashladne uređaje", "Elektrotehničar informacionih tehnologija",
        "Elektrotehničar procesnog upravljanja", "Elektrotehničar računara",
        "Tehničar grafičke dorade", "Tehničar za zaštitu životne sredine",
        "Tehničar za industrijsku farmaceutsku tehnologiju", "Tehničar štampe",
        "Fotograf", "Hemijski laborant", "Hemijsko-tehnološki tehničar",
        "Tekstilni tehničar", "Građevinski tehničar za laboratorijska ispitivanja",
        "Građevinski tehničar za hidrogradnju", "Izvođač instalaterskih i završnih građevinskih radova",
        "Nautički tehničar – rečni smer", "Saobraćajno-transportni tehničar",
        "Tehničar vuče", "Tehničar PTT saobraćaja", "Tehničar unutrašnjeg transporta",
        "Transportni komercijalista", "Aranžer u trgovini", "Trgovinski tehničar",
        "Kulinarski tehničar", "Ugostiteljski tehničar", "Ekonomski tehničar",
        "Finansijski tehničar", "Carinski tehničar", "Ginekološko-akušerska sestra",
        "Zubni tehničar", "Medicinska sestra – vaspitač", "Pedijatrijska sestra – tehničar",
        "Sanitarno-ekološki tehničar", "Scenski masker i vlasuljar"
    };

    // Umetnička matura – treći predmet
    public static List<string> UmetnickaTreciPredmet = new List<string>
    {
        "Solfeđo",
        "Harmonija"
    };
}
