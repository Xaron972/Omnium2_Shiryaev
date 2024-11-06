using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ICharacterComponent;

public interface IControlComponent : ICharacterComponent
{
    void OnUpdate();
}


