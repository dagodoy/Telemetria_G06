using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public interface Serializer
    {
        public string Serialize(Event e);
    }

    public class JsonSerializer : Serializer
    {
        public string Serialize(Event e)
        {
            string s = "comemelosjotasones";

            return s;
        }
    }
    public class CSVSerializer : Serializer
    {
        public string Serialize(Event e)
        {
            string s = "comemeloscojones_encsv";

            return s;
        }
    }

}
