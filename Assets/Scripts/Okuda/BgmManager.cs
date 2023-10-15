using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Windows.WebCam.VideoCapture;

public class BgmManager : MonoBehaviour
{
    //�X�^�[�g����HowToPlay�ւ̉�ʑJ�ڂ�BGM���ς�炸�Ȃ葱����d�l
    public static BgmManager instance;//static �ϐ���BgmManager�^�̃C���X�^���X��ێ�
    void Awake()
    {
        //�����Awake�̎��݂̂�����true�ɂȂ�C���X�^���X���o�^�����
        if (instance == null)
        {
            instance = this;//���̃C���X�^���X��static �� instance�ɓo�^
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);//�Q��ڈȍ~�d�����č쐬���Ă��܂���gameObject���폜
        }
    }
    

    // Update is called once per frame
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
       
    }
    // HowToPlay�ȊO�̃V�[���ɑJ�ڂ����ꍇ��BGM���~
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name != "HowToPlay")
        {
            Destroy(gameObject);
        }
    }
}
