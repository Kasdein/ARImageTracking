using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaneVisibilityManager : MonoBehaviour
{
    public Color initialPlaneColour = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    // Start is called before the first frame update
    void Start()
    {
        ARPlaneManager planeManager = GetComponent<ARPlaneManager>();
        planeManager.planesChanged += OnplanesChanged;
    }

    public void OnplanesChanged(ARPlanesChangedEventArgs args)
    {
        List<ARPlane> changed = args.updated;
        for (int i = 0; i < changed.Count; i++)
        {
            changed[i].gameObject.GetComponent<Renderer>().material.SetColor("_TexTintColor", initialPlaneColour);
            StartCoroutine(ChangeColour(changed[i]));
        }
        List<ARPlane> added = args.added;
        for (int i = 0; i < added.Count; i++)
        {
            StartCoroutine(ChangeColour(added[i]));
        }
    }
    IEnumerator ChangeColour(ARPlane plane)
    {
        float alpha = initialPlaneColour.a;
        Renderer renderer = plane.gameObject.GetComponent<Renderer>();
        while (alpha > 0.0f)
        {
            renderer.material.SetColor("_TextTintColor", new Color(initialPlaneColour.r, initialPlaneColour.g, initialPlaneColour.b, alpha));
            alpha -= 0.01f;
            yield return null;
        }
    }
}
