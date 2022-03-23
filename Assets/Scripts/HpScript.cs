using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HpScript : MonoBehaviour
{

    public EnemyInfoScriptableObject obj;
    
   

    public static float number;

    
    private void Start()
    {
        number = obj.health;
     

    }

    internal float GetHPValue()
    {
        return number;
    }
    [SerializeField] float reduceNumber;
  
    public void ReduceHp()
    {
        number -= DisplayWeapon.getReduceNumber() ;
       
        if(number <=0.1)
        {
            Destroy(gameObject);

            
            

        }

    }

}
