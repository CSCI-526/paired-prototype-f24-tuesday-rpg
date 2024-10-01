using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private float topBound = 5;         
    private float lowerBound = -5;      
    public float lifetime = 5.0f;        

    void Start()
    {
        //Self destroy by time, not used in test version
        //Destroy(gameObject, lifetime);
    }

    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
