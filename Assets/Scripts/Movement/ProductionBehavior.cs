using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionBehavior : MonoBehaviour
{
    [SerializeField]
    private float _spinspeed = 1;
    [SerializeField]
    GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * _spinspeed * Time.deltaTime);

        PlayerController player = _player.GetComponent<PlayerController>();
        if (player)
            player.GetEnergy(_spinspeed);
    }
}
