using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     bool gameHasEnded = false;
     public GameObject CompleteGameUI; 

    public void CompleteGame()
    {
        CompleteGameUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }
     
}
    
