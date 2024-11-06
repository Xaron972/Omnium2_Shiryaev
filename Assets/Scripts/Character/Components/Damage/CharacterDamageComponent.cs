using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamageComponent : IDamageComponent
{
    public float Damage => 10;

    public float AttackRange => throw new System.NotImplementedException();

    public void Initialize(Character character)
    {
        //throw new System.NotImplementedException();
    }

    public void MakeDamage(Character characterTarget)
    {
        if (characterTarget.LifeComponent != null)
            characterTarget.LifeComponent.SetDamage(Damage);
    }

    public void MakeDamage()
    {
       // throw new System.NotImplementedException();
    }

    public void OnUpdate()
    {
      //  throw new System.NotImplementedException();
    }
}
