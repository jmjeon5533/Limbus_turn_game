using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Conditions // ����
{
    public enum Elemental
    {
        HP,
        burned,
        blooded,
        vibration,
        burst,
        depress,
        breath,
        Charge
    }
    public enum Sign
    {
        GreaterThanOrEqual,
        LessThanOrEqual,
        GreaterThan,
        LessThan,
        equal
    }
    public enum Target
    {
        AlliesIncludingSelf,
        AlliesExcludingSelf,
        Self,
        Enemies
    }

}
public class CoinKeyword // ������ ������ ���� ���� & Ű����
{
    public List<KeywordCondition> eachCoinEffects = new List<KeywordCondition>();
}
public class KeywordCondition //���� & Ű����
{
    public Func<Conditions.Elemental[], int, Conditions.Sign, bool> judgmentFunction; // Condition�� int��ŭ sign���� Ž��
}
public class Skill // ��ų �ϳ��� ���� ���� �� Ű����
{
    public int coins;
    public int attackLevel;
    public KeywordCondition[] StartEffects; // ���� ���� ��
    public KeywordCondition[] usedEffects; // ��� ��
    public CoinKeyword[] effects; // ���� �ϳ� �� Ű����
}
