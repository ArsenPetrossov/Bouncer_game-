using UnityEngine;

/// <summary>
/// Контроллер игры, содержащий ссылку на ColorsProvider и инициализирующий EnemySpawner и SphereController.
/// </summary>
public class GameController : MonoBehaviour
{
    [SerializeField] private ColorsProvider _colorsProvider;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private Colorizer _colorizer;
    [SerializeField] private EnemiesView _enemiesView;

    private void Awake()
    {
        _enemiesView.Initialize(_colorsProvider);
        _enemySpawner.Initialize(_colorsProvider);
        _colorizer.Initialize(_colorsProvider);
    }
}