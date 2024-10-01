using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objectA;  
    public Transform objectB;  
    public float radius = 2f; 
    public float speed = 50f;   
    private float angle; 
    void Start()
    {
        Vector2 offset = objectA.position - objectB.position;
        angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg; 
        radius = offset.magnitude; 
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        if (angle >= 360f) angle -= 360f;
        float x = objectB.position.x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        float y = objectB.position.y + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
        objectA.position = new Vector3(x, y ,-1);
    }
}
