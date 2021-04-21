using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoalBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject _player;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        HealthBehavior health = _player.GetComponent<HealthBehavior>();
        if (health)
            health.TakeDamage(1);
    }
}
