using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass whiteMageClass = new BaseWhiteMageClass();
    private BaseCharacterClass dragoonClass = new BaseDragoonClass();
    private BronzeSword bronzesword = new BronzeSword();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
       // GUILayout.Label(whiteMageClass.CharacterClassName);
        //GUILayout.Label(whiteMageClass.CharacterClassDescription);

        GUILayout.Label(dragoonClass.CharacterClassName);
        GUILayout.Label(dragoonClass.CharacterClassDescription);
        GUILayout.Label("HP = " + dragoonClass.HitPoints.ToString());
        GUILayout.Label("MP = " + dragoonClass.MagicPoints.ToString());
        GUILayout.Label("STR = " + dragoonClass.Strength.ToString());
        GUILayout.Label("WILL = " + dragoonClass.Willpower.ToString());
        GUILayout.Label("CHA = " + dragoonClass.Charisma.ToString());
        GUILayout.Label("DEX = " + dragoonClass.Dexterity.ToString());
        GUILayout.Label("INT = " + dragoonClass.Intelligence.ToString());
        GUILayout.Label("LUCK = " + dragoonClass.Luck.ToString());

        GUILayout.Label("ItemId is " + bronzesword.ItemId.ToString());
        GUILayout.Label(bronzesword.ItemName);
        GUILayout.Label(bronzesword.ItemDescription);
        GUILayout.Label("STR = " + bronzesword.BaseStats.getStrength().ToString());
        GUILayout.Label("CON = " + bronzesword.BaseStats.getConsitution().ToString());
        GUILayout.Label("WILL = " +bronzesword.BaseStats.getWillpower().ToString());
        GUILayout.Label("CHA = " + bronzesword.BaseStats.getCharism().ToString());
        GUILayout.Label("DEX = " + bronzesword.BaseStats.getDexterity().ToString());
        GUILayout.Label("INT = " + bronzesword.BaseStats.getIntelligence().ToString());
        GUILayout.Label("LUCK = " + bronzesword.BaseStats.getLuck().ToString());

    }
}
