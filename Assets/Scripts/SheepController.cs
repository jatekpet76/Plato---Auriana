using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public GameObject sheep;

    public int position;

    public bool doSpin = false;

    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = sheep.gameObject.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("isSpinning", doSpin);
    }
}
