using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;

    public float Health
    {
        get
        {
            return _health;
        }
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
            _health = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
            Destroy(gameObject);
    }
}
