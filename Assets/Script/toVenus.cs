﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toVenus : MonoBehaviour
{
    public Animator Anime;
    public float myTime = 0f;
    public Transform RadialProgress;

    // Start is called before the first frame update
    void Start()
    {
        Anime = GetComponent<Animator>();
        RadialProgress.GetComponent<Image>().fillAmount = myTime;
    }

    public void Update (){
        myTime += Time.deltaTime;

        RadialProgress.GetComponent<Image>().fillAmount = myTime/2;

        if (myTime >= 2f)
        {
            changeSpot();
        }
    }

    public void resetTime()
    {
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime;
    }

    // Update is called once per frame
    public void changeSpot()
    {
        Anime.Play("toVenus");
        
    }
}
