using System;
using Grid.Elements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

class Battery :Element
{
    [SerializeField] private Image _testMark; //test
    [SerializeField] private LaserReceiver _laserReceiver;
    public override ElementType ElementType { get;  set; } = ElementType.Battery;

    private int Energy;


    private void OnEnable()
    {
        _laserReceiver.Connected += OnConnect;
        _laserReceiver.LostConnection+= OnDisconnect;
    }

    private void OnDisable()
    {
        _laserReceiver.Connected -= OnConnect;
        _laserReceiver.LostConnection-= OnDisconnect;
    }


    private void OnConnect()
    {
        Energy += 1;
        if (Energy > 0)
        {
            _testMark.enabled = true;
        }
    }

    private void OnDisconnect()
    {
        Energy -= 1;
        if (Energy == 0)
        {
            _testMark.enabled = false;
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        //TODO 
    }
}