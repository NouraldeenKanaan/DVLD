using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }


        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }
        private clsCountry(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }


        public static clsCountry FindByID(int CountryID)
        {
            string CountryName = "";

            if (clsCountriesData.GetCountryInfoByID(CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
        public static clsCountry FindByName(string CountryName)
        {
            int CountryID = -1;

            if (clsCountriesData.GetCountryInfoByName(CountryName, ref CountryID))
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

    }
}
