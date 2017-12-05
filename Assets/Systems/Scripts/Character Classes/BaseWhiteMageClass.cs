using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWhiteMageClass : BaseCharacterClass {

	public BaseWhiteMageClass()
    {
        CharacterClassName = "White Mage";
        CharacterClassDescription = " A healer";
        HitPoints = 55;
        MagicPoints = 8;
        Strength = 2;
        Consitution = 3;
        Willpower = 5;
        Charisma = 3;
        Dexterity = 3;
        Intelligence = 5;
        Luck = 1;
    }
}
