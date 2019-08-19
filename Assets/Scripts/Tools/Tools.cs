using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tools: MonoBehaviour
{
    public Sprite sprite;
    public type t;
    public abstract void Action();
}public enum type
{
    knife,picaxe,pan
}
