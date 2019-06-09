using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager> {


    public AudioClip cursor;
    public AudioClip drop;
    public AudioClip control;
    public AudioClip lineClear;

    private AudioSource[] mAudioSources;

    private bool mIsMute;

	// Use this for initialization
	protected override void Awake () {
        base.Awake();
        mAudioSources = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayCursor()
    {
        PlayAudio(cursor,1);
    }

    private void PlayAudio(AudioClip clip, int index)
    {
        if (mIsMute) return;
        mAudioSources[index].clip = clip;
        mAudioSources[index].Play();
    }




}
