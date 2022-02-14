using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // Start is called before the first frame update
    //That is healthy points of character
    
    public float maxHitPoints;
    public float startingHitPoints;
    public enum CharacterCategory
    {
        PLAYER,
        ENEMY
    }
    public CharacterCategory characterCategory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This method will be called when the character hit points reach zero
    public virtual void KillCharacter()
    {
        //Remove the current GameObject from the Scene
        Destroy(gameObject);
    }
    //Set the character back to its original starting state, so it can be used again
    public abstract void ResetCharacter();
    //Called by other characters to damage the current character. Takes an amount to damage the character by and a time interval
    public abstract IEnumerator DamageCharacter(int damage, float interval);
    public virtual IEnumerator FlickerCharacter()
    {
        //Assign color red to the SpriteRenderer component will tint the sprite red
        GetComponent<SpriteRenderer>().color = Color.red;
        // Yield execution for 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        // By default, the SpriteRenderer uses a tint color of white. Change the SpriteRenderer tint back to the default color
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
