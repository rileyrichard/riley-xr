﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// Play a single video or play from a list of videos 
/// </summary>
[RequireComponent(typeof(VideoPlayer))]
public class PlayVideo : MonoBehaviour
{
    [Tooltip("Whether video should play on load")]
    public bool playAtStart = false;

    [Tooltip("Material used for playing the video (Uses URP/Unlit by default)")]
    public Material videoMaterial = null;

    [Tooltip("List of video clips to pull from")]
    public List<VideoClip> videoClips = new List<VideoClip>();

    private VideoPlayer videoPlayer = null;
    private MeshRenderer meshRenderer = null;

    private readonly string shaderUsed = "Universal Render Pipeline/Unlit";

    private Material offMaterial = null;
    public int index;


    void Update(){
        
    }
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoClips.Count > 0)
            videoPlayer.clip = videoClips[0];

        offMaterial = meshRenderer.material;

        videoMaterial = new Material(Shader.Find(shaderUsed));
        videoMaterial.color = Color.white;
    }


    private void Start()
    {
        if (playAtStart)
        {
            Play();
        }
        else
        {
            Stop();
        }
    }

    public void NextClip()
    {
        index = ++index % videoClips.Count;
        Play();
    }

    public void PreviousClip()
    {
        index = --index % videoClips.Count;
        Play();
    }

    public void RandomClip()
    {
        if (videoClips.Count > 0)
        {
            index = Random.Range(0, videoClips.Count);
            Play();
        }
    }

    public void PlayAtIndex(int value)
    {
        if (videoClips.Count > 0)
        {
            index = Mathf.Clamp(value, 0, videoClips.Count);
            Play();
        }
    }

    public void Play()
    {
        if(index == 1){
            videoPlayer.url = "Assets/Video/yt5s.com-Among Us Trap Remix Bass Boosted Leonz.mp4";
        }else if(index == 2){
            videoPlayer.url = "Assets/Video/yt5s.com-Binging with Babish_ Isotope Dog from The Simpsons.mp4";
        }else if(index == 3){
            videoPlayer.url = "Assets/Video/yt5s.com-Man Punches a Kangaroo in the Face to Rescue His Dog (Original HD) __ ViralHog.mp4";
        }else if(index == 4){
            videoPlayer.url = "Assets/Video/yt5s.com-It Appears We Have Been Boarded By Another Ship meme-(480p).mp4";
        }else if(index == 5){
            videoPlayer.url = "Assets/Video/yt5s.com-Monkey Paying for Pizza Delivery-(480p).mp4";
        }else{
            videoPlayer.url = "Assets/Video/yt5s.com-Funny Vine - _Just a spoon full_(360p).mp40";
        }
        ApplyVideoMaterial();
        videoPlayer.Play();
    }

    public void Stop()
    {
        meshRenderer.material = offMaterial;
        videoPlayer.Stop();
    }

    public void TogglePlayStop()
    {
        bool isPlaying = !videoPlayer.isPlaying;
        SetPlay(isPlaying);
    }

    public void TogglePlayPause()
    {
        meshRenderer.material = videoMaterial;

        if (videoPlayer.isPlaying)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }

    public void SetPlay(bool value)
    {
        if (value)
        {
            Play();
        }
        else
        {
            Stop();
        }
    }

    private void ApplyVideoMaterial()
    {
        meshRenderer.material = videoMaterial;
    }

    private void OnValidate()
    {
            
        if (TryGetComponent(out VideoPlayer videoPlayer))
            videoPlayer.targetMaterialProperty = "_BaseMap";
    }
}