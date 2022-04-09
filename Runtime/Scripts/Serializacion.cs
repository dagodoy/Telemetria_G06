using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
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
            return JsonUtility.ToJson(e);
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
