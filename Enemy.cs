using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed;

    public Transform target;

    public int playerDamge;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            Player player = other.GetComponent<Player>();
            player.TakeDamge(playerDamge);
        }
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
