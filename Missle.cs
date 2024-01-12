using UnityEngine;
public class Missle : MonoBehaviour
{
    private float speed = 3;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.OnDestroy();
        }
        Destroy(gameObject);
    }
}
