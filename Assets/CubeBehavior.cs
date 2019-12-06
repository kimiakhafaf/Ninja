using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 100 * Time.deltaTime);
    }
}
