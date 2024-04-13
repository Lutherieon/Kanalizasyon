using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;
using RPG.Combat;

namespace RPG.Control
{
    public class PlayerContoller : MonoBehaviour
    {


        // Update is called once per frame
        void Update()
        {



            InteractWithCombat();
            InteractWithMovement();
        }


        private void InteractWithCombat()
        {
            RaycastHit[] hits = Physics.RaycastAll(GetMauseRay());
            foreach (RaycastHit hit in hits)
            {
             
                CombatTarget target = hit.transform.GetComponent<CombatTarget>();
                if (target == null) continue;

                if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Fighter>().Attack(target);
                }
            }
            
        }
        private void InteractWithMovement()
        {
            if (Input.GetMouseButtonDown(0))
            {
                MoveToCursor();
            }
        }

        void MoveToCursor()
        {
            Ray ray = GetMauseRay();
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            if (hasHit)
            {
                GetComponent<Mover>().MoveTo(hit.point);
            }
        }

        private static Ray GetMauseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}



