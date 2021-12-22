using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Text scoreText;
    int count = 0;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }

    void OnTriggerExit(Collider colliderInfo)
    {
        if (colliderInfo.gameObject.CompareTag("Trigger"))
        {
            Debug.Log(count);
            count += 1;
            scoreText.text = count.ToString();
        }
    }

}
