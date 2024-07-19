// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL \n Armut = 3TL \n Çilek = 2TL \n Muz = 3 TL \n Diğer Meyveler = 4 TL \n");
Console.WriteLine("Hangi Meyveyi satın almak istersiniz? Elma/Armut/Çilek/Muz/Diğer Meyveler");
string meyve = Console.ReadLine();
int fiyat = 0;

// if ile
if (meyve.ToLower() == "elma")
    fiyat = 2;
else if (meyve.ToLower() == "armut")
    fiyat = 3;
else if (meyve.ToLower() == "çilek")
    fiyat = 2;
else if (meyve.ToLower() == "muz")
    fiyat = 3;
else
    fiyat = 4;

// switch case ile
switch (meyve.ToLower())
{
    case "elma":
        fiyat = 2;
        break;
    case "armut":
        fiyat = 3;
        break;
    case "çilek":
        fiyat = 2;
        break;
    case "muz":
        fiyat = 3;
        break;
     default:
        fiyat=4;
        break;
}

Console.WriteLine("Seçtiğiniz meyvenin fiyatı " + fiyat + " TL'dir.");

/*
 İf-else mi yoksa switch case mi diye araştırma yaparken medium platformunda şöyle bir değerlendirmeye denk geldim.

"Kodların okunaklılığı bakımından bu iki deyimin farklılık sunması dışında aslında işleyişleri de farklıdır.
switch deyiminde koşul sadece bir defa sorgulanır ve sonrasında doğru case deyimine kadar değerlerle karşılaştırma yapılır. 
Oysa if deyiminden elseif deyimine geçildiği anda koşul bir kez daha sorgulanır ve sonrasında değer ile karşılaştırma yapılır."

Kaynak : https://medium.com/@timemrah/if-mi-switch-mi-d3359f74a0b9

bence de belirli bir liste üzerinde çalışacaksak switch case daha iyi,hızlı ve kolay okunur bir kullanım. 
Ama kullanıcı alışkanlığı olarak ben if else daha yatkınım.
 */


