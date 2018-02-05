using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthColliderController : MonoBehaviour {
    public int depth;
    PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController = collision.GetComponent<PlayerController>();
        if (collision.name == "Player")
        {
            if(playerController.draught >= depth)
            {
                playerController.canMove = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerController = collision.GetComponent<PlayerController>();
        if (collision.name == "Player")
        {
             playerController.canMove = true;
        }
    }
}
