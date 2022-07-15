using UnityEngine;

public class piston : MonoBehaviour
{
    public Animator anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("push");
    }
}