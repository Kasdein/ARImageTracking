using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public List<Texture> frames = new List<Texture>();
    private Texture firstframe;
    // Start is called before the first frame update
    void Start()
    {
        firstframe = gameObject.GetComponent<MeshRenderer>().material.GetTexture("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
