using UnityEngine;

public class lever : MonoBehaviour
{
    public bool on = false;
    public bool connected = false;
    public GameObject connectedObject;
    public Animator anim;

    void Update()
    {
        connectedObject.GetComponent<cable_drawer>().electrified = on;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "electrical")
        {
            on = !on;
            anim.SetBool("on", on);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("electrical"))
        {
            connected = true;
            connectedObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == connectedObject.name)
        {
            connected = false;
            connectedObject = null;
        }
    }
}