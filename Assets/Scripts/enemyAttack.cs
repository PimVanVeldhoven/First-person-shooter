using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    private enemyAi enemyAi;
    private Transform player;
    public float attackRange = 10f;

    public Material defaultmaterial;
    public Material attackMaterial;
    private Renderer rend;
    private bool foundPlayer = false;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAi = GetComponent<enemyAi>();
        rend = GetComponent<Renderer>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            enemyAi.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if (foundPlayer)
        {
            rend.sharedMaterial = defaultmaterial;
            enemyAi.newLocation();
            foundPlayer = false;
        }
    }
}
