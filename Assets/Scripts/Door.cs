using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        anim.SetTrigger("Open");
    }

    public void CloseDoor()
    {
        anim.SetTrigger("Close");
    }
}
