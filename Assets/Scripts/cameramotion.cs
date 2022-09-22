using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramotion : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 offset;
    private Vector3 movevector;
    private float transistion = 0f;
    private Vector3 animationoffset = new Vector3(0.002000014f, 10,-15);
    private float animationduration = 3f;
    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        movevector = lookAt.position + offset;
        movevector.x = -3.8f;
        movevector.y = Mathf.Clamp( 0, movevector.y,5);
        if (transistion > 1f)
        {
            transform.position = movevector;
        }
        else
        {
            transform.position = Vector3.Lerp(movevector + animationoffset, movevector, transistion);
            transistion += Time.deltaTime * 1 / animationduration;
           // transform.LookAt(lookAt.position + Vector3.up);
        }
    }
}
