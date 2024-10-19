using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject targetPrefab;  
    public Vector2 spawnAreaMin;     
    public Vector2 spawnAreaMax;     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject); 
            Respawn(); 
            Destroy(gameObject); 
        }
    }

    void Respawn()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(targetPrefab, spawnPosition, Quaternion.identity);
    }
}
