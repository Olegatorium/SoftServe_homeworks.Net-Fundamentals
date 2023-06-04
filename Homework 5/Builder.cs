using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm5
{
    class Builder : IDeveloper
    {
        private string _tool;

        public string Tool 
        {
            get { return _tool; }
            set { _tool = value; }
        }

        public int Id { get; set; }

        private string _destroyTool;

        public Builder(int id, string tool, string destroyTool) 
        {
            this.Id = id;
            _tool = tool;
            _destroyTool= destroyTool;
            
        }

        public void Create()
        {
            Console.WriteLine($"Builder ID {Id} use {_tool} and creates buildings!))");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder ID {Id} demolishes structures with {_destroyTool}(");
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
