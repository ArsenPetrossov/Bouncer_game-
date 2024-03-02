using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ColorProvider _colorProvider;
    [SerializeField] private PresentManager _presentManager;
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.Initialize(_colorProvider);
        _presentManager.Initialize(_colorProvider);
    }
}