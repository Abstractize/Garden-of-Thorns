using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    
    CharacterController2D controller2D;
    Movement player;
    private void Awake() {
        
        controller2D = GetComponent<CharacterController2D>();
        player = GetComponent<Movement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate() {
                 
    }
    
    
}
