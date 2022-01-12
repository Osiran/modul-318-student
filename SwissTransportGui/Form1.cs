using SwissTransport.Models;
using SwissTransport.Core;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {
               
        ITransport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fromStation.Text))
            {
                
            }
            else if(string.IsNullOrEmpty(toStation.Text))
            {
                clearInfo();
                tableConnections.ColumnCount = 6;
                tableConnections.ColumnHeadersVisible = true;
                tableConnections.Columns[0].Name = "Zug Name";
                tableConnections.Columns[1].Name = "Kategory";
                tableConnections.Columns[2].Name = "Nach";
                tableConnections.Columns[3].Name = "Zug Nummer";
                tableConnections.Columns[4].Name = "Firma";
                tableConnections.Columns[5].Name = "Abfahrt";

                stationName.Text = transport.GetStationBoard(fromStation.Text, "id").Station.Name;
                ObjectToString stringList = new(transport.GetStationBoard(fromStation.Text, "id").Station.Name);                
                foreach(List<string> stationBoard in stringList.StationBoardString)
                {

                    tableConnections.Rows.Add(stationBoard.ToArray());
                }
            }
            else if(!string.IsNullOrEmpty(toStation.Text)&& !string.IsNullOrEmpty(fromStation.Text))
            {
                clearInfo();
                tableConnections.ColumnCount = 5;
                tableConnections.ColumnHeadersVisible = true;
                tableConnections.Columns[0].Name = "Ankunft";
                tableConnections.Columns[1].Name = "verspätung";
                tableConnections.Columns[2].Name = "Abfahrt";
                tableConnections.Columns[3].Name = "Gleis";
                tableConnections.Columns[4].Name = "ReiseZeit";

                stationName.Text = transport.GetStationBoard(fromStation.Text, "id").Station.Name;
                arrivalName.Text = transport.GetStationBoard(toStation.Text, "id").Station.Name;
                ObjectToString stringList = new(transport.GetStationBoard(fromStation.Text, "id").Station.Name, transport.GetStationBoard(toStation.Text, "id").Station.Name);
                foreach (List<string> rout in stringList.ConnectionString)
                {
                    tableConnections.Rows.Add(rout.ToArray());
                }
            }

        }

        private void clearInfo()
        {
            stationName.Text = "";
            arrivalName.Text = "";
            tableConnections.Rows.Clear();
            tableConnections.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}