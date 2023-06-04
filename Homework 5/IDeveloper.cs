using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm5
{
    interface IDeveloper: IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public int Id { get; set; }
        public void Create();
        public void Destroy();
    }
}
