using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update.
    public float spawnrate = 1f;
    public GameObject[] poly;
    public float nexttimespawn = 0f;



    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nexttimespawn)
        {
            int i = Random.Range(0, poly.Length);
            Instantiate(poly[i], Vector3.zero, Quaternion.identity);
            nexttimespawn = Time.time + 1f / spawnrate;
        }

    }
}
