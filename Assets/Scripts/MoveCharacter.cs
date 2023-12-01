using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace leveldesign{

    public class MoveCharacter : MonoBehaviour
        {
       
        //Code from class tutorials
        public Transform pointATransform;

        public Transform pointBTransform;

        public Transform pointCTransform;

        public Transform pointDTransform;

        public float Speed = 20.0f;

        private Vector3 pointA;

        private Vector3 pointB;

        private Vector3 pointC;

        private Vector3 pointD;

        private float journeyLength;

        private float startTime;

        //point to the game manager
        private GameManager theGM;


        // Start is called before the first frame update
        void Start()
        {
            theGM = FindObjectOfType<GameManager>();
            //Code from class tutorials
            if (pointATransform && pointBTransform)
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
            //code from class tutorials
if(pointATransform&& pointDTransform)
            {
                float distCovered = (Time.time - startTime) * Speed;
                float fractionOfJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(fractionOfJourney, 1));
            }
        }
       
    }
}
