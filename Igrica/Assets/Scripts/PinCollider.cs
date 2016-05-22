using UnityEngine;
using System.Collections;

public class PinCollider : MonoBehaviour {

    private bool wasExecuted = false;

    public GameObject ScoreText;
    public Transform pinspawn;  //Transform point where we want the pin to be placed on reset()


    public void reset_pin()
    {

        if (!wasExecuted)
        {

            GameObject respawn_pins = GameObject.Instantiate(gameObject, transform.position = pinspawn.position, transform.rotation = pinspawn.rotation) as GameObject;
            wasExecuted = true;
        }

        Destroy(gameObject);



    }

 
     void OnTriggerEnter(Collider pinCollider){

         //Has pin fallen down? if yes increment score by one
         if (pinCollider.gameObject.tag == "Plane" && pinCollider.gameObject.transform.position.y >= -5)
         {
             //Increment scoreupdate by 1 for each pin that falls down only once
             if (!wasExecuted)
             {
                 ScoreText.gameObject.SendMessage("scoreUpdate");
                 new WaitForSeconds(10);
                 reset_pin();
                 wasExecuted = true;
             }


             
         }
         
     
     }

}
