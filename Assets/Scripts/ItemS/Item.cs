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
    public GameObject _effect;

    public void Recolected()
    {
        Destroy(gameObject);
    }

    public void CreateParticles()
    {
        Instantiate(_effect, transform.position, Quaternion.identity);
    }
}
