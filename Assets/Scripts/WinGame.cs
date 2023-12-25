using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class WinGame : MonoBehaviour
{
    [SerializeField] private RawImage _videoPlayer;
    [SerializeField] private Text _win;
    [SerializeField] private Button _winButton;
    private GameObject _player;

    private void Start()
    {
        _win.gameObject.SetActive(false);
        _videoPlayer.gameObject.SetActive(false);
        _winButton.gameObject.SetActive(false);
        _player = FindObjectOfType<MovePlayer>().gameObject;
    }

    public void StartPortal()
    {
        _videoPlayer.gameObject.SetActive(true);
        Destroy(_player);
        Invoke("Texts",5f);
    }

    public void Texts()
    {
        _winButton.gameObject.SetActive(true);
        _win.gameObject.SetActive(true);
    }
    
}
