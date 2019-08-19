using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TimeDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    public float destroyTime;

    private bool active = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!active)
        {
            active = true;


            StartCoroutine(AppAfterTime(5));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            StartCoroutine(DisAfterTime(1));
        }
    }

    IEnumerator DisAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay

        active = false;

        gameObject.GetComponent<TilemapRenderer>().enabled = false;

        gameObject.GetComponent<TilemapCollider2D>().enabled = false;

    }

    IEnumerator AppAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay

        gameObject.GetComponent<TilemapRenderer>().enabled = true;

        gameObject.GetComponent<TilemapCollider2D>().enabled = true;



    }
}
