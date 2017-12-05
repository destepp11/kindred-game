using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelSword : BaseSword
{
    private static int itemId = 1002;
    private static string itemName = "Steel Sword";
    private static string itemDescription = "A basic sword forged from steel.";
    private static BaseStats steelBaseStats = new BaseStats(22, 7, 4, 1, 1, 0, 0);
    private static BaseRequiredStats steelBaseRequiredStats = new BaseRequiredStats(16, 12, 5, 2, 5, 5, 2);

    public SteelSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = steelBaseStats;
        BaseRequiredStats = steelBaseRequiredStats;
    }
}
