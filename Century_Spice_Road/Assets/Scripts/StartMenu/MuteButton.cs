using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MuteButton : MonoBehaviour, IPointerUpHandler
{

    public AudioSource audioSrc;
    private Button muteButton;
    public Sprite MuteSprite;
    public Sprite UnmuteSprite;
    private Image currentIcon;
    private enum PlayState { MUTE, UNMUTE };
    private PlayState musicalState;

    // Start is called before the first frame update
    void Start()
    {
        muteButton = GetComponent<Button>();
        currentIcon = GetComponent<Image>();
        musicalState = PlayState.UNMUTE;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (musicalState == PlayState.UNMUTE)
        {
            currentIcon.sprite = MuteSprite;
            musicalState = PlayState.MUTE;
            audioSrc.mute = true;
        }
        else
        {
            currentIcon.sprite = UnmuteSprite;
            musicalState = PlayState.UNMUTE;
            audioSrc.mute = false;
        }
    }
}
