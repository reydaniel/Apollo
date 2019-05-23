using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMercury : MonoBehaviour
{
    public Animator Mercury;

    // Start is called before the first frame update
    void Start()
    {
        Mercury = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Mercury.Play("backMercury");
    }
}
