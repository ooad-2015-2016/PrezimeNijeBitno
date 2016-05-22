using UnityEngine;
using System.Collections;

public class FrameCount : MonoBehaviour {

		 public int ballCount = 0;
         public int frame = 0;
         void Start () {
 
         }
 
         void Update () {
             
            GetComponent<GUIText>().text = "Frame: " + frame;

         }
        
         public void frameUpdate () {

             ballCount++;
             frame = ballCount / 2; //every 2 ball throws is equal to one frame
             }

}

