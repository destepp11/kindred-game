using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iverosa : BaseSword
{

    private static int itemId = 1015;
    private static string itemName = "Iverose";
    private static string itemDescription = "The sword of Seballian.";
    private static BaseStats iverosaBaseStats = new BaseStats(301, 102, 50, 24, 24, 24, 25);
    private static BaseRequiredStats iverosaBaseRequiredStats = new BaseRequiredStats(283, 215, 86, 35, 86, 86, 35);

    public Iverosa()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = iverosaBaseStats;
        BaseRequiredStats = iverosaBaseRequiredStats;
    }
}