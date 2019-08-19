using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public List<GameObject> inventory;
    public GameObject[] tools;

    [SerializeField]private int invIter;
    [SerializeField]private int toolIter;

    private void Awake() {
        this.invIter = 0;
        this.toolIter = 0;
    }
    public GameObject GetItem(){
        return this.inventory[this.invIter];
    }
    public void NextItem(){
        this.invIter++;
        if (this.invIter == this.inventory.Capacity)
            this.invIter = 0; 
    }
    public void DeleteItem(int item){
        this.inventory.RemoveAt(item);
        if (this.invIter >= this.inventory.Capacity)
            this.invIter = 0;
    }
    public void AddItem(GameObject item){
        this.inventory.Add(item);
    }
    public GameObject GetTool(){
        Debug.Log(this.toolIter);
        return this.tools[this.toolIter];
    }
    public void NextTool(){
        this.toolIter++;
        
        if (this.toolIter == this.tools.Length)
            this.toolIter = 0; 
    }
}
