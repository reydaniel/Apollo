using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMars : MonoBehaviour
{
    public Animator Mars;

    // Start is called before the first frame update
    void Start()
    {
        Mars = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Mars.Play("backMars");
    }
}
