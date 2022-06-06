using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    [Serializable]
    internal class FilmList : ISerializable
    {
        public List<Film> members;

        public FilmList()
        {
            members = new List<Film>();
        }

        public void Add(Film member) => members.Add(member);

        public void Remove(Film member) => members.Remove(member);

        public List<Film> GetMembers() => members;


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
       

    }
}
