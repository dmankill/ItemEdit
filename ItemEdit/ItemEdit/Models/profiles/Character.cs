using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ItemEdit.Models.profiles
{
    public class Character
    {
        public string _id { get; set; }
        public string aid { get; set; }
        public string savage { get; set; }
        public Info Info { get; set; }
        public Customization Customization { get; set; }
        public Health Health { get; set; }
        public Inventory Inventory { get; set; }
        public Skills Skills { get; set; }
        public Stats Stats { get; set; }
        public Dictionary<string,bool> Encyclopedia { get; set; }
        public Conditioncounters ConditionCounters { get; set; }
        public Dictionary<string, BackendCounter> BackendCounters { get; set; }
        public Insureditem[] InsuredItems { get; set; }
        public Hideout Hideout { get; set; }
        public Bonus[] Bonuses { get; set; }
        public Notes Notes { get; set; }
        public Quest[] Quests { get; set; }
        public Dictionary<string, Ragfair> TraderStandings { get; set; }
        public Ragfairinfo RagfairInfo { get; set; }
        public string[] WishList { get; set; }
    }

    public class Info
    {
        public string Nickname { get; set; }
        public string LowerNickname { get; set; }
        public string Side { get; set; }
        public string Voice { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int RegistrationDate { get; set; }
        public string GameVersion { get; set; }
        public int AccountType { get; set; }
        public string MemberCategory { get; set; }
        public bool lockedMoveCommands { get; set; }
        public int SavageLockTime { get; set; }
        public int LastTimePlayedAsSavage { get; set; }
        public Settings Settings { get; set; }
        public bool NeedWipe { get; set; }
        public bool GlobalWipe { get; set; }
        public int NicknameChangeDate { get; set; }
        public object[] Bans { get; set; }
    }

    public class Settings
    {
        public string Role { get; set; }
        public string BotDifficulty { get; set; }
        public int Experience { get; set; }
    }

    public class Customization
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Feet { get; set; }
        public string Hands { get; set; }
    }

    public class Health
    {
        public Hydration Hydration { get; set; }
        public Energy Energy { get; set; }
        public Bodyparts BodyParts { get; set; }
        public int UpdateTime { get; set; }
    }

    public class Hydration
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Energy
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Bodyparts
    {
        public Head Head { get; set; }
        public Chest Chest { get; set; }
        public Stomach Stomach { get; set; }
        public Leftarm LeftArm { get; set; }
        public Rightarm RightArm { get; set; }
        public Leftleg LeftLeg { get; set; }
        public Rightleg RightLeg { get; set; }
    }

    public class Head
    {
        public Health1 Health { get; set; }
    }

    public class Health1
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Chest
    {
        public Health2 Health { get; set; }
    }

    public class Health2
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Stomach
    {
        public Health3 Health { get; set; }
    }

    public class Health3
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Leftarm
    {
        public Health4 Health { get; set; }
    }

    public class Health4
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Rightarm
    {
        public Health5 Health { get; set; }
    }

    public class Health5
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Leftleg
    {
        public Health6 Health { get; set; }
    }

    public class Health6
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Rightleg
    {
        public Health7 Health { get; set; }
    }

    public class Health7
    {
        public float Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Inventory
    {
        public Item[] items { get; set; }
        public string equipment { get; set; }
        public string stash { get; set; }
        public string questRaidItems { get; set; }
        public string questStashItems { get; set; }
        public Fastpanel fastPanel { get; set; }
    }

    public class Fastpanel
    {
    }

    public class Item
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        
        public string parentId { get; set; }
        public string slotId { get; set; }
        public object location { get; set; }
        public Upd upd { get; set; }
    }

    public class Upd
    {
        public int? StackObjectsCount { get; set; }
        public Tag Tag { get; set; }
        public Repairable Repairable { get; set; }
        public Firemode FireMode { get; set; }

        public bool? SpawnedInSession { get; set; }
        public Fooddrink FoodDrink { get; set; }
        public Medkit MedKit { get; set; }
        public Sight Sight { get; set; }
        public Resource Resource { get; set; }
        public Light Light { get; set; }
        public Key Key { get; set; }
        public Foldable Foldable { get; set; }
        public Togglable Togglable { get; set; }
        public Faceshield FaceShield { get; set; }
        public Dogtag Dogtag { get; set; }
        public Map Map { get; set; }
    }

    public class Tag
    {
        public int Color { get; set; }
        public string Name { get; set; }
    }

    public class Repairable
    {
        public float MaxDurability { get; set; }
        public float Durability { get; set; }
    }

    public class Firemode
    {
        public string FireMode { get; set; }
    }

    public class Fooddrink
    {
        public int HpPercent { get; set; }
    }

    public class Medkit
    {
        public int HpResource { get; set; }
    }

    public class Sight
    {
        public int SelectedSightMode { get; set; }
    }

    public class Resource
    {
        public int Value { get; set; }
    }

    public class Light
    {
        public bool IsActive { get; set; }
        public int SelectedMode { get; set; }
    }

    public class Key
    {
        public int NumberOfUsages { get; set; }
    }

    public class Foldable
    {
        public bool Folded { get; set; }
    }

    public class Togglable
    {
        public bool On { get; set; }
    }

    public class Faceshield
    {
        public int Hits { get; set; }
        public int HitSeed { get; set; }
    }

    public class Dogtag
    {
        public string Nickname { get; set; }
        public string Side { get; set; }
        public int Level { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public string KillerName { get; set; }
        public string WeaponName { get; set; }
    }

    public class Map
    {
        public object[] Markers { get; set; }
    }

    public class Skills
    {
        public Common[] Common { get; set; }
        public Mastering[] Mastering { get; set; }
        public object Bonuses { get; set; }
        public int Points { get; set; }
    }

    public class Common
    {
        public string Id { get; set; }
        public double Progress { get; set; }
        public double PointsEarnedDuringSession { get; set; }
        public int LastAccess { get; set; }
    }

    public class Mastering
    {
        public string Id { get; set; }
        public int Progress { get; set; }
    }

    public class Stats
    {
        public Sessioncounters SessionCounters { get; set; }
        public Overallcounters OverallCounters { get; set; }
        public float SessionExperienceMult { get; set; }
        public double ExperienceBonusMult { get; set; }
        public int TotalSessionExperience { get; set; }
        public int LastSessionDate { get; set; }
        public Aggressor Aggressor { get; set; }
        public Droppeditem[] DroppedItems { get; set; }
        public object[] FoundInRaidItems { get; set; }
        public Victim[] Victims { get; set; }
        public string[] CarriedQuestItems { get; set; }
        public int TotalInGameTime { get; set; }
        public string SurvivorClass { get; set; }
    }

    public class Sessioncounters
    {
        public Item1[] Items { get; set; }
    }

    public class Item1
    {
        public string[] Key { get; set; }
        public int Value { get; set; }
    }

    public class Overallcounters
    {
        public Item2[] Items { get; set; }
    }

    public class Item2
    {
        public string[] Key { get; set; }
        public int Value { get; set; }
    }

    public class Aggressor
    {
        public string Name { get; set; }
        public string Side { get; set; }
        public string BodyPart { get; set; }
        public string HeadSegment { get; set; }
        public string WeaponName { get; set; }
        public string Category { get; set; }
    }

    public class Droppeditem
    {
        public string QuestId { get; set; }
        public string ItemId { get; set; }
        public string ZoneId { get; set; }
    }

    public class Victim
    {
        public string Name { get; set; }
        public string Side { get; set; }
        public string Time { get; set; }
        public int Level { get; set; }
        public string BodyPart { get; set; }
        public string Weapon { get; set; }
    }
     

    public class Conditioncounters
    {
        public Counter[] Counters { get; set; }
    }

    public class Counter
    {
        public string id { get; set; }
        public int value { get; set; }
    }

    public class BackendCounter
    { 
        public string id { get; set; }
        public string qid { get; set; }
        public int value { get; set; }
    }

    public class Hideout
    {
        public Dictionary<string, Production> Production { get; set; }
        public Area[] Areas { get; set; }
    }

    public class Production
    { 
        public int Progress { get; set; }
        public bool inProgress { get; set; }
        public string RecipeId { get; set; }
        public object[] Products { get; set; }
        public int SkipTime { get; set; }
        public int StartTime { get; set; }
    }

    public class Area
    {
        public int type { get; set; }
        public int level { get; set; }
        public bool active { get; set; }
        public bool passiveBonusesEnabled { get; set; }
        public int completeTime { get; set; }
        public bool constructing { get; set; }
        public Slot[] slots { get; set; }
    }

    public class Slot
    {
        public Item3[] item { get; set; }
    }

    public class Item3
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public Upd1 upd { get; set; }
    }

    public class Upd1
    {
        public int StackObjectsCount { get; set; }
        public Resource1 Resource { get; set; }
    }

    public class Resource1
    {
        public float Value { get; set; }
    }
    public class Notes
    {
        [JsonProperty("Notes")]
        public object[] Sub_Notes { get; set; }
    }
     

    public class Ragfair
    {
        public int currentLevel { get; set; }
        public int currentSalesSum { get; set; }
        public float currentStanding { get; set; } 
        public object NextLoyalty { get; set; }
        public Dictionary<string, loyaltyLevel> loyaltyLevels { get; set; }
    }

     

    public class loyaltyLevel
    {
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public float minStanding { get; set; }
    }

    public class Ragfairinfo
    {
        public float rating { get; set; }
        public bool isRatingGrowing { get; set; }
        public object[] offers { get; set; }
    }

    public class Insureditem
    {
        public string tid { get; set; }
        public string itemId { get; set; }
    }

    public class Bonus
    {
        public string type { get; set; }
        public string templateId { get; set; }
    }

    public class Quest
    {
        public string qid { get; set; }
        public int startTime { get; set; }
        public string[] completedConditions { get; set; }
        public Dictionary<string, double> statusTimers { get; set; }
        public string status { get; set; }
    }
     
}