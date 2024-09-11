using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;
    AudioSource source; //initializes an audiosource into the script

    private void Start()
    {
        anim = GetComponent<Animator>();
        source = gameObject.AddComponent<AudioSource>(); //assgins source to have a component added from a gameobject (in this case the door)
    }
    public void OpenDoor()
    {
        anim.SetTrigger("Open");
        source.PlayOneShot((AudioClip)Resources.Load("Open Door")); //Plays sound clip from Resources folder
    }

    public void CloseDoor()
    {
        anim.SetTrigger("Close");
        source.PlayOneShot((AudioClip)Resources.Load("Close Door")); //Plays sound clip from Resources folder
    }
}
