using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPreFabs : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cube, new Vector3(-2, 0, 0), Quaternion.identity);
        Instantiate(Cube, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Cube, new Vector3(2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
