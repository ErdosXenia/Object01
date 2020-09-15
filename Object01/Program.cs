using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            //string valasz2 = nev + " vagyok" + eletkor + " éves.";

            /*string valasz = $"{nev} vagyok, {eletkor} éves,";
            return valasz;*/

            return $"{nev} vagyok, {eletkor} éves,";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ember pisti = new ember();
            ember eva = new ember();

            eva.nev = "Nagy Éva";
            eva.eletkor = 18;

            pisti.nev = "Nagy Pisti";
            pisti.eletkor = 20;

            //pisti.eletkor++;

            Console.WriteLine(pisti.Bemutatkozas());
            Console.WriteLine(eva.Bemutatkozas());


            Console.ReadKey();
        }
    }
}
