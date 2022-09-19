using ClassRoomNet60;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        KlasseRum klasseRum = new KlasseRum();
        klasseRum.KlasseNavn = "3B";
        klasseRum.SemesterStart = new DateTime(2022, 9, 1);

        Studerende anders = new Studerende("Anders Petersen", 1998, 1);
        Studerende jonathan = new Studerende("Jonathan Elberg", 1999, 7);
        Studerende alexander = new Studerende("Alexander Gerdil", 1996, 8);
        Studerende runi = new Studerende("Runi Bjartalið", 1989, 2);
        Studerende fejl = new Studerende("Fejl tjek", 1999, 14);

        List<Studerende> StuderendeListe = new List<Studerende>();
        StuderendeListe.Add(anders);
        StuderendeListe.Add(jonathan);
        StuderendeListe.Add(alexander);
        StuderendeListe.Add(runi);
        StuderendeListe.Add(fejl);

        Console.WriteLine($"{klasseRum}");

        foreach (Studerende std in StuderendeListe)
        {
            Console.WriteLine(std);
        }

        void Counter()
        {
            int antal_vinter = 0;
            int antal_forår = 0;
            int antal_efterår = 0;
            int antal_sommer = 0;
            foreach (Studerende aarstid in StuderendeListe)
            {
                if (aarstid.Aarstid(aarstid.Fødselsmåned) == "Vinter")
                {
                    antal_vinter++;
                }
                else if (aarstid.Aarstid(aarstid.Fødselsmåned) == "Forår")
                {
                    antal_forår++;
                }
                else if (aarstid.Aarstid(aarstid.Fødselsmåned) == "Sommer")
                {
                    antal_sommer++;
                }
                else if (aarstid.Aarstid(aarstid.Fødselsmåned) == "Efterår")
                {
                    antal_efterår++;
                }
            }
            Console.WriteLine($"Vinter: {antal_vinter} studerende\nForår: {antal_forår} studerende\nSommer: {antal_sommer} studerende\nEfterår: {antal_efterår} studerende");
        }
        Counter();
    }
}