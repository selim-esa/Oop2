// See https://aka.ms/new-console-template for more information
using Oop2;

GercekMusteri musteri1 = new();
musteri1.Id = 1;
musteri1.MusteriNo="12345";
musteri1.Adi = "Selim";
musteri1.Soyadi = "Esa";
musteri1.TcNo = "12345678910";

TuzelMusteri musteri2 = new();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "ESA mühendislik";
musteri2.VergiNo = "123456789";

Musteri musteri3= new GercekMusteri();  
Musteri musteri4= new TuzelMusteri();   

CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);
customerManager.Add(musteri2);
