using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRock : Item
{
    const float ROCK_FORCE = 10000;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Recolected();

        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            PlayerDetections playerDetections = collision.gameObject.GetComponent<PlayerDetections>();

            if (playerDetections.IsGrounded == false)
                jetpack.GetComponent<Rigidbody2D>().AddForce(Vector2.down * ROCK_FORCE);
            else
            {
                jetpack.GetComponent<Rigidbody2D>().AddForce(Vector2.up * ROCK_FORCE);
            }

            Recolected();
        }
    }

    public override void Recolected()
    {
        base.Recolected();
    }
}
