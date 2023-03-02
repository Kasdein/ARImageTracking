using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedState : MonoBehaviour
{
    public Material materialSelected;
    private Material materialDefault;
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        audioSource.clip = audioClip;
        materialDefault = gameObject.GetComponent<MeshRenderer>().material;
    }

    public void playAudio()
    {
        audioSource.Play();
    }

    public void setSelectedMaterial ()
    {
        gameObject.GetComponent<MeshRenderer>().material = materialSelected;
    }

    public void setDefaultMaterial ()
    {
        gameObject.GetComponent<MeshRenderer>().material = materialDefault;
    }


}
