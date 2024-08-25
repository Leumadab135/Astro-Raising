using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPiragna : Item
{
    const float PIRAGNA_DAMAGE = -20;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Recolected();

        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            PlayerDetections playerDetections = collision.gameObject.GetComponent<PlayerDetections>();
            jetpack.AddEnergy(PIRAGNA_DAMAGE);


            Recolected();
        }
    }

    public override void Recolected()
    {
        base.Recolected();
    }
}

