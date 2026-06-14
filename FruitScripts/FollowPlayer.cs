using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Only for UIs
        SetMousePos();
    }

    void SetMousePos()
    {
        if(ContainerScript.IsGameOver == false)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            MousePos.x = Mathf.Clamp(MousePos.x, -19, 20);
            MousePos.y = 20;
            MousePos = Camera.main.WorldToScreenPoint(MousePos);
            transform.position = MousePos;
        }
    }


}
