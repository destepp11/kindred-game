using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseKnightClass : BaseCharacterClass {

	public BaseKnightClass()
    {
        CharacterClassName = "Knight";
        CharacterClassDescription = "Expert one-handed swordsman.";
        CharacterClassGroup = "Physical";
        CharacterName = "Iann";
        CharacterBackStory = "Born an orphan and raised by the Secretary of War of Fanil, Iann's childhood was greatly influence by miltary life. Iann quickly advanced through the ranks and achieved the second highest rank of any solider, serving as an Imperial Protector.";
        HitPoints = 80;
        MagicPoints = 2;
        Strength = 4;
        Consitution = 3;
        Willpower = 3;
        Charisma = 5;
        Dexterity = 3;
        Intelligence = 2;
        Luck = 2;
    }

}
