using UnityEngine;
using System.Collections;

public class BounceCheck : MonoBehaviour {

    private enemy1AI player;

    void Start()
    {

        player = gameObject.GetComponentInParent<enemy1AI>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
       // try
        //{
          //  if (!col.GetComponent<enemy1AI>().enemy)
          //  {

                player.grounded = true;
           // }
      //  } catch (System.NullReferenceException e)
       // {

            player.grounded = true;
       // }
            
        
    }

    void OnTriggerExit2D(Collider2D col)
    {

            player.grounded = false;       
    }
}

