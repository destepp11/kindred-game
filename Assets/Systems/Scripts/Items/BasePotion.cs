using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem {

public enum PotionTypes
    {
        HEALTH,
        MAGIC,
        STRENGTH,
        CONSITUTION,
        WILLPOWER,
        CHARISMA,
        DEXTERITY,
        INTELLIGENCE,
        LUCK
    }

    private PotionTypes potionType;
    private int spellEffectId;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectId; }
        set { spellEffectId = value; }
    }

}