using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject Enemy1;

    public int level = 1;
    float time;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gameManager created");
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time > 0.1)
        {
            int x = Random.Range(-30,30);
            int y = Random.Range(-30,30);
            Instantiate(Enemy1, new Vector2(x,y), Quaternion.identity);
            time = Time.time;
        }
    }
}
