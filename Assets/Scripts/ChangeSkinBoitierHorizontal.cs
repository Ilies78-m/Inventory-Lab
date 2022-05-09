using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinBoitierHorizontal : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteBoitierHorizontal;
    public Sprite newSpriteBoitierHorizontal1;
    public Sprite newSpriteBoitierHorizontal2;
    public string o;
    public string n;
    public GameObject objet;
    public SpriteRenderer sp;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            o = MouseControl.objectTag;
            n = MouseControl.objectName;
            if(o == "Banc Boitier Horizontal")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteBoitierHorizontal;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteBoitierHorizontal1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteBoitierHorizontal2;
                }
            }
        }
    }
}
