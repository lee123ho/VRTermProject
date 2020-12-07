using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private key _key;
    private Renderer _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _key = FindObjectOfType<key>();
        if (_key.active)
        {
            transform.position = _target.position;
            _material.material.color = new Color(0f, 0f, 0f, 1f); 
        }
    }
}
