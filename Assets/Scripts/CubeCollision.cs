using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCollision : MonoBehaviour
{
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Straged"))
        {
            score++;
        }
        SetCountText();
    }

    void SetCountText()
    {
        scoreText.text = "Count: " + score.ToString();
    }
}
