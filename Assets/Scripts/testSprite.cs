using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSprite : MonoBehaviour
{
    private Texture2D texture;
    public List<Vector3> v;
    public GameObject player;
    void Start()
    {
        texture = new Texture2D(250, 250);
        v = Points.pointsList;
        //texture

    }

    void Update()
    {
        Vector3 p = player.transform.position;
        int x;
        int y;
        Repaint();
        x = Convert.ToInt32((p.x + 10) * 1000) / 100 + 25;
        y = Convert.ToInt32((p.z + 10) * 1000) / 100 + 25;
        texture.SetPixel(x, y, Color.green);
        x = Convert.ToInt32((p.x + 10) * 1000) / 100 + 24;
        y = Convert.ToInt32((p.z + 10) * 1000) / 100 + 25;
        texture.SetPixel(x, y, Color.green);
        x = Convert.ToInt32((p.x + 10) * 1000) / 100 + 24;
        y = Convert.ToInt32((p.z + 10) * 1000) / 100 + 24;
        texture.SetPixel(x, y, Color.green);
        x = Convert.ToInt32((p.x + 10) * 1000) / 100 + 25;
        y = Convert.ToInt32((p.z + 10) * 1000) / 100 + 24;
        texture.SetPixel(x, y, Color.green);
        texture.Apply();

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
        for (int i = 0; i < 251; i++)
        {
            for (int j = 0; j < 251; j++)
            {
                texture.SetPixel(i, j, Color.gray);

            }
        }

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
