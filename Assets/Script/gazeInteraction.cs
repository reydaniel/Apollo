using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class gazeInteraction : MonoBehaviour
{
    public float gazeTime = 2f;
    public Transform RadialProgress;
    private float timer = 0f;
    private bool gazedAt;

    // Use this for initialization
    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = timer;
    }

    // Update is called once per frame
    public void Update()
    {

        if (gazedAt)
        {
            timer += Time.deltaTime;

            RadialProgress.GetComponent<Image>().fillAmount = timer/gazeTime;

            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
                
            }
            
        }

    }

    public void resetTime()
    {
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer/gazeTime;
        
    }

    public void PointerEnter()
    {
        RadialProgress.GetComponent<Image>().fillAmount = timer/gazeTime;
        gazedAt = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }
}
