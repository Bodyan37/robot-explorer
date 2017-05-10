using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static List<Vector3> pointsList = new List<Vector3>();
    void Start()
    {
        pointsList.Add(new Vector3(5, 0, 5));
    }
    
}
