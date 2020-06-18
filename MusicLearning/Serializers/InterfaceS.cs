using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.Serializers
{
    public interface InterfaceS
    {
        void Serialize(object myObject, string filePath);
        object Deserialize(string filePath);
        string FileExtension { get; }
    }
}
