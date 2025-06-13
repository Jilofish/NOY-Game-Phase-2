using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Collider2D))]
public class Draggable2D : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 pointerPos = Touchscreen.current != null
                ? (Vector3)Touchscreen.current.primaryTouch.position.ReadValue()
                : Mouse.current.position.ReadValue();

            Vector3 worldPos = mainCamera.ScreenToWorldPoint(pointerPos);
            worldPos.z = 0;
            transform.position = worldPos + offset;
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetPointerWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    private Vector3 GetPointerWorldPosition()
    {
        Vector3 pointerPos = Touchscreen.current != null
            ? (Vector3)Touchscreen.current.primaryTouch.position.ReadValue()
            : Mouse.current.position.ReadValue();

        Vector3 worldPos = mainCamera.ScreenToWorldPoint(pointerPos);
        worldPos.z = 0;
        return worldPos;
    }
}