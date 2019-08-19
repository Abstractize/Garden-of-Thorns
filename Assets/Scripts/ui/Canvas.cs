using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public GameObject player;
    private Menu menu;
    private Image itemsGO;
    private Image toolsGO;

    private void Awake() {
        menu = player.GetComponent<Menu>();
        itemsGO = transform.GetChild(0).GetComponent<Image>();
        toolsGO = transform.GetChild(1).GetComponent<Image>();
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {       
        itemsGO.sprite = menu.GetItem().GetComponent<Items>().spr;
        toolsGO.sprite = menu.GetTool().GetComponent<Tools>().sprite;
    }
}
