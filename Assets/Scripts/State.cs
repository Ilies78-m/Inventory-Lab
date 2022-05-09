using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(MouseControl.click == 1)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
