using UnityEngine;

namespace Complete
{
    public class CameraControl : MonoBehaviour
    {
        public float m_DampTime = 20f;
        public float m_ScreenEdgeBuffer = 4f;
        public float m_MinSize = 6.5f;
        [HideInInspector] public Transform[] m_Targets;
        private Vector3 m_MoveVelocity;
        private Vector3 m_DesiredPosition;
        private void Awake ()
        {
            //m_Camera = GetComponentInChildren<Camera> ();
        }
        private void FixedUpdate ()
        {
            Move ();
        }
        private void Move ()
        {
            FindAveragePosition ();
            transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
        }
        private void FindAveragePosition ()
        {
            Vector3 averagePos = new Vector3 ();
            int numTargets = 0;
            for (int i = 0; i < m_Targets.Length; i++)
            {
                if (!m_Targets[i].gameObject.activeSelf)
                    continue;
                averagePos += m_Targets[i].position;
                numTargets++;
            }
            if (numTargets > 0)
                averagePos /= numTargets;
            averagePos.y = transform.position.y;
            m_DesiredPosition = averagePos;
        }
    }
}