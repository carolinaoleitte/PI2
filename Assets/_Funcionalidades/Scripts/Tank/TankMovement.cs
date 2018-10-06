using UnityEngine;

namespace Complete
{
    public class TankMovement : MonoBehaviour
    {

        public float _speed;
        public float _rotate;

        private void FixedUpdate()
        {
            if (Input.GetKey("w"))
            {
                transform.Translate((-_speed * Time.deltaTime), 0, 0);
                
            }

            if (Input.GetKey("s"))
            {
                transform.Translate((_speed * Time.deltaTime), 0, 0);
            }

            if (Input.GetKey("a"))
            {
                transform.Rotate(0, (-_rotate * Time.deltaTime), 0);
            }

            if (Input.GetKey("d"))
            {
                transform.Rotate(0, (_rotate * Time.deltaTime), 0);
            }
        }
    }
}