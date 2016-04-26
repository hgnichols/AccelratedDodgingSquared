using UnityEngine;
using System.Collections;

public class TouchCheck : MonoBehaviour
{

    private EnemyAI player;

    void Start()
    {
        player = gameObject.GetComponentInParent<EnemyAI>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {

        player.grounded = false;

    }
}

