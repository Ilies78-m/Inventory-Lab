using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinGene : MonoBehaviour
{   
    public int c = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteGene;
    public Sprite newSpriteGene1;
    public Sprite newSpriteGene2;
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
            if(o == "Gene")
            {

                objet = GameObject.Find(n);

                spriteRenderer = GetComponent<SpriteRenderer>();

                c = MouseControl.click;
                sp = objet.GetComponent<SpriteRenderer>();

                if(c == 0)
                {
                    sp.sprite = newSpriteGene;
                }
                else if(c == 1)
                {
                    sp.sprite = newSpriteGene1;
                }   
                else if(c == 2)
                {
                    sp.sprite = newSpriteGene2;
                }
            }
        }
    }
}
