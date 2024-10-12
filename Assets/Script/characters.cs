using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class characters : MonoBehaviour
{

    [SerializeField] Transform reachPoint;

    Animator anim;
    // Start is called before the first frame update
    bool startRun;

    NavMeshAgent agent;

    void Start()
    {
        startRun = false;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        StartCoroutine(Run());

        agent.stoppingDistance = UnityEngine.Random.Range(0, 7);

    }

    // Update is called once per frame
    void Update()
    {
        if (startRun)
        {
            agent.SetDestination(reachPoint.position);



            if (agent.remainingDistance > 0 && agent.remainingDistance <= agent.stoppingDistance)
            {
                anim.SetTrigger("Nervouse");
                startRun = false;
            }
        }




    }

    IEnumerator Run()
    {

        yield return new WaitForSeconds(2);

        if(UnityEngine.Random.Range(0, 11)%2==0)
        {
            anim.SetTrigger("Nervouse");

            yield return new WaitForSeconds(2);

        }
        anim.SetTrigger("Run");
        startRun = true;


    }
}
