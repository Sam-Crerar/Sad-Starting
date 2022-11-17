using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvoice : MonoBehaviour
{
    // Create my game objects for left / right bounds.
    public GameObject invoice;
    public GameObject leftBound;
    public GameObject rightBound;
    private float leftX;
    private float rightX;
    private float leftY;
    private float rightY;

    // Start is called before the first frame update
    void Start()
    {
        leftX = leftBound.transform.position.x;
        rightX = rightBound.transform.position.x;
        leftY = leftBound.transform.position.y;
        rightY = rightBound.transform.position.y;

        StartCoroutine(SpawnInvoices());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnInvoices()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            var floatX = NextFloat(leftX, rightX);
            var floatY = NextFloat(leftY, rightY);

            Instantiate(invoice, new Vector3(floatX, floatY, 0), new Quaternion(0, 0, 0, 0));
        }
    }

    static float NextFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}