using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block3 : MonoBehaviour
{
    float speed = 10;
    float distance = 10;

    GameObject block;

    System.Random r = new System.Random();
    int ran;
    int collider_count;

    void Start()
    {
        objectcreate objectcreate = FindObjectOfType<objectcreate>();
        //ran = r.Next(1, 4);
    }

    private void Update()
    {
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.tag == "block3")
        {
            //GetComponent<ParticleSystem>().Play();
            objectcreate.block3_destroy = objectcreate.block3_destroy + 1;
                objectcreate.collision_detect3C = true;
                Destroy(other.gameObject,0.2f);
                // Debug.Log("!!!!!!!!!")
                // Debug.Log("3번블록 충돌!");
                //Debug.Log(collider_count);

                //GameObject block = (GameObject)Instantiate(block4D, new Vector3(randomX, randomY, 0f), Quaternion.identity);

            
        }
        //Destroy(other.gameObject);
    }

    void OnMouseDrag()
    {
    
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag != "block3")
        {
            transform.Translate(this.speed, 0, 0);
            this.speed *= 0.3f;
        }
    }

}