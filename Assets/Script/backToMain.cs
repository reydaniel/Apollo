using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backToMain : MonoBehaviour
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
                // timer = 0f;
                
            }
            
        }

    }

    public void resetTime()
    {
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer/gazeTime;
        gazedAt = false;
    }

    // public void ChangeScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void PointerEnter()
    {
        RadialProgress.GetComponent<Image>().fillAmount = timer/gazeTime;
        gazedAt = true;
        Debug.Log("PointerEnter");
        
    }
    public void PointerDown()
    {
        if (timer >= gazeTime){
            SceneManager.LoadScene("MainMenu");
        }
        Debug.Log("PointerDown");
    }
}
