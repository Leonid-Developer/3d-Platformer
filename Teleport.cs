using UnityEngine;
public class Teleport : MonoBehaviour
{
    public Vector3 position;

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.transform.position = position;
        }
    }
}
