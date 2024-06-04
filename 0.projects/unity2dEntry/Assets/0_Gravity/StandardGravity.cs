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
    //重力速度(1が最大値)
    float _gravitySpeed;

    // Start is called before the first frame update
    void Start()
    {
        //床の設定
        //ゲームオブジェクトの取得から一気にｙ座標まで取得
        _floorY= GameObject.Find("Floor").transform.position.y;
        _floorSize = 1.8f;//床のサイズ
        _delSize = _floorY + _delSize;

        //重力の設定
        _gravitySpeed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        //床に当たってるかの判定
        if (this.transform.position.y < _delSize)
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
