using HarmonyLib.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Transactions;
using UnityEngine;
using static BlueprintGrowth;

namespace Stella_FarmingNS
{
    internal class MidwayFood : Food
    {
        protected override bool CanHaveCard(CardData otherCard)
        {
            if (otherCard.MyCardType == CardType.Humans) return true;

            return base.CanHaveCard(otherCard);
        }
    }
}
