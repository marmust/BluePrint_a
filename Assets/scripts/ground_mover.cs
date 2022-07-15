using UnityEngine;

public class ground_mover : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 nextPos = new Vector3(player.transform.position.x, -2, 0);

        transform.position = nextPos;
    }
}
