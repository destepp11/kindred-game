using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem {

    private BaseStats baseStats;
    private BaseRequiredStats baseRequiredStats;

    public BaseStats BaseStats
    {
        get { return baseStats; }
        set { baseStats = value; }
    }

    public BaseRequiredStats BaseRequiredStats
    {
        get { return baseRequiredStats; }
        set { baseRequiredStats = value; }
    }
}
