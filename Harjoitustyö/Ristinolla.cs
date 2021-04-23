using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjoitustyö
{
    public partial class Ristinolla : Form
    {
        public List<Pelaaja> lista;


        int valittuRivi = -1;
        int vuoromaara = 0; //Lasketaan vuorot, peli loppuu viimeistään vuorolla 9
        bool vuoro = true; //Kumman vuoro? True = X
        public bool tietokone = false; //Tietokonepelaaja päällä vai ei?
        Graffat piirros; //Töhrätään laudalle (Älä poista vaikka turha, leikitään tällä lisää)
        public string pelaaja1, pelaaja2; //Pelaajanimet
        public int p1h, p2h; //Profiilin gridikorkeus listassa
        public int pelaaja1haviot, pelaaja1tasurit;
        public int pelaaja2haviot, pelaaja2tasurit;
        public bool skipataanko = false;
        Random rnd = new Random();
        public bool odotus = false;
        

        public Ristinolla()
        {
            InitializeComponent();
            if (File.Exists("c:\\temp\\pelaaja.xml"))
            {
                lista = DeserializeXML();
                dgvPelaajat.DataSource = lista;
            }
            else
            {
                lista = new List<Pelaaja>();
                var pelaaja = new Pelaaja();

                pelaaja.nimi = "Oletusprofiili";
                pelaaja.voitot = 0;
                pelaaja.haviot = 0;
                pelaaja.tasurit = 0;
                pelaaja.ai = false;
                lista.Add(pelaaja);
                SerializeXML(lista);
                dgvPelaajat.DataSource = null;
                dgvPelaajat.DataSource = lista;
            }
        }
        private void aloitusToolStripMenuItem_Click(object sender, EventArgs e)
        { } //Pysyköön tyhjänä
        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tehnyt: Niklos Kettunen"); //Hei sehän oon mä
        } //Test
        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Pistetään ohjelma kiinni
        private void säännötToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fi.wikipedia.org/wiki/Ristinolla");
        } //Säännötmenu
        private async void klikkaus(object sender, EventArgs e)
        {
            skipataanko = false;
            Panel b = (Panel)sender;
            if (pelaaja1 == null || pelaaja2 == null)
            {
                MessageBox.Show("Valitse pelaajat!");
                tabit_kaikki.SelectedTab = tab_profiilit;

            }
            else if (odotus == true)
            {

            }
            else
            {
                if (vuoro)
                {
                    // Pistetään X:n vuorolla X
                    b.Text = "X";
                    vuoromaara++;
                    b.Enabled = false;
                    vuoro = !vuoro; //Vaihetaan vuoro
                    Piirtaja(b);

                }

                else
                {
                    // Pistetään O:n vuorolla O 
                    b.Text = "O";
                    vuoromaara++;
                    b.Enabled = false;
                    vuoro = !vuoro; //Vaihetaan vuoro
                    Piirtaja(b);
                }
                if (tietokone == true)
                {
                    Tarkistus();
                    if (skipataanko == false)
                    {
                        odotus = true;
                        TimeSpan ts = new TimeSpan(0, 0, rnd.Next(1, 3));
                        AIaika(ts);
                        await Task.Delay(ts);
                        Panel aib = AIsiirto();
                        aib.Text = "O";
                        vuoromaara++;
                        aib.Enabled = false;
                        vuoro = !vuoro; //Vaihetaan vuoro
                        Piirtaja(aib);
                        odotus = false;
                        
                    }
                }
                ajastin.Stop();
                progbar_ai.Value = 0;
                Application.UseWaitCursor = false;
                Tarkistus();
            }
        } //Mitä tapahtuu, kun klikataan
        private void Tarkistus() 
        {
            if (
                A1.Text == "X" && A2.Text == "X" && A3.Text == "X" ||
                B1.Text == "X" && B2.Text == "X" && B3.Text == "X" ||
                C1.Text == "X" && C2.Text == "X" && C3.Text == "X" ||
                A1.Text == "X" && B1.Text == "X" && C1.Text == "X" ||
                A2.Text == "X" && B2.Text == "X" && C2.Text == "X" ||
                A3.Text == "X" && B3.Text == "X" && C3.Text == "X" ||
                A1.Text == "X" && B2.Text == "X" && C3.Text == "X" ||
                A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                MessageBox.Show(pelaaja1+" voitti");
                X_Voitot.Text = (Int32.Parse(X_Voitot.Text) + 1).ToString();


                lista[p1h].Voitot++;
                lista[p2h].Haviot++;


                Peliohi();
            }
            else if (
                A1.Text == "O" && A2.Text == "O" && A3.Text == "O" ||
                B1.Text == "O" && B2.Text == "O" && B3.Text == "O" ||
                C1.Text == "O" && C2.Text == "O" && C3.Text == "O" ||
                A1.Text == "O" && B1.Text == "O" && C1.Text == "O" ||
                A2.Text == "O" && B2.Text == "O" && C2.Text == "O" ||
                A3.Text == "O" && B3.Text == "O" && C3.Text == "O" ||
                A1.Text == "O" && B2.Text == "O" && C3.Text == "O" ||
                A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
            {
                MessageBox.Show(pelaaja2 + " voitti");
                O_Voitot.Text = (Int32.Parse(O_Voitot.Text) + 1).ToString();


                lista[p2h].Voitot++;
                lista[p1h].Haviot++;


                Peliohi();
            }
            else if (vuoromaara == 9)
            {
                MessageBox.Show("Ei voittajia, kaikki hävisi");
                Tasurimaara.Text = (Int32.Parse(Tasurimaara.Text) + 1).ToString();


                lista[p1h].Tasurit++;
                lista[p2h].Tasurit++;


                Peliohi();
            }
            if (vuoro)
            {
                label_x.ForeColor = Color.Green;
                label_o.ForeColor = Color.Black;
            }
            else
            {
                label_o.ForeColor = Color.Green;
                label_x.ForeColor = Color.Black;
            }
        } //Tarkistetaan voitto/tasuri tilanne
        private void AIaika(TimeSpan ts)
        {
            Application.UseWaitCursor = true;
            ajastin.Enabled = true; // Enable the timer.
            ajastin.Start();//Start it
            int intervaali = Convert.ToInt32(ts.TotalMilliseconds);
            intervaali = (intervaali / 3);

            ajastin.Interval = intervaali; // The time per tick.

            progbar_ai.Maximum = 3;
            ajastin.Tick += new EventHandler(ajastin_Tick);
        } //Älytön tekoäly
        public Panel AIsiirto() //AI siirtojen "logiikka"
        { //Ensin yritetään voittaa tietyillä tapaa
            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "") //Vaaka1
                return A3;
            else if (B1.Text == "O" && B2.Text == "O" && B3.Text == "") //Vaaka2
                return B3;
            else if (C1.Text == "O" && C2.Text == "O" && C3.Text == "") //Vaaka3
                return C3;
            else if (A1.Text == "O" && B1.Text == "O" && C1.Text == "") //Pysty1
                return C1;
            else if (A2.Text == "O" && B2.Text == "O" && C2.Text == "") //Pysty2
                return C2;
            else if (A3.Text == "O" && B3.Text == "O" && C3.Text == "") //Pysty3
                return C3;
            else if (A1.Text == "O" && B2.Text == "O" && C3.Text == "") //Ristiin A1:stä
                return C3;
            else if (A3.Text == "O" && B2.Text == "O" && C1.Text == "") //Ristiin A3:sta
                return C1;
            //Nyt yritetään estää vastustajan voitto
            else if (A1.Text == "X" && A2.Text == "X" && A3.Text == "")
                return A3;
            else if (B1.Text == "X" && B2.Text == "X" && B3.Text == "")
                return B3;
            else if (C1.Text == "X" && C2.Text == "X" && C3.Text == "")
                return C3;
            else if (A1.Text == "X" && B1.Text == "X" && C1.Text == "")
                return C1;
            else if (A2.Text == "X" && B2.Text == "X" && C2.Text == "")
                return C2;
            else if (A3.Text == "X" && B3.Text == "X" && C3.Text == "")
                return C3;
            else if (A1.Text == "X" && B2.Text == "X" && C3.Text == "")
                return C3;
            else if (A3.Text == "X" && B2.Text == "X" && C1.Text == "")
                return C1;
            //Jos ei osata tehä mitään ylläolevista, niin etitään tyhjä reunapaikka
            else if (A1.Text == "")
                return A1;
            else if (A2.Text == "")
                return A2;
            else if (A3.Text == "")
                return A3;
            else if (B1.Text == "")
                return B1;
            else if (B3.Text == "")
                return B3;
            else if (C1.Text == "")
                return C1;
            else if (C2.Text == "")
                return C2;
            else if (C3.Text == "")
                return C3;
            else //Pelkkä keskipaikka vapaa? No sinne siis
                return B2;


        } //AI tekee siirron
        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odotus == false)
            {
                Peliohi();
            }
            else
            {
                MessageBox.Show("Etkai sä yritä rikkoa tätä?");
            }
        } //Uusi peli
        private void Peliohi()
        {
            A1.Enabled = true;
            A1.Text = "";
            A1.Refresh();

            A2.Enabled = true;
            A2.Text = "";
            A2.Refresh();

            A3.Enabled = true;
            A3.Text = "";
            A3.Refresh();

            B1.Enabled = true;
            B1.Text = "";
            B1.Refresh();

            B2.Enabled = true;
            B2.Text = "";
            B2.Refresh();

            B3.Enabled = true;
            B3.Text = "";
            B3.Refresh();

            C1.Enabled = true;
            C1.Text = "";
            C1.Refresh();

            C2.Enabled = true;
            C2.Text = "";
            C2.Refresh();

            C3.Enabled = true;
            C3.Text = "";
            C3.Refresh();

            vuoro = true;
            vuoromaara = 0;
            skipataanko = true;
            label_x.ForeColor = Color.Green;
            label_o.ForeColor = Color.Black;
            Tallennus();
            
        } //Palautetaan napit alkutilaan
        private void Tallennus() //Tallennetaan pisteet
        {
            SerializeXML(lista);
            dgvPelaajat.DataSource = null;
            dgvPelaajat.DataSource = lista;

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics toPass = A1.CreateGraphics();
            piirros = new Graffat(toPass);
        } //(((VANHA & TURHA GRAFFOJEN HARJOTTELUJUTSQ)))
        private void bt_tallenna_Click(object sender, EventArgs e)
        {
            try
            {
                var pelaaja = new Pelaaja();
                pelaaja.nimi = tb_uusinimi.Text;
                pelaaja.voitot = 0;
                pelaaja.haviot = 0;
                pelaaja.tasurit = 0;
                pelaaja.ai = cbox_tietokoneohjaus.Checked;

                lista.Add(pelaaja);
                SerializeXML(lista);
                dgvPelaajat.DataSource = null;
                dgvPelaajat.DataSource = lista;
                tb_uusinimi.Text = "";
                cbox_tietokoneohjaus.CheckState = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Profiililista alustettu, avataan valikko uudelleen"); //Vanha catchi, ei tarpeen
            }
        }
        private void btn_poista_Click(object sender, EventArgs e)
        {
            try
            {
                valittuRivi = dgvPelaajat.CurrentRow.Index;
                lista.RemoveAt(valittuRivi);
                SerializeXML(lista);
                dgvPelaajat.DataSource = null;
                dgvPelaajat.DataSource = lista;
            }
            catch (Exception) //Miten tää ei toimi?
            {
                MessageBox.Show("Ei mitään poistettavaa");
            }
        }
        private void btn_valitse_1_Click(object sender, EventArgs e)
        {
            string aicheck = Convert.ToString(dgvPelaajat.CurrentRow.Cells[4].Value);

            if (aicheck == "True")
            {
                MessageBox.Show("Vain pelaaja 2 voi olla tietokone.");
            }
            else if (Convert.ToString(dgvPelaajat.CurrentRow.Cells[0].Value) == pelaaja2)
            {
                MessageBox.Show("Et voi valita kahdesti samaa profiilia.");
            }
            else //Mennään peliin, viedään pelaaja 1
            {
                pelaaja1 = Convert.ToString(dgvPelaajat.CurrentRow.Cells[0].Value);
                p1h = dgvPelaajat.CurrentRow.Index; //Otetaan korkeus ylös
                MessageBox.Show("Valittu : " + pelaaja1);
                tb_pelaaja1.Text = pelaaja1;
            }
            Peliohi();
        }
        private void btn_valitse_2_Click(object sender, EventArgs e)
        {
            string aicheck = Convert.ToString(dgvPelaajat.CurrentRow.Cells[4].Value);
            if (Convert.ToString(dgvPelaajat.CurrentRow.Cells[0].Value) == pelaaja1)
            {
                MessageBox.Show("Et voi valita kahdesti samaa profiilia.");
            }
            else 
            { 
                if (aicheck == "True") //Mennään peliin, viedään pelaaja 2 + AI päälle
                {
                    tietokone = true;
                    pelaaja2 = Convert.ToString(dgvPelaajat.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Valittu : " + pelaaja2 + "\nTietokonepelaaja");
                    tb_pelaaja2.Text = pelaaja2;
                    
                    p2h = dgvPelaajat.CurrentRow.Index; //Otetaan korkeus ylös
                }
                else //Mennään peliin, viedään pelaaja 2
                {
                    pelaaja2 = Convert.ToString(dgvPelaajat.CurrentRow.Cells[0].Value);
                    tietokone = false;
                    MessageBox.Show("Valittu : " + pelaaja2);
                    tb_pelaaja2.Text = pelaaja2;
                    
                    p2h = dgvPelaajat.CurrentRow.Index; //Otetaan korkeus ylös
            }
        }
            Peliohi();
        }
        private void tabit_kaikki_TabIndexChanged(object sender, EventArgs e)
        {
            tb_pelaaja1.Text = pelaaja1;
            tb_pelaaja2.Text = pelaaja2;
            if (File.Exists("c:\\temp\\pelaaja.xml"))
            {
                lista = DeserializeXML();
                dgvPelaajat.DataSource = lista;
                
                X_Voitot.Text = Convert.ToString(lista[p1h].Voitot);
                O_Voitot.Text = Convert.ToString(lista[p2h].Voitot);
            }
        }
        private void ajastin_Tick(object sender, EventArgs e)
        {
            if (progbar_ai.Value != 2)
            {
                progbar_ai.Value++;
            }
            else
            {

            }
        }
        private void tabit_kaikki_Click(object sender, EventArgs e)
        {
            tb_pelaaja1.Text = pelaaja1;
            tb_pelaaja2.Text = pelaaja2;
            if (File.Exists("c:\\temp\\pelaaja.xml"))
            {
                lista = DeserializeXML();
                dgvPelaajat.DataSource = lista;

                X_Voitot.Text = Convert.ToString(lista[p1h].Voitot);
                O_Voitot.Text = Convert.ToString(lista[p2h].Voitot);
            }
            if (pelaaja1 == null || pelaaja2 == null)
            {
                X_Voitot.Text = "0";
                O_Voitot.Text = "0";
            }
        }
        private void Piirtaja(Panel b) //Piirretään X ja O ruutuihin
        {
            Graphics g = b.CreateGraphics();
            Pen p = new Pen(Color.Black);
            if (vuoro == false)
            {
                g.DrawLine(p, 1, 1, 99, 99);
                g.DrawLine(p, 1, 99, 99, 0);
            }
            else
            {
                g.DrawEllipse(p, 1, 1, 98, 98);
            }
        }
        public List<Pelaaja> DeserializeXML() //Tehtävän 5 tyyliin
        {
            if (File.Exists("c:\\temp\\pelaaja.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\pelaaja.xml");
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Pelaaja>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<Pelaaja>)obj;
            }
            else
                return null;
        }
        public void SerializeXML(List<Pelaaja> input) //Tehtävän 5 tyyliin
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\pelaaja.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }
    }
}
