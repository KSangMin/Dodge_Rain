using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject raindrop;
    private int _score = 0;

    public Text scoreText;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateRain", 0f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
