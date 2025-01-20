using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    private float _size = 1f;
    private int _score = 0;
    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);
        int type = Random.Range(1, 5);

        switch (type)
        {
            case 1:
                _size = 0.6f;
                _score = 1;
                _renderer.color = new Color(50 / 255f, 50 / 255f, 1f, 1f);
                break;
            case 2:
                _size = 1.2f;
                _score = 2;
                _renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
                break;
            case 3:
                _size = 1.8f;
                _score = 3;
                _renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
                break;
            case 4:
                _size = 0.8f;
                _score = -5;
                _renderer.color = new Color(255 / 255f, 70 / 255f, 52 / 255f, 1f);
                break;
            default:
                break;
        }

        transform.localScale = new Vector3(_size, _size, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) Destroy(this.gameObject);
        else if (collision.gameObject.CompareTag("Player")) 
        { 
            GameManager.Instance.AddScore(_score);
            Destroy(this.gameObject);
        }
    }
}
