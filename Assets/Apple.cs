using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public Color color = Color.green;
    private GameObject appleGO;

    // Default constructor.
    public Apple()
    {
    }

    public Apple(Color color)
    {
       this.color = color;
    }

    public Apple(GameObject applePrefab, Material material, int x, int y, int z, Color color)
    {
        appleGO = Instantiate(applePrefab, new Vector3(x, y, z), Quaternion.AngleAxis(30, Vector3.forward));
        appleGO.GetComponent<Renderer>().material = material;
        appleGO.GetComponent<Renderer>().material.color = color;

    }
}
