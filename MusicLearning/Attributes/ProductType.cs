using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.Attributes
{
    //атрибут для названий конечных классов
    public class ProductType:Attribute
    {
        public string TypeName { set; get; }

        public ProductType(string name)
        {
            TypeName = name;
        }
    }
}
