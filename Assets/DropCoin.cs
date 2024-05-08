using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCoin : MonoBehaviour
{
    [SerializeField]
    [Tooltip("弾の発射場所")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("弾")]
    private GameObject coin;

    [SerializeField]
    [Tooltip("弾の速さ")]
    private float speed = 30f;

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたかを判定
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 弾を発射する
            LauncherShot();
        }
    }

    /// <summary>
	/// 弾の発射
	/// </summary>
    private void LauncherShot()
    {
        // 弾を発射する場所を取得
        Vector3 bulletPosition = firingPoint.transform.position+ new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(coin, bulletPosition, transform.rotation);

        // 出現させたボールの名前を"bullet"に変更
        newBall.name = coin.name;
    }
}
