using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slither : BaseSword
{

    private static int itemId = 1010;
    private static string itemName = "Slither";
    private static string itemDescription = "The sword of Hanon.";
    private static BaseStats slitherBaseStats = new BaseStats(121, 41, 20, 10, 10, 10, 14);
    private static BaseRequiredStats slitherBaseRequiredStats = new BaseRequiredStats(114, 86, 35, 14, 35, 35, 14);

    public Slither()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = slitherBaseStats;
        BaseRequiredStats = slitherBaseRequiredStats;
    }
}
