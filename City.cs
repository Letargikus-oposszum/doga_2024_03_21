public class City
{
    /// <summary>
    /// <term>Település irányító száma</term>
    /// </summary>
    public int PostalCode { get; set; }

    /// <summary>
    /// <term>Vármegye rövidített neve</term>
    /// <br></br>
    /// <br>BK Bacs-Kiskun</br>
    /// <br>BE  Bekes</br>
    /// <br>BA Baranya</br>
    /// <br>BZ Borsod-Abauj-Zemplen</br>
    /// <br>BU Budapest</br>
    /// <br>CS  Csongrad</br>
    /// <br>FE Fejer</br>
    /// <br>GS Gyor-Moson-Sopron</br>
    /// <br>HB Hajdu-Bihar</br>
    /// <br>HE Heves</br>
    /// <br>JN Jasz-Nagykun-Szolnok</br>
    /// <br>KE Komarom-Esztergom</br>
    /// <br>NO Nograd</br>
    /// <br>PE Pest</br>
    /// <br>SO Somogy</br>
    /// <br>SZ Szabolcs-Szatmar-Bereg</br>
    /// <br>TO Tolna</br>
    /// <br>VA Vas</br>
    /// <br>VE Veszprem</br>
    /// <br>ZA Zala</br>
    /// </summary>
    public string County { get; set; }

    /// <summary>
    /// <term>Település szélességi GPS koordinátája</term>
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// <term>Település hosszúsági GPS koordinátája</term>
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// <term>Település területe (km²)</term>
    /// </summary>
    public double CitySize { get; set; }

    /// <summary>
    /// <term>Település lakosainak száma</term>
    /// </summary>
    public int Population {  get; set; }
    
    /// <summary>
    /// <term>Település neve</term>
    /// </summary>
    public string CityName { get; set; }
    
    /// <summary>
    /// <term>Település távolsága Kecskeméttől</term>
    /// </summary>
    public int DistanceToKecskemet { get; set; }
    
    /// <summary>
    /// <term>Település távolsága Szegedtől</term>
    /// </summary>
    public int DistanceToSzeged { get; set; }

    public City() { }

    public City(int postalCode, string county, double latitude, double longitude, double citySize, int population, string cityName, int distanceToKecskemet, int distanceToSzeged)
    {
        PostalCode = postalCode; //
        County = county; //
        Latitude = latitude; //
        Longitude = longitude; //
        CitySize = citySize; //
        Population = population; //
        CityName = cityName; //
        DistanceToKecskemet = distanceToKecskemet;
        DistanceToSzeged = distanceToSzeged;
    }

    public override string ToString()
    {
        return $"{County}-{CityName}({PostalCode}) [{Latitude};{Longitude}] is {CitySize}km² has a population of {Population} \nDistance To:\nKecskemét:{DistanceToKecskemet}\nSzeged:{DistanceToSzeged}";
    }
}
