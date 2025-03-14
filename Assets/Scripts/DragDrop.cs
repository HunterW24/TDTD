using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private RectTransform rectTransform;

    /*[SerializeField] private Canvas canvas;*/

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        /* throw new System.NotImplementedException();*/
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta /*/ canvas.scaleFactor*/ ;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        /*throw new System.NotImplementedException();*/
        Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        /*throw new System.NotImplementedException();*/
        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        /*throw new System.NotImplementedException();*/
        Debug.Log("OnDrop");
    }
}
