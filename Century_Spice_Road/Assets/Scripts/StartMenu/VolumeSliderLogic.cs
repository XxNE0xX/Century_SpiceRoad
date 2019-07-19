using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderLogic : MonoBehaviour
{

    public AudioSource audioSrc;
    private Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = volumeSlider.value;
    }
}
