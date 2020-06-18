using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using MusicLearning.Attributes;

namespace MusicLearning.Serializers
{
    [SerializerType("JSON")]
    public class JSON:InterfaceS
    {
        
        public string FileExtension { get; } = ".json|*.json";
        public void Serialize(object myObject, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath, false))
            {
                string jsonObject = JsonConvert.SerializeObject(myObject, Formatting.Indented, new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                fileStream.Write(jsonObject);
            }
        }

        public object Deserialize(string filePath)
        {
            object myObject;
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                string jsonObject = fileStream.ReadToEnd();
                myObject = (object)JsonConvert.DeserializeObject<object>(jsonObject, new JsonSerializerSettings
                { TypeNameHandling = TypeNameHandling.All, PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
            return myObject;
        }
    }
}
