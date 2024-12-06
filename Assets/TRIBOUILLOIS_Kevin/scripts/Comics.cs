using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new_comics", menuName ="Comics", order = 0)]

public class Comics : ScriptableObject
{
    public string comicsName;
    public int pageBase;
    public Sprite comicsImage;
    public int comicsPrice;
}
