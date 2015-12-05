/* Author: Max Sazhaev
 * File: Follow.cs
 * Creation Date: November 19th 2015
 * Description: This script controls the enemy movement toward the player
 */

using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_moveSpeed = 3.0f;

    void Start()
    {
        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation
            , Quaternion.LookRotation(tr_Player.position - transform.position)
            , f_RotSpeed * Time.deltaTime);

        transform.position += transform.forward * f_moveSpeed * Time.deltaTime;
    }
}
