using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomShooter : MonoBehaviour
{

    [SerializeField] private Transform shooters;
    private Transform[] childs;
    private int shooterIndex;
    private GameObject randomShooter;
    private float timer;

    void Start()
    {
        childs = new Transform[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {
            childs[i] = transform.GetChild(i);
        }
        
    }
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            ChooseShooter();
            timer = 5; 
        }

    }

    void ChooseShooter()
    {
        shooterIndex = Random.Range(0, childs.Length);
        childs[shooterIndex].BroadcastMessage("BulletGenerator", SendMessageOptions.DontRequireReceiver);

    }
}
