using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinEnceinte : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteEnceinte;
    public Sprite newSpriteEnceinte1;
    public Sprite newSpriteEnceinte2;
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
            if(o == "Enceinte")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteEnceinte;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteEnceinte1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteEnceinte2;
                }
            }
        }
    }
}
