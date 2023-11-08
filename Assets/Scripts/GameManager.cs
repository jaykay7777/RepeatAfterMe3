using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //colour array for buttons...select colour and light it up for alloted time
    public SpriteRenderer[] colours;

    private int colourSelect;

    public float stayLit;
    private float stayLitCounter;

   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
    if(stayLitCounter > 0)
        {
            stayLitCounter -= Time.deltaTime;

        } else
        {
            colours[colourSelect].color = new Color(colours[colourSelect].color.r, colours[colourSelect].color.g, colours[colourSelect].color.b, 0.5f);
        }
    }

    public void StartGame()
    {
        //select random colour in array and change its alpha value to light it up for alloted time
        colourSelect = Random.Range(0, colours.Length);

        colours[colourSelect].color = new Color(colours[colourSelect].color.r, colours[colourSelect].color.g, colours[colourSelect].color.b, 1f);

        stayLitCounter = stayLit;
    
    }
}
