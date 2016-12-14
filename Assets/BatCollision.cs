using UnityEngine;
using System.Collections;

public class BatCollision : MonoBehaviour
{

    private AudioSource hit = null;

    void Start()
    {
        hit = GetComponent<AudioSource>();
        if (hit == null)
            throw new UnityException("Bat audio not found");
    }

    void OnCollisionEnter(Collision col)
    {
        hit.Play();

        Destroy(col.gameObject);
    }
}