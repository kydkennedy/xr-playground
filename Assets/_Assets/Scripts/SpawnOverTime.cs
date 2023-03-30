using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOverTime : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeBetweenSpawns = 2f;
    float _currentTime;

   
    void OnEnable()
    {
        Spawn();
        _currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
       // Debug.Log(_currentTime);
       if (_currentTime >= timeBetweenSpawns) {
            _currentTime = 0;
            //  Debug.Log("Time");
            Spawn();
        };
    }

    public void Spawn()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);

    }

}
