using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Sprite normalImage;

    public Sprite hoverImage;

    

    private void Awake()
    {
        normalImage = GetComponent<Image>().sprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       
        GetComponent<Image>().sprite = hoverImage;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
       
        GetComponent<Image>().sprite = normalImage;
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
}

