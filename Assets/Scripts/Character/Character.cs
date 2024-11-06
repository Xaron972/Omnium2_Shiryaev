using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected CharacterType characterType;
    [SerializeField] protected CharacterData characterData;

    public virtual Character CharacterTarget { get; }
    public CharacterType CharacterType => CharacterType;
    public CharacterData CharacterData => characterData;

    public IMovable MovableComponent { get; protected set; }
    public ILifeComponent LifeComponent { get; protected set; }
    public IDamageComponent DamageComponent { get; protected set; }
    public IControlComponent ControlComponent { get; protected set; }


    public abstract Character Target { get; }


    public virtual void Initialize()
    {
        MovableComponent = new CharacterMovementComponent();
        MovableComponent.Initialize(this);

        LifeComponent = new CharacterLifeComponent();
        LifeComponent.Initialize(this);
    }

    protected abstract void Update();
}
