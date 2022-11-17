using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInvoice : MonoBehaviour
{
    public GameObject gameObject;
    public float speed;

    // Start is called before the first frame update.
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -speed, 0);
    }
}