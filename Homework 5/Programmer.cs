using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hm5
{
    class Programmer : IDeveloper
    {
        private string _language;

        public string Tool { get; set; }
        
        public int Id { get; set; }

        public Programmer(int id, string language, string tool)
        {
            this.Id = id;
            _language = language;
            Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Programmer ID {Id} use {_language} for creating new programs!");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer ID {Id} destroys bugs with the help of a {Tool}!");
        }

        public int CompareTo(IDeveloper? other)
        {
            if (other != null)
            {
                if (Id > other.Id)
                    return 1;
                else if (Id < other.Id)
                    return -1;
                else
                    return 0;
            }

            return -1;
        }
    }
}
