using UnityEngine;
using System.Collections;

public class MoseMovementSEMIWORKING : MonoBehaviour {
    Camera mouseCam;
    // Use this for initialization
    void Start () {
        mouseCam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(mouseCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouseCam.nearClipPlane)), Vector3.up);
    }
}
