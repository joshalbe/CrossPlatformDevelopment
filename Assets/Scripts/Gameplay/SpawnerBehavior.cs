using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _spawnedEntity;
    [SerializeField]
    private float _spawnTimer;
    [SerializeField]
    private bool _canSpawn;
    [SerializeField]
    private GameObject _targetEntity;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEntities());
    }

    //Spawns Entities as long as it can
    public IEnumerator SpawnEntities()
    {
        while (_canSpawn)
        {
            //Create a new enemy in the scene
            GameObject spawnedEnemy = Instantiate(_spawnedEntity, transform.position, transform.rotation);
            //Set the enemy target to be the target the spawner was given
            spawnedEnemy.GetComponent<MovementEnemy>().Target = _targetEntity;
            //Pause for the given time in seconds before resuming the function
            yield return new WaitForSeconds(_spawnTimer);
        }
    }
}
