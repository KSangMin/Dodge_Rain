using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject raindrop;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateRain", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateRain()
    {
        Instantiate(raindrop);
    }
}
