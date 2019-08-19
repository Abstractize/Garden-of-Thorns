using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public List<GameObject> inventory;
    public GameObject[] tools;

    public int invIter = 0;
    public int toolIter = 0;

    private void Awake() {

    }
    public GameObject GetItem(){
        return inventory[invIter];
    }
    public void NextItem(){
        
        invIter++;
        
        if (invIter == inventory.Capacity)
            invIter = 0; 
    }
    public void DeleteItem(int item){
        inventory.RemoveAt(item);
    }
    public void AddItem(GameObject item){
        inventory.Add(item);
    }
    public GameObject GetTool(){
        return tools[toolIter];
    }
    public void NextTool(){
        toolIter++;
        
        if (toolIter == tools.Length)
            toolIter = 0; 
    }
}
