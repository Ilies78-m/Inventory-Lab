using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinBoitierVertical : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteBoitierVertical;
    public Sprite newSpriteBoitierVertical1;
    public Sprite newSpriteBoitierVertical2;
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
            if(o == "Banc Boitier Vertical")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteBoitierVertical;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteBoitierVertical1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteBoitierVertical2;
                }
            }
        }
    }
}
