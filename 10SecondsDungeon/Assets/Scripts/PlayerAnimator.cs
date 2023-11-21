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

            am.SetFloat("Horizontal", moveDir.x);
            am.SetFloat("Vertical", moveDir.y);
        }
        else
        {
            am.SetBool("Move", false);
            am.SetFloat("Horizontal", 0f);
            am.SetFloat("Vertical", 0f);
        }
    }
}
