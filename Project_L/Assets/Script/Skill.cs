using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Conditions // 조건
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
public class CoinKeyword // 각각의 코인의 여러 조건 & 키워드
{
    public List<KeywordCondition> eachCoinEffects = new List<KeywordCondition>();
}
public class KeywordCondition //조건 & 키워드
{
    public Func<Conditions.Elemental[], int, Conditions.Sign, bool> judgmentFunction; // Condition이 int만큼 sign한지 탐지
}
public class Skill // 스킬 하나의 여러 코인 및 키워드
{
    public int coins;
    public int attackLevel;
    public KeywordCondition[] StartEffects; // 전투 시작 시
    public KeywordCondition[] usedEffects; // 사용 시
    public CoinKeyword[] effects; // 코인 하나 당 키워드
}
