using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingSword : BaseSword {

    private static int itemId = 1006;
    private static string itemName = "Viking Sword";
    private static string itemDescription = "A straight, double-edged sword.";
    private static BaseStats vikingBaseStats = new BaseStats(58, 19, 10, 2, 5, 0, 7);
    private static BaseRequiredStats vikingBaseRequiredStats = new BaseRequiredStats(55, 42, 17, 7, 17, 17, 7);

    public VikingSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = vikingBaseStats;
        BaseRequiredStats = vikingBaseRequiredStats;
    }
}
