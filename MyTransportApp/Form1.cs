using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelUhrzeit.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            labelUhrzeit.Text = DateTime.Now.ToLongTimeString();
            labelDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void StartortSuchleiste1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VorschlagBox1.Items.Clear();
                Stations Vorschlag = transport.GetStations(StartortSuchleiste1.Text);

                foreach (Station station in Vorschlag.StationList)
                {
                    VorschlagBox1.Items.Add(station.Name);
                }
            }
            catch
            {

            }
        }

        private void ZielortSuchleiste_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VorschlagBox2.Items.Clear();
                Stations Vorschlag = transport.GetStations(ZielortSuchleiste.Text);

                foreach (Station station in Vorschlag.StationList)
                {
                    VorschlagBox2.Items.Add(station.Name);
                }
            }
            catch
            {

            }
        }

        private void SuchenButton1_Click(object sender, EventArgs e)
        {
            try
            {
                AusgabeFahrplan.Rows.Clear();
                var connections = transport.GetConnections(StartortSuchleiste1.Text, ZielortSuchleiste.Text);
                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    AusgabeFahrplan.Rows.Add(new String[]
                    {
                    connections.ConnectionList[i].From.Platform,
                    connections.ConnectionList[i].From.Departure.Value.ToString("HH:mm"),
                    connections.ConnectionList[i].To.Arrival.Value.ToString("HH:mm"),
                    connections.ConnectionList[i].Duration.Substring(4),
                    });
                }
            }
            catch
            {

            }
        }

        private void VorschlagBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartortSuchleiste1.Text = Convert.ToString(VorschlagBox1.SelectedItem);
        }

        private void VorschlagBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZielortSuchleiste.Text = Convert.ToString(VorschlagBox2.SelectedItem);
        }

        private void StartortSuchleiste2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VorschlagBox3.Items.Clear();
                List<Station> stationen = transport.GetStations(StartortSuchleiste2.Text + "*").StationList;

                foreach (Station station in stationen)
                {
                    VorschlagBox3.Items.Add(station.Name);
                }
            }
            catch
            {

            }
        }

        private void SuchenButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AusgabeAbfahrtstafel.Rows.Clear();
                AusgabeAbfahrtstafel.Refresh();
                List<StationBoard> Abfahrtstafel = transport.GetStationBoard(StartortSuchleiste2.Text, TimeTableID(StartortSuchleiste2.Text)).Entries;

                for (int i = 0; i < 12; i++)
                {
                    AusgabeAbfahrtstafel.Rows.Add(new string[]
                    {
                        Abfahrtstafel[i].Number.ToString(),
                        Abfahrtstafel[i].Stop.Departure.ToString("HH:mm") ?? "unbekant",
                        Abfahrtstafel[i].To.ToString()
                    });
                }
            }
            catch
            {

            }
        }

        private void VorschlagBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartortSuchleiste2.Text = VorschlagBox3.SelectedItem.ToString();
        }

        private string TimeTableID(string station)
        {
            return transport.GetStations(station).StationList[0].Id.ToString();
        }
    }
}
