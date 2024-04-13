using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        Vector3 destinationTarget;
        NavMeshAgent agent;
        RaycastHit hit;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }
        void Start()
        {

        }

        void Update()
        {

            UpdateAnimator();
        }

        //private vector3 getpoint()
        //{
        //    return hit.point;
        //}



        public void MoveTo(Vector3 destination)
        {
            agent.destination = destination;
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("ForwardMovement", speed);




        }

    }
}

