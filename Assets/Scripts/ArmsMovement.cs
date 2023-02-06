using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _leftArm;
    [SerializeField] private Rigidbody2D _rightArm;

    [SerializeField] private float _power;

    [SerializeField] private Button _leftArmButton;
    [SerializeField] private Button _rightArmButton;

    private Action _onLeftButton;
    private Action _onRightButton;

    private void Awake()
    {
        _leftArmButton.onClick.AddListener(OnLeftArmButtonClicked);
        _rightArmButton.onClick.AddListener(OnRightArmButtonClicked);
    }

    private void OnLeftArmButtonClicked()
    {
        _onLeftButton?.Invoke();
        _leftArm.AddForce(Vector2.up * _power);
    }

    private void OnRightArmButtonClicked()
    {
        _onRightButton?.Invoke();
        _rightArm.AddForce(Vector2.up * _power);
    }


}
