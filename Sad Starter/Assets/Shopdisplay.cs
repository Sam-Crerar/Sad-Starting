using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopdisplay : MonoBehaviour
{
    public GameObject shopCanvas;
    public GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenShops()
    {
        Time.timeScale = 0.0f;
        shopCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }

    public void CloseShops()
    {
        Time.timeScale = 1.0f;
        shopCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }
}
