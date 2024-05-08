using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCoin : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�̔��ˏꏊ")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("�e")]
    private GameObject coin;

    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;

    // Update is called once per frame
    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ���𔻒�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �e�𔭎˂���
            LauncherShot();
        }
    }

    /// <summary>
	/// �e�̔���
	/// </summary>
    private void LauncherShot()
    {
        // �e�𔭎˂���ꏊ���擾
        Vector3 bulletPosition = firingPoint.transform.position+ new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
        GameObject newBall = Instantiate(coin, bulletPosition, transform.rotation);

        // �o���������{�[���̖��O��"bullet"�ɕύX
        newBall.name = coin.name;
    }
}
