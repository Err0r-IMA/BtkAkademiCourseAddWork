namespace BtkAkademiCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BTK Akademi'ye Hoş Geldiniz!");

            Console.WriteLine("        ");
           

            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "Sıfırdan İleri Python Programlama"; 
            kurs1.kursId =  1;
            kurs1.kursEgitmeni = "Sadık Turan";
            kurs1.katilimSayisi = "252.2K Katılımcı";

            
            Kurs kurs2 = new Kurs();
            
            kurs2.kursAdi = "React";
            kurs2.kursId = 2;
            kurs2.kursEgitmeni = "Engin Demirog";
            kurs2.katilimSayisi = "29.9K Katılımcı";

            
            Kurs kurs3 = new Kurs();
            
            kurs3.kursAdi = "HTLM5 ile Web Geliştirme";
            kurs3.kursId = 3;
            kurs3.kursEgitmeni = " Fahrettin Erdinç";
            kurs3.katilimSayisi = "68.8K Katılımcı";

            
            Kurs kurs4 = new Kurs();

            kurs4.kursAdi = "İleri Seviye Java";
            kurs4.kursId = 4;
            kurs4.kursEgitmeni = "Engin Demirog";
            kurs4.katilimSayisi = "26.9K Katılımcı";


            Kurs kurs5 = new Kurs();

            kurs5.kursAdi = "Bilgi Teknolojilerine Giriş";
            kurs5.kursId = 5;
            kurs5.kursEgitmeni = " Sadi Evren Şeker";
            kurs5.katilimSayisi = "153.3K Katılımcı";



            Kurs kurs6 = new Kurs();

            kurs6.kursAdi = "C#";
            kurs6.kursId = 6;
            kurs6.kursEgitmeni = "Engin Demirog";
            kurs6.katilimSayisi = "153.7K Katılımcı";



            Kurs kurs7 = new Kurs();

            kurs7.kursAdi = "Python ile Siber Güvenlik Uygulamaları";
            kurs7.kursId = 7;
            kurs7.kursEgitmeni = "Kazım Emre Karaer";
            kurs7.katilimSayisi = "760 Katılımcı";



            Kurs kurs8 = new Kurs();

            kurs8.kursAdi = "Uçtan Uca WordPress";
            kurs8.kursId = 8;
            kurs8.kursEgitmeni = "İzzet Alşan";
            kurs8.katilimSayisi = "2.2K Katılımcı";



            Kurs kurs9 = new Kurs();

            kurs9.kursAdi = "Uygulamalarla SQL Öğreniyorum";
            kurs9.kursId = 9;
            kurs9.kursEgitmeni = "Ömer Faruk Çolakoğlu";
            kurs9.katilimSayisi = "95.6K Katılımcı";



            Kurs kurs10 = new Kurs();

            kurs10.kursAdi = "mBlock ile Robotik Kodlama";
            kurs10.kursId = 10;
            kurs10.kursEgitmeni = "Talat Çetin ";
            kurs10.katilimSayisi = "983 Katılımcı Sayısı";




            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4,kurs5,kurs6,kurs7,kurs8,kurs9,kurs10};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı : " + kurs.kursAdi );
                Console.WriteLine("Kurs Eğitmeni : " + kurs.kursEgitmeni);
                Console.WriteLine("Kursa Katılım Sayısı : "  + kurs.katilimSayisi );
                Console.WriteLine("Kurs ID : " + kurs.kursId);
                Console.WriteLine("______________________");
            }

            KursManager kursManager = new KursManager();
            Console.WriteLine(" ");


            kursManager.Ekle(kurs1);
            kursManager.Ekle(kurs2);
            kursManager.Ekle(kurs3);
            kursManager.Ekle(kurs4);
            kursManager.Ekle(kurs5);
            kursManager.Ekle(kurs6);
            kursManager.Ekle(kurs7);
            kursManager.Ekle(kurs8);
            kursManager.Ekle(kurs9);
            kursManager.Ekle(kurs10);




        }
    }
}