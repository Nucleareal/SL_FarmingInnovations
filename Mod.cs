using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace Stella_FarmingNS
{
    public class Stella_Farming : Mod
    {
        private void Awake()
        {
        }

        public override void Ready()
        {
            RegisterRecipes();

            Logger.Log("Farming Innovations Ready!");
        }

        private void RegisterRecipes()
        {
            //パックから直接出る育成可能食材
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_barley", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_lettuce", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_rice", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_soy", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_raw_wasabi", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedHarvestable, "stella_farming_raw_mustard", 1);

            //パックから直接出る中間素材
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedFood, "stella_farming_pork", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedFood, "stella_farming_salt", 1);

            //動物
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.Animal, "stella_farming_pig", 1);

            //建築物のアイデア
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_large_green_house", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_magic_farm", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_farm_decompiler", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_wasabi_farm", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_flatten_farm", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedBuildingIdea, "stella_farming_blueprint_salt_mine", 1);

            //料理のアイデア
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_ketchup", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_mayonnaise", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_hamburger", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_pork_cutlet", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_salt", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_salt_from_rock", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_wasabi", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_mustard", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_soy_sauce", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_raw_egg_on_rice", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_tofu", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_salad", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_string_cheese", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_roasted_meat_with_pepper", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_cold_tofu", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "stella_farming_blueprint_katsudon", 1);
        }
    }
}