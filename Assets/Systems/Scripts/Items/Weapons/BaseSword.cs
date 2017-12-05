using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSword : BaseWeapon {

    public enum SwordTypes
    {
        BRONZE,
        IRON,
        STEEL,
        RAPIER,
        CLAYMORE,
        GLADIUS,
        VIKING,
        NOVGOS,
        MOGOL,
        OGOL,
        SLITHER,
        GLIMMER,
        SHAZARD,
        DUVIRCH,
        ARCANON,
        IVEROSA
    }

    private SwordTypes swordType;

    public SwordTypes SwordType
    {
        get { return swordType; }
        set { swordType = value; }
    }

    public BaseSword()
    {
        ItemId = 0;
        ItemName = "";
        ItemDescription = "";
        BaseStats = null;
        BaseRequiredStats = null;

    }

    
}
