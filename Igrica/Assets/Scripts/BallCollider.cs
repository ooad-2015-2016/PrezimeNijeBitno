using UnityEngine;
using System.Collections;

public class BallCollider : MonoBehaviour
{
    private bool wasExecuted = false;
    public GameObject FrameText;

    public Transform spawn;  //Transform point where we want the ball to be placed on reset()

    void reset_ball()
    {

        if (!wasExecuted)
        {

            GameObject respawn_bowling_ball = GameObject.Instantiate(gameObject, transform.position = spawn.position, transform.rotation = spawn.rotation) as GameObject;
            wasExecuted = true;
        }

        Destroy(gameObject);


    }


    void OnTriggerEnter(Collider ballCollider)
    {
        //Reset ball after each throw
        if (ballCollider.gameObject.tag == "Plane")
        {

              reset_ball();
              FrameText.gameObject.SendMessage("frameUpdate");
            
        }
    }
}
