using UnityEngine;

public class gate_input : MonoBehaviour
{
    public GameObject connectedObject;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "electrical")
        {
            connectedObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "electrical")
        {
            connectedObject = null;
        }
    }
}
