using SwissTransport.Models;
using SwissTransport.Core;
using System.Collections.Generic;

namespace SwissTransportGui
{
    internal class ObjectToString
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
        private string duration = "";
        
       
        private int mode = 0;
        
        ITransport transport = new Transport();
        private List<List<string>> returnList = new List<List<string>>() { };
        private List<string> stationBoardString = new List<string>() { };
        private List<string> connectionString = new List<string>() { };
        
        public ObjectToString(string fromStation)
        {
            this.fromStation = fromStation;
            toStation = "";
        }
        public ObjectToString(string fromStation, string toStation)
        {
            this.fromStation = fromStation;
            this.toStation = toStation;
        }
        void CreateStationTableList()
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
                stationBoardString.Add(trainName);
                stationBoardString.Add(category);
                stationBoardString.Add(toStation);
                stationBoardString.Add(trainNumber);
                stationBoardString.Add(firm);
                stationBoardString.Add(departure);
                returnList.Add(stationBoardString);
                stationBoardString.Clear();
            }

            
        }
        void CreateConnectionTableList()
        {
            if(string.IsNullOrEmpty(toStation))
            {
                CreateStationTableList();
            }else {
                var rout = transport.GetConnections(fromStation, toStation).ConnectionList;
            foreach (var connection in rout)
                {
                    arrival = connection.To.Arrival.Value.ToString("hh:mm");
                    delay = connection.To.Delay.Value.ToString();
                    departure = connection.From.ToString();
                    platform = connection.From.Platform.ToString();
                    duration = connection.Duration.ToString();
                    connectionString.Add(arrival);
                    connectionString.Add(delay);
                    connectionString.Add(departure);
                    connectionString.Add(platform);
                    connectionString.Add(duration);
                    returnList.Add(connectionString);
                    connectionString.Clear();
                }

            }
            

        }
        public List<List<string>> StationBoardString
        {
            get {
                CreateStationTableList();
                return returnList; 
            }            
        }
        public List<List<string>> ConnectionString {
            get
            {
                CreateConnectionTableList();
                return returnList;
            }            
        }
    
    }
} 