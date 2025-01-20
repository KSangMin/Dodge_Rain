using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _direction = 1f;
    private float _speed = 4f;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _direction *= -1f;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }
        if (transform.position.x > 2.4f)
        {
            _spriteRenderer.flipX = true;
            _direction = -1f;
        }
        else if (transform.position.x < -2.4f)
        {
            _spriteRenderer.flipX = false;
            _direction = 1f;
        }
        transform.position += Vector3.right * Time.deltaTime * _speed * _direction;
    }
}
