using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinGeneHT : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteGeneHT;
    public Sprite newSpriteGeneHT1;
    public Sprite newSpriteGeneHT2;
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
            if(o == "GeneHT")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteGeneHT;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteGeneHT1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteGeneHT2;
                }
            }
        }
    }
}
