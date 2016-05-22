using UnityEngine;
using System.Collections;

public class KeyRotate : MonoBehaviour {

    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public float rotateSpeed = 2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(leftKey))
            transform.Rotate(0, -rotateSpeed*Time.deltaTime,0);

        if (Input.GetKey(rightKey))
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	}
}
