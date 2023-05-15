using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movement_scalar;
    private Rigidbody2D rb;
    public float max_horizontal_speed;
    public float max_vertical_speed;

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

        // Current velocity after force is added
        Vector2 currentVelocity = rb.velocity;

        // Check horizontal speed against max speed
        if(currentVelocity.x > max_horizontal_speed)
        {
            // Update currentVelocity and assign it to rigidbody
            currentVelocity = new Vector2(max_horizontal_speed, currentVelocity.y);
            rb.velocity = currentVelocity;
        }
        else if(currentVelocity.x < -max_horizontal_speed)
        {
            // Update currentVelocity and assign it to rigidbody
            currentVelocity = new Vector2(-max_horizontal_speed, currentVelocity.y);
            rb.velocity = currentVelocity;
        }

        // Check vertical speed against max speed
        if(currentVelocity.y > max_vertical_speed)
        {
            // Update currentVelocity and assign it to rigidbody
            currentVelocity = new Vector2(currentVelocity.x, max_vertical_speed);
            rb.velocity = currentVelocity;
        }
        else if (currentVelocity.y < -max_vertical_speed)
        {
            // Update currentVelocity and assign it to rigidbody
            currentVelocity = new Vector2(currentVelocity.x, -max_vertical_speed);
            rb.velocity = currentVelocity;
        }
    }
}
