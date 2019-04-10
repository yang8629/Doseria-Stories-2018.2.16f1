using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;//Camera要面向的物件
    public Vector3 cameraPosition;//相機要移動的位置
    public Vector3 targetPosition;//相機要移動的位置
    public Vector3 offset;
    public float speed;//相機環繞移動的速度
    public float number;

    public float radius;//移動的半徑

    private void Start()
    {
        //由於我這個範例是x和z軸的移動，而y軸不會改變，所以要先設定好y軸的初始位置
        cameraPosition.x = transform.position.x;
        transform.position = cameraPosition;
        targetPosition = target.transform.position;
        targetPosition.y += 4;
        //計算當前攝影機和目標物件的半徑
        radius = Vector3.Distance(targetPosition, target.transform.position);
        //InvokeRepeating("Rotate", 0f, 0.01f);
    }

    private void Update()
    {
        //使用Time.deltaTime，使得移動時更加平滑
        //將速度進行一定比例縮放，方便控制速度(縮放多少都隨意，自己覺得數值修改方便就好)
        number += 0.0002f * speed * Time.realtimeSinceStartup;

        //計算並設定新的x和y軸位置
        //負數是順時針旋轉，正數是逆時針旋轉
        cameraPosition.y = radius * Mathf.Sin(number);
        cameraPosition.z = radius * Mathf.Cos(-number);
        transform.position = cameraPosition + offset;

        //使相機永遠面對著目標物件
        transform.LookAt(target.transform.position);
    }

    private void Rotate()
    {
        //使用Time.deltaTime，使得移動時更加平滑
        //將速度進行一定比例縮放，方便控制速度(縮放多少都隨意，自己覺得數值修改方便就好)
        number += 0.001f * speed;

        //計算並設定新的x和y軸位置
        //負數是順時針旋轉，正數是逆時針旋轉
        cameraPosition.y = radius * Mathf.Sin(number);
        cameraPosition.z = radius * Mathf.Cos(-number);
        transform.position = cameraPosition + offset;

        //使相機永遠面對著目標物件
        transform.LookAt(target.transform.position);
        if (transform.position.y < 2.5f)
        {
            CancelInvoke("Rotate");
        }
    }
}
