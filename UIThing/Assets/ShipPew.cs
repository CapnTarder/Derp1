using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPew : MonoBehaviour
{
    
    public Transform muzzle;

   // [SerializeField]
    //private AudioClip shooting;

    
    public float coolDownTime = 0.5f;

    
    public GameObject Bullet;

    private float shootTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime)
        {
            shootTimer = 0f;

            Instantiate(Bullet, muzzle.position, Quaternion.identity);
            
        }
    }

}
