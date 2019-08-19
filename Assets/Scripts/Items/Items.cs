using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items: MonoBehaviour
{
    public Sprite spr;
    public typeI t;

}
public enum typeI
{
    cebolla, lechuga, pizza, pizza_cocida, pizza_cruda, pizza_pan, pizza_quemada, salad, salami, tomate, queso,
    cebolla_cortada, tomate_cortado, awa, vapor, vegetales, fideos_crud
}
