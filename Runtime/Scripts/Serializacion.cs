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
            DataContractJsonSerializer js = new DataContractJsonSerializer(e.GetType());

            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, e);
            msObj.Position = 0;
            
            StreamReader sr = new StreamReader(msObj);
            string json = sr.ReadToEnd();

            sr.Close();
            msObj.Close();

            return json;
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
