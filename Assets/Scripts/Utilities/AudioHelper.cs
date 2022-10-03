using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioHelper
{
    public static void PlayClipAtPoint(AudioClip clip, Vector3 pos, float volume = 1f)
    {
        GameObject tempGO = new GameObject("TempAudio");
        
        tempGO.transform.position = pos;
        AudioSource aSource = tempGO.AddComponent<AudioSource>();
        aSource.clip = clip;
        aSource.loop = false;

        aSource.volume = volume;
        aSource.spatialBlend = 1f;

        aSource.minDistance = 1f;
        aSource.maxDistance = 10f;

        aSource.Play();

        Object.Destroy(tempGO, clip.length);

    }
}