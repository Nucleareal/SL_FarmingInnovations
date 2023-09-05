using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Stella_FarmingNS
{
    public class StellaFarming : Mod
    {
        private bool _isFarmingLoaded;
        private bool _isMachineLoaded;
        private bool _isFoodsLoaded;
        private bool _isMagicLoaded;

        private const string FARMING_MOD_CLASSNAME = "StellaFarming";
        private const string MACHINE_MOD_CLASSNAME = "StellaMachine";
        private const string FOODS_MOD_CLASSNAME = "StellaFoods";
        private const string MAGIC_MOD_CLASSNAME = "StellaMagic";

        private void Awake()
        {
        }

        public override void Ready()
        {
            DetectBridges();

            RegisterRecipes();

            Logger.Log("StellaFarming Ready!");
        }

        private void DetectBridges()
        {
            foreach (var m in ModManager.LoadedMods)
            {
                var mod_classname = m.GetType().Name;

                _isFarmingLoaded |= mod_classname == FARMING_MOD_CLASSNAME;
                _isMachineLoaded |= mod_classname == MACHINE_MOD_CLASSNAME;
                _isFoodsLoaded |= mod_classname == FOODS_MOD_CLASSNAME;
                _isMagicLoaded |= mod_classname == MAGIC_MOD_CLASSNAME;
            }
        }

        private void RegisterRecipes()
        {
            //建築物のアイデア
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_large_green_house", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_magic_farm", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_farm_decompiler", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_flatten_farm", 1);
        }
    }
}