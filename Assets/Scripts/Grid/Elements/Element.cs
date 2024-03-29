using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Element:MonoBehaviour,IPointerDownHandler
{
    public abstract ElementType ElementType { set; get; }
    public  int StartRotation 
    { 
        get=>(int)transform.rotation.eulerAngles.z;
        set
        {
            Quaternion newRotation = Quaternion.Euler(0, 0, value);
            transform.rotation = newRotation;
        }
    }
    
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        StartRotation -= 90;
    }
}