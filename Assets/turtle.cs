using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtle : MonoBehaviour
{
    private CharacterController controller;
    public float thrust;
    public float torque;

    private float speed;
    private float angular_rate;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0;
        angular_rate = 0;
        if (Input.GetKey(KeyCode.W)) {
            speed += thrust;
        }
        if (Input.GetKey(KeyCode.S)) {
            speed -= thrust;
        }
        if (Input.GetKey(KeyCode.A)) {
            angular_rate -= torque;
        }
        if (Input.GetKey(KeyCode.D)) {
            angular_rate += torque;
        }

        transform.Rotate(0, angular_rate, 0);
        controller.SimpleMove(transform.forward * speed);
    }
}
