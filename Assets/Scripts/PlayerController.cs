using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : InputController 
{
    private float zAxisMov = 0;
    private float xAxisMov = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            zAxisMov = 1;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            zAxisMov = -1;
        } else
        {
            zAxisMov = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {

            xAxisMov = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            xAxisMov = -1;
        } else
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
