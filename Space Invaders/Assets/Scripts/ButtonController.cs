using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject button;
    [SerializeField] private bool isPressed;
    
    

   public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    private void Update()
    {
      if (isPressed)
        {
            if(button.name == "ButtonLeft")
            {
                player.BroadcastMessage("MoveLeft", SendMessageOptions.DontRequireReceiver);
            }
            
            if(button.name == "ButtonRight")
            {
                player.BroadcastMessage("MoveRight", SendMessageOptions.DontRequireReceiver);
            }

            

            
        }
    }

    
}
