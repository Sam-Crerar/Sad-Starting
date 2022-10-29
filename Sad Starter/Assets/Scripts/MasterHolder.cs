using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public float points { get; set;}
    public float multiplier { get; set; }
    public float passiveIncome { get; set; }


    void Start()
    {
        points = 0;
        multiplier = 0;
        passiveIncome = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
