using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

    public float rotationSpeed;
    public float rotationSpeed_accel;
    float max_rotation = 0.6f;
    float rotation;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.acceleration.x < -max_rotation) {
            rotation = -max_rotation;
        } else if (Input.acceleration.x > max_rotation) {
            rotation = max_rotation;
        } else {
            rotation = Input.acceleration.x;
        }
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed);
        transform.Rotate(0, 0, -rotation * rotationSpeed_accel);
    }

    //void OnGUI()
    //{
    //    GUI.Label(new Rect(10, 25, 200, 500), "X-Accel: " + Input.acceleration.x.ToString());
    //    GUI.Label(new Rect(10, 75, 200, 500), "Y-Accel: " + Input.acceleration.y.ToString());
    //    GUI.Label(new Rect(10, 125, 200, 500), "Z-Accel: " + Input.acceleration.z.ToString());
    //    GUI.Label(new Rect(10, 175, 200, 500), "Rotation: " + rotation);
    //}
}
