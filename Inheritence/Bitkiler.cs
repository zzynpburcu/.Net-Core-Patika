using System;

namespace Inheritence
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            //base bana miras veren üst sınıfların metoflarına erişim sağlar
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
         public TohumsuzBitkiler(){
            //base bana miras veren üst sınıfların metoflarına erişim sağlar
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SoparlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
}
