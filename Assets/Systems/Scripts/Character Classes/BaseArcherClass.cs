using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArcherClass : BaseCharacterClass {

	public BaseArcherClass()
    {
        CharacterClassName = "Archer";
        CharacterClassDescription = "Shoots Shit";
        HitPoints = 65;
        MagicPoints = 4;
        Strength = 2;
        Consitution = 3;
        Willpower = 3;
        Charisma = 1;
        Dexterity = 3;
        Intelligence = 4;
        Luck = 2;
    }
}
