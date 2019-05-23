using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backJupiter : MonoBehaviour
{
    public Animator Jup;

    // Start is called before the first frame update
    void Start()
    {
        Jup = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jup.Play("backJupiter");
    }
}
