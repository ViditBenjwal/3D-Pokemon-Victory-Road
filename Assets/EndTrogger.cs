using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrogger : MonoBehaviour
{
    public GameManager gamemanager;

    void OnTriggerEnter ()
    {
        gamemanager.CompleteGame();
    }
}
