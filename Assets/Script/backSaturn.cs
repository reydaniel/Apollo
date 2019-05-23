using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backSaturn : MonoBehaviour
{
    public Animator Saturn;

    // Start is called before the first frame update
    void Start()
    {
        Saturn = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Saturn.Play("backSaturn");
    }
}
