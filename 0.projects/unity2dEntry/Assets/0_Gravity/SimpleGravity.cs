using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Gravity1*/
//非常に簡単な重力を作ってみます。
//・物体の落下
//・床に当たったら止まる
//をやってみます。


public class SimpleGravity : MonoBehaviour
{
    //床関連
    GameObject _floor;
    Transform _floorTrans;
    float _floorY;
    float _floorSize;

    //判定変数
    bool _hitFloorFlag;//床に当たっているか

    //重力速度(1が最大値)
    float _gravitySpeed;

    // Start is called before the first frame update
    void Start()
    {
        //床の設定
        _floor = GameObject.Find("Floor");//ゲームオブジェクト取得
        _floorTrans = _floor.transform;//トランスフォーム取得
        _floorY = _floor.transform.position.y;//Y座標取得
        _floorSize = 1.5f;//床のサイズ 

        //重力の設定
        _gravitySpeed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        //床に当たってるかの判定
        if (this.transform.position.y <= (_floorY +_floorSize))
        {
            _hitFloorFlag = true;
        }
        else
        {
            _hitFloorFlag = false;
        }


        //床に当たっていないなら、落下
        if (_hitFloorFlag == false)
        {
            this.transform.position += Vector3.down * _gravitySpeed;
        }

    }
}
