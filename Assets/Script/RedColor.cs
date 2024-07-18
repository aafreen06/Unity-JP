using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColor : Shape
{

    public RedColor()
    {
        colors = "Color : Red \n Shape : Star";
        print("Red Constructor Running");
    }

    protected override void NameColor()
    {
        print("Override Call Red");
        base.NameColor();
    }
}
