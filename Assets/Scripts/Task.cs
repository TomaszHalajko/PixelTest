using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public string Description;

    [SerializeField]
    private bool completed;

    public void SetCompleted(bool isCompleted)
    {
        completed = isCompleted;
    }
}
