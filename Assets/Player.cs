using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Color Color { get; private set; }
    private Rigidbody _rigidbody;
    private Renderer _renderer;
    
    private string _materialName = "colored";
    [SerializeField] private float _force;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Initialize(ColorProvider colorProvider)
    {
        
        _renderer = GetComponent<Renderer>();
        
        Instantiate(this.gameObject, Vector3.zero, Quaternion.identity);
        
        var color = colorProvider.GetColor();
        
        var material = FindMaterialByNameInRenderer(_renderer, _materialName);
        
        if (material != null)
        {
            material.color = color;
            Color = color;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToMouseDirection();
        }
    }
    
    private Material FindMaterialByNameInRenderer(Renderer renderer, string materialName)
    {
       
        foreach (Material material in renderer.sharedMaterials)
        {
            // Сравниваем имена материалов
            
            if (material.name == materialName)
            {
                return material; 
            }
        }

        return null;
    }

    private void MoveToMouseDirection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 mousePos = hit.point;
            Vector3 direction = mousePos - transform.position;

            _rigidbody.AddForce(direction * _force, ForceMode.Impulse);
        }
    }
}