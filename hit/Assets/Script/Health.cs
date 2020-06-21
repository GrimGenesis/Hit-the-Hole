using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int noofbombs;

    public Image[] bombs;
    public Sprite fullbomb;
    public Sprite blast;

    void Update()
    {
        
        if(health > noofbombs)
        {
            health = noofbombs;
        }
        
        for(int i = 0; i < bombs.Length; i++ )
        {
            if(i < health)
            {
                bombs[i].sprite = fullbomb;
            }
            else
            {
                bombs[i].sprite = blast;
            }

            if(i < noofbombs)
            {
                bombs[i].enabled = true;
            }
            else
            {
                bombs[i].enabled = false;
            }
        }
    }


}
