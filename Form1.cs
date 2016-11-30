using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3CityPetrol
{

    public partial class Form1 : Form
    {
        List<stacja> listaStacji = new List<stacja>();
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMapOverlay routesOverlay = new GMapOverlay("routes");

        public Form1()
        {
            InitializeComponent();
            getDatabese();
            fillComboBoxGasName();
        }

        private void getDatabese()
        {
            listaStacji.Clear();
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename=|DataDirectory|\GasDatabase.mdf;
                    Database=Stacje;
                    Integrated Security=True;
                    Connect Timeout=30";

            SqlConnection con = new SqlConnection(sqlCon);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Stacje;", con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                       listaStacji.Add(new stacja(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                                    reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                    }
                }
                else
                {
                    MessageBox.Show("No rows found");
                }
                
                reader.Close();
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();  //zarządzanie wyjątkami - zwolnienie zasobu połączenia z bazą danych
            }
        }

        private void fillComboBoxGasName()
        {
            comboBoxGasName.Items.Clear();
            List<string> stacje = new List<string>();
            foreach (stacja s in listaStacji)
            {
                stacje.Add(s.nazwa);
            }
            IEnumerable<string> marka = stacje.Distinct();
           
            foreach(string s in marka)
            {
                comboBoxGasName.Items.Add(s);
            }
            
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            switch (comboBoxProvider.Text)
            {
                case "Google":
                    gmap.MapProvider = GoogleMapProvider.Instance;
                    break;
                case "Bing":
                    gmap.MapProvider = BingMapProvider.Instance;
                    break;
                case "OpenStreet":
                    gmap.MapProvider = OpenStreetMapProvider.Instance;
                    break;
                default:
                    gmap.MapProvider = GoogleMapProvider.Instance;
                    break;
            }            
            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(54.3442815, 18.7187827);
            gmap.Zoom = 10;
            gmap.DragButton = MouseButtons.Left;
        }

        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat=0, lng=0;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            }
            if (textBoxLatStart.Text == "")
            {
                textBoxLatStart.Text = lat.ToString();
                textBoxLonStart.Text = lng.ToString();
                textBoxLon.Text = lat.ToString();
                textBoxLat.Text = lng.ToString();
            }
            else
            {
                textBoxLatStop.Text = lat.ToString();
                textBoxLonStop.Text = lng.ToString(); 
            }
            
        }

        private void gmap_OnMarkerLeave(GMapMarker item)
        {

        }

        private void gmap_OnMarkerEnter(GMapMarker item)
        {
            string source = item.ToolTipText;
            string[] result;
            result = source.Split(new string[] {"\r\n","\n"},StringSplitOptions.None);
            textBoxNazwa.Text = result[0];
            textBoxAdress.Text = result[1];
            string[] result1 = result[2].Split(new char[] { ' ' });
            result1[3] = result1[3].Replace(",", ".");
            textBoxCena95.Text = result1[3];
            string[] result2 = result[3].Split(new char[] { ' ' });
            result2[3] = result2[3].Replace(",", ".");
            textBoxCenaD.Text = result2[3];
            string lat = item.Position.Lat.ToString();
            lat = lat.Replace(",", ".");
            textBoxLat.Text = lat;
            string lon = item.Position.Lng.ToString();
            lon = lon.Replace(",", ".");
            textBoxLon.Text = lon;
        }

        

        private void btnAllStations_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listaStacji.Count().ToString());   
            foreach (stacja s in listaStacji)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(s.lat, s.lon), GMarkerGoogleType.green_small);
                marker.Position = new PointLatLng(s.lat, s.lon);
                marker.ToolTipText = s.nazwa+ "\n"+s.adres+ "\n cena E95: "+s.cena95 + "\n cena Diesel: "+s.cenad;
                //marker.IsVisible = true;
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
                //gmap.Update();
                //MessageBox.Show(s.nazwa);
            }
        }
        private void btnSelectnazwa_Click(object sender, EventArgs e)
        {
            var result = from i in listaStacji
                         where i.nazwa == comboBoxGasName.SelectedItem.ToString()
                         select i;
            markersOverlay.Clear();
            foreach (stacja s in result)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(s.lat, s.lon), GMarkerGoogleType.green_small);
                marker.Position = new PointLatLng(s.lat, s.lon);
                marker.ToolTipText = s.nazwa;
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            markersOverlay.Clear();
            routesOverlay.Clear();
        }
        
        private void btnClearLatLon_Click(object sender, EventArgs e)
        {
            textBoxLatStart.Clear();
            textBoxLonStart.Clear();
            textBoxLatStop.Clear();
            textBoxLonStop.Clear();
            textBoxDystans.Clear();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            markersOverlay.Clear();
            if (checkBoxStacja.Checked)
            {
                double slat, slon, elat, elon,dist = 500;
                stacja najbl = listaStacji[0];
     
                slat = Convert.ToDouble(textBoxLatStart.Text);
                slon = Convert.ToDouble(textBoxLonStart.Text);
                PointLatLng start = new PointLatLng(slat, slon);
                foreach (stacja s in listaStacji)
                {
                    elat = s.lat;
                    elon = s.lon;
                    
                    PointLatLng end = new PointLatLng(elat, elon);
                    MapRoute route = OpenStreetMapProvider.Instance.GetRoute(start, end, false, false, 10);
                    if (dist > route.Distance)
                    {
                        najbl = s;
                        dist = route.Distance;
                    }
                }
                PointLatLng end0 = new PointLatLng(najbl.lat, najbl.lon);
                MapRoute route0 = OpenStreetMapProvider.Instance.GetRoute(start, end0, false, false, 10);
                GMapRoute r = new GMapRoute(route0.Points, "My route");
                r.Stroke.Width = 4;
                r.Stroke.Color = Color.Red;
                routesOverlay.Routes.Add(r);
                gmap.Overlays.Add(routesOverlay);

                gmap.Zoom = 12;
                double distance;
                distance = Math.Round(route0.Distance, 2);
                textBoxDystans.Text = distance.ToString();
                gmap.Update();
                gmap.Zoom = 10;

                markersOverlay.Clear();
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(najbl.lat,najbl.lon), GMarkerGoogleType.red);
                marker.Position = new PointLatLng(najbl.lat, najbl.lon);
                marker.ToolTipText = najbl.nazwa + "\n" + najbl.adres + "\n cena E95: " + najbl.cena95 + "\n cena Diesel: " + najbl.cenad;
                //marker.IsVisible = true;
                gmap.Overlays.Add(markersOverlay);
                markersOverlay.Markers.Add(marker);
               // gmap.ReloadMap();
            }
            else
            {
                double slat, slon, elat, elon;
                slat = Convert.ToDouble(textBoxLatStart.Text);
                slon = Convert.ToDouble(textBoxLonStart.Text);
                elat = Convert.ToDouble(textBoxLatStop.Text);
                elon = Convert.ToDouble(textBoxLonStop.Text);
                PointLatLng start = new PointLatLng(slat, slon);
                PointLatLng end = new PointLatLng(elat, elon);
                MapRoute route = OpenStreetMapProvider.Instance.GetRoute(start, end, false, false, 10);
                /*
                string start = "Niepodległości 370, Sopot, Polska";
                string end = "Kołobrzeska 31, Gdańsk, Polska";
                MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(
                  start, end, false, false, 10);
                */
                GMapRoute r = new GMapRoute(route.Points, "My route");
                r.Stroke.Width = 4;
                r.Stroke.Color = Color.Green;
                routesOverlay.Routes.Add(r);
                gmap.Overlays.Add(routesOverlay);
                gmap.Zoom = 12;
                double distance;
                distance = Math.Round(route.Distance, 2);
                textBoxDystans.Text = distance.ToString();
                gmap.Update();
                gmap.Zoom = 10;
            }
        }

        private void btnChangeProvider_Click(object sender, EventArgs e)
        {
            gmap_Load(sender,e);
        }

        private void btnDodajStacje_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename=|DataDirectory|\GasDatabase.mdf;
                    Database=Stacje;
                    Integrated Security=True;
                    Connect Timeout=30"))
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [Stacje] (nazwa, adres, cena95, cenad,lat,lon) VALUES (@Name, @adress, @e95, @d, @lat, @lon)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", textBoxNazwa.Text);
                CmdSql.Parameters.AddWithValue("@adress", textBoxAdress.Text);
                CmdSql.Parameters.AddWithValue("@e95", textBoxCena95.Text);
                CmdSql.Parameters.AddWithValue("@d", textBoxCenaD.Text);
                CmdSql.Parameters.AddWithValue("@lat", textBoxLat.Text);
                CmdSql.Parameters.AddWithValue("@lon", textBoxLon.Text);
                CmdSql.ExecuteNonQuery();
                //conn.Close();
                markersOverlay.Clear();
                routesOverlay.Clear();
                getDatabese();
                fillComboBoxGasName();
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            textBoxNazwa.Clear();
            textBoxAdress.Clear();
            textBoxCena95.Clear();
            textBoxCenaD.Clear();
            textBoxLat.Clear();
            textBoxLon.Clear();
        }

        private void btnUsunStacje_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename=|DataDirectory|\GasDatabase.mdf;
                    Database=Stacje;
                    Integrated Security=True;
                    Connect Timeout=30"))
            {
                SqlCommand CmdSql = new SqlCommand("DELETE FROM [Stacje] WHERE (nazwa = @Name AND  adres = @adress)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", textBoxNazwa.Text.ToString());
                CmdSql.Parameters.AddWithValue("@adress", textBoxAdress.Text.ToString());
                CmdSql.ExecuteNonQuery();

                //conn.Close();
                markersOverlay.Clear();
                routesOverlay.Clear();
                getDatabese();
                fillComboBoxGasName();
            }
        }

        private void comboBoxGasName_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Focus();
        }

        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Focus();
        }

        private void btnUaktualnij_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename=|DataDirectory|\GasDatabase.mdf;
                    Database=Stacje;
                    Integrated Security=True;
                    Connect Timeout=30"))
            {
                SqlCommand CmdSql = new SqlCommand("UPDATE [Stacje] SET cena95 = @e95, cenad = @d WHERE (nazwa = @Name AND  adres = @adress)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", textBoxNazwa.Text.ToString());
                CmdSql.Parameters.AddWithValue("@adress", textBoxAdress.Text.ToString());
                CmdSql.Parameters.AddWithValue("@e95", textBoxCena95.Text);
                CmdSql.Parameters.AddWithValue("@d", textBoxCenaD.Text);
                CmdSql.Parameters.AddWithValue("@lat", textBoxLat.Text);
                CmdSql.Parameters.AddWithValue("@lon", textBoxLon.Text);
                CmdSql.ExecuteNonQuery();

                //conn.Close();
                markersOverlay.Clear();
                routesOverlay.Clear();
                getDatabese();
                fillComboBoxGasName();
            }
        }
    }
}
