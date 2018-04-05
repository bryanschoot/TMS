namespace TMS.Model
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public AddressModel(int id, string streetName, string streetNumber, string zipCode, string cityName, string counrtyName)
        {
            this.Id = id;
            this.StreetName = streetName;
            this.StreetNumber = streetNumber;
            this.ZipCode = zipCode;
            this.CityName = cityName;
            this.CountryName = counrtyName;
        }
        public override string ToString()
        {
            return $"{Id}\n{StreetName} : {StreetNumber}\n{CityName} : {ZipCode}\n{CountryName}";
        }
    }
}