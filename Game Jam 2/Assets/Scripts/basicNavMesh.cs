using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class basicNavMesh : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform goal;
    [SerializeField] private float updateDelay = 1.0f;
    private NavMeshAgent agent;
    private float timer;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > updateDelay)
        {
            timer = 0;
            agent.destination = goal.position;
        }
    }
}
