using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats {

    //Stats
    private int strength;
    private int consitution;
    private int willpower;
    private int charisma;
    private int dexterity;
    private int intelligence;
    private int luck;


    public BaseStats(int strength, int consitution, int willpower, int charisma, int dexterity, int intelligence, int luck)
    {
        this.strength = strength;
        this.consitution = consitution;
        this.willpower = willpower;
        this.charisma = charisma;
        this.dexterity = dexterity;
        this.intelligence = intelligence;
        this.luck = luck;
    }

    public int getStrength()
    {
        return strength;
    }
    public int getConsitution()
    {
        return consitution;
    }
    public int getWillpower()
    {
        return willpower;
    }
    public int getCharism()
    {
        return charisma;
    }
    public int getDexterity()
    {
        return dexterity;
    }
    public int getIntelligence()
    {
        return intelligence;
    }
    public int getLuck()
    {
        return luck;
    }

}
