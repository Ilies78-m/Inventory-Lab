using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private float sensi = 69.0f;
    public static int click = 0;
    public static string objectTag;
    public static string objectName;


    void Update()
    {
        RaycastHit hit;

        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, sensi));

        transform.position = new Vector3(mousePos.x, mousePos.y, -1.0f);

        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);

        
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10) && Input.GetMouseButtonDown(0))
        {
            objectTag = hit.collider.gameObject.tag;
            objectName = hit.collider.gameObject.name;
            if(click == 0)
            {
                click = 1;
            }
            else if(click == 1)
            {
                click = 2;
            }
            else
            {
                click = 0;
            }
        }
    }
}
