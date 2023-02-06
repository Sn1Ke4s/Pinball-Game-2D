using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelGoalText : MonoBehaviour
{
    public static int Grass = 0;
    private TextMeshProUGUI _text;

    [SerializeField] private GameObject _woodObstacle;
    [SerializeField] private AudioSource _winVoice;
    [SerializeField] private GameObject _winPoint;
    [SerializeField] private TextMeshProUGUI _winText;

    private void Start()
    {
        Grass = 0;
        _text = GetComponent<TextMeshProUGUI>();
        _winText.gameObject.SetActive(false);
        _winPoint.gameObject.SetActive(false);
    }

    private void Update()
    {
        _text.text = $"Grass need to win: {Grass}/1000";
        if(Grass == 1000)
        {
            _text.gameObject.SetActive(false);
            _winText.gameObject.SetActive(true);
            _woodObstacle.gameObject.SetActive(false);
            _winPoint.gameObject.SetActive(true);
            _winVoice.Play();

        }
    }
}
