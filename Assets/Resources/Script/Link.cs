using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Link : MonoBehaviour
{

  // void Update()
  // {
  //
  //   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //クリックした位置をrayに格納
  //   RaycastHit hit = new RaycastHit();
  //
  //   if(EventSystem.current.IsPointerOverGameObject()){//PCのみの場合
  //   return;
  //   }
  //   if(Input.touchCount > 0){
  //   if(EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)){//スマホの場合で、GetMouseButtonDownで画面タッチされたことを検知する前に、ボタンのクリックをチェックして、ボタンがクリックされている時にはreturnしている
  //   return;
  //   }
  //   }
  //
  //     if(Input.GetMouseButtonDown(0))
  //     {
  //       if(Physics.Raycast(ray, out hit))//Raycast(開始位置、○○方向に飛ばし、距離○○のrayを飛ばす)。rayを投影して、何らかのオブジェクトと衝突したら、
  //       {
  //            Application.OpenURL("https://opensea.io");
  //        }
  //      }
  //  }

  public void OnClickStartButton()
  {
        Application.OpenURL("https://opensea.io");
   }
}
