using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    public bool dragging = false;
    private float distance;
    public Vector3 CharacterVector;
   
    
    public float ExitValue, Clampvalue;
  public float max, min;

    public bool moveRotation=true;
    public Vector3 FirstTouch;

    public void ScreenTouchDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(distance);
        FirstTouch = rayPoint - transform.position;
    }
    //public void ChangeDirection(bool rotation, float ExitPosition,float direction)
    //{
    //    //if (direction==90)
    //    //{
           
    //    //}
    //    //else
    //    //{

    //    //}
    //    moveRotation = rotation;
    
    //    ExitValue = ExitPosition;
    //    min = ExitValue - Clampvalue;
    //    max = Clampvalue + ExitValue;
    //}
    public void ScreenTouchUp()
    {
        dragging = false;
    }

    void Update()
    {

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            //if (moveRotation)
            //{
            //    CharacterVector = new Vector3(Mathf.Clamp(rayPoint.x - FirstTouch.x, min, max), transform.position.y, transform.position.z);

            //}
            //else
            //{
            //    CharacterVector = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(rayPoint.x - FirstTouch.x, min, max));
            //    Debug.Log(Mathf.Clamp(rayPoint.x - FirstTouch.x, min, max));
            //}
           CharacterVector = new Vector3(Mathf.Clamp(rayPoint.x - FirstTouch.x, min, max), transform.position.y, transform.position.z);

            transform.position = Vector3.MoveTowards(transform.position, CharacterVector, 10f * Time.deltaTime);
        }

    }

}