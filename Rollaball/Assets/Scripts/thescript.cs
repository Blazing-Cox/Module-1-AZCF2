using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thescript : MonoBehaviour
{
    public GameObject sizeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sizeObject.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
    }
}
