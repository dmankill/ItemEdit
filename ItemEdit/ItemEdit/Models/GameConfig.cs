using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEdit.Models
{

    public class GameConfig
    {
        public Lan lan { get; set; }
        public Autosave autosave { get; set; }
        public Inraid inraid { get; set; }
        public Bots bots { get; set; }
        public Trading trading { get; set; }
        public Location location { get; set; }
        public Locationloot locationloot { get; set; }
    }

    public class Lan
    {
        public bool enabled { get; set; }
    }

    public class Autosave
    {
        public bool saveOnReceive { get; set; }
        public bool saveOnExit { get; set; }
        public int saveIntervalSec { get; set; }
    }

    public class Inraid
    {
        public bool saveLootEnabled { get; set; }
        public bool saveHealthEnabled { get; set; }
        public float saveHealthMultiplier { get; set; }
    }

    public class Bots
    {
        public bool pmcEnabled { get; set; }
        public int pmcSpawnChance { get; set; }
        public int pmcUsecChance { get; set; }
    }

    public class Trading
    {
        public int ragfairMultiplier { get; set; }
        public int repairMultiplier { get; set; }
        public float insureMultiplier { get; set; }
        public int insureReturnChance { get; set; }
        public int fenceAssortSize { get; set; }
        public bool buyItemsMarkedFound { get; set; }
    }

    public class Location
    {
        public bool realTimeEnabled { get; set; }
        public bool forceWeatherEnabled { get; set; }
        public int forceWeatherId { get; set; }
    }

    public class Locationloot
    {
        public int bigmap { get; set; }
        public int develop { get; set; }
        public int factory4_day { get; set; }
        public int factory4_night { get; set; }
        public int interchange { get; set; }
        public int laboratory { get; set; }
        public int rezervbase { get; set; }
        public int shoreline { get; set; }
        public int woods { get; set; }
        public int hideout { get; set; }
        public int lighthouse { get; set; }
        public int privatearea { get; set; }
        public int suburbs { get; set; }
        public int tarkovstreets { get; set; }
        public int terminal { get; set; }
        public int town { get; set; }
    }

}
