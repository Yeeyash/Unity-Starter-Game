using UnityEngine;

public class birdscript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapstrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Barb";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.linearVelocity = Vector2.up * flapstrength;
        }
    }
}
