using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Grupo06
{
    public class FilePersistence : Persistence
    {
        public FilePersistence(Serializer s) : base(s) { }
        public override void Send(Event e)
        {
            string s = serializer.Serialize(e);
            //Aqui tiene que guardar el string en un archivo
            //string directory = Application.persistentDataPath + "/Telemetria_G06" + "/HW_" + SystemInfo.deviceUniqueIdentifier; //directory
            //DIRECTORIO A PELO CAMBIARLO PARA QUE ESTE BIEN
            string directory = "../Pruebas" + "/Telemetria_G06" + "/HW_" + SystemInfo.deviceUniqueIdentifier;
            string name = "/ID_" + e.sesion + serializer.getExtension(); //name

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            FileStream fs;
            if (!File.Exists(directory + name))
                fs = File.Open(directory + name, FileMode.Create);
            else
                fs = File.Open(directory + name, FileMode.Append);

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(s);
            writer.Close();
        }
    }
}
