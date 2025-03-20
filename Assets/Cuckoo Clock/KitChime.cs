using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public void Chime(int hour)
    {
        Debug.Log("Chiming " +hour +"O'clock");
    }

    public void ChimeWithoutArguements()
    {
        Debug.Log("Chiming");
    }
}
