using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

[RequireComponent(typeof(Seeker), typeof(AIPath), typeof(Funnel))]
public class AgentPathfinding : MonoBehaviour
{
    private Seeker m_Seeker;
    private AIPath m_AIPath;

    [SerializeField] private GameObject m_Target;

    private void Start()
    {
        m_Seeker = GetComponent<Seeker>();
        m_AIPath = GetComponent<AIPath>();
    }

    private void Update()
    {
        m_AIPath.destination = m_Target.transform.position;
    }

    public void setTarget(GameObject target)
    {
        m_Target = target;
    }
}
