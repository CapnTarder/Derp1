using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRock : MonoBehaviour
{
    public Transform spawn;

    // [SerializeField]
    //private AudioClip shooting;


    private float coolDownTime = 0.5f;


    public GameObject rock;
    [SerializeField]
    private float lifeTime = 5f;
    private float shootTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Invoke("DestroySelf", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime)
        {
            shootTimer = 0f;

            Instantiate(rock, spawn.position, Quaternion.identity);

        }
    }
}
