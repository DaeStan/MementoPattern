using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    public void SetColor(Color color)
    {
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = color;
        }
    }

    public Color GetColor()
    {
        return cubeRenderer.material.color;
    }
}
