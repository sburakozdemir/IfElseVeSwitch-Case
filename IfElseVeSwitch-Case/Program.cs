using System.Linq.Expressions;

Console.WriteLine("Rüya Manavına Hoşgeldiniz");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL ");
Console.WriteLine("Diğer Bütün Meyveler 4 TL  \n");

Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diger) ");

string StrÜrün=Console.ReadLine()!.ToLower();
// Switch-case ile programın yapımı
switch(StrÜrün)
    {
    case "elma":
        Console.WriteLine("Seçtiğiniz ürünün fiyatı 2 TL");
            break;

    case "armut":
        Console.WriteLine("Seçtiğiniz ürünün fiyatı 3 TL");
        break;

    case "çilek":
        Console.WriteLine("Seçtiğiniz ürünün fiyatı 2 TL");
        break;

    case "muz":
        Console.WriteLine("Seçtiğiniz ürünün fiyatı 3 TL");
        break;

    case "diger":
        Console.WriteLine("Seçtiğiniz ürünün fiyatı 4 TL");
        break;

    default:

        Console.WriteLine("Hatalı bir giriş yaptınız");
        break;
}

//İf-Else ile Programın Yapımı

if (StrÜrün == "elma")

{
    Console.WriteLine("Seçtiğiniz ürünün fiyatı 2 TL");
}
else if (StrÜrün == "armut")
{
    Console.WriteLine("Seçtiğiniz ürünün fiyatı 3 TL");
}
else if (StrÜrün == "çilek")
{
    Console.WriteLine("Seçtiğiniz ürünün fiyatı 2 TL");
}

else if (StrÜrün == "muz")
{
    Console.WriteLine("Seçtiğiniz ürünün fiyatı 3 TL");
}

else
{
    Console.WriteLine("Hatalı bir giriş yaptınız");
}

//Bana kalırsa Switch-Case ile bu programın yapımı hem daha basit hemde sornadan okuyan biri için anlaması daha kolay bu yüzden tercihim Switch-Case ' den yana