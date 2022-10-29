using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public GameObject GameManager;
    public MasterHolder script;
    public Text text;
    public int PointsPerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        script = GameManager.GetComponent<MasterHolder>();
        StartCoroutine(AddScoreOverTime());
    }

    // Update is called once per frame
    void Update()
    {
        text.text = script.points.ToString();
    }

    private IEnumerator AddScoreOverTime() { 
        while (true)
        {
            yield return new WaitForSeconds(1);
            script.points += PointsPerSeconds;
        }
    }
}
