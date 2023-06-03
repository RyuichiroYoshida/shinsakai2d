using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab = default;
    [SerializeField] float _enemySpawnTime = 2f;
    //Transform SpawnPosition = default(Transform);
    float _timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Transform SpawnPosition = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _enemySpawnTime)
        {
            _timer = 0;
            Instantiate(_enemyPrefab, this.transform.position, Quaternion.identity);
            _enemySpawnTime -= 0.0001f;
        }
    }
}
