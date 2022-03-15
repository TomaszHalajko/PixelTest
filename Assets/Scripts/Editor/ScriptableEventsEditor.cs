﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameEvent))]
public class ScriptableEventsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var script = (GameEvent)target;

        if (GUILayout.Button("Raise", GUILayout.Height(40)))
        {
            script.Raise();
        }

    }
}
