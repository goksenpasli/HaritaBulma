using System;
using System.Collections.Generic;

namespace Harita
{
    public class Veri
    {
        public static List<string> iller;

        private static readonly Random rd = new Random();

        public Veri()
        {
            iller = new List<string>
            {
                "Adana",
                "Adıyaman",
                "Afyonkarahisar",
                "Ağrı",
                "Amasya",
                "Ankara",
                "Antalya",
                "Artvin",
                "Aydın",
                "Balıkesir",
                "Bilecik",
                "Bingöl",
                "Bitlis",
                "Bolu",
                "Burdur",
                "Bursa",
                "Çanakkale",
                "Çankırı",
                "Çorum",
                "Denizli",
                "Diyarbakır",
                "Edirne",
                "Elazığ",
                "Erzincan",
                "Erzurum",
                "Eskişehir",
                "Gaziantep",
                "Giresun",
                "Gümüşhane",
                "Hakkâri",
                "Hatay",
                "Isparta",
                "İçel",
                "İstanbul",
                "İzmir",
                "Kars",
                "Kastamonu",
                "Kayseri",
                "Kırklareli",
                "Kırşehir",
                "Kocaeli",
                "Konya",
                "Kütahya",
                "Malatya",
                "Manisa",
                "Kahramanmaraş",
                "Mardin",
                "Muğla",
                "Muş",
                "Nevşehir",
                "Niğde",
                "Ordu",
                "Rize",
                "Sakarya",
                "Samsun",
                "Siirt",
                "Sinop",
                "Sivas",
                "Tekirdağ",
                "Tokat",
                "Trabzon",
                "Tunceli",
                "Şanlıurfa",
                "Uşak",
                "Van",
                "Yozgat",
                "Zonguldak",
                "Aksaray",
                "Bayburt",
                "Karaman",
                "Kırıkkale",
                "Batman",
                "Şırnak",
                "Bartın",
                "Ardahan",
                "Iğdır",
                "Yalova",
                "Karabük",
                "Kilis",
                "Osmaniye",
                "Düzce"};
        }

        public static string İl
        {
            get;
            set;
        }

        public static void Yeniİl(MainWindow mv)
        {
            mv.tbilismi.Text = iller[rd.Next(0, iller.Count)];
        }
    }
}