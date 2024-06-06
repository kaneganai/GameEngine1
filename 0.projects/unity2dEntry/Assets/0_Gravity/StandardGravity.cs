using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Gravity2*/
//物理の式に沿った正しい重力を作ります。
//・物体式での重力の理解
//・時間の導入(Fixedupdate())
//・速度と加速度の導入
//をやってみます。

public class StandardGravity : MonoBehaviour
{
    //床関連
    float _floorY;
    float _floorSize;
    float _delSize;
    //判定変数
    bool _hitFloorFlag;//床に当たっているか
    //重力の調整変数
    float _gravitySpeed;
    //速度
    float _velocityY;//Y方向の速度
    //加速度
    float _accel;

    //オブジェクト作成時に一回だけ実行
    void Start()
    {
        //床の設定
        //ゲームオブジェクトの取得から一気にｙ座標まで取得
        _floorY= GameObject.Find("Floor").transform.position.y;
        _floorSize = 1.5f;//床のサイズ
        _delSize = _floorY + _floorSize;

        //重力の調整変数
        _gravitySpeed = 0.04f;

        //速度の設定
        _velocityY = 0;

        //加速度の設定

    }


    // 毎フレーム更新(最高速度で更新：性能により更新回数が変わる)
    void Update()
    {
        /*当たり判定*/
        //床に当たってるかの判定
        if (this.transform.position.y < _delSize)
        {
            _hitFloorFlag = true;
        }
        else
        {
            _hitFloorFlag = false;
        }


        /*重力動作*/
        //床に当たっていないなら、落下
        if (_hitFloorFlag == false)
        {
            this.transform.position += Vector3.down * _gravitySpeed;
        }
    }

    private void FixedUpdate()
    {
        
    }
}
