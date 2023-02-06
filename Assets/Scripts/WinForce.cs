using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinForce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _ballRigidbody;
    [SerializeField] private GameObject _winPoint;
    [SerializeField] private Button _restartButton;
    [SerializeField] private GameObject _winPanel;

    [SerializeField] private float _forceValue;

    private Action _OnRestart;

    private void Awake()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClicked);
        _winPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            _ballRigidbody.AddForce(_ballRigidbody.transform.position * _forceValue, ForceMode2D.Impulse);
            _winPanel.gameObject.SetActive(true);
        }
    }

    private void OnRestartButtonClicked()
    {
        _OnRestart?.Invoke();
        SceneManager.LoadScene(0);
    }
}
