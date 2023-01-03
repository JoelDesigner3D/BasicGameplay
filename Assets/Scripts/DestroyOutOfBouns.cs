using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBouns : MonoBehaviour
{

    private float topBound = 30f;
    private float lowerBound = -20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
