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
               
        ITransport transport = new Transport();
        private List<List<string>> returnList = new List<List<string>>() { };
       
                
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

                List<string> stationBoardString = new List<string>();

                stationBoardString.Add(trainName);
                stationBoardString.Add(category);
                stationBoardString.Add(toStation);
                stationBoardString.Add(trainNumber);
                stationBoardString.Add(firm);
                stationBoardString.Add(departure);

                returnList.Add(stationBoardString);
                
            }

            
        }
        void CreateConnectionTableList()
        {
            if(string.IsNullOrEmpty(toStation))
            {
                CreateStationTableList();
            }else if(transport.GetConnections(fromStation, toStation).ConnectionList.Count>0) {
                var rout = transport.GetConnections(fromStation, toStation).ConnectionList;
            foreach (var connection in rout)
                {
                    if (connection.To.Arrival.HasValue) 
                    {
                        arrival = connection.To.Arrival.Value.ToString("HH:mm"); 
                    }
                    if (connection.To.Delay.HasValue) 
                    { 
                        delay = connection.To.Delay.Value.ToString();
                    }
                    if (connection.From.Departure.HasValue) 
                    { 
                        departure = connection.From.Departure.Value.ToString("HH:mm");
                    }
                    if (connection.From.Platform != null) 
                    { 
                        platform = connection.From.Platform.ToString();
                    }
                    
                    duration = connection.Duration;
                    List<string> connectionString = new List<string>() { };
                    connectionString.Add(arrival);
                    connectionString.Add(delay);
                    connectionString.Add(departure);
                    connectionString.Add(platform);
                    connectionString.Add(duration);
                    returnList.Add(connectionString);
                    
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