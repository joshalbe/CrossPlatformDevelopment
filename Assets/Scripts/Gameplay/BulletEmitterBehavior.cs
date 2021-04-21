using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitterBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _shotSpeed;
    [SerializeField]
    private float _fireRate;
    private float _fireTimer = 0;


    private void Update()
    {
        _fireTimer += Time.deltaTime;
        if (_fireTimer > _fireRate)
        {
            _fireTimer = 0;
            Fire(-transform.up * _shotSpeed);
        }
    }

    public void Fire(Vector3 force)
    {
        

        GameObject firedBullet = Instantiate(_bullet, transform.position, transform.rotation);
        BulletBehavior bulletScript = firedBullet.GetComponent<BulletBehavior>();
        if (bulletScript)
            bulletScript.Rigidbody.AddForce(force, ForceMode.Impulse);

    }
}
