using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : InputController
{
    private float zAxisMov = 0;
    private float xAxisMov = 0;

    void Update()
    {
        // Get direction from A to B
        Vector3 posA = transform.position;
        Vector3 posB = GameObject.FindGameObjectWithTag("Player").transform.position;
        //Destination - Origin
        Vector3 dir = (posB - posA).normalized;
        zAxisMov = dir.z > 0 ? 1 : -1;
        xAxisMov = dir.x > 0 ? -1 : 1;

        Debug.Log(dir);
        
        //if (Input.GetKey(KeyCode.D))
        //{

        //    zAxisMov = 1;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    zAxisMov = -1;
        //}
        //else
        //{
        //    zAxisMov = 0;
        //}

        //if (Input.GetKey(KeyCode.W))
        //{

        //    xAxisMov = 1;
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    xAxisMov = -1;
        //}
        //else
        //{
        //    xAxisMov = 0;
        //}
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
