using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinPupitre : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpritePupitre;
    public Sprite newSpritePupitre1;
    public Sprite newSpritePupitre2;
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
            if(o == "Pupitre")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpritePupitre;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpritePupitre1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpritePupitre2;
                }
            }
        }
    }
}
