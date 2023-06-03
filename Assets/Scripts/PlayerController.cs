using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    Rigidbody2D _rb = default;
    [SerializeField] GameObject _kickPrefab = default;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        _rb.velocity = h * Vector2.right * _speed;

        if (Input.GetButton("Jump"))
        {
            Instantiate(_kickPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
