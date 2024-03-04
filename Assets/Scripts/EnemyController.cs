using System.Linq;
using UnityEngine;

/// <summary>
/// Класс врага - цилиндра.
/// </summary>
public class EnemyController : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private Material _material;
    private Color _color;

    public void Initialize(Color color)
    {
        // Сохраняем colored материал
        var materials = _renderer.materials;
        _material = materials.First(material => material.name.Contains(GlobalConstants.COLORED_MATERIAL));
        
        _material.color = color;
        _color = color;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        // Если столкнувшийся с врагом объект - это Player
        if (collision.gameObject.TryGetComponent<Player>(out var player))
        {
            // Если цвет врага совпадает с цветом игрока
            if (player.Color == _color)
            {
                // Разрушаем врага
                Destroy(gameObject);
            }
        }
    }
}