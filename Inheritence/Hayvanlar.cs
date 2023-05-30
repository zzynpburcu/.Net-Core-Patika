using System;

namespace Inheritence
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
        //virtual olan methodları getirmek için override kullanıyoruz
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SurunerekHareketEtmek() 
        {
            Console.WriteLine("Sürüngenler srünerek hareket eder.");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
