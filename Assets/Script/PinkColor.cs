using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkColor : Shape
{
    public PinkColor()
    {
        colors = "Color : Pink \n Shape : Square";
        print("Pink Constructor Running");
    }

    protected override void NameColor()
    {
        print("Override Call Pink");
        base.NameColor();
    }
}
