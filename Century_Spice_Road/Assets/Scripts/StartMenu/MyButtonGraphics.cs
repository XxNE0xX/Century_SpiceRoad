using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyButtonGraphics : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject mainMenu;
    public Sprite Deselected;
    public Sprite Selected;
    private Image background;
    // Start is called before the first frame update
    void Start()
    {
        background = mainMenu.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        background.sprite = Selected;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        background.sprite = Deselected;
    }

}
