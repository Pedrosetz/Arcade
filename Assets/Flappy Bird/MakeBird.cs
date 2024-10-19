using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBird : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D rig;

    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D (Collision2D colisor) {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
