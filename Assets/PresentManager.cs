using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PresentManager : MonoBehaviour
{
    [SerializeField] private Present _present;
    [SerializeField] private int _count;


    public void Initialize(ColorProvider colorProvider)
    {
        
        for (int i = 0; i < _count; i++)
        {
            var color = colorProvider.GetColor();
            var gift = Instantiate(_present, GetRandomPosition(), Quaternion.identity);
            gift.Initialize(color);
        }
    }


    private Vector3 GetRandomPosition()
    {
        int randomX = Random.Range(-8, 8);
        int randomZ = Random.Range(-8, 8);
        return new Vector3(randomX, 0, randomZ);
    }
}