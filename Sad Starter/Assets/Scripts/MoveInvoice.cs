using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInvoice : MonoBehaviour
{
    public GameObject gameObject;
    public float speed;

    float timer = 0.0f; // begins at this value
    float timerMax = 5.0f; // event occurs at this value

    // Start is called before the first frame update.
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -speed, 0);
        timer += Time.deltaTime;


        if (timer >= timerMax)
        {
            Destroy(gameObject);
        }
    }
}