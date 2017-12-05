using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {

    public enum WeaponTypes
    {
        SWORD,
        SPEAR,
        JAVELIN,
        PIKE,
        HACHET,
        SCYTHE,
        AXE,
        HAMMER,
        KNIFE,
        DAGGER,
        CANE,
        MACE,
        WAND,
        ROD,
        STAFF,
        BONE,
        ROPE,
        BOW
    }

    private WeaponTypes weaponType;
    private int spellEffectId;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectId; }
        set { spellEffectId = value; }
    }

}
