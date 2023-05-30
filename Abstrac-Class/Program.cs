using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** INTERFACE **********");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAracı().ToString()); // enum değerler olduğu için stringe dönüştürdük
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine("**********  **********");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı().ToString()); // enum değerler olduğu için stringe dönüştürdük
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("********** ABSTRACT **********");
            NewFocus newfocus = new NewFocus();
            Console.WriteLine(newfocus.HangiMarkanınAracı().ToString()); // enum değerler olduğu için stringe dönüştürdük
            Console.WriteLine(newfocus.KacTekerlektenOlusur());
            Console.WriteLine(newfocus.StandartRengiNe().ToString());
            Console.WriteLine("**********  **********");
            NewCivic newcivic = new NewCivic();
            Console.WriteLine(newcivic.HangiMarkanınAracı().ToString()); // enum değerler olduğu için stringe dönüştürdük
            Console.WriteLine(newcivic.KacTekerlektenOlusur());
            Console.WriteLine(newcivic.StandartRengiNe().ToString());
        }
    }
}
