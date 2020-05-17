using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEdit.Models
{
    public class ModsConfigJson
    {
        public string name { get; set; }
        public string author { get; set; }
        public string license { get; set; }
        public string version { get; set; }
        public Dependencies dependencies { get; set; }
        public Res res { get; set; }
        public Src src { get; set; }
        public Dictionary<string, Dictionary<string,object>> db { get; set; }
    }

    public class Dependencies
    {
    }

    public class Res
    {
    }

    public class Src
    {
        
    }
    
}