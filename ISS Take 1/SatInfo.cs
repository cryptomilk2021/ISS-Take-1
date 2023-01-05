using Newtonsoft.Json.Linq;
using RestSharp;

namespace ISS_Take_1
{
    public class SatInfo
    {
        public static List<string> info(string NORADId)
        {
            JObject? jsonObj = new JObject();
            string myAPIKey = "ENTER YOUR API KEY";
            string Uri = @"https://api.n2yo.com/rest/v1/satellite/positions/" + NORADId + @"/0/0/0/1&apiKey=" + myAPIKey;
            List<string> values = new List<string>();
            bool test = true;
            test = false;

            if (!test)
            {
                var client = new RestClient(Uri);

                var request = new RestRequest(Uri, Method.GET);

                var response = client.Execute(request);
                jsonObj = JObject.Parse(response.Content);

                values.Add(jsonObj["positions"][0]["satlatitude"].ToString());
                values.Add(jsonObj["positions"][0]["satlongitude"].ToString());
                values.Add(jsonObj["positions"][0]["timestamp"].ToString());
                values.Add(jsonObj["info"]["transactionscount"].ToString());

                return values;
            }
            else
            {
                //https://api.n2yo.com/rest/v1/satellite/positions/25544/0/0/0/1&apiKey=VBMLDS-EF3VR9-W4SC2G-4Z07
                //{"info":{"satname":"SPACE STATION","satid":25544,"transactionscount":0},"positions":[{"satlatitude":27.43918409,"satlongitude":107.79160274,"sataltitude":417.08,"azimuth":61.55,"elevation":-51.52,"ra":264.34916274,"dec":17.29055796,"timestamp":1672621954,"eclipsed":false}]}
                //string reponse = @"{ "info":{ "satname":"SPACE STATION","satid":25544,"transactionscount":0},"positions":[{ "satlatitude":27.43918409,"satlongitude":107.79160274,"sataltitude":417.08,"azimuth":61.55,"elevation":-51.52,"ra":264.34916274,"dec":17.29055796,"timestamp":1672621954,"eclipsed":false}]}";
                foreach (string line in System.IO.File.ReadLines("stub.txt"))
                {

                    jsonObj = JObject.Parse(line);
                    values.Add(jsonObj["positions"][0]["satlatitude"].ToString());
                    values.Add(jsonObj["positions"][0]["satlongitude"].ToString());
                    values.Add(jsonObj["positions"][0]["timestamp"].ToString());


                }
                return values;
            }
        }
    }

}