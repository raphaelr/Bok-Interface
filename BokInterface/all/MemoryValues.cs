using System.Collections.Generic;
using BokInterface.All;
using BokInterface.Boktai;
using BokInterface.Zoktai;
using BokInterface.Shinbok;
using BokInterface.LunarKnights;

namespace BokInterface {

    /// <summary>Class containing instances of memory values for the current game</summary>
    class MemoryValues {

        private readonly BoktaiAddresses boktaiAddresses = new();
        private readonly ZoktaiAddresses zoktaiAddresses = new();
        private readonly ShinbokAddresses shinbokAddresses = new();
        private readonly LunarKnightsAddresses lunarKnightsAddresses = new();

        /// <summary>Django-related memory values</summary>
        public IDictionary<string, DynamicMemoryValue> Django = new Dictionary<string, DynamicMemoryValue>();
        
        /// <summary>Solls-related memory values</summary>
        public IDictionary<string, DynamicMemoryValue> Solls = new Dictionary<string, DynamicMemoryValue>();
        
        /// <summary>Bike-related memory values</summary>
        public IDictionary<string, DynamicMemoryValue> Bike = new Dictionary<string, DynamicMemoryValue>();

        /// <summary>Misc memory values</summary>
        public IDictionary<string, DynamicMemoryValue> Misc = new Dictionary<string, DynamicMemoryValue>();

        /// <summary>Constructor</summary>
        /// <param name="shorterGameName">Shortened game name (used for setting the lists containing the memory values instances)</param>
        public MemoryValues(string shorterGameName) {

            this.ClearLists();
            
            switch(shorterGameName) {
                case "Boktai":
                    this.InitializeBoktaiList();
                    break;
                case "Zoktai":
                    this.InitializeZoktaiList();
                    break;
                case "Shinbok":
                    this.InitializeShinbokList();
                    break;
                case "LunarKnights":
                    this.InitializeLunarKnightsList();
                    break;
                default:
                    break;
            }
        }

        private void ClearLists() {
            this.Django.Clear();
            this.Solls.Clear();
            this.Bike.Clear();
            this.Misc.Clear();
        }

        private void InitializeBoktaiList() {

        }

        private void InitializeZoktaiList() {
            
        }

        private void InitializeShinbokList() {

            this.Django.Add("current_hp", new DynamicMemoryValue("current_hp", shinbokAddresses.Misc["room"], shinbokAddresses.Django["hp"]));
            this.Django.Add("base_vit", new DynamicMemoryValue("base_vit", shinbokAddresses.Misc["stat"], shinbokAddresses.Django["base_vit"]));
            this.Django.Add("base_spr", new DynamicMemoryValue("base_spr", shinbokAddresses.Misc["stat"], shinbokAddresses.Django["base_spr"]));
            this.Django.Add("base_str", new DynamicMemoryValue("base_str", shinbokAddresses.Misc["stat"], shinbokAddresses.Django["base_str"]));
        }

        private void InitializeLunarKnightsList() {

        }
    }
}