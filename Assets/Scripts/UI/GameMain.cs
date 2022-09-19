using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class GameMain : MonoBehaviour
{
    public GameObject InventoryUI;
    public GameObject SkillUI;
    public GameObject StatusUI;
    public GameObject StatusBar;
    public GameObject PresetUI;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {   
        InventoryUI.SetActive(false);
        SkillUI.SetActive(false);
        StatusUI.SetActive(false);
        StatusBar.SetActive(true); 
        PresetUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //if (input.GetKeyDown(KeyCode.Escape))
        //{
        //    //GameObject.SetActive(false);
        //}

        //if (input.GetKeyDown(KeyCode.I))
        //{
        //    if (InventoryUI.activeSelf == true)
        //    {
        //        InventoryClose();
        //    }
        //    else
        //    {
        //        InventoryOpen();
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{
                      
        //}
    }

    public void InventoryOpen()
    {
        InventoryUI.SetActive(true);
    }

    public void InventoryClose()
    {
        InventoryUI.SetActive(false);
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);
    }
}
