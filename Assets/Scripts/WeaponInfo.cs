using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon Info")]
public class WeaponInfo : ScriptableObject
{

    public string name;
    public float damage;
    public Sprite weaponArt;
}
