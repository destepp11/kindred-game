using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaymoreSword : BaseSword {

    private static int itemId = 1004;
    private static string itemName = "Claymore";
    private static string itemDescription = "A long great sword that can deliver mighty blows.";
    private static BaseStats claymoreBaseStats = new BaseStats(40, 13, 7, 2, 3, 0, 5);
    private static BaseRequiredStats claymoreBaseRequiredStats = new BaseRequiredStats(38, 29, 12, 5, 12, 12, 5);

    public ClaymoreSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = claymoreBaseStats;
        BaseRequiredStats = claymoreBaseRequiredStats;
    }
}
