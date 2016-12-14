using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
    private Rigidbody ballBody;
    private AudioSource hit = null;
    // Use this for initialization
    void Start () {
        ballBody = GetComponent<Rigidbody>();
	}
	

    // Activates when the bullet collides with an object
    public void OnCollisionEnter(Collision col)
    {
        // These will skip the bot and earth when playing sound
        if (col.gameObject.name == "Bat")
            return;

       
        if (gameObject.name == "Earth")
            return;

        hit.Play();

        Destroy(gameObject);

        Destroy(this.gameObject);
        }
 }
