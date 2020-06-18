using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.InstrumentElements
{
    [Serializable]
    public class Teacher
    {
        public string Name { set; get; }
        public string Experience { set; get; }

        //для работы с тичер до открытия при просмотре-редактировании
        public Teacher(string name, string experience)
        {
            this.Name = name;
            this.Experience = experience;
        }
        public Teacher()
        {
            this.Name = "";
            this.Experience = "";
        }
    }
}
