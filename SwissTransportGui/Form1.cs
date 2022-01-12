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
        BindingList<List<string>> rootBoard = new();
        
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
                stationName.Text = transport.GetStationBoard(fromStation.Text, "id").Station.Name;
                ObjectToString stringList = new(transport.GetStationBoard(fromStation.Text, "id").Station.Name);                
                foreach(List<string> stationBoard in stringList.StationBoardString)
                {
                    rootBoard.Add(stationBoard);
                }
            }
            else if(string.IsNullOrEmpty(toStation.Text)&& string.IsNullOrEmpty(fromStation.Text))
            {
                stationName.Text = transport.GetStationBoard(fromStation.Text, "id").Station.Name;
                ObjectToString stringList = new(transport.GetStationBoard(fromStation.Text, "id").Station.Name, transport.GetStationBoard(toStation.Text, "id").Station.Name);
                foreach (List<string> rout in stringList.ConnectionString)
                {
                    rootBoard.Add(rout);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableConnections.DataSource = rootBoard;
        }
    }
}