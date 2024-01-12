using UnityEngine;
public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player player = GetComponent<Player>();

            player.CollectCoins();

            Destroy(gameObject);
        }
    }
}
