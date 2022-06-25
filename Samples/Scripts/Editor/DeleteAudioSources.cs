using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

class DeleteAudioSources
{
    [MenuItem("Window/Fabric/Utils/DeleteAudioSources")]
    static void Delete()
    {
        AudioSource[] audioSources = Selection.activeGameObject.GetComponentsInChildren<AudioSource>(true);

        for (int i = 0; i < audioSources.Length; i++)
        {
            AudioSource audioSource = audioSources[i];

            GameObject.DestroyImmediate(audioSource);
        }
    }
}