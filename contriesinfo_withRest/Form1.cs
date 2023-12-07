using System.Text.Json;
using System.Windows.Forms;
 using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace contriesinfo_withRest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string nachbarstring(List<string> list)
        {
            string ausgabe = "";
            foreach (var item in list)
            {
                ausgabe += item + " ,";
            }
            return ausgabe;
        }
        private void resetbildschirm()
        {
            rtb_ausgabe.Text = "";
            pictureBox_flags.Image = null;
            pictureBox_arms.Image = null;
        }
        private void Bildzeigen(string pfad_falgs, string pfadArm)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                byte[] imageData = client.DownloadData(pfad_falgs); // Lade das Bild herunter
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                {
                    // Setze das Bild aus dem MemoryStream in die PictureBox
                    pictureBox_flags.Image = System.Drawing.Image.FromStream(ms);
                }
                imageData = client.DownloadData(pfadArm);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                {
                    // Setze das Bild aus dem MemoryStream in die PictureBox
                    pictureBox_arms.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }
        private async void btn_suche_Click(object sender, EventArgs e)
        {
            resetbildschirm();
            string land = tb_eingabe.Text;
            verbindungzuaPi(land);
            
        }
      
        private async void verbindungzuaPi(string eingabe)
        {
            string apiUr = $"https://restcountries.com/v3.1/name/{eingabe}?fullText=true";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUr);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JsonElement[] countries = JsonSerializer.Deserialize<JsonElement[]>(jsonResponse);
                    JsonElement country = countries[0];
                    Land land1 = new Land();
                    land1.Oficial_name = country.GetProperty("name").GetProperty("official").GetString();
                    JsonElement arr = country.GetProperty("capital");

                    foreach (JsonElement item in arr.EnumerateArray())
                    {
                        land1.Capital.Add(item.GetString());
                    }
                    JsonElement nachbaren = country.GetProperty("borders");
                    int j = 0;
                    foreach (JsonElement jsonElement in nachbaren.EnumerateArray())
                    {
                        land1.Nachbar.Add(jsonElement.GetString());
                    }
                    land1.Region = country.GetProperty("region").GetString();
                    land1.population = country.GetProperty("population").GetInt32();
                    land1.flags = country.GetProperty("flags").GetProperty("png").GetString();
                    land1.CoatArms = country.GetProperty("coatOfArms").GetProperty("png").GetString();
                    land1.Grose = country.GetProperty("area").GetDouble();
                    rtb_ausgabe.Text = $" Name :{land1.Oficial_name}\n Hauptstadt : {nachbarstring(land1.Capital)}\n Region :{land1.Region} \n Anzahlderbewohner :{land1.population} \n Gröse des Landes : {land1.Grose} \n Grenze mit : {nachbarstring(land1.Nachbar)} ";
                    Bildzeigen(land1.flags, land1.CoatArms);


                }
                else
                {
                    MessageBox.Show(" die angegeben name ist nicht richtig oder gibt es keine Land die so Heißt \n Versuchen sie ernuet");
                    tb_eingabe.Text = "";
                }
            }
        }
    }
}