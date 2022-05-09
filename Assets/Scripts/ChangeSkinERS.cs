using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinERS : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteERS;
    public Sprite newSpriteERS1;
    public Sprite newSpriteERS2;
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
            if(o == "ERS")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteERS;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteERS1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteERS2;
                }
            }
        }
    }
}