using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backUranus : MonoBehaviour
{
    public Animator Neptune;

    // Start is called before the first frame update
    void Start()
    {
        Neptune = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Neptune.Play("backUranus");
    }
}
