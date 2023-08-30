using HarmonyLib.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;
using static BlueprintGrowth;

namespace Stella_FarmingNS
{
    internal class LargeGreenHouse : CardData
    {
        protected override bool CanHaveCard(CardData otherCard)
        {
            if (otherCard.MyCardType != CardType.Resources && otherCard.MyCardType != CardType.Humans)
            {
                return otherCard.MyCardType == CardType.Food;
            }
            return true;
        }
    }
}
