using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeachColor : Shape
{
    public PeachColor()
    {
        colors = "Color : Peach \n Shape : Circle";
        print("Peach Constructor Running");
    }

    protected override void NameColor()
    {
        print("Override Call Peach");
        base.NameColor();
    }
}
