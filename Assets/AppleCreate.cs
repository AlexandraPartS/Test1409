using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCreate : MonoBehaviour
{
    public GameObject applePrefab;
    public Material material;
    //private Vector3 pos;
    //private Color color;



    void Start()
    {
        Apple apple1 = new Apple();
        Debug.Log(apple1.color);

        Apple apple2 = new Apple(Color.yellow);
        Debug.Log(apple2.color);

        Apple apple3 = new Apple(applePrefab, material, 1, 2, 0, Color.yellow);

    }

}
