﻿using SwissTransport.Models;
using SwissTransport.Core;

namespace SwissTransportGui
{
    internal class StationBoardView
    {
        private String fromStation = null;
        private String toStation = null;

        ITransport transport = new Transport();
        public StationBoardView(String stationName)
        {

        }

        public List<StationBoard> connections()
        {

            return new List<StationBoard>();
        }
    }
}