using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{  private int score = 0;

    public Text scoreDisplay;
    private void OnTriggerEnter2D(Collider2D other) {

       if ( other.gameObject.CompareTag("Obstacle")){
            Destroy(other.gameObject); 
            //increse score
            score++;
            scoreDisplay.text = "Score: " + score;
       }    
   }
}
