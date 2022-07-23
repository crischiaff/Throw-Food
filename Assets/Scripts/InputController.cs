using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputController: MonoBehaviour
{
    public abstract float xAxisMovement();

    public abstract float zAxisMovement();
}
