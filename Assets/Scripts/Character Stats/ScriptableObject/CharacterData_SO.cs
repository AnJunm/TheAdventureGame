using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data",menuName ="Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    // Start is called before the first frame update
    [Header("Stats Info")]
    public int maxHealth;
    public int currentHealth;
    public int baseDefence;
    public int currentDefence;

    [Header("Kill")]
    public int killPoint;
    [Header("Level")]
    public int currentLevel;

    public int maxLevel;

    public int baseExp;

    public int currentExp;

    public float levelBuff;

    public float LevelMultifplier
    {
        get { return 1 + (currentLevel - 1) * levelBuff; }
    }
    public void UpdateExp(int point)
    {
        currentExp += point;

        if (currentExp >= baseExp)
            LevelUp();
    }

    private void LevelUp()
    {
        //ȷ���ڷ�Χ��(�ڶ��������͵����������ı�����)
        currentLevel = Mathf.Clamp(currentLevel+1,1,maxLevel);
        baseExp += (int)(baseExp * LevelMultifplier);

        maxHealth = (int)(maxHealth * LevelMultifplier);
        currentHealth = maxHealth;

        Debug.Log("LEVEL UP!" + currentLevel + "Max Health:" + maxHealth);
    }
}
