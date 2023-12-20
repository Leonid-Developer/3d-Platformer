using UnityEngine;
public class Trap : MonoBehaviour
{
    public FirstPersonMovement player_sc;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player_sc.health--;
        }
    }
}
