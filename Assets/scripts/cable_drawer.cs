using UnityEngine;

public class cable_drawer : MonoBehaviour
{
    public bool electrified;
    public bool connected;
    public GameObject connectedObject;
    public GameObject self;
    public Animator anim;

    private void Awake()
    {
        self.name = "cable" + Time.time;
    }

    void Update()
    {
        anim.SetBool("electrified", electrified);

        if(connectedObject.GetComponent<cable_drawer>().electrified == true)
        {
            electrified = true;
        }

        if (connectedObject.GetComponent<cable_drawer>().electrified == false)
        {
            electrified = false;
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