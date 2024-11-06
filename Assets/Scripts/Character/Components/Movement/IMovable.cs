using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable : ICharacterComponent
{
    public float Speed { get; set; }


    public void Move(Vector3 direction);
    public void Rotation(Vector3 direction);
}
