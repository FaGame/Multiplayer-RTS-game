using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MiniMap : MonoBehaviour, IPointerDownHandler {

    private Vector3 clickMousePos;
    public int offsetX;
    public int offsetY;
  

    public void OnPointerDown(PointerEventData ped)
    {
        Vector3 localHit = transform.InverseTransformPoint(ped.pressPosition);
        clickMousePos = new Vector3((1000 / 256) * localHit.x + offsetX, Camera.main.transform.position.y, (1000 / 256) * localHit.y - offsetY);
        Camera.main.transform.position = clickMousePos;
    }
}
