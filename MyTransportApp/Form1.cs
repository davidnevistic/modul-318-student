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

        private void StartortSuchleiste1_TextChanged(object sender, EventArgs e)
        {
            VorschlagBox1.Items.Clear();
            Stations Vorschlag = transport.GetStations(StartortSuchleiste1.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                VorschlagBox1.Items.Add(station.Name);
            }
        }

        private void ZielortSuchleiste_TextChanged(object sender, EventArgs e)
        {
            VorschlagBox2.Items.Clear();
            Stations Vorschlag = transport.GetStations(ZielortSuchleiste.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                VorschlagBox2.Items.Add(station.Name);
            }
        }

        private void SuchenButton1_Click(object sender, EventArgs e)
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

        private void VorschlagBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartortSuchleiste1.Text = Convert.ToString(VorschlagBox1.SelectedItem);
        }

        private void VorschlagBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZielortSuchleiste.Text = Convert.ToString(VorschlagBox2.SelectedItem);
        }
    }
}
