using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladiusSword : BaseSword {

    private static int itemId = 1005;
    private static string itemName = "Gladius";
    private static string itemDescription = "A common short sword used by soilders.";
    private static BaseStats gladiusBaseStats = new BaseStats(48, 16, 8, 2, 4, 0, 6);
    private static BaseRequiredStats gladiusBaseRequiredStats = new BaseRequiredStats(46, 35, 14, 6, 14, 14, 6);

    public GladiusSword()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = gladiusBaseStats;
        BaseRequiredStats = gladiusBaseRequiredStats;
    }
}
