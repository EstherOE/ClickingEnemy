using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DisplayWeapon : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI damageText;
    
   
    public Image weaponArtImage;
   internal static float reduceNumber;
    public WeaponInfo[] weapons;
    int random;
    // Start is called before the first frame update
    void Start()
    {
       
       
        
       
       

   
        random = UnityEngine.Random.Range(0, 2);

        reduceNumber = weapons[random].damage;
        //getReduceNumber(reduceNumber);
        switch (random)
        {
            case 0:
                nameText.text = "Name: " +  weapons[0].name;
                damageText.text = "Damage   :  " + weapons[0].damage;
                weaponArtImage.sprite = weapons[0].weaponArt;
                break;
            case 1:
                nameText.text = "Name: " + weapons[1].name;
                damageText.text = "Damage  :  " + weapons[1].damage;
                weaponArtImage.sprite = weapons[1].weaponArt;
                break;
            case 2:
                nameText.text = "Name: " + weapons[2].name;
                damageText.text = "Damage  :  " + weapons[2].damage;
                weaponArtImage.sprite = weapons[2].weaponArt;
                break;
            

        }
    }

    public static float getReduceNumber()
    {
        return reduceNumber;
    }
}
