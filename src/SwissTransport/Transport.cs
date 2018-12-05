﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message
                        , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    return stations;
                }
            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        /// <summary>
        /// added parameters date and time to given implementation, if datetime is not edited the present time is used.
        /// API allows date and time parameters.
        /// </summary>
        /// <param name="fromStation"></param>
        /// <param name="toStattion"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public Connections GetConnections(string fromStation, string toStattion, string date, string time)
        {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date + "&time=" + time);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                        var readToEnd = new StreamReader(responseStream).ReadToEnd();
                        var connections =
                            JsonConvert.DeserializeObject<Connections>(readToEnd);
                        return connections;
            }

                return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
