using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform carPosition;
    public Text scoreText;

    void Update()
    {
        scoreText.text = carPosition.position.z.ToString("0");
    }
}
