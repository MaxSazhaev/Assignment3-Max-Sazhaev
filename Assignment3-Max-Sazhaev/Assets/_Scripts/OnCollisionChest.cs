/* Author: Max Sazhaev
 * File: OnCollisionChest.cs
 * Creation Date: November 19th 2015
 * Description: This script controls the collision between the player and the chest
 */

using UnityEngine;
using System.Collections;

public class OnCollisionChest : MonoBehaviour {

    private GameController gameController;
    public int lifeValue;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
	}
	
    void OnTriggerEnter(Collider other)
    {
        // If the chest collides with player it ends the game
        if (other.tag == "Player")
        {
            gameController.SubtractLife(lifeValue);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
