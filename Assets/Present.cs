using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    public Color Color { get; private set; }
    private Renderer _renderer;
    


    private void Awake()
    {
        
    }

    public void Initialize(Color color)
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = color;
        Color = color;
    }
}