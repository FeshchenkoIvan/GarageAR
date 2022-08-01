using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeInfo : MonoBehaviour
{
    [SerializeField] GameObject panelRuntime;
    float timer = 1;
    int touchCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touchCount>0)
        {
            if (timer<0)
            {
                timer = 1; touchCount = 0;
            }
            else
            {
                timer -= Time.deltaTime;
                if (touchCount>=3)
                {
                    timer = 1; touchCount = 0; panelRuntime.SetActive(true);
                }
            }
        }
    }
    public void ClickButtonDeveloper()
    {
        touchCount += 1;
    } 
}
