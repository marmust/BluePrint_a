using UnityEngine;

public class destroyer : MonoBehaviour
{
    public bool onTarget = false;
    public bool isPressing = false;

    public GameObject self;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isPressing = true;
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            isPressing = false;
        }

        if(onTarget == true && isPressing == true)
        {
            destroy();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            onTarget = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            onTarget = false;
        }
    }

    void destroy()
    {
        Destroy(self);
    }
}