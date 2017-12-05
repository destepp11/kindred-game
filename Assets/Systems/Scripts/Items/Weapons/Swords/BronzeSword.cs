using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeSword : BaseSword {

    private static int itemId = 1000;
    private static string itemName = "Bronze Sword";
    private static string itemDescription = "A basic sword forged from bronze.";
    private static BaseStats bronzeBaseStats = new BaseStats(10, 3, 2, 0, 0, 0, 0);
    private static BaseRequiredStats bronzeBaseRequiredStats = new BaseRequiredStats(3, 2, 1, 0, 1, 1, 0);

    public BronzeSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = bronzeBaseStats;
        BaseRequiredStats = bronzeBaseRequiredStats;
    }
  
}