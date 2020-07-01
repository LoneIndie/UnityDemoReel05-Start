using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("walk", true);
            anim.SetBool("punch", false);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.SetBool("walk", false);
            anim.SetBool("punch", true);
        }
    }
}
