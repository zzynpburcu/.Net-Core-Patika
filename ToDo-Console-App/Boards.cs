using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    public class Boards
{
    public Dictionary<string, List<Card>> Lines { get; private set; }

    public Boards()
    {
        Lines = new Dictionary<string, List<Card>>();
        Lines.Add("TODO", new List<Card>());
        Lines.Add("IN PROGRESS", new List<Card>());
        Lines.Add("DONE", new List<Card>());
    }

    public void KartEkle(Card card, string line)
    {
        if (Lines.ContainsKey(line))
        {
            Lines[line].Add(card);
            Console.WriteLine("Kart başarıyla eklendi.");
        }
        else
        {
            Console.WriteLine("Geçersiz line ismi. Kart eklenemedi.");
        }
    }

    public void KartSil(string baslik)
    {
        bool kartBulundu = false;

        foreach (var line in Lines.Values)
        {
            for (int i = 0; i < line.Count; i++)
            {
                if (line[i].Baslik == baslik)
                {
                    line.RemoveAt(i);
                    kartBulundu = true;
                    i--;
                }
            }
        }

        if (kartBulundu)
        {
            Console.WriteLine("Kart başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
        }
    }

    public void KartTasi(string baslik, string hedefLine)
    {
        Card card = null;

        foreach (var line in Lines.Values)
        {
            foreach (var k in line)
            {
                if (k.Baslik == baslik)
                {
                    card = k;
                    break;
                }
            }
        }

        if (card == null)
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
        }
        else
        {
            foreach (var line in Lines.Values)
            {
                line.Remove(card);
            }

            if (Lines.ContainsKey(hedefLine))
            {
                Lines[hedefLine].Add(card);
                Console.WriteLine("Kart başarıyla taşındı.");
            }
            else
            {
                Console.WriteLine("Geçersiz line ismi. Kart taşınamadı.");
            }
        }
    }

    public void BoarduListele()
    {
        foreach (var line in Lines)
        {
            Console.WriteLine(line.Key + " Line");
            Console.WriteLine("************************");

            if (line.Value.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in line.Value)
                {
                    Console.WriteLine("Başlık      : " + kart.Baslik);
                    Console.WriteLine("İçerik      : " + kart.Icerik);
                    Console.WriteLine("Atanan Kişi : " + kart.Atanankisi);
                    Console.WriteLine("Büyüklük    : " + kart.Buyukluk.ToString());
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine();
        }
    }
}



}