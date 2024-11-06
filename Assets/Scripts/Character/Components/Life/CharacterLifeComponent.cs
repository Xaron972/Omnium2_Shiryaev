using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLifeComponent : ILifeComponent
{
    Character selfCharacter;
    private float currentHealth;


    public event Action<Character> OnCharacterDeath;


    public float MaxHealth
    {
        get => 50;
        protected set { return; }
    }

    public float Health
    {
        get => currentHealth;
        protected set
        {
            currentHealth = value;
            if (currentHealth > MaxHealth)
                currentHealth = MaxHealth;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                SetDeath();
            }
        }
    }

    public CharacterLifeComponent()
    {
        Health = MaxHealth;
    }

    public void SetDamage(float damage)
    {
        Health -= damage;
    }

    private void SetDeath()
    {
        OnCharacterDeath?.Invoke(selfCharacter);
        Debug.Log("Character is dead");
    }

    public void Initialize(Character selfCharacter)
    {
        this.selfCharacter = selfCharacter;
    }
}
   