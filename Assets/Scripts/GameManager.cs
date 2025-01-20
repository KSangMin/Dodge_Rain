using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject raindrop;
    private int _score = 0;
    private float _time = 10;

    public Text scoreText;
    public Text TimeText;

    public GameObject endPanel;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateRain", 0f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        if(_time > 0)
        {
            _time -= Time.deltaTime;
        }
        else
        {
            _time = 0f;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        TimeText.text = _time.ToString("N1");
    }

    public void CreateRain()
    {
        Instantiate(raindrop);
    }

    public void AddScore(int score)
    {
        _score += score;
        scoreText.text = _score.ToString();
    }
}
