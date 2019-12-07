using UnityEngine;
using System.Collections;

public class Parallax: MonoBehaviour
{
    private float length, startPos;
    public GameObject Camera;

    [Range(1,10)]
    public float ParallaxModifier;
    // Use this for initialization
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        var temp = Camera.transform.position.x * (1 - ParallaxModifier);
        float dist = Camera.transform.position.x * ParallaxModifier;

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if (temp > startPos) startPos += length;
        else if (temp < startPos - length) startPos -= length;
    }
}
