using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movement_scalar;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called on a fixed time interval
    void FixedUpdate()
    {
        // Get horizontal movement from input
        float x_movement = Input.GetAxis("Horizontal");

        // Create vector for movement force
        Vector2 movement = new Vector2(x_movement, 0);

        // Add force to rigidbody
        rb.AddForce(movement_scalar * movement);
    }
}
