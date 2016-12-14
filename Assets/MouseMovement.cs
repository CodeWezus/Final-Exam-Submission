using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {

    private float camXRot = 0.0f;
    private float camYRot = 0.0f;


	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(camYRot, camXRot, 0.0f);
    }
}
