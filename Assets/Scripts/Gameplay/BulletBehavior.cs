using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _despawnTime;

    public Rigidbody Rigidbody
    {
        get
        {
            return _rigidbody;
        }
    }

    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    private void Awake()
    {
        //Get a reference to this object's rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Destroy this object once after enough time has passed
        Destroy(gameObject, _despawnTime);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        HealthBehavior health = other.GetComponent<HealthBehavior>();

        if (health)
            health.TakeDamage(Damage);
        
    }
}
