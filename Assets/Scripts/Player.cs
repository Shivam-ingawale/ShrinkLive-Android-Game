using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move = 20f;
    public TextMeshProUGUI score;
    //public TextMeshProUGUI HighScore;
    bool Alive = true;
    float time;
    public float moveit=0f;
    int curr=0;
    float movement = 0;
    float Screenwid;


    // Update is called once per frame
    private void Start()
    {
        score.text = "0";
        Screenwid = Screen.width;
        time = 0f;
        //HighScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
    void Update()
    {
        /*int i =0;
        while((Input.touchCount>i))
        {
            if ((Input.GetTouch(i).position.x>Screenwid/2))
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, 1.0f * Time.fixedDeltaTime * -move);
                
            }
            if ((Input.GetTouch(i).position.x<Screenwid/2))
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, -1.0f * Time.fixedDeltaTime * -move);
                
            }
        }*/

        /*if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, 1.0f * Time.fixedDeltaTime * -move);
            Debug.Log("D");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, -1.0f * Time.fixedDeltaTime * -move);
            Debug.Log("A");
        }*/

        movement = Input.GetAxisRaw("Horizontal");
        if (Alive)
        {
            time += 1*Time.deltaTime;
            score.text = ((int)time).ToString();
            curr = (int)time;
        }
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, moveit * Time.fixedDeltaTime * -move);
#if UNITY_EDITOR
        // transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * -move);
#endif
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Alive = false;
        PlayerPrefs.SetInt("CurrentScore", curr);
        if (time > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", time);
            curr = (int)time;
            //HighScore.text = time.ToString();
        }
        SceneManager.LoadScene(2);
    }
    public void left()
    {
        moveit = -1f;
    }
    public void right()
    {
        moveit = 1f;
    }public void stop()
    {
        moveit = 0f;
    }
}
