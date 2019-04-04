using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace riot
{

    public class Schedule
    {
        public static Schedule ReadToObject(string json)
        {
            Schedule deserializedSchedule = new Schedule();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedSchedule.GetType());
            deserializedSchedule = ser.ReadObject(ms) as Schedule;
            ms.Close();
            return deserializedSchedule;
        }

        int scheduledGames { get; }
        int liveGames { get; }
        int completedGames { get; }

    }
}