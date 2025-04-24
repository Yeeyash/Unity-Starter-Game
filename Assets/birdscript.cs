using UnityEngine;

public class birdscript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapstrength;
    public logicscript logic;
    public bool birdisalive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (birdisalive == true))
        {
            myRigidBody.linearVelocity = Vector2.up * flapstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;
    }
}
