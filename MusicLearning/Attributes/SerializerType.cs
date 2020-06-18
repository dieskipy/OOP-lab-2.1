using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.Attributes
{
    public class SerializerType:Attribute
    {
        public string TypeName { set; get; }

        public SerializerType(string name)
        {
            TypeName = name;
        }
    }
}
