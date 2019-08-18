using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlataform : MonoBehaviour
{
    private int rotate = 15;
    public Side side;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlataform();
        transform.Rotate(0f,0f,rotate * speed *Time.deltaTime * (int)side,Space.World);
        
    }
    void RotatePlataform(){
        float rot = AngleConvert(transform.rotation.eulerAngles.z); 
        Debug.Log(rot);
        if (rot <= -15.0f)
            side = Side.right;
        else if(rot >= 15.0f)
            side = Side.left;   
    }
    float AngleConvert(float angle){
        float newangle = angle;
        if (angle > 180)
            return newangle-360;
        return newangle;
    }
}
public enum Side{
    left = -1, right = 1
}