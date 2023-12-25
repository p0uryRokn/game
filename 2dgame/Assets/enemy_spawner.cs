using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject enemy_prefeb;
    [SerializeField] private float spawn_rate = 1f;
    private float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = spawn_rate;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown < 0)
        {
            var go = Instantiate<GameObject>(enemy_prefeb, transform.position, Quaternion.identity);
            go.transform.parent = transform;
            cooldown = spawn_rate;
        } 
    }

}
