using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block4 : MonoBehaviour
{
    float speed = 10;
    float distance = 10;


    public GameObject block1A;
    public GameObject block2B;
    public GameObject block3C;
    public GameObject block4D;
   // public GameObject Panel2;

    GameObject block;


    System.Random r = new System.Random();
    int ran;
    int collider_count;

    void Start()
    {
        objectcreate objectcreate = FindObjectOfType<objectcreate>();

        ran = r.Next(1, 3);
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

        if (other.gameObject.tag == "block4")
        {
            //GetComponent<ParticleSystem>().Play();

            objectcreate.block4_destroy = objectcreate.block4_destroy + 1;
                // Debug.Log("!!!!!!!!!");
               // Debug.Log("4번블록 충돌!");
                //Debug.Log(collider_count);
                objectcreate.collision_detect4D = true;
                Destroy(other.gameObject,0.2f);
            /*float randomX = Random.Range(30f, 570f);
                float randomY = Random.Range(200f, 800f);

                if (ran == 1)
                {
                    GameObject block = (GameObject)Instantiate(block1A, new Vector3(randomX, randomY, 0f), Quaternion.identity);
                //block.transform.parent = Panel2.transform;
            }
                else if (ran == 2)
                {
                GameObject block = (GameObject)Instantiate(block2B, new Vector3(randomX, randomY, 0f), Quaternion.identity);
               // block.transform.parent = Panel2.transform;
            }
                else if (ran == 3)
                {
                    GameObject block = (GameObject)Instantiate(block3C, new Vector3(randomX, randomY, 0f), Quaternion.identity);
              //  block.transform.parent = Panel2.transform;
            }
                else if (ran == 4)
                {
                GameObject block = (GameObject)Instantiate(block1A, new Vector3(randomX, randomY, 0f), Quaternion.identity);
              //  block.transform.parent = Panel2.transform;
            }*/


        }
        //Destroy(other.gameObject);
    }

    void OnMouseDrag()
    {
       
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag != "block4")
        {
            transform.Translate(this.speed, 0, 0);
            this.speed *= 0.3f;
        }
    }


}