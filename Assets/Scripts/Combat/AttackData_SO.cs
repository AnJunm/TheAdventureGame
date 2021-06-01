using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Data",menuName ="Attack")]
public class AttackData_SO : ScriptableObject
{
    // Start is called before the first frame update
    public float attackRange;

    public float skillRange;

    public float coolDown;

    public int minDamage;

    public int maxDamage;

    public float criticalMultiplier;

    public float criticalChance;
}
