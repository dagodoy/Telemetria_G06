using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Grupo06
{
    //sistema de persistencia síncrono
    public abstract class Persistence
    {
        public Persistence(Serializer s)
        {
            serializer = s;
        }
        public abstract void Send(Event e);
        protected Serializer serializer;

    }

    public class FilePersistence : Persistence
    {
        public FilePersistence(Serializer s) : base(s) 
        {
            CreateDirectory();
        }
        void CreateDirectory()
        {
            directory = "./Resultado del test";

            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
                Directory.Delete(directory);

            }
            Directory.CreateDirectory(directory);
        }
        public override void Send(Event e)
        {
            string s = serializer.Serialize(e);
            //Aqui tiene que guardar el string en un archivo
            //string directory = Application.persistentDataPath + "/Telemetria_G06" + "/HW_" + SystemInfo.deviceUniqueIdentifier; //directory

            string fileName = "/ID_" + e.sesion + serializer.getExtension(); //name
            FileStream fs;
            if (!File.Exists(directory + fileName))
                fs = File.Open(directory + fileName, FileMode.Create);
            else
                fs = File.Open(directory + fileName, FileMode.Append);

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(s);
            writer.Close();
        }

        string directory;
    }
}
