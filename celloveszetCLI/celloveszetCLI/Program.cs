using System.IO;

namespace celloveszetCLI
{

    public class Program
    {
        public static List<Cellovo> cellovok = new List<Cellovo>();

        public int legnagyobb(int l1, int l2, int l3, int l4)
        {
            int max = l1;
            if (l2 > max) { max = l2; }
            if (l3 > max) { max = l3; }
            if (l4 > max) { max = l4; }
            return max;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream)
            {
                cellovok.Add(new Cellovo(sr.ReadLine()));
            }
            sr.Close();
            //9.feladat
            Console.WriteLine("9.feladat:");
            foreach (Cellovo cellovo in cellovok)
            {
                Console.WriteLine($"{cellovo.Nev} {cellovo.Legnagyobb()}");
            }
            //10.feladat
            Console.WriteLine("10.feladat:");

            int index = 0;
            int max = 0;
            for (int i = 0; i < cellovok.Count; i++)
            {
                if (cellovok[i].Legnagyobb() > max) 
                {
                    max = cellovok[i].Legnagyobb();
                    index = i;
                }                        
            }
            Console.WriteLine($"{cellovok[index].Nev} {cellovok[index].Elsoloves} {cellovok[index].Masodikloves} {cellovok[index].Harmadikloves} {cellovok[index].Negyedikloves}");
            //11.feladat
            Console.WriteLine("A legnagyobb találatot lövő eredményei:");
            Console.WriteLine("11.feladat:");

            int min = cellovok[0].Atlag();
            string nev = cellovok[0].Nev;
            for (int i = 1; i < cellovok.Count; ++i) 
            {
                if (cellovok[i].Atlag() < min) 
                { 
                    min = cellovok[i].Atlag();
                    nev = cellovok[i].Nev;
                }            
            }
            Console.WriteLine("A leggyengébb átlagu találatot lövő eredményei:");
            Console.WriteLine($"{nev} {min}");
        }
    }
}
