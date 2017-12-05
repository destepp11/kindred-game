using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogol : BaseSword
{

    private static int itemId = 1009;
    private static string itemName = "Ogol";
    private static string itemDescription = "The sword of Odgol.";
    private static BaseStats ogolBaseStats = new BaseStats(101, 34, 17, 8, 8, 8, 12);
    private static BaseRequiredStats ogolBaseRequiredStats = new BaseRequiredStats(95, 72, 29, 12, 29, 29, 12);

    public Ogol()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = ogolBaseStats;
        BaseRequiredStats = ogolBaseRequiredStats;
    }
}
