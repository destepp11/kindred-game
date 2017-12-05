using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcanon : BaseSword
{

    private static int itemId = 1014;
    private static string itemName = "Arcanon";
    private static string itemDescription = "The sword of Argeis.";
    private static BaseStats arcanonBaseStats = new BaseStats(251, 85, 42, 20, 20, 20, 29);
    private static BaseRequiredStats arcanonBaseRequiredStats = new BaseRequiredStats(236, 179, 72, 29, 72, 72, 29);

    public Arcanon()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = arcanonBaseStats;
        BaseRequiredStats = arcanonBaseRequiredStats;
    }
}
