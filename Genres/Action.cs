using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    [Serializable]
    internal class Action : Film, ISerializable
    {
        public override string Name { get; set; } = "";

        public override int Year { get; set; }


        public override string Director { get; set; } = "";

      
        public Action()
        {
            
        }

        public override string Work()
        {
            return "It's so cool";
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
          //  info.AddValue("nam", Name, typeof(string));
           // info.AddValue("yer",Year, typeof(int));
        }

      
    }
}
