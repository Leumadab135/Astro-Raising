using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Jetpack _jetpack;

    void Update()
    {
        //Horizontal Fly
        if (Input.GetAxis("Horizontal") > 0)
            _jetpack.FlyHorizontal(Jetpack.Direction.Right);
        if (Input.GetAxis("Horizontal") < 0)
            _jetpack.FlyHorizontal(Jetpack.Direction.Left);

        //Vertical Fly
        if (Input.GetAxis("Vertical") > 0)
            _jetpack.FlyUp();
        else
            _jetpack.StopFlying();

        //Moving while falling
        if (Input.GetAxis("Horizontal") > 0)
            _jetpack.Falling(Jetpack.Direction.Right);
        if (Input.GetAxis("Horizontal") < 0)
            _jetpack.Falling(Jetpack.Direction.Left);
    }
}
