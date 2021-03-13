using UnityEngine;
using UnityEngine.AI;

namespace NavMeshTest
{
    public class MoveTo : MonoBehaviour
    {
        [SerializeField] private Transform goal;

        private void Start()
        {
            var agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
        }
    }
}