using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

    private string characterClassName;
    private string characterClassDescription;

    private string characterClassGroup;
    private string characterName;
    private string characterBackStory;
    //Stats
    private int hitPoints;
    private int magicPoints;
    private int strength;
    private int consitution;
    private int willpower;
    private int charisma;
    private int dexterity;
    private int intelligence;
    private int luck;

    public string CharacterClassName
    {
        get{ return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }
    
    public string CharacterClassGroup
    {
        get { return characterClassGroup; }
        set { characterClassGroup = value; }
    }

    public string CharacterName
    {
        get { return characterName; }
        set { characterName = value; }
    }

    public string CharacterBackStory
    {
        get { return characterBackStory; }
        set { characterBackStory = value; }
    }

    public int HitPoints
    {
        get { return hitPoints; }
        set { hitPoints = value; }
    }

    public int MagicPoints
    {
        get { return magicPoints; }
        set { magicPoints = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Consitution
    {
        get { return consitution; }
        set { consitution = value; }
    }

    public int Willpower
    {
        get { return willpower; }
        set { willpower = value; }
    }

    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }
}
