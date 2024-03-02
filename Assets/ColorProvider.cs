using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class ColorProvider
{
    [SerializeField] private Color[] _colors;

    public Color GetColor()
    {
        int random = Random.Range(0, _colors.Length);
        return _colors[random];
    }
}