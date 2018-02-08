using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthColliderController : MonoBehaviour {
    //do note that the depth is measured in
    public int depth;
    PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            print("collider belongs to " + gameObject);
            playerController = collision.GetComponent<PlayerController>();
            if (playerController.draught >= depth)
            {
                playerController.stuckInShallows = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            playerController = collision.GetComponent<PlayerController>();
            playerController.stuckInShallows = false;
        }
    }
}
