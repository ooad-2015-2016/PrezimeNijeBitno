using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {

	    int score = 0;
 
         void Start () {
 
         }
 
         void Update () {
 
         GetComponent<GUIText>().text = "Score: " + score;
         }

         public void scoreUpdate () {
             
             score++;
             }

         
}
