using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskHUD : MonoBehaviour
{
    [SerializeField]
    private Task task;
    [SerializeField]
    private TextMeshProUGUI taskText;

    private void Start()
    {
        taskText.text = task.Description;
    }
}
