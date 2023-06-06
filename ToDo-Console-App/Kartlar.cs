using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    public class Card
    {
        private string baslik;
        private string icerik;
        private string atanankisi;
        private Buyukluk buyukluk;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Atanankisi { get => atanankisi; set => atanankisi = value; }
        public Buyukluk Buyukluk { get => buyukluk; set => buyukluk = value; }
        public string Icerik { get => icerik; set => icerik = value; }

    }








}