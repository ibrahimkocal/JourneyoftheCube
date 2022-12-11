using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource musicplayer;
    [SerializeField] AudioClip music;

    void Start() {
    // Müzik dosyasının bilgilerini saklamak için AudioClip değişkenini doldurun
  
    // AudioSource nesnesini oluşturun ve müzik dosyasını ekleyin
    AudioSource musicPlayer = GetComponent<AudioSource>();
    musicPlayer.clip = music;
  
    // Müziği oynatın
    musicPlayer.Play();
  
    // Sahne değiştirildiğinde müziğin kesilmemesi için DontDestroyOnLoad fonksiyonunu kullanın
    DontDestroyOnLoad(musicPlayer);
    }
}