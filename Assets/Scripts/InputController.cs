using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputController: MonoBehaviour
{
    // INHERITANCE : the Input (AI and Player) extend this class
    public abstract float xAxisMovement();

    public abstract float zAxisMovement();
}
