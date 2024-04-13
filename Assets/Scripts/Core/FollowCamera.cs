using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG.Core
{
    public class RayCast : MonoBehaviour
    {
        [SerializeField] Transform target;
        void Update()
        {
            transform.position = target.position;
        }
    }
}

