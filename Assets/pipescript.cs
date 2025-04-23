using UnityEngine;

public class pipescript : MonoBehaviour
{

    public float movespeed = 5;
    public float deadzone = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("Deleted.");
            Destroy(gameObject);
        }
    }
}
