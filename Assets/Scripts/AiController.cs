using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : InputController
{
    private float zAxisMov = 0;
    private float xAxisMov = 0;

    void Update()
    {
        // ABSTRACTION
        Vector3 dir = GetPlayerPositionVector();

        zAxisMov = dir.z > 0 ? 1 : -1;
        xAxisMov = dir.x > 0 ? -1 : 1;

       
    }

    private Vector3 GetPlayerPositionVector()
    {
        // Get direction from A to B
        Vector3 posA = transform.position;
        Vector3 posB = GameObject.FindGameObjectWithTag("Player").transform.position;
        //Destination - Origin
        return (posB - posA).normalized;
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
