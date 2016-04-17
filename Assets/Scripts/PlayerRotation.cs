using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed);
        transform.Rotate(0, 0, Input.gyro.attitude.x * rotationSpeed);
    }
}
