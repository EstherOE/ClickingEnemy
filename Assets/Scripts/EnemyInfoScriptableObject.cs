using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Enemy", menuName ="Enemy Info")]
public class EnemyInfoScriptableObject : ScriptableObject
{

    public string name;
    public float health;
}
