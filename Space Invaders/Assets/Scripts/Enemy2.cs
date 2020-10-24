using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    [SerializeField] private Transform bulletTransform;
    [SerializeField] private GameObject bulletPrefab;
    private float timer;

    void Start()
    {

    }


    void Update()
    {
       


    }


    public void BulletGenerator()
    {
        Instantiate(bulletPrefab, bulletTransform.transform.position, bulletTransform.transform.rotation);
    }


    


}


