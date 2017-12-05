using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    int theWeaponIWant;

    public void AssignWeapon(BaseWeapon newWeapon)
    {
      //  newWeapon = GetWeapon(theWeaponIWant);
        /*
        newWeapon = new BaseWeapon();
        newWeapon.ItemName = "W" + Random.Range(1, 101);     
        newWeapon.ItemDescription = "This is a new Weapon";
        newWeapon.ItemId = Random.Range(1, 101);
        newWeapon.Strength = Random.Range(1, 11);
        newWeapon.Consitution = Random.Range(1, 11);
        newWeapon.Willpower = Random.Range(1, 11);
        newWeapon.Charisma = Random.Range(1, 11);
        newWeapon.Dexterity = Random.Range(1, 11);
        newWeapon.Intelligence = Random.Range(1, 11);
        newWeapon.Luck = Random.Range(1, 11);
        //ChooseWeaponType();
        newWeapon.SpellEffectID = Random.Range(1, 101);*/
    }

    public BaseWeapon GetWeapon()
    {
        BaseWeapon thisWeapon = new BaseWeapon{
            ItemId = 676,
            ItemName = "thing",
            ItemDescription = "descption"
        };
        return thisWeapon;
    }



    

    
}


