using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMenu: MonoBehaviour{

    bool ses = false;
    public GameObject completeGame;

    public void levelComplete()
    {
        completeGame.SetActive(true);
        Invoke("Restart",3f);
    }

    public void EndGame()
    {
        if(ses == false)
        {
            Debug.Log("End Game");
            ses = true;
            Invoke("Restart",2f);
        }
    }

     void Restart()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}
