using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed = 12f;
    public bool grounded;
    public bool isEnemy = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float h = 0;
        float v = 0;

        if(Input.GetKey("w"))
        {

            h = 1; 
        }

        if (Input.GetKey("s"))
        {

            h = -1;
        }

        if (Input.GetKey("a"))
        {

            v = -1;
        }

        if (Input.GetKey("d"))
        {

            v = 1;
        }

        transform.position += transform.right * speed * v * Time.deltaTime;

        transform.position += transform.up * speed * h * Time.deltaTime;

        if (grounded == true)
        {
            SceneManager.LoadScene("GameOver"); ;
        }

        
    }
}
