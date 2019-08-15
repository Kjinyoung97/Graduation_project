using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class objectcreate : MonoBehaviour {

    List<GameObject> PostList = new List<GameObject>();
    List<GameObject> fileList = new List<GameObject>();
    List<GameObject> subList = new List<GameObject>();
    List<GameObject> mainList = new List<GameObject>();

    public static bool collision_detect1A, collision_detect2B, collision_detect3C, collision_detect4D;
    int prefabIndex,fileIndex, subIndex,mainIndex;


    private float time;
    public Text timeset;

    public GameObject A1, A2,A3, A4, A5, A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,A16;
    public GameObject B1, B2, B3, B4, B5, B6, B7, B8, B9, B10;
    public GameObject C1, C2, C3, C4, C5, C6, C7, C8, C9;
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8;
    public GameObject Panel,Panel2;

    public GameObject block;

    public static int block1_destroy = 0;
    public static int block2_destroy = 0;
    public static int block3_destroy = 0;
    public static int block4_destroy=0;


    System.Random r = new System.Random();
    int ran;

	// Use this for initialization
	void Start () {
        //start_count = r.Next(5, 7);

        //포스트잇 랜덤리스트에 추가
        PostList.Add(A1);
        PostList.Add(A2);
        PostList.Add(A3);
        PostList.Add(A4);
        PostList.Add(A5);
        PostList.Add(A6);
        PostList.Add(A7);
        PostList.Add(A8);
        PostList.Add(A9);
        PostList.Add(A10);
        PostList.Add(A11);
        PostList.Add(A12);
        PostList.Add(A13);
        PostList.Add(A14);
        PostList.Add(A15);
        PostList.Add(A16);
        //Debug.Log(PostList.Count);

        //파일 랜덤 리스트 추가
        fileList.Add(B1);
        fileList.Add(B2);
        fileList.Add(B3);
        fileList.Add(B4);
        fileList.Add(B5);
        fileList.Add(B6);
        fileList.Add(B7);
        fileList.Add(B8);
        fileList.Add(B9);
        fileList.Add(B10);
        //Debug.Log(PostList.Count);

        //교양책 랜덤 리스트 추가 
        subList.Add(C1);
        subList.Add(C2);
        subList.Add(C3);
        subList.Add(C4);
        subList.Add(C5);
        subList.Add(C6);
        subList.Add(C7);
        subList.Add(C8);
        subList.Add(C9);

        //전공책 랜덤 리스트 추가 
        mainList.Add(D1);
        mainList.Add(D2);
        mainList.Add(D3);
        mainList.Add(D4);
        mainList.Add(D5);
        mainList.Add(D6);
        mainList.Add(D7);
        mainList.Add(D8);


        time = 20f;

        for (int i = 0; i < 10; i++)
        {
    
            Invoke("random_block", 0.1f);
        }

        if (Panel)
        {
            Panel.gameObject.SetActive(false);
        }
    }

    void random_block()
    {
        prefabIndex = Random.Range(0, PostList.Count - 1);
        fileIndex = Random.Range(0, fileList.Count - 1);
        subIndex = Random.Range(0, subList.Count - 1);
        mainIndex = Random.Range(0, mainList.Count - 1);

        float randomX = Random.Range(30f, 570f);
        float randomY = Random.Range(200f, 800f);

        ran = r.Next(1, 5);

        if (ran == 1)
        {
            GameObject block = (GameObject)Instantiate(PostList[prefabIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
        }
        else if (ran == 2)
        {
            GameObject block = (GameObject)Instantiate(fileList[fileIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
        }
        else if (ran == 3)
        {
            GameObject block = (GameObject)Instantiate(subList[subIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
        }
        else if (ran == 4)
        {
            GameObject block = (GameObject)Instantiate(mainList[mainIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
        }
    }
	// Update is called once per frame
	void Update ()
    {

        //timeset.text = Mathf.Ceil(time).ToString();
        timeset.text = "남은 시간  " + time.ToString("F2");
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene("endgame");
                
        }
        //Debug.Log("충돌감지!");
        prefabIndex = Random.Range(0, PostList.Count - 1);
        fileIndex = Random.Range(0, fileList.Count - 1);
        subIndex = Random.Range(0, subList.Count - 1);
        mainIndex = Random.Range(0, mainList.Count - 1);

        float randomX = Random.Range(30f, 570f);
        float randomY = Random.Range(200f, 800f);

          if (collision_detect1A)
            {
            Invoke("random_block", 0.2f);
            GameObject block = (GameObject)Instantiate(fileList[fileIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;

            GetComponent<AudioSource>().Play();
            collision_detect1A = false;
            }
          if (collision_detect2B)
            {
            Invoke("random_block", 0.2f);
            GameObject block = (GameObject)Instantiate(subList[subIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
            GetComponent<AudioSource>().Play();
            collision_detect2B = false;
            }
          if (collision_detect3C)
            {
            Invoke("random_block", 0.2f);
            GameObject block = (GameObject)Instantiate(mainList[mainIndex], new Vector3(randomX, randomY, 500f), Quaternion.identity);
            block.transform.parent = Panel2.transform;
          
            GetComponent<AudioSource>().Play();
            collision_detect3C = false;
            }
        if (collision_detect4D)
        {
            Invoke("random_block", 0.2f);
            Invoke("random_block", 0.2f);
            GetComponent<AudioSource>().Play();

            collision_detect4D = false;
        }
          }

    private void setupCamera()
    {
        float targetWidthAspect = 9.0f;
        float targetHeightAspect = 16.0f;

        Camera mainCamera = Camera.main;

        mainCamera.aspect = targetWidthAspect / targetHeightAspect;

        float widthRatio = (float)Screen.width / targetWidthAspect;
        float heightRatio = (float)Screen.height / targetHeightAspect;

        float heightadd = ((widthRatio / (heightRatio / 100)) - 100) / 200;
        float widthtadd = ((heightRatio / (widthRatio / 100)) - 100) / 200;

        if (heightRatio > widthRatio)
        {
            widthtadd = 0.0f;
        }
        else
        {
            heightadd = 0.0f;
        }

        mainCamera.rect = new Rect(
            mainCamera.rect.x + Mathf.Abs(widthtadd),
            mainCamera.rect.y + Mathf.Abs(heightadd),
            mainCamera.rect.width + (widthtadd * 2),
            mainCamera.rect.height + (heightadd * 2));
    }
}
