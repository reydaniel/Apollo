using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backVenus : MonoBehaviour
{
   public Animator Venus;

    // Start is called before the first frame update
    void Start()
    {
        Venus = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Venus.Play("backVenus");
    }
}
