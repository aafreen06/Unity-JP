using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shape : MonoBehaviour
{
    public Text t;
    public string colors { get; set; }
    public void Call()
    {
        this.NameColor();
        print("Call");
    }



    protected virtual void NameColor() 
    {
        print("Virtual Call");
        t.text = colors;
    }
}
