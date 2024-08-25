using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemSpawner : MonoBehaviour
{
    //Attributes
    [SerializeField] private List<Item> _spawnList;
    private float _minSpawnTime = 1;
    private float _maxSpawnTime = 7;
    private float _nextSpawnTime;
    private float _cronoTime = 0;


    void Start()
    {
        ResetTime();
    }

    void Update()
    {
        _cronoTime += Time.deltaTime;

        if (_cronoTime > _nextSpawnTime)
        {
            ResetTime();
            SpawnItem();
        }
    }


    private void ResetTime()
    {
        _cronoTime = 0;
        _nextSpawnTime = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    private void SpawnItem()
    {
        //Random Object from a List
        int index = Random.Range(0, _spawnList.Count);
        float xPos = Random.Range(-7, 7);

        //Spawn Item in a random position
        Vector2 itemPosition = new Vector2(xPos, transform.position.y);
        Item newItem = Instantiate(_spawnList[index], itemPosition, Quaternion.identity);

        //Spawn with torque
        newItem.GetComponent<Rigidbody2D>().AddTorque(70);

        //Difficulty progression
        if(_maxSpawnTime < _minSpawnTime)
            _maxSpawnTime -= 0.1f;
    }
}

