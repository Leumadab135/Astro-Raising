using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Jetpack _jetpack;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Flying animation
        _anim.SetBool("Flying", _jetpack._flying);

        //Fall animation
        if (_jetpack._fall)
            _anim.SetBool("Falling", true);
        else
            _anim.SetBool("Falling", false);

    }
}
