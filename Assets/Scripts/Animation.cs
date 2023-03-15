using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public List<Texture> frames = new List<Texture>();
    private Texture firstFrame;
    private int frameCount;
    // Start is called before the first frame update
    void Start()
    {
        firstFrame = gameObject.GetComponent<MeshRenderer>().material.GetTexture("Walk cycle000");
        frameCount = 0;
    }

    public IEnumerator animationDelay()
    {

        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
