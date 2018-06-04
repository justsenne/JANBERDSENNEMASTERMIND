using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newColor : MonoBehaviour {

    public Material[] materials;
    public Renderer rend;
    private int index = 1;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnMouseDown()
    {
        if (materials.Length == 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            index = 1;
        }
        rend.sharedMaterial = materials[index - 1];
    }
}
