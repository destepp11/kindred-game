using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glimmer : BaseSword
{

    private static int itemId = 1011;
    private static string itemName = "Glimmer";
    private static string itemDescription = "The sword of Geraud.";
    private static BaseStats glimmerBaseStats = new BaseStats(145, 49, 24, 12, 12, 12, 17);
    private static BaseRequiredStats glimmerBaseRequiredStats = new BaseRequiredStats(137, 103, 42, 17, 42, 42, 17);

    public Glimmer()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = glimmerBaseStats;
        BaseRequiredStats = glimmerBaseRequiredStats;
    }
}
