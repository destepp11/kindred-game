using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapierSword : BaseSword {

    private static int itemId = 1003;
    private static string itemName = "Rapier";
    private static string itemDescription = "A slender, sharply pointed sword, best suited for thrusting attacks.";
    private static BaseStats rapierBaseStats = new BaseStats(33, 11, 6, 2, 2, 0, 4);
    private static BaseRequiredStats rapierBaseRequiredStats = new BaseRequiredStats(32, 24, 10, 4, 10, 10, 4);

    public RapierSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = rapierBaseStats;
        BaseRequiredStats = rapierBaseRequiredStats;
    }
}
