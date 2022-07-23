using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : InputController
{
    private float zAxisMov = 0;
    private float xAxisMov = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            zAxisMov = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            zAxisMov = -1;
        }
        else
        {
            zAxisMov = 0;
        }

        if (Input.GetKey(KeyCode.W))
        {

            xAxisMov = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            xAxisMov = -1;
        }
        else
        {
            xAxisMov = 0;
        }
    }

    public override float xAxisMovement()
    {
        return xAxisMov;
    }

    public override float zAxisMovement()
    {
        return zAxisMov;
    }
}
