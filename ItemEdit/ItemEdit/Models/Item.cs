using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ItemEdit.Models
{

    public class Item
    {
        public string _id { get; set; }
        public string _name { get; set; }
        public string _parent { get; set; }
        public string _type { get; set; }
        public _Props _props { get; set; }
        public string _proto { get; set; }
    }

    public class _Props
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public string BackgroundColor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int StackMaxSize { get; set; }
        public string Rarity { get; set; }
        public float SpawnChance { get; set; }
        public int CreditsPrice { get; set; }
        public string ItemSound { get; set; }
        public Prefab Prefab { get; set; }
        public Useprefab UsePrefab { get; set; }
        public int StackObjectsCount { get; set; }
        public bool NotShownInSlot { get; set; }
        public bool ExaminedByDefault { get; set; }
        public int ExamineTime { get; set; }
        public bool IsUndiscardable { get; set; }
        public bool IsUnsaleable { get; set; }
        public bool IsUnbuyable { get; set; }
        public bool IsUngivable { get; set; }
        public bool IsLockedafterEquip { get; set; }
        public bool QuestItem { get; set; }
        public int LootExperience { get; set; }
        public int ExamineExperience { get; set; }
        public bool HideEntrails { get; set; }
        public int RepairCost { get; set; }
        public int RepairSpeed { get; set; }
        public int ExtraSizeLeft { get; set; }
        public int ExtraSizeRight { get; set; }
        public int ExtraSizeUp { get; set; }
        public int ExtraSizeDown { get; set; }
        public bool ExtraSizeForceAdd { get; set; }
        public bool MergesWithChildren { get; set; }
        public bool CanSellOnRagfair { get; set; }
        public bool CanRequireOnRagfair { get; set; }
        public bool BannedFromRagfair { get; set; }
        public object[] ConflictingItems { get; set; }
        public bool FixedPrice { get; set; }
        public bool Unlootable { get; set; }
        public string UnlootableFromSlot { get; set; }
        public object[] UnlootableFromSide { get; set; }
        public int ChangePriceCoef { get; set; }
        public object[] AllowSpawnOnLocations { get; set; }
        public bool SendToClient { get; set; }
        public int AnimationVariantsNumber { get; set; }
        public bool DiscardingBlock { get; set; }
        public object[] Grids { get; set; }
        public Slot[] Slots { get; set; }
        public bool CanPutIntoDuringTheRaid { get; set; }
        public object[] CantRemoveFromSlotsDuringRaid { get; set; }
        public int Durability { get; set; }
        public int Accuracy { get; set; }
        public float Recoil { get; set; }
        public int Loudness { get; set; }
        public int EffectiveDistance { get; set; }
        public float Ergonomics { get; set; }
        public float Velocity { get; set; }
        public bool RaidModdable { get; set; }
        public bool ToolModdable { get; set; }
        public bool BlocksFolding { get; set; }
        public bool BlocksCollapsible { get; set; }
        public bool IsAnimated { get; set; }
        public bool HasShoulderContact { get; set; }
        public int SightingRange { get; set; }
        public string muzzleModType { get; set; }
    }

    public class Prefab
    {
        public string path { get; set; }
        public string rcid { get; set; }
    }

    public class Useprefab
    {
        public string path { get; set; }
        public string rcid { get; set; }
    }

    public class Slot
    {
        public string _name { get; set; }
        public string _id { get; set; }
        public string _parent { get; set; }
        public _Props1 _props { get; set; }
        public bool _required { get; set; }
        public bool _mergeSlotWithChildren { get; set; }
        public string _proto { get; set; }
    }

   
    public class _Props1
    {
      
    }


}