using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _kickPower = 5f;
    Rigidbody2D _rb = default;
    GameObject _kick;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _kick = GameObject.FindGameObjectWithTag("kick");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        _rb.velocity = h * Vector2.right * _speed;

        if (Input.GetButton("Jump"))
        {
            Rigidbody2D rb = _kick.GetComponent<Rigidbody2D>();
            rb.AddForce(_kickPower * Vector2.left, ForceMode2D.Impulse);
        }
    }
}
