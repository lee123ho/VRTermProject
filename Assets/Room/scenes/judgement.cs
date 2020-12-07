using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judgement : MonoBehaviour
{
    private int count;
    private float _time;
    private attach[] _attaches;
    [SerializeField] private Transform _key;
    private void Awake()
    {
        _attaches = FindObjectsOfType<attach>();
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
    }

    private void OnTriggerExit(Collider other)
    {
        count = 0;
        _time = 0f;
    }

    private void OnTriggerStay(Collider other)
    {
        if (count >= 27)
            _time += Time.deltaTime;
    }

    private void Update()
    {
        if(_time >= 100)
        {
            foreach (var cube in _attaches)
                cube.gameObject.SetActive(false);
            _key.gameObject.SetActive(true);
            Destroy(gameObject);
        }
        _key.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
    }
}
