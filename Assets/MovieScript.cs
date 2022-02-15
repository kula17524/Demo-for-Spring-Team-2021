using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MovieScript : MonoBehaviour
{
    VideoPlayer videoPlayer;
    [SerializeField] VideoClip videoClip;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.clip = videoClip;
        videoPlayer.playOnAwake = true;
        videoPlayer.loopPointReached += FinishPlayingVideo;
    }

    public void FinishPlayingVideo(VideoPlayer vp)
    {
        videoPlayer.Stop();
        SceneManager.LoadScene("Title Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
