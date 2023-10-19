using UnityEngine;

public class EnemyWatchPlayer : MonoBehaviour
{
    public GameObject player;
    public bool facingRight = false;

    private void Update()
    {
        if (player.transform.position.x < gameObject.transform.position.x && facingRight)
            Flip ();
        if (player.transform.position.x > gameObject.transform.position.x && !facingRight)
            Flip ();
    }
 
    void Flip () 
    {
        //here your flip function, as example
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}
