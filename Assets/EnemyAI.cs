using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public static Vector2 movement;
    public float moveSpeedX = 1f;
    public float moveSpeedY = .5f;
    Rigidbody2D physics;
    public bool grounded = false;
    public Vector2 velocityChange;

    // Use this for initialization
    void Start () {

        movement = new Vector2(moveSpeedX, moveSpeedY);
        physics = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        physics.velocity = movement;

        if(grounded)
        {
            movement = -physics.velocity;

            if(movement.x > 0)
            {

                movement.x += 0.09f;
            }

            if (movement.x < 0)
            {

                movement.x -= 0.09f;
            }

            if (movement.y < 0)
            {

                movement.y -= 0.09f;
            }

            if (movement.y > 0)
            {

                movement.y += 0.09f;
            }
            physics.velocity = movement;
        }
    }
}
