using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVikingClass : BaseCharacterClass {

	public BaseVikingClass()
    {
        CharacterClassName = "Viking";
        CharacterClassDescription = "Axemen and expert blacksmith.";
        CharacterClassGroup = "Physical";
        CharacterName = "Skjald";
        CharacterBackStory = "Skjald is an experience seaman and blacksmith. The only thing that he enjoys more than a fight is a beer. Maybe a nap as well. Don't play tricks on him while he's asleep because he can get awfully angry.";
        HitPoints = 90;
        MagicPoints = 2;
        Strength = 5;
        Consitution = 2;
        Willpower = 3;
        Charisma = 2;
        Dexterity = 2;
        Intelligence = 2;
        Luck = 3;
    }
}
