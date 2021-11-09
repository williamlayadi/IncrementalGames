using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public AudioClip clip;
    public AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        audioSource.PlayOneShot(clip);
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}
