using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端
{
    public class FileObject
    {
        public void Storge(object alg, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, alg);
            fs.Flush();
            fs.Close();
        }
        public object GetObj(string filename)
        {
            object al = null;
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                al = bf.Deserialize(fs);
                fs.Flush();
                fs.Close();
            }
            catch { }
            return al;
        }
        public object GetObj(byte []bt)
        {
            object al = null;
            try
            {
                MemoryStream ms = new MemoryStream(bt);
                BinaryFormatter bf = new BinaryFormatter();
                al = bf.Deserialize(ms);
                ms.Close();
            }
            catch { }
            return al;
        }
        //public byte Storge(object alg)
        //{
        //    byte []buffer = new byte[];
        //    MemoryStream fs = new MemoryStream();
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(fs, alg);
        //    fs.Read(buffer, 0, (int)fs.Length);
        //    fs.Flush();
        //    fs.Close();
        //}
    }
}
