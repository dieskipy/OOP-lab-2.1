using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MusicLearning.Attributes;

namespace MusicLearning.Serializers
{
    [SerializerType("BINARY")]
    public class BINARY:InterfaceS
    {
        public string FileExtension { get; } = ".dat|*.dat";
        public void Serialize(object myObject, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, myObject);
            }
        }
        public object Deserialize(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            object myObject;
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                myObject = (object)formatter.Deserialize(fileStream);
            }
            return myObject;
        }
    }
}
