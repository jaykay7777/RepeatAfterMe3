using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace leveldesign{

    public class MoveCharacter : MonoBehaviour
        {
        public Transform pointATransform;

        public Transform pointBTransform;

        public float Speed = 2.0f;

        private Vector3 pointA;

        private Vector3 pointB;

        private float journeyLength;

        private float startTime;
        // Start is called before the first frame update
        void Start()
        {
            if(pointATransform && pointBTransform)
            {
                pointA = pointATransform.position;
                pointB = pointBTransform.position;

                startTime = Time.time;
                journeyLength = Vector3.Distance(pointA, pointB);
            }
            else
            {
                Debug.LogWarning("Point Transforms are not set! There will be no movement");
            }
        }

        // Update is called once per frame
        private void Update()
        {
if(pointATransform&& pointBTransform)
            {
                float distCovered = (Time.time - startTime) * Speed;
                float fractionOfJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(fractionOfJourney, 1));
            }
        }
       
    }
}
