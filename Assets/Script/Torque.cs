using UnityEngine;
using UnityEngine.InputSystem;

public class Torque : MonoBehaviour
{
    public float torqueSpeed;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Press D
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(0, torqueSpeed, 0);
        }

    }
}