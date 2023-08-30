using HarmonyLib.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;
using static BlueprintGrowth;

namespace Stella_FarmingNS
{
    internal class SaltMine : CardData
    {
        protected override bool CanHaveCard(CardData otherCard)
        {
            return otherCard.MyCardType == CardType.Humans;
        }
    }
}
