using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    [SerializeField] Renderer passObstacle;

    void OnTriggerExit(Collider colliderInfo)
    {
        
        if (colliderInfo.tag == "Player1")
        {
            Debug.Log("hit");
            passObstacle.material.color = Color.red;
        }
    }


}
