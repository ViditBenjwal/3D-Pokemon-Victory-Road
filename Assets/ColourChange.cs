using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public DestroyWall destroyWall;
    public Material[] material;
    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Trig")
        {
            rend.sharedMaterial = material[1];
            Destroy (destroyWall.MoveWall);
        }
    }
}
