using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//懒汉模式的单例
// public class AudioManager
// {
//     private static AudioManager _instance = null;
//     private AudioManager() { } //构造函数都是private，只有静态类才能访问。
//     public static AudioManager getInstance()
//     {
//         if (!_instance)
//         {
//             _instance = new AudioManager();
//         }
//         return _instance;
//     }

//     public static releaseInstance()
//     {
//         if (_instance)
//         {
//             delete _instance;
//             _instance = null;
//         }
//     }
// }
//双重锁模式,在懒汉模式的基础上，增加线程锁定机制
// public class AudioManager
// {
//     private static AudioManager _instance = null;//如果此处声明时就创建属于饿汉模式。
//     private static readonly object _syslock = new object();
//     private AudioManager() { }
//     public static AudioManager getInstance()
//     {
//         if (_instance == null)
//         {
//             lock (_syslock)
//             {
//                 if (_instance == null)
//                 {
//                     _instance = new AudioManager();
//                     return _instance;
//                 }
//                 else
//                 {
//                     return _instance;
//                 }
//             }
//         }
//         return _instance;
//     }
// }
// 抽象单例类


// unity3D的单例模式
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T m_Instance = null;
    public static T instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = GameObject.FindObjectOfType(typeof(T)) as T;
                if (m_Instance == null)
                {
                    m_Instance = new GameObject("Singleton of" + typeof(T).ToString(), typeof(T)).GetComponent<T>();
                }
            }
            return m_Instance;
        }
    }
    private void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = this as T;
        }
    }
    private void OnApplicationQuit()
    {
        if (m_Instance)
            m_Instance = null;
    }
}

public class AudioManager : MonoSingleton<AudioManager>
{
    private AudioManager() { }
    public AudioSource soundPlayer;
    public AudioSource musicPlayer;
    public GameObject soundPrefab;
    public GameObject bgmPrefab;
    // bg music
    private void Awake()
    {
    }
    private void Start()
    {
        soundPlayer = soundPrefab.GetComponent<AudioSource>();
        musicPlayer = bgmPrefab.GetComponent<AudioSource>();
        // musicPlayer = Camera.main.GetComponent<AudioSource>();
        playBgMusic("scene1_bgm");

    }
    public void playBgMusic(string name, bool isLoop = false)
    {
        Debug.Log("_playBgMusic:_name=" + name);
        AudioClip clip = Resources.Load<AudioClip>(name);
        musicPlayer.clip = clip;
        musicPlayer.Play();
    }
    public void pauseBgMusic()
    {
        musicPlayer.Pause();
    }
    public void resumeBgMusic()
    {
        musicPlayer.UnPause();
    }
    public void stopBgMusic()
    {
        musicPlayer.Stop();
    }

    public void setBgMusicVolume(int volu)
    {
        if (volu < 0)
            volu = 0;
        if (volu > 1)
            volu = 1;
        musicPlayer.volume = volu;
    }
    public float getBgMusicVolume()
    {
        return musicPlayer.volume;
    }

    //audio 
    public void playSound(string name)
    {
        Debug.Log("_playSound:_name=" + name);
        AudioClip clip = Resources.Load<AudioClip>(name);
        soundPlayer.clip = clip;
        soundPlayer.Play();
    }
    public void stopSound(string name)
    {
        soundPlayer.Pause();
    }
    public void setSoundVolume(int volu)
    {
        if (volu < 0)
            volu = 0;
        if (volu > 1)
            volu = 1;
        soundPlayer.volume = volu;
    }
    public float getSoundVolume()
    {
        return soundPlayer.volume;
    }
}
// public class SoundManager : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public AudioSource soundPlayer;
//     public AudioSource musicPlayer;

//     void Start()
//     {
//         // sm = this;
//         // SoundManager.getInstance();
//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }

//     // bg music
//     public void playBgMusic(string name, bool isLoop)
//     {
//         Debug.Log("_playBgMusic:_name=" + name);
//         AudioClip clip = Resources.Load<AudioClip>(name);
//         musicPlayer.clip = clip;
//         musicPlayer.Play();
//     }
//     public void pauseBgMusic()
//     {
//         musicPlayer.Pause();
//     }
//     public void resumeBgMusic()
//     {
//         musicPlayer.UnPause();
//     }
//     public void stopBgMusic()
//     {
//         musicPlayer.Stop();
//     }

//     public void setBgMusicVolume(int volu)
//     {
//         if (volu < 0)
//             volu = 0;
//         if (volu > 1)
//             volu = 1;
//         musicPlayer.volume = volu;
//     }
//     public float getBgMusicVolume()
//     {
//         return musicPlayer.volume;
//     }

//     //audio 
//     public void playSound(string name)
//     {
//         Debug.Log("_playSound:_name=" + name);
//         AudioClip clip = Resources.Load<AudioClip>(name);
//         soundPlayer.clip = clip;
//         soundPlayer.Play();
//     }
//     public void stopSound(string name)
//     {
//         soundPlayer.Pause();
//     }
//     public void setSoundVolume(int volu)
//     {
//         if (volu < 0)
//             volu = 0;
//         if (volu > 1)
//             volu = 1;
//         soundPlayer.volume = volu;
//     }
//     public float getSoundVolume()
//     {
//         return soundPlayer.volume;
//     }
// }