using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUpgrade : MonoBehaviour
{
    public GameObject gameobject;

    private MasterHolder masterHolder;
    // Start is called before the first frame update
    void Start()
    {
        masterHolder = gameobject.GetComponent<MasterHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buy()
    {
        masterHolder.passiveIncome += 1; 
    }
}
