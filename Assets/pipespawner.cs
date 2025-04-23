using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class pipespawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }

}
