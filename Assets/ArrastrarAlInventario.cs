using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarAlInventario : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{

    public GameObject ObjetoArrastrado;
    


    public void OnBeginDrag(PointerEventData eventData) {
        print("empezando a arrastrar");
    

       
    }


    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        print("Arrastrando");
    }



    public void OnEndDrag(PointerEventData eventData)
    {
        print("soltado");
    }
}
