using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEdit.Models
{
    public class PropLocale
    {
        public int err { get; set; }
        public object errmsg { get; set; }
        public Data data { get; set; }
        public int crc { get; set; }
    }

    public class Data
    {
        public Dictionary<string, string> _interface { get; set; }
        public object[] _enum { get; set; }
        public Dictionary<string,string> error { get; set; }
        public Dictionary<string, string> mail { get; set; }
        public Dictionary<string,Questa> quest { get; set; }
        public Preset preset { get; set; }
        public Dictionary<string,string> handbook { get; set; }
        public Dictionary<string,string> season { get; set; }
        public Dictionary<string,Templates> templates { get; set; }
        public Dictionary<string, Locations> locations { get; set; }
        public Dictionary<string, Banners> banners { get; set; }
        public Dictionary<string, Tradinga> trading { get; set; }
    }
  
    public class Questa 
    {
        public Dictionary<string,string> conditions { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string description { get; set; }
        public string failMessageText { get; set; }
        public string startedMessageText { get; set; }
        public string successMessageText { get; set; }
        public string location { get; set; }
    }
       

    public class Preset 
    {
        public string Name { get; set; }
    }


    

   

    public class Templates
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string casingName { get; set; } 
        public string RigLayoutName { get; set; }
    }
     

    public class Locations
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }

    public class Banners
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }

    public class Tradinga
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }

}
