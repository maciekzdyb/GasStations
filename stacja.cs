using System;

namespace _3CityPetrol
{
    class stacja
    {
        public int id;
        public string nazwa;
        public string adres;
        public double cena95;
        public double cenad;
        public double lat;
        public double lon;
        //public string open_time;
        //public string close_time;

        public stacja(int iid, string inazwa, string iadres, string icena95, string icenad, string ilat, string ilon)
        {
            this.id = iid;
            this.nazwa = inazwa;
            this.adres = iadres;
            this.cena95 = Convert.ToDouble(icena95, new System.Globalization.NumberFormatInfo());
            this.cenad = Convert.ToDouble(icenad, new System.Globalization.NumberFormatInfo());
            this.lat = Convert.ToDouble(ilat, new System.Globalization.NumberFormatInfo());
            this.lon = Convert.ToDouble(ilon, new System.Globalization.NumberFormatInfo());
        }

    }
}
