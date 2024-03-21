using System.Text;
using System.Globalization;


public class FileService
{
    public static async Task<List<City>> ReadFromFileAsync(string fileName)
    {
        List<City> cities = new List<City>();
        City city = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split(" ");

            city = new City();

            city.PostalCode = int.Parse(data[0]);
            city.County = data[1];
            city.Latitude = double.Parse(data[2], new CultureInfo("en-EN"));
            city.Longitude = double.Parse(data[3], new CultureInfo("en-EN"));
            city.CitySize = double.Parse(data[4], new CultureInfo("en-EN"));
            city.Population = int.Parse(data[5]);
            city.CityName = data[6];
            city.DistanceToKecskemet = int.Parse(data[7]);

            cities.Add(city);
        }

        return cities;
    }

    public static async Task WriteToFileAsync(string fileName, ICollection<City> cities)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (City city in cities)
        {
            await sw.WriteLineAsync($"{city}");
        }
    }
}
