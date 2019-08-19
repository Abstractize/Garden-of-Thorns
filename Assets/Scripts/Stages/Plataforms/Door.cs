using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string nextworld;
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log(other.gameObject.tag);
        GameObject player = other.gameObject;
        if(player.tag.Equals("Player"))
            if(other.gameObject.GetComponent<Movement>().verticalMove > 0.5)
                StageManager.LoadScene(nextworld);     
    }
}
