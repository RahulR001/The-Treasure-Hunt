using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coincollection : MonoBehaviour
{
    
     
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject .tag=="coin")
        {
            
            Destroy(other.gameObject);
        }
        
    }

}  
