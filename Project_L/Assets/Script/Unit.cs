using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStatus
{
    public readonly int basicHP;
    public readonly int basicDisturb;
    public readonly int minSpeed;
    public readonly int maxSpeed;
    public BasicStatus(int initHP, int initDisturb, int minSpeed, int maxSpeed)
    {
        basicHP = initHP;
        basicDisturb = initDisturb;
        this.minSpeed = minSpeed;
        this.maxSpeed = maxSpeed;
    }
}
public class Status
{
    public int HP;
    public int disturb;
    public int speed;
    public int mental;
    public Status(int initHP, int initDisturb, int minSpeed, int maxSpeed)
    {
        HP = initHP;
        disturb = initDisturb;
        speed = Random.Range(minSpeed, 1 + maxSpeed);
        mental = 0;
    }
}
public abstract class Unit : MonoBehaviour
{
    [HideInInspector]
    public BattleManager battleManager;
    public List<Skill> skills;
    public BasicStatus basicStatus;
    public Status status;
    public List<Keywords> MyKeywords = new List<Keywords>();
    
    public void StartBattle(int initHP, int initDisturb, int minSpeed, int maxSpeed)
    {
        status = new Status(initHP,initDisturb,minSpeed,maxSpeed);
        basicStatus = new BasicStatus(initHP,initDisturb,minSpeed,maxSpeed);
    }

    public virtual void InitAct()
    {
        status.speed = Random.Range(basicStatus.minSpeed, 1 + basicStatus.maxSpeed);
    }
    public virtual void StartAct(){}
    public virtual void EndAct(){}

    // public Unit SelectTarget(Skill skill)
    // {

    // }
    public void Attack(Unit target, Skill skill)
    {

    }
}
