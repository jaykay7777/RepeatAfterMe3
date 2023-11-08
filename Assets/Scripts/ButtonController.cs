using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSprite;

    public int thisButtonNumber;

    private GameManager theGM;

    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theGM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update() {
      
        

    }

    private void OnMouseDown()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
    }

    private void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.5f);
        theGM.ColourPressed(thisButtonNumber);
    }
}
