using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Managers;
namespace Project1.UIs
{
public class WinConditionObject : MonoBehaviour
{
    [SerializeField] GameObject _winConditionPanel;

    private void Start() 
    {
        if(_winConditionPanel.activeSelf)
        {
            _winConditionPanel.SetActive(false);
        }
    }

    private void OnEnable() { //Event'i calistiracak fonk. cagirildiginda, eventin icerisine
    //ekledigimiz bu fonksiyon da calistirilir.
    //Eventlerin tek kafa karisik old. kisim fonksiyondan cagirmamiz ve 
    //icerisinde fonksiyon icermesi.
        GameManager._instance.OnMissionComplete+=HandleOnMissionComplete;
    }
    private void OnDisable() {
        GameManager._instance.OnMissionComplete-=HandleOnMissionComplete;
    }
    private void HandleOnMissionComplete(){
        if(!_winConditionPanel.activeSelf){
            _winConditionPanel.SetActive(true);
        }
    }


}

}