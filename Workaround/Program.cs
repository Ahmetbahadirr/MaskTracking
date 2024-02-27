using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
	class Program
	{
		static void Main(string[] args)
		{
			//SelamVer(isim: "Ahmet");
			//SelamVer(isim: "Engin");
			//SelamVer(isim: "İlayda");
			//SelamVer();

			//int sonuc = Topla(6, 58);

			//string ogrenci1 = "Ahmet";
			//string ogrenci2 = "Engin";
			//string ogrenci3 = "Fatih";

			//string[] ogrenciler = new string[3];
			//ogrenciler[0] = "Ahmet";
			//ogrenciler[1] = "Engin";
			//ogrenciler[2] = "Fatih";
			//ogrenciler = new string[4];
			//ogrenciler[3] = "İlker";

			//for (int i = 0; i < ogrenciler.Length; i++)
			//{
			//	Console.WriteLine(ogrenciler[i]);
			//}

			//string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
			//string[] sehirler2 = new[] { "Bursa", "Antalya", "Kayseri" };

			//sehirler2 = sehirler1;
			//sehirler1[0] = "Adana";
			//Console.WriteLine(sehirler2[0]);

			Person person1 = new Person();
			person1.FirstName = "AHMET";
			person1.LastName = "BAHADIR";
			person1.DateOfBirthYear = 1998;
			person1.NationalIdentity = 123;

			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);


			Console.ReadLine();

			//foreach (string sehir in sehirler1)
			//{
			//	Console.WriteLine(sehir);
			//}

			//List<string> yeniSehirler1 = new List<string> { "Ankara 1 ", "İstanbul 1", "İzmir 1" };
			//yeniSehirler1.Add("Adana 1");
			//foreach (string sehir in yeniSehirler1)
			//{
			//	Console.WriteLine(sehir);
			//}


		}

		//static void SelamVer(string isim = "isimsiz")
		//{
		//	Console.WriteLine("Merhaba " + isim);
		//}

		//static int Topla(int sayi1 = 5, int sayi2 = 10)
		//{
		//	int sonuc = sayi1 + sayi2;
		//	Console.WriteLine("Toplam: " + sonuc);
		//	return sonuc;
		//}

	}
}