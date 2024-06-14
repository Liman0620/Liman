using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingGame : MonoBehaviour
{
    public Slider audioSlider;
    public Toggle audioToggle;
    public Text audioName;
    public AudioSource au;
    public AudioClip[] audioClips=new AudioClip[4];
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSlider=audioSlider.GetComponent<Slider>();
        audioToggle=audioToggle.GetComponent<Toggle>();
        audioName= audioName.GetComponent<Text>();
        au= au.GetComponent<AudioSource>();
        au.clip = audioClips[index];//默认播放第一首音乐
        audioName.text = au.clip.name;
        au.Play();
    }
    public void UpMusic()
    {
        index++;
        if(index == audioClips.Length)
        {
            index= 0;
        }
        au.clip = audioClips[index];
        au.Play();
        audioName.text = au.clip.name;
    }
    public void DownMusic() 
    { 
        index--;
        if(index <0)
        {
            index= audioClips.Length-1;
        }
        au.clip = audioClips[index];
        au.Play();
        audioName.text = au.clip.name;
    }


    // Update is called once per frame
    void Update()
    {
        au.volume = audioSlider.value;
        au.mute = audioToggle.isOn;
    }
}
