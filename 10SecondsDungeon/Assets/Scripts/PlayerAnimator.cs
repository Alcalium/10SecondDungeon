using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator am;
    PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = pm.moveDir;

        if (moveDir.magnitude > 0.1f)
        {
            am.SetBool("Move", true);


            if (Mathf.Abs(moveDir.x) > Mathf.Abs(moveDir.y))
            {
                am.SetFloat("Horizontal", moveDir.x);
            }
            else if (Mathf.Abs(moveDir.y) > Mathf.Abs(moveDir.x))
            {
                am.SetFloat("Vertical", moveDir.y);
            }
            else
            {
                am.SetFloat("Horizontal", moveDir.x);
            }
        }
       
        else
        {
            am.SetBool("Move", false);
            am.SetFloat("Horizontal", 0f);
            am.SetFloat("Vertical", 0f);
        }
    }
}
