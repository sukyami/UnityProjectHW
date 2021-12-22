using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gamemanager; 
    void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
