using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateControl : MonoBehaviour
{
    static GameObject pyramid;
    Animator animator;
    static int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        pyramid = GameObject.Find("niz");
        animator = pyramid.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        Input.simulateMouseWithTouches = true;
        Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                i++;
            }
        }
        animator.SetInteger("solution_stage", i);
    }
}
