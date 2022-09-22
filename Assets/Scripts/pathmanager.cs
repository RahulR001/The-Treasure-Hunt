using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class pathmanager : MonoBehaviour
{
    public GameObject[] pathprefab;
    private Transform player;
    private float spawnz = -45f;
    private float pathlength = 48f;
    private int amtofpathonscreen= 15;
    private List<GameObject> activepath;
    int lastprefabindex = 0;
    private float safezone=80f;

    // Start is called before the first frame update
    void Start()
    {
        activepath = new List<GameObject>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0; i < amtofpathonscreen; i++)
        {
            pathspawner();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - safezone > (spawnz - amtofpathonscreen * pathlength))
        {
            pathspawner();
            destroyer();
        }
        
    }
    private void pathspawner(int prefabid=-1)
    {
        GameObject go;
        go = Instantiate(pathprefab[randomprefabindex() ]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward *spawnz;
        spawnz += pathlength;
        activepath.Add(go);
            }
    void destroyer()
    {
        Destroy(activepath[0]);
        activepath.RemoveAt(0);
    }
   private int randomprefabindex()
    {
        if (pathprefab.Length <= 1)
          return 0;
         
            

        int randomindex = lastprefabindex; 
        while (randomindex ==lastprefabindex)
        {
            randomindex = Random.Range(0, pathprefab.Length);
        }
        lastprefabindex = randomindex;
        return randomindex;
    } 
}
