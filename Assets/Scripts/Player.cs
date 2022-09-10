using Assets.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody rb;
    public Game Game;
    public AudioSource BounceSound;
    public AudioSource BreakSound;
  

    public Platform CurrentPlatform;

    
    public void Bounce()
    {
        rb.velocity = new Vector3(0, BounceSpeed, 0);
        BounceSound.Play();
    }

    public void ReachFinish()
    {
        rb.velocity = Vector3.zero;
        Game.OnPlayerReachedFinish();

    }

    public void Die()
    {
       
        Game.OnPlayerDied();
        rb.velocity = Vector3.zero;


    }

    internal void GetPoint()
    {
        Game.Score++;
    }

}
