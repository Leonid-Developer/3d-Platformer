using UnityEngine;
public class Missle : MonoBehaviour
{
    private float speed = 3;

    void Update()
    {
        Destroy(gameObject, 3);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if(other.gameObject.tag == "Enemy")
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.OnDestroy();
        }
    }
}
