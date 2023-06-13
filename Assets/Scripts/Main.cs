using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    private AudioSource nomalAudio; // 기본 배경 음악 객체

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoopAudio();
    }

    void LoopAudio() {
        // 현재 mp3 재생시간대가 13초 이후라면 0부터 재시작
        // if (nomalAudio.time >= 13f){ 
        //     nomalAudio.time = 0f; // 오디오 시간대 0으로 처리
        //     nomalAudio.Play(); // 다시 플레이
        // }
    }
}
