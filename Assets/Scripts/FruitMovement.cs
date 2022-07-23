using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMovement : MonoBehaviour
{
    private Rigidbody rb;



    // ENCAPSULATION: Preventing other object from changing speed 
    [SerializeField]
    private float speed = 3.0f;

    private InputController inputController;

    public enum Type
    {
        Player,
        AI
    }

    public Type type;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (type == Type.Player)
        {
            inputController = gameObject.AddComponent<PlayerController>();
        } else
        {
            inputController = gameObject.AddComponent<AiController>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // POLYMORPHISM: The implementation depends on the child class
        if (inputController.zAxisMovement() > 0)
        {

            rb.AddForce(Vector3.forward * speed);
        }
        else if (inputController.zAxisMovement() < 0)
        {
            rb.AddForce(Vector3.back * speed);
        }
        else
        {
            //rb.AddForce(Vector3.forward * Mathf.Clamp(rb.velocity.z, 0, 1) * -1 * breakingSpeed);
        }

        if (inputController.xAxisMovement() > 0)
        {

            rb.AddForce(Vector3.left * speed);
        }
        else if (inputController.xAxisMovement() < 0)
        {
            rb.AddForce(Vector3.right * speed);
        }
        else
        {
            //rb.AddForce(Vector3.right * Mathf.Clamp(rb.velocity.x, 0, 1) * -1 * breakingSpeed);
        }
    }
}
