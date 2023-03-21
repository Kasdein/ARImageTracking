using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public List<Texture> frames = new List<Texture>();
    private int frameCount;
    public Material myMaterial;
    public float lengthOfFrame = 0.0417f;
    public float timeSinceLastFrame;
    public bool onLoop;
    public bool loopOnce;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastFrame += Time.deltaTime;

        if (timeSinceLastFrame >= lengthOfFrame && onLoop)
        {
            NextFrame();
            timeSinceLastFrame = 0;
        }
    }

    public void LoopEnabled()
    {
        onLoop = true;
    }

    void NextFrame()
    {
        if (frameCount < frames.Count - 1)
        {
            frameCount++;
        }
        else
        {
            frameCount = 0;
            if (loopOnce == true)
            {
                onLoop = false;
            }
        }

        myMaterial.SetTexture("_MainTex", frames[frameCount]);
    }
}
