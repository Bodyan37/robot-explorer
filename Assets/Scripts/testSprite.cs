using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSprite : MonoBehaviour
{
    private Texture2D texture;
    public List<Vector3> v;
    void Start()
    {
        texture = new Texture2D(250, 250);
        v = Points.pointsList;
        //texture

    }

    void Update()
    {
        Repaint();
        foreach (Vector3 e in v)
        {
            // print(e.ToString());
        }
        print(v != Points.pointsList);
        if (v != Points.pointsList)
        {
            v = Points.pointsList;
        }
    }


    void Repaint()
    {
        GetComponent<Renderer>().material.mainTexture = texture;
        int x;
        int y;
        foreach (Vector3 p in v)
        {
            x = Convert.ToInt32((p.x + 10) * 1000) / 100 + 25;
            y = Convert.ToInt32((p.z + 10) * 1000) / 100 + 25;
            print(x.ToString() + ' ' + y.ToString());
            texture.SetPixel(x, y, Color.red);
        }
        texture.Apply();
    }


}
