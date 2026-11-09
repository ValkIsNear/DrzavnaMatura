using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Tipovi mature
/// </summary>
public enum MaturaType
{
    Opsta,
    Strucna,
    Umetnicka
}

/// <summary>
/// Jezici koji se mogu birati kao prvi predmet i kao drugi/treći predmet
/// </summary>
public enum Language
{
    SrpskiJezikIKnjizevnost,
    AlbanskiJezikIKnjizevnost,
    BosanskiJezikIKnjizevnost,
    BugarskiJezikIKnjizevnost,
    MadjarskiJezikIKnjizevnost,
    RumunskiJezikIKnjizevnost,
    RusinskiJezikIKnjizevnost,
    SlovackiJezikIKnjizevnost,
    HrvatskiJezikIKnjizevnost
}

/// <summary>
/// Treći predmet za opštu maturu
/// </summary>
public enum OpstaMaturaSubject
{
    Biologija,
    Geografija,
    EngleskiJezik,
    Istorija,
    ItalijanskiJezik,
    NemackiJezik,
    RuskiJezik,
    SrpskiKaoNematernjiJezik,
    Fizika,
    FrancuskiJezik,
    Hemija,
    SpanskiJezik
}

/// <summary>
/// Stručni predmeti za stručnu maturu
/// </summary>
public enum StrucnaMaturaSubject
{
    Zootehnicar,
    TehnicarZaBiotehnologiju,
    TehnicarPoljoprivredneTehnike,
    TehnicarHortikulture,
    TehnicarZaPejzaznuArhitekturu,
    SumarskiTehnicar,
    GeoloskiTehnicarZaGeotehnikuIHidrogeologiju,
    GeoloskiTehnicarZaIstrazivanjeMineralnihSirovina,
    RudarskiTehnicar,
    RudarskiTehnicarZaPripremuMineralnihSirovina,
    BrodomasinskiTehnicar,
    MasinskiTehnicarZaKompjuterskoKonstruisanje,
    MasinskiTehnicarMerneIRegulacioneTehnike,
    MasinskiTehnicarMotornihVozila,
    TehnicarGrejanjaIKlimatizacije,
    TehnicarZaKompjuterskoUpravljanjeCncMasina,
    TehnicarZaRobotiku,
    TehnicarMasinskeEnergetike,
    TehnicarOptike,
    ElektrotehnicarAutomatike,
    ElektrotehnicarElektromotornihPogona,
    ElektrotehnicarElektronike,
    ElektrotehnicarEnergetike,
    ElektrotehnicarZaTermickeIRashladneUredjaje,
    ElektrotehnicarInformacionihTehnologija,
    ElektrotehnicarProcesnogUpravljanja,
    ElektrotehnicarRacunara,
    TehnicarGrafickeDorade,
    TehnicarZaZastituZivotneSredine,
    TehnicarZaIndustrijskuFarmaceutskuTehnologiju,
    TehnicarStampe,
    Fotograf,
    HemijskiLaborant,
    HemijskoTehnoloskiTehnicar,
    TekstilniTehnicar,
    GradjevinskiTehnicarZaLaboratorijskaIspitivanja,
    GradjevinskiTehnicarZaHidrogradnju,
    IzvodjacInstalaterskihIZavrsnihGradjevinskihRadova,
    NautickiTehnicarRecniSmer,
    SaobracajnoTransportniTehnicar,
    TehnicarVuce,
    TehnicarPttSaobracaja,
    TehnicarUnutrasnjegTransporta,
    TransportniKomercijalista,
    AranzerUTrgovini,
    TrgovinskiTehnicar,
    KulinarskiTehnicar,
    UgostiteljskiTehnicar,
    EkonomskiTehnicar,
    FinansijskiTehnicar,
    CarinskiTehnicar,
    GinekoloskoAkuserskaSestra,
    ZubniTehnicar,
    MedicinskaSestraVaspitac,
    PedijatrijskaSestraTehnicar,
    SanitarnoEkoloskiTehnicar,
    ScenskiMaskerIVlasuljar
}

/// <summary>
/// Treći predmet za umetničku maturu
/// </summary>
public enum UmetnickaMaturaSubject
{
    SolfedoIHarmonija
}

