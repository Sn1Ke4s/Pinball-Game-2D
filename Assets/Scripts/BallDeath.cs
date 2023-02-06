using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDeath : MonoBehaviour
{
    [SerializeField] private Canvas _losePanel;
    [SerializeField] private GameObject _ball;

    private void Awake()
    {
        _losePanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            _losePanel.gameObject.SetActive(true);
        }
    }

    public void OnRestartClicked()
    {
        SceneManager.LoadScene(0);
    }
}
