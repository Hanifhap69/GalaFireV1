using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float HorizontalAxis = Input.GetAxis("Horizontal");

        print(HorizontalAxis);
    }
}