/// <summary>
/// Statička klasa za rad sa predmetima mature
/// </summary>
public static class Enums
{
    /// <summary>
    /// Dobija naziv jezika na osnovu enum vrednosti
    /// </summary>
    public static string GetLanguageName(Language language)
    {
        return language switch
        {
            Language.SrpskiJezikIKnjizevnost => "Srpski jezik i književnost",
            Language.AlbanskiJezikIKnjizevnost => "Albanski jezik i književnost",
            Language.BosanskiJezikIKnjizevnost => "Bosanski jezik i književnost",
            Language.BugarskiJezikIKnjizevnost => "Bugarski jezik i književnost",
            Language.MadjarskiJezikIKnjizevnost => "Mađarski jezik i književnost",
            Language.RumunskiJezikIKnjizevnost => "Rumunski jezik i književnost",
            Language.RusinskiJezikIKnjizevnost => "Rusinski jezik i književnost",
            Language.SlovackiJezikIKnjizevnost => "Slovački jezik i književnost",
            Language.HrvatskiJezikIKnjizevnost => "Hrvatski jezik i književnost",
            _ => throw new ArgumentException($"Nepoznat jezik: {language}")
        };
    }

    /// <summary>
    /// Dobija naziv predmeta opšte mature na osnovu enum vrednosti
    /// </summary>
    public static string GetOpstaSubjectName(OpstaMaturaSubject subject)
    {
        return subject switch
        {
            OpstaMaturaSubject.Biologija => "Biologija",
            OpstaMaturaSubject.Geografija => "Geografija",
            OpstaMaturaSubject.EngleskiJezik => "Engleski jezik",
            OpstaMaturaSubject.Istorija => "Istorija",
            OpstaMaturaSubject.ItalijanskiJezik => "Italijanski jezik",
            OpstaMaturaSubject.NemackiJezik => "Nemački jezik",
            OpstaMaturaSubject.RuskiJezik => "Ruski jezik",
            OpstaMaturaSubject.SrpskiKaoNematernjiJezik => "Srpski kao nematernji jezik",
            OpstaMaturaSubject.Fizika => "Fizika",
            OpstaMaturaSubject.FrancuskiJezik => "Francuski jezik",
            OpstaMaturaSubject.Hemija => "Hemija",
            OpstaMaturaSubject.SpanskiJezik => "Španski jezik",
            _ => throw new ArgumentException($"Nepoznat predmet: {subject}")
        };
    }

