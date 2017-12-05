using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duvirch : BaseSword
{

    private static int itemId = 1013;
    private static string itemName = "Duvirch";
    private static string itemDescription = "The sword of Denethor.";
    private static BaseStats duvrichBaseStats = new BaseStats(209, 71, 35, 17, 17, 17, 24);
    private static BaseRequiredStats duvrichBaseRequiredStats = new BaseRequiredStats(197, 149, 60, 24, 60, 60, 24);

    public Duvirch()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = duvrichBaseStats;
        BaseRequiredStats = duvrichBaseRequiredStats;
    }
}

