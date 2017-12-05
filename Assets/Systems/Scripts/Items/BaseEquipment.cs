using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmor : BaseStatItem {

	public enum ArmorTypes
    {
        HEAD,
        CHEST,
        ARMS,
        HANDS,
        LEGS,
        FEET,
        NECK,
        EARING,
        RING
    }

    private ArmorTypes armorType;
    private int spellEffectId;


    public ArmorTypes ArmorType
    {
        get { return armorType; }
        set { armorType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectId; }
        set { spellEffectId = value; }
    }
}
