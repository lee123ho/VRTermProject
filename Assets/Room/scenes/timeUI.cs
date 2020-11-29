using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class timeUI : MonoBehaviour
{
    private TextMeshProUGUI _timerText;
    private float _time;

    private void Awake()
    {
        _timerText = GetComponent<TextMeshProUGUI>();
        _time = 500f;
    }

    private void Update()
    {
        _time -= Time.deltaTime;
        _timerText.text = $"{(int)_time}";
    }
}
