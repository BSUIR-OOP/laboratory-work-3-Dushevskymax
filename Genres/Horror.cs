using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    [Serializable]
    internal class Horror : Film, ISerializable
    {
        public override string Name { get; set; } = "";

        public override int Year { get; set; }

        public override string Director { get; set; } = "";

        public Horror(string fio, int age)
        {
            Name = fio; Year = age;
        }

        public Horror()
        {
        }

        public override string Work()
        {
            return "It's so scarry";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
        }

        
    }
}
