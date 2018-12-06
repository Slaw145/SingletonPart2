using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SecureBeforeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instanceOne = Singleton.instance;
            BinaryFormatter binFormat = new BinaryFormatter();

            string path = "C:\\Users\\" + Environment.UserName + "\\Desktop\\filename.ser";

            FileStream savefile = new FileStream(path, FileMode.Open, FileAccess.Write);
            binFormat.Serialize(savefile, instanceOne);
            savefile.Close();

            FileStream openfile = new FileStream(path, FileMode.Open);

            Singleton instanceTwo = (Singleton)binFormat.Deserialize(openfile);
            openfile.Close();

            Console.WriteLine("instanceOne hashCode=" + instanceOne.GetHashCode());
            Console.WriteLine("instanceTwo hashCode=" + instanceTwo.GetHashCode());

            Console.ReadKey();
        }
    }
}
