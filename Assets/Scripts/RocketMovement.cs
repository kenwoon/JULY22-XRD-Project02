using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float thrust;
    public float rotationalThrust;
    private Rigidbody spaceshipBody;

    // Start is called before the first frame update
    void Start()
    {
        spaceshipBody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;   // This will lock the cursor to the center
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            spaceshipBody.AddForce(thrust * transform.forward); // Moves the spaceship forward

        if (Input.GetKey(KeyCode.S))
            spaceshipBody.AddForce(thrust * transform.forward * -1); // Moves the spaceship backward

        if (Input.GetKey(KeyCode.A))
            spaceshipBody.AddForce(thrust * transform.right * -1); // Moves the spaceship to the left

        if (Input.GetKey(KeyCode.D))
            spaceshipBody.AddForce(thrust * transform.right); // Moves the spaceship to the right

        if (Input.GetKey(KeyCode.Q))
            spaceshipBody.AddForce(thrust * transform.up); // Moves the spaceship upward

        if (Input.GetKey(KeyCode.E))
            spaceshipBody.AddForce(thrust * transform.up * -1); // Moves the spaceship downward

        if (Input.GetMouseButton(1))
            spaceshipBody.AddTorque(Input.GetAxis("Mouse X") * rotationalThrust * transform.up);
    }
}
