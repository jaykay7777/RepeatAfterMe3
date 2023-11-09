using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //colour array for buttons...select colour and light it up for alloted time
    public SpriteRenderer[] colours;

    private int colourSelect;

    //counter for how long buttons stay lit
    public float stayLit;
    private float stayLitCounter;

    //sets a time value between buttons lighting up
    public float waitBetweenLights;
    private float waitBetweenCounter;

    private bool shouldBeLit;
    private bool shouldBeDark;

    //creating light up sequence using a list
    public List<int> activeSequence;
    private int positionInSequence;
      
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
    if(shouldBeLit)
        {
            stayLitCounter -= Time.deltaTime;

            if (stayLitCounter < 0)
            {
                colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 0.5f);
                shouldBeLit = false;

                //add a delay between buttons lighting in sequence
                shouldBeDark = true;
                waitBetweenCounter = waitBetweenLights;

                //adds number to sequence
                positionInSequence++;
            }
        }

    if(shouldBeDark)
        {
            waitBetweenCounter -= Time.deltaTime;

            //checks if the number is greater than or equal to the active sequence, if it is then stop task
            if(positionInSequence >= activeSequence.Count)
            {
                shouldBeDark = false;

                //if not
            } else
            {
if (waitBetweenCounter < 0)
                {
                    
                    colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 1f);

                    stayLitCounter = stayLit;
                    shouldBeLit = true;
                    shouldBeDark = false;
                }
            }
        }
    }

    public void StartGame()
    {
        //sets start position in sequence
        positionInSequence = 0;

        //selects random colour in array and changes its alpha value to light it up for alloted time
        colourSelect = Random.Range(0, colours.Length);

        //adds random numbers to list
        activeSequence.Add(colourSelect);

        colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 1f);

        stayLitCounter = stayLit;
        shouldBeLit = true;
    
    }
    //checks if the button is pressed and relays a correct or wrong msg
    public void ColourPressed(int whichButton)
    {
if(colourSelect == whichButton)
        {
            Debug.Log("Correct");
        } else
        {
            Debug.Log("Wrong");
        }
    }
}
