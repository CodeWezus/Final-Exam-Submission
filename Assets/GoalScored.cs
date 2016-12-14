using UnityEngine;
using System.Collections;

public class GoalScored : MonoBehaviour
{
    private AudioSource hit = null;
    void Start()
    {
        hit= GetComponent<AudioSource>();
        if (hit == null)
            throw new UnityException("No goal sound found");
    }

    void OnTriggerEnter(Collider enteredObject)
    {
        hit.Play();

        Destroy(enteredObject.gameObject);
    }
}