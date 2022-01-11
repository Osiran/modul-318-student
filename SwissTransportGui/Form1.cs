using SwissTransport.Models;
using SwissTransport.Core;
using System.ComponentModel;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {
        BindingList<StationBoard> rootBoard = new();

        DataGridData dataGridData = new DataGridData();
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
            else
            {
                stationName = transport.GetStationBoard(fromStation, "id").Station.Name;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableConnections.DataSource = rootBoard;
        }
    }
}