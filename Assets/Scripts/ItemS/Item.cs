using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Item : MonoBehaviour, IRecolectable
{
    enum ItemTypes
    {
        None,
        Rock,
        Piragna,
        Reactor
    }

    //Attributes
    [SerializeField] ItemTypes Type { get; set; }
    public GameObject _particles;

    public virtual void Recolected()
    {
        Destroy(gameObject);
        CreateParticles();
    }

    private void CreateParticles()
    {
        Instantiate(_particles, transform.position, Quaternion.identity);
    }
}
