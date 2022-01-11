using SwissTransport.Models;
using SwissTransport.Core;
using System;

namespace SwissTransportGui
{
    internal class DataGridData
    {
        private string toStation = "";
        private string fromStation = "";

        private string category = "";
        private string trainName = "";
        private string trainNumber = "";
        private string firm = "";
        private string departure = "";

        private string arrival = "";       
        private string delay = "";        
        private string platform = "";
        
       
        private int mode = 0;
        
        ITransport transport = new Transport();

        public DataGridData(string fromStation)
        {
            this.fromStation = fromStation;
            toStation = "";
            stationTable();
        }
        public DataGridData(string fromStation, string toStation)
        {
            this.fromStation = fromStation;
            this.toStation = toStation;
        }
        void stationTable()
        {


            var root = transport.GetStationBoard(fromStation, "id");
            foreach (var stationBoard in root.Entries)
            {
                trainName = stationBoard.Name;
                category = stationBoard.Category;
                toStation = stationBoard.To;
                trainNumber = stationBoard.Number;
                firm = stationBoard.Operator;
                departure = stationBoard.Stop.Departure.ToString("hh:mm");
                
            }
        }
        void connectionTable()
        {


            var rout = transport.GetConnections(fromStation, toStation).ConnectionList;
            foreach (var connection in rout)
            {
                arrival = connection.To.Arrival.Value.ToString("hh:mm");
                delay = connection.To.Delay.Value.ToString();
                departure = connection.From.ToString();
                platform = connection.From.Platform.ToString();


                
            }
        }

    }
}