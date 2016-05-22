using UnityEngine;
using System.Collections;

public class LaunchClick : MonoBehaviour {

    public float LaunchForce = 1000;

    void OnMouseDown() {

        GetComponent<Rigidbody>().AddForce(LaunchForce*transform.forward);

    }
}
