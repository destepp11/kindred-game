using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : BaseSword
{
    private static int itemId = 1001;
    private static string itemName = "Iron Sword";
    private static string itemDescription = "A basic sword forged from iron.";
    private static BaseStats ironBaseStats = new BaseStats(16, 5, 3, 0, 0, 0, 0);
    private static BaseRequiredStats ironBaseRequiredStats = new BaseRequiredStats(7, 5, 2, 1, 2, 2, 1);

    public IronSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = ironBaseStats;
        BaseRequiredStats = ironBaseRequiredStats;
    }
}
