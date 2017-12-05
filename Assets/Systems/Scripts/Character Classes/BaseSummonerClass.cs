using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSummonerClass : BaseCharacterClass {

    public BaseSummonerClass()
    {
        CharacterClassName = "Summoner";
        CharacterClassDescription = "Able to summon monsters";
        HitPoints = 50;
        MagicPoints = 12;
        Strength = 3;
        Consitution = 3;
        Willpower = 4;
        Charisma = 2;
        Dexterity = 3;
        Intelligence = 3;
        Luck = 2;
    }
}
