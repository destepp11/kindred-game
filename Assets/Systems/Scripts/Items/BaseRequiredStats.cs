using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRequiredStats {
    //Requirements
    private int requiredStrength;
    private int requiredConsitution;
    private int requiredWillpower;
    private int requiredCharisma;
    private int requiredDexterity;
    private int requiredIntelligence;
    private int requiredLuck;

    public BaseRequiredStats(int requiredStrength, int requiredConsitution, int requiredWillpower, int requiredCharisma, int requiredDexterity, int requiredIntelligence, int requiredLuck)
    {
        this.requiredStrength = requiredStrength;
        this.requiredConsitution = requiredConsitution;
        this.requiredWillpower = requiredWillpower;
        this.requiredCharisma = requiredCharisma;
        this.requiredDexterity = requiredDexterity;
        this.requiredIntelligence = requiredIntelligence;
        this.requiredLuck = requiredLuck;
    }

    public int getRequiredStrength()
    {
        return requiredStrength;
    }
    public int getRequiredConsitution()
    {
        return requiredConsitution;
    }
    public int getRequiredWillpower()
    {
        return requiredWillpower;
    }
    public int getRequiredCharism()
    {
        return requiredCharisma;
    }
    public int getRequiredDexterity()
    {
        return requiredDexterity;
    }
    public int getRequiredIntelligence()
    {
        return requiredIntelligence;
    }
    public int getRequiredLuck()
    {
        return requiredLuck;
    }
}
