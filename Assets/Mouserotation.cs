
using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour
{
    private GameObject floor = null;

    public float CamMovSpeed = 0.3f; 

    void Start()
    {
        floor = GameObject.Find("Ground");
        if (floor == null)
            throw new UnityException("Object Doesnt exist");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            transform.RotateAround(floor.transform.position, Vector3.up, CamMovSpeed * Time.deltaTime);

        else if (Input.GetKeyDown(KeyCode.D))
            transform.RotateAround(floor.transform.position, Vector3.up, -1.0f * CamMovSpeed * Time.deltaTime);
    }
}