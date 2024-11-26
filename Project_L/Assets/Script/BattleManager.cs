using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance {get; private set;}
    public Unit[] joinUnit;
    private void Awake()
    {
        for(int i = 0; i < joinUnit.Length; i++)
        {
            joinUnit[i].battleManager = this;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void SimulateBattle()
    {
        
    }
    public void CheckTurnEnd()
    {

    }
}
