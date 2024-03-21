#region AdatBeszerzés
using System.Linq;

List<City> cities = await FileService.ReadFromFileAsync("telepules.txt");
#endregion

/*  a) Melyik az a megyénk, amelynek a második legalacsonyabb a népessége? A megye nevét adja meg
    válaszként, a megyek.txt fájlban szereplő módon, majd tőle egy "-" jellel elválasztva a fájlban található
    adatok alapján a lakosok számát!
    Pl.: ha eredményül Veszprém megyét kapja és a lakosok száma 312670, akkor a beküldendő válasz:
    Veszprem - 312670
*/
List<City> citiesSmallToLargePopulation = cities.OrderBy(county => county.Population).ToList();


City cityWithSecondLeastPopulation = citiesSmallToLargePopulation.Skip(1).First();

Console.WriteLine("a)");
Console.WriteLine($"{cityWithSecondLeastPopulation.County}-{cityWithSecondLeastPopulation.Population}");

/*  b) Melyik a legészakibb település a telepules.txt fájl adatai szerint?
    Beküldendő a település neve a fájlban tárolt módon.
*/

City northermostCity = cities.MaxBy(city => city.Latitude);

Console.WriteLine("b)");
Console.WriteLine($"{northermostCity.CityName}");

/*  c) Hány olyan település van, amely Kecskemét és Szeged 50 km sugarú körzetében található?
    Tehát ha rajzolnánk a fájlban tárolt GPS koordináták alapján Kecskemét és Szeged köré is egy 50 km
    sugarú kört, akkor a település mindkét körön belül lenne. Beküldendő egy szám (a válasz a kérdésre)
*/

int citiesWithin50kmOfSzegedAndKecskemet = cities.Where(city => city.DistanceToKecskemet <= 50 && city.DistanceToSzeged <= 50).Count();

Console.WriteLine("c)");
Console.WriteLine($"{citiesWithin50kmOfSzegedAndKecskemet}");
Console.WriteLine();

/*  d) A 47.3 és 47.4 szélességi körök között, ha a hosszúsági koordináták szerint növekvő sorrendben
    haladunk a fájlban szereplő településeken keresztül, akkor az egymást követő települések
    területkülönbségei közül melyik a legnagyobb?
    A választ a két település nevének és területkülönbségnek a megadásával adja meg, az adatokat „-” jellel
    elválasztva! A területkülönbséget 2 tizedesjegyre kerekítve adja meg!
    Pl.: Ha az egymást követő települések nevei és területeik rendre: A - 123.12; B - 49.55; C - 32.1; D - 55.42
    A területkülönbségek: AB = 73.57; BC = 17.45; CD = 23.32 A válasz a két város neve és a legnagyobb
    különbség „-” jellel elválasztva: A - B - 73.57
*/


Console.WriteLine("d)");

/*  e) Sok olyan település van, amelynek nevében szerepel a buda szórészlet. A buda szórészletet
    tartalmazó települések közül melyik lesz a harmadik, ha nyugatról kelet felé haladunk? A kicsi és nagy
    betűk között ne tegyen különbséget! A település adatbázisban szereplő nevét adja meg!
*/


Console.WriteLine("e)");
List<City> citybyname = cities.Where(city => city.CityName.Contains("uda")).OrderBy(city => city.Longitude).ToList();
City cityvalami = citybyname.Skip(2).First();

Console.WriteLine($"{cityvalami.CityName}");

/*  f) Egy település nevéről annyit tudunk, hogy előfordulnak benne az alábbi sorrendben a következő
    betűk: a e t (A kis és nagybetűs változat is megfelelő.) A betűk között bármennyi más betű is
    szerepelhet, de a fenti 3 betűt ebben a sorrendben kell tartalmaznia a település nevének.
    Hány ilyen település található az adatforrásban? Beküldendő egy szám (a válasz a kérdésre).
*/

Console.WriteLine("f)");
