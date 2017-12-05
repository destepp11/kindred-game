using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mogol : BaseSword
{

    private static int itemId = 1008;
    private static string itemName = "Mogol";
    private static string itemDescription = "The sword of Amos.";
    private static BaseStats mogolBaseStats = new BaseStats(84, 28, 14, 7, 7, 7, 10);
    private static BaseRequiredStats mogolBaseRequiredStats = new BaseRequiredStats(66, 50, 20, 8, 20, 20, 8);

    public Mogol()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = mogolBaseStats;
        BaseRequiredStats = mogolBaseRequiredStats;
    }
}
