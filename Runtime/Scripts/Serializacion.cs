using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace Grupo06
{
    public interface Serializer
    {
        public string Serialize(Event e);
        public string getExtension();
    }

    public class JsonSerializer : Serializer
    {

        public string Serialize(Event e)
        {
            return JsonUtility.ToJson(e);
        }

        public string getExtension()
        {
            return ".json";
        }
    }
    public class BinarySerializer : Serializer
    {
        public string Serialize(Event e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            binaryFormatter.Serialize(stream, e);
            stream.Position = 0;

            StreamReader reader = new StreamReader(stream);
            string s = reader.ReadToEnd();

            return s;
        }

        public string getExtension()
        {
            return ".bin";
        }

    }

}
