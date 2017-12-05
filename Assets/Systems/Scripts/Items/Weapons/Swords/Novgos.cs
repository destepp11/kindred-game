using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novgos : BaseSword
{

    private static int itemId = 1007;
    private static string itemName = "Novgos";
    private static string itemDescription = "The sword of Logallian.";
    private static BaseStats novgosBaseStats = new BaseStats(70, 23, 12, 6, 6, 6, 8);
    private static BaseRequiredStats novgosBaseRequiredStats = new BaseRequiredStats(66, 50, 20, 8, 20, 20, 8);

    public Novgos()
    {
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        BaseStats = novgosBaseStats;
        BaseRequiredStats = novgosBaseRequiredStats;
    }
}
