using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public gameMenu gamemenu;

    private void OnTriggerEnter(){

        gamemenu.levelComplete();
        
    }
}
