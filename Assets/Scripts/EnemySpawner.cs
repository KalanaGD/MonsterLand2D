using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _enemyPrefabs;

    [SerializeField]
    private Transform _leftPos, _rightPos;

    private GameObject _spawnedEnemies;

    private int _randomIndex;
    private int _randomSide;


    private void Start()
    {
        StartCoroutine(SpawnedEnemies());

    }//Start

    private IEnumerator SpawnedEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f)); //Time Range

            _randomIndex = Random.Range(0, _enemyPrefabs.Length); //Select Enemies
            _randomSide = Random.Range(0, 2); //Randomise Side

            _spawnedEnemies = Instantiate(_enemyPrefabs[_randomIndex]); //spawn Enemies

            if (_randomSide == 0)
            {
                _spawnedEnemies.transform.position = _leftPos.position;
                _spawnedEnemies.GetComponent<EnemyController>()._speed = Random.Range(4f,8f);
                _spawnedEnemies.transform.localScale = new Vector3(1f, 1f,1f);
            }
            else 
            {
                _spawnedEnemies.transform.position = _rightPos.position;
                _spawnedEnemies.GetComponent<EnemyController>()._speed = -Random.Range(4f, 8f);

                _spawnedEnemies.transform.localScale = new Vector3(-1f,1f,1f);
            }

        }//loop

    }//SpawnedEnemies

}//class
