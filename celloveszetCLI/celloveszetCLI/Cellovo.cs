using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class Cellovo
    {
        public string Nev { get; private set; }
        public int Elsoloves { get; private set; }
        public int Masodikloves { get; private set; }
        public int Harmadikloves { get; private set; }
        public int Negyedikloves { get; private set; }

        public int Legnagyobb()
        {
            int max = Elsoloves;
            if (Masodikloves > max) { max = Masodikloves; }
            if (Harmadikloves > max) { max = Harmadikloves; }
            if (Negyedikloves > max) { max = Negyedikloves; }
            return max;
        }

        public int Atlag()
        {
            int atlag = (Elsoloves + Masodikloves + Harmadikloves + Negyedikloves) / 4;
            return atlag;
        }
        public Cellovo(string line)
        {
            string[] darabok = line.Split(';');
            Nev = darabok[0];
            Elsoloves = int.Parse(darabok[1]);
            Masodikloves = int.Parse(darabok[2]);
            Harmadikloves = int.Parse(darabok[3]);
            Negyedikloves = int.Parse(darabok[4]);
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
