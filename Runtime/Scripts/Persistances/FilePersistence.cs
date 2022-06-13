using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Grupo06
{

    public class FilePersistence : Persistence
    {
        public FilePersistence(Serializer s) : base(s)
        {
            cola = new ConcurrentQueue<string>();
            Thread t = new Thread(new ThreadStart(PersistThread));
            t.Start();
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

            //create stream
            string fileName = "/ID_" + sesion + serializer.getExtension(); //name
            FileStream fs;
            fs = File.Open(directory + fileName, FileMode.Create);
            _streamWriter = new StreamWriter(fs);
        }

        public override void Persist()
        {
            while (cola.Count > 0)
            {
                string s;
                if (cola.TryDequeue(out s))
                {
                    _streamWriter.WriteLine(s);
                }
            }
        }


        public override void Send(Event e)
        {
            string s = serializer.Serialize(e);
            if (e.tipo == Event.tipoEvento.SESSION_END)
                exit = true;
            if (sesion == 0) //primer mensaje de todos
            {
                sesion = e.sesion;
                CreateDirectory();
            }
            cola.Enqueue(s);
        }

        string directory;
    }
}