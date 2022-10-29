using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesspawn : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawntime = 1;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>spawntime)
        {
            int rand = Random.Range(0, obstacles.Length);

            GameObject obj = Instantiate(obstacles[rand]);
            obj.transform.position = transform.position + new Vector3(0, 0, 0);
           //Destroy(obj, 15);
            timer = 0;

        }
        timer = Time.deltaTime;
    }
}
