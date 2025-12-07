using UnityEngine;

public class Object_Eater_Sc : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

}
