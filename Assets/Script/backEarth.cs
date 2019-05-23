using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backEarth : MonoBehaviour
{
    public Animator Earth;

    // Start is called before the first frame update
    void Start()
    {
        Earth = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Earth.Play("backEarth");
    }
}
