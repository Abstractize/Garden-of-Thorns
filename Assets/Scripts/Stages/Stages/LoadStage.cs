using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStage : MonoBehaviour
{
    public Vector3 Spawn1;
    public Vector3 Spawn2;
    public Vector3 Spawn3;
    public Vector3 Spawn4;
    // Start is called before the first frame update
    private void Start() {
    
        GameObject player1 = Instantiate(StageManager.player1,Spawn1,Quaternion.identity);
        GameObject player2 = Instantiate(StageManager.player2,Spawn2,Quaternion.identity);
        GameObject player3 = Instantiate(StageManager.player3,Spawn3,Quaternion.identity);
        GameObject player4 = Instantiate(StageManager.player4,Spawn4,Quaternion.identity);
        GameObject canvas = Instantiate(StageManager.canvas);
        canvas.transform.GetChild(0).gameObject.GetComponent<Canvas>().player = player1.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(1).gameObject.GetComponent<Canvas>().player = player2.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(2).gameObject.GetComponent<Canvas>().player = player3.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(3).gameObject.GetComponent<Canvas>().player = player4.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
