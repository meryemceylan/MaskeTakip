using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas = new Vatandas();
SelamVer();
SelamVer(isim : "Meryem");

int sonuç = Topla(35, 52);


static void SelamVer(string isim="x")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1=0, int sayi2=067 )
{
    int sonuç = sayi1 + sayi2;
    Console.WriteLine("Toplam " + sonuç);
    return sonuç;
}

string[] sehirler1 = new[] {"Ankara", "İstanbul","İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

Person person1 = new Person();
person1.FirstName = "MERYEM";
person1.LastName = "CEYLAN ";
person1.DateOfBirthYear = 1997;
person1.NationalIdentity = 123;


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler = new List<string> { "Kocaeli", "İstanbul", "Sivas" };
yeniSehirler.Add("Adana");
foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

string mesaj = "Mesaj";
double tutar = 1000;
int sayi = 10;
bool girisYapmisMi = false;

string ad = "Meryem";
string soyad = "Ceylan Çelik";
int dogumYili = 1997;
long tcno = 12312312312;

//Console.WriteLine(mesaj);
//Console.WriteLine(tutar);


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
