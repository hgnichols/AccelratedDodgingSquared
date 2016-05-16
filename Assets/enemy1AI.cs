using UnityEngine;
using System.Collections;

public class enemy1AI : MonoBehaviour {
    public float moveSpeedX = 1f;
    public float moveSpeedY = .5f;
    public bool grounded = false;
    public bool enemy = true;
    public float speedChangeX;
    public float speedChangeXOld;
    public float speedChangeY;
    public float speedChangeYOld;
    public float speed;
	// Use this for initialization
	void Start () {

        speedChangeXOld = 0;
        speedChangeYOld = 0;
        speedChangeX = 0;
        speedChangeY = 0;
        speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
  
           transform.Translate(transform.right * Time.deltaTime * moveSpeedX);
           transform.Translate(transform.up * Time.deltaTime * moveSpeedY);

           
        
        if(grounded)
        {
            //Here set the speed change variables
            speedChangeX = speedChangeX + (Random.value * moveSpeedX);
            speedChangeY = speedChangeY + (Random.value * moveSpeedY);

            moveSpeedX = (-moveSpeedX);
            moveSpeedY = (-moveSpeedY);
            if(moveSpeedX < 0)
            {
                moveSpeedX = moveSpeedX - 0.09f - (speedChangeX + speedChangeXOld) - speed;
            }

            if (moveSpeedX > 0)
            {
                moveSpeedX = moveSpeedX + 0.09f + (speedChangeX - speedChangeXOld) + speed;
            }

            if (moveSpeedY < 0)
            {
                moveSpeedY = moveSpeedY - 0.09f - (speedChangeY + speedChangeYOld) - speed;
            }

            if (moveSpeedY > 0)
            {
                moveSpeedY = moveSpeedY + 0.09f + (speedChangeY - speedChangeYOld) + speed;
            }

            transform.Translate(transform.right * Time.deltaTime * (moveSpeedX));
            transform.Translate(transform.up * Time.deltaTime * moveSpeedY);
            grounded = false;
            speedChangeXOld = speedChangeX;
            speedChangeYOld = speedChangeY;
            speed += 0.2f;

        }
   
    }
}
