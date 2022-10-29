using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatingOnBut : MonoBehaviour
{
    public GameObject GameManager;
    public MasterHolder script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameManager.GetComponent<MasterHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Morepoints()
    {
        script.points += 10;
    }
}
