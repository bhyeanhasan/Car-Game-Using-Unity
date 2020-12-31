using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dhakka : MonoBehaviour
{
    public carControll carController;
    
    private void OnCollisionEnter(Collision dhakkas) {
        if(dhakkas.collider.tag == "badha")
        {
            carController.enabled = false;
            FindObjectOfType<gameMenu>().EndGame();
        }
    }
}


