using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Класс, создающий врагов на сцене.
/// </summary>
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyController _enemyPrefab;
    [SerializeField] private int _enemiesCount = 6;
    [SerializeField] private int _randomRadius = 8;
    [SerializeField] private float _enemyRadius = 1;

    private ColorsProvider _colorsProvider;
    
    public void Initialize(ColorsProvider colorsProvider)
    {
        _colorsProvider = colorsProvider;
        
        for (var i = 0; i < _enemiesCount; i++)
        {
            var position =PositionGenerator.GetRandomPosition(_randomRadius);
            
            // Пока враг касается кого-либо - генерируем новую позицию
            while (position.HasCollisions(_enemyRadius))
            {
                position = PositionGenerator.GetRandomPosition(_randomRadius);
            }
            
            // Создаем объект врага
            var enemy = Instantiate(_enemyPrefab);
            
            // Задаем позицию врагу
            enemy.transform.position = position;

            // Передаем врагу цвет
            enemy.Initialize(_colorsProvider.GetColor());
        }
    }
}