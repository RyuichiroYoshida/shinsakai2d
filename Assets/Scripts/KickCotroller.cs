using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickCotroller : MonoBehaviour
{
    [SerializeField] float _kickPowar = 10f;
    [SerializeField] GameObject _kickPrefab = default;
    [SerializeField] float _kickLifeTime = 0.5f;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(_kickPowar * Vector2.left);
            
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(_kickPrefab, _kickLifeTime);
    }
}
