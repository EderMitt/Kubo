using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Touch touch;
    [SerializeField] private Vector2 touchPosition;
    [SerializeField] private Quaternion rotation;

    private float rotateSpeedModifier = 0.2f;
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                rotation = Quaternion.Euler(0f, - touch.deltaPosition.x * rotateSpeedModifier, 0f);

                transform.rotation = rotation * transform.rotation;
            }
        }
    }
}

/* !!!   Colocar no objeto que irá rotacionar   !!! */
