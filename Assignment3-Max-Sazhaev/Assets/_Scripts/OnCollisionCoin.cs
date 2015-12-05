/* Author: Max Sazhaev
 * File: OnCollisionCoin.cs
 * Creation Date: November 19th 2015
 * Description: This script controls the collision between the coin and the player
 */

using UnityEngine;
using System.Collections;

public class OnCollisionCoin : MonoBehaviour {

    public int scoreValue;
    private GameController gameController;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}