    /// <summary>
    /// Dobija naziv stručnog predmeta na osnovu enum vrednosti
    /// </summary>
    public static string GetStrucnaSubjectName(StrucnaMaturaSubject subject)
    {
        return subject switch
        {
            StrucnaMaturaSubject.Zootehnicar => "Zootehničar",
            StrucnaMaturaSubject.TehnicarZaBiotehnologiju => "Tehničar za biotehnologiju",
            StrucnaMaturaSubject.TehnicarPoljoprivredneTehnike => "Tehničar poljoprivredne tehnike",
            StrucnaMaturaSubject.TehnicarHortikulture => "Tehničar hortikulture",
            StrucnaMaturaSubject.TehnicarZaPejzaznuArhitekturu => "Tehničar za pejzažnu arhitekturu",
            StrucnaMaturaSubject.SumarskiTehnicar => "Šumarski tehničar",
            StrucnaMaturaSubject.GeoloskiTehnicarZaGeotehnikuIHidrogeologiju => "Geološki tehničar za geotehniku i hidrogeologiju",
            StrucnaMaturaSubject.GeoloskiTehnicarZaIstrazivanjeMineralnihSirovina => "Geološki tehničar za istraživanje mineralnih sirovina",
            StrucnaMaturaSubject.RudarskiTehnicar => "Rudarski tehničar",
            StrucnaMaturaSubject.RudarskiTehnicarZaPripremuMineralnihSirovina => "Rudarski tehničar za pripremu mineralnih sirovina",
            StrucnaMaturaSubject.BrodomasinskiTehnicar => "Brodomašinski tehničar",
            StrucnaMaturaSubject.MasinskiTehnicarZaKompjuterskoKonstruisanje => "Mašinski tehničar za kompjutersko konstruisanje",
            StrucnaMaturaSubject.MasinskiTehnicarMerneIRegulacioneTehnike => "Mašinski tehničar merne i regulacione tehnike",
            StrucnaMaturaSubject.MasinskiTehnicarMotornihVozila => "Mašinski tehničar motornih vozila",
            StrucnaMaturaSubject.TehnicarGrejanjaIKlimatizacije => "Tehničar grejanja i klimatizacije",
            StrucnaMaturaSubject.TehnicarZaKompjuterskoUpravljanjeCncMasina => "Tehničar za kompjutersko upravljanje (CNC) mašina",
            StrucnaMaturaSubject.TehnicarZaRobotiku => "Tehničar za robotiku",
            StrucnaMaturaSubject.TehnicarMasinskeEnergetike => "Tehničar mašinske energetike",
            StrucnaMaturaSubject.TehnicarOptike => "Tehničar optike",
            StrucnaMaturaSubject.ElektrotehnicarAutomatike => "Elektrotehničar automatike",
            StrucnaMaturaSubject.ElektrotehnicarElektromotornihPogona => "Elektrotehničar elektromotornih pogona",
            StrucnaMaturaSubject.ElektrotehnicarElektronike => "Elektrotehničar elektronike",
            StrucnaMaturaSubject.ElektrotehnicarEnergetike => "Elektrotehničar energetike",
            StrucnaMaturaSubject.ElektrotehnicarZaTermickeIRashladneUredjaje => "Elektrotehničar za termičke i rashladne uređaje",
            StrucnaMaturaSubject.ElektrotehnicarInformacionihTehnologija => "Elektrotehničar informacionih tehnologija",
            StrucnaMaturaSubject.ElektrotehnicarProcesnogUpravljanja => "Elektrotehničar procesnog upravljanja",
            StrucnaMaturaSubject.ElektrotehnicarRacunara => "Elektrotehničar računara",
            StrucnaMaturaSubject.TehnicarGrafickeDorade => "Tehničar grafičke dorade",
            StrucnaMaturaSubject.TehnicarZaZastituZivotneSredine => "Tehničar za zaštitu životne sredine",
            StrucnaMaturaSubject.TehnicarZaIndustrijskuFarmaceutskuTehnologiju => "Tehničar za industrijsku farmaceutsku tehnologiju",
            StrucnaMaturaSubject.TehnicarStampe => "Tehničar štampe",
            StrucnaMaturaSubject.Fotograf => "Fotograf",
            StrucnaMaturaSubject.HemijskiLaborant => "Hemijski laborant",
            StrucnaMaturaSubject.HemijskoTehnoloskiTehnicar => "Hemijsko-tehnološki tehničar",
            StrucnaMaturaSubject.TekstilniTehnicar => "Tekstilni tehničar",
            StrucnaMaturaSubject.GradjevinskiTehnicarZaLaboratorijskaIspitivanja => "Građevinski tehničar za laboratorijska ispitivanja",
            StrucnaMaturaSubject.GradjevinskiTehnicarZaHidrogradnju => "Građevinski tehničar za hidrogradnju",
            StrucnaMaturaSubject.IzvodjacInstalaterskihIZavrsnihGradjevinskihRadova => "Izvođač instalaterskih i završnih građevinskih radova",
            StrucnaMaturaSubject.NautickiTehnicarRecniSmer => "Nautički tehničar – rečni smer",
            StrucnaMaturaSubject.SaobracajnoTransportniTehnicar => "Saobraćajno-transportni tehničar",
            StrucnaMaturaSubject.TehnicarVuce => "Tehničar vuče",
            StrucnaMaturaSubject.TehnicarPttSaobracaja => "Tehničar PTT saobraćaja",
            StrucnaMaturaSubject.TehnicarUnutrasnjegTransporta => "Tehničar unutrašnjeg transporta",
            StrucnaMaturaSubject.TransportniKomercijalista => "Transportni komercijalista",
            StrucnaMaturaSubject.AranzerUTrgovini => "Aranžer u trgovini",
            StrucnaMaturaSubject.TrgovinskiTehnicar => "Trgovinski tehničar",
            StrucnaMaturaSubject.KulinarskiTehnicar => "Kulinarski tehničar",
            StrucnaMaturaSubject.UgostiteljskiTehnicar => "Ugostiteljski tehničar",
            StrucnaMaturaSubject.EkonomskiTehnicar => "Ekonomski tehničar",
            StrucnaMaturaSubject.FinansijskiTehnicar => "Finansijski tehničar",
            StrucnaMaturaSubject.CarinskiTehnicar => "Carinski tehničar",
            StrucnaMaturaSubject.GinekoloskoAkuserskaSestra => "Ginekološko-akušerska sestra",
            StrucnaMaturaSubject.ZubniTehnicar => "Zubni tehničar",
            StrucnaMaturaSubject.MedicinskaSestraVaspitac => "Medicinska sestra – vaspitač",
            StrucnaMaturaSubject.PedijatrijskaSestraTehnicar => "Pedijatrijska sestra – tehničar",
            StrucnaMaturaSubject.SanitarnoEkoloskiTehnicar => "Sanitarno-ekološki tehničar",
            StrucnaMaturaSubject.ScenskiMaskerIVlasuljar => "Scenski masker i vlasuljar",
            _ => throw new ArgumentException($"Nepoznat stručni predmet: {subject}")
        };
    }

