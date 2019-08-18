using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector2[] points;
    int current = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movePlataform();
        recalculate();
    }
    void movePlataform(){
        Vector3 transformPosition = this.transform.position;
        Vector2 pos = new Vector2(transformPosition.x,transformPosition.y);
        transform.position =  Vector2.MoveTowards(pos,points[current],speed);
        if (pos == points[current])
            current++;
    }
    void recalculate(){
        if (current >= points.Length)
            current = 0;
    }
}
