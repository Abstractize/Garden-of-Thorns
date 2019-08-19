using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public List<GameObject> inventory;
    public GameObject[] tools;

    protected int invIter = 0;
    protected int toolIter = 0;

    public GameObject GetItem(){
        return inventory[invIter];
    }
    public void NextItem(){
        invIter++;
        if (invIter == inventory.Capacity)
            invIter = 0; 
    }
    public void DeleteItem(){
        inventory.RemoveAt(invIter);
        if (invIter >= inventory.Capacity)
            invIter = 0;
    }
    public void AddItem(GameObject item){
        inventory.Add(item);
    }
    public GameObject GetTool(){
        Debug.Log(toolIter);
        return tools[toolIter];
    }
    public void NextTool(){
        toolIter++;
        
        if (toolIter == tools.Length)
            toolIter = 0; 
    }
}