    /// <summary>
    /// Dobija naziv predmeta umetničke mature na osnovu enum vrednosti
    /// </summary>
    public static string GetUmetnickaSubjectName(UmetnickaMaturaSubject subject)
    {
        return subject switch
        {
            UmetnickaMaturaSubject.SolfedoIHarmonija => "Solfeđo i harmonija",
            _ => throw new ArgumentException($"Nepoznat predmet: {subject}")
        };
    }

    /// <summary>
    /// Konvertuje string u odgovarajući enum za jezik
    /// </summary>
    public static Language ParseLanguage(string languageName)
    {
        return languageName switch
        {
            "Srpski jezik i književnost" => Language.SrpskiJezikIKnjizevnost,
            "Albanski jezik i književnost" => Language.AlbanskiJezikIKnjizevnost,
            "Bosanski jezik i književnost" => Language.BosanskiJezikIKnjizevnost,
            "Bugarski jezik i književnost" => Language.BugarskiJezikIKnjizevnost,
            "Mađarski jezik i književnost" => Language.MadjarskiJezikIKnjizevnost,
            "Rumunski jezik i književnost" => Language.RumunskiJezikIKnjizevnost,
            "Rusinski jezik i književnost" => Language.RusinskiJezikIKnjizevnost,
            "Slovački jezik i književnost" => Language.SlovackiJezikIKnjizevnost,
            "Hrvatski jezik i književnost" => Language.HrvatskiJezikIKnjizevnost,
            _ => throw new ArgumentException($"Nepoznat naziv jezika: {languageName}")
        };
    }

    /// <summary>
    /// Dobija sve vrednosti jezika kao listu enum-ova
    /// </summary>
    public static IEnumerable<Language> GetAllLanguages() => Enum.GetValues(typeof(Language)).Cast<Language>();

    /// <summary>
    /// Dobija sve vrednosti opšte mature kao listu enum-ova
    /// </summary>
    public static IEnumerable<OpstaMaturaSubject> GetAllOpstaSubjects() => Enum.GetValues(typeof(OpstaMaturaSubject)).Cast<OpstaMaturaSubject>();

    /// <summary>
    /// Dobija sve vrednosti stručne mature kao listu enum-ova
    /// </summary>
    public static IEnumerable<StrucnaMaturaSubject> GetAllStrucnaSubjects() => Enum.GetValues(typeof(StrucnaMaturaSubject)).Cast<StrucnaMaturaSubject>();

    /// <summary>
    /// Dobija sve vrednosti umetničke mature kao listu enum-ova
    /// </summary>
    public static IEnumerable<UmetnickaMaturaSubject> GetAllUmetnickaSubjects() => Enum.GetValues(typeof(UmetnickaMaturaSubject)).Cast<UmetnickaMaturaSubject>();
}