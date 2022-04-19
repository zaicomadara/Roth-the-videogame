using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;


public class Draganddrop : MonoBehaviour, IPointerUpHandler,IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    GameObject Regla;
    public bool Pressed;
    private void Awake()
    {
        Regla = GetComponent<GameObject>();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
       // Regla.color = Color.green;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // Regla.color = Color.white;
    }
}
