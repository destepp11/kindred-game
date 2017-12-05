using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shazard : BaseSword
{

    private static int itemId = 1012;
    private static string itemName = "Shazard";
    private static string itemDescription = "The sword of Bethera.";
    private static BaseStats shazardBaseStats = new BaseStats(174, 59, 29, 14, 14, 14, 20);
    private static BaseRequiredStats shazardBaseRequiredStats = new BaseRequiredStats(164, 124, 50, 20, 50, 50, 20);

    public Shazard()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = shazardBaseStats;
        BaseRequiredStats = shazardBaseRequiredStats;
    }
}
