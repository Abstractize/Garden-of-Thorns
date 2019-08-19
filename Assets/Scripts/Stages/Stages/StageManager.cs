using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public GameObject cs;
    static public GameObject canvas;
    public GameObject playersandcameras;
    static public GameObject player1;
    static public GameObject player2;
    static public GameObject player3;
    static public GameObject player4;
    // Start is called before the first frame update
    void Start()
    {
        player1 = playersandcameras.transform.GetChild(0).gameObject;
        player2 = playersandcameras.transform.GetChild(1).gameObject;
        player3 = playersandcameras.transform.GetChild(2).gameObject;
        player4 = playersandcameras.transform.GetChild(3).gameObject;
        canvas = cs;
        canvas.transform.GetChild(0).gameObject.GetComponent<Canvas>().player = player1.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(1).gameObject.GetComponent<Canvas>().player = player2.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(2).gameObject.GetComponent<Canvas>().player = player3.transform.GetChild(0).gameObject;
        canvas.transform.GetChild(3).gameObject.GetComponent<Canvas>().player = player4.transform.GetChild(0).gameObject;
    }
    void Update(){
        if(Input.anyKeyDown)   
            LoadScene("OvenStage");          
        
    }
    static public void LoadScene(string scene){
        SceneManager.LoadScene(scene);
    }
}
