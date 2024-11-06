using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementComponent : IMovable
{
    private Character character;
    private CharacterData characterData;


    public float Speed
    {
        get => Speed;
        set
        {
            if (value < 0)
                return;
            Speed = value;
        }

    }

    public void Initialize(CharacterData characterData)
    {
        this.characterData = characterData;
        Speed = characterData.DefaultSpeed;
    }

    public void Initialize(Character character)
    {
       // throw new System.NotImplementedException();
    }

    public void Move(Vector3 direction)
    {
        if (direction == Vector3.zero)
            return;

        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        Vector3 move = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
        characterData.CharacterController.Move(move * Speed * Time.deltaTime);
    }

    public void Rotation(Vector3 direction)
    {
        if (direction == Vector3.zero)
            return;

        float smooth = 0.1f;
        float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(characterData.CharacterTransform.eulerAngles.y, TargetAngle, ref smooth, smooth);
    }
}
