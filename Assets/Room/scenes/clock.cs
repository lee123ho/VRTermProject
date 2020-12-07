using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private void Update()
    {
        var dir = transform.position - _target.position;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
