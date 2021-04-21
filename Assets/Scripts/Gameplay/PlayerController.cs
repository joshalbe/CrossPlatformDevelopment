using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _startingEnergy;
    public float _energy;


    public float Energy
    {
        get
        {
            return _energy;
        }
        set
        {
            _energy = value;
        }
    }

    public void GetEnergy(float amount)
    {
        _energy += amount;
    }

    public void SpendEnergy(float amount)
    {
        if (amount > _energy)
            return;

        _energy -= amount;
    }

    // Start is called before the first frame update
    void Start()
    {
        _energy = _startingEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
