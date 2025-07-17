using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject dragonPrefab;
    [SerializeField] private Vector3 prefabOffset;

    private ARTrackedImageManager _trackedImageManager;

    private void OnEnable()
    {
        _trackedImageManager = GetComponent<ARTrackedImageManager>();
        _trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        if (_trackedImageManager != null)
        {
            _trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage image in eventArgs.added)
        {
            GameObject dragon = Instantiate(dragonPrefab, image.transform.position + prefabOffset, Quaternion.identity);
            dragon.transform.parent = image.transform; // Optional: parent to the image
        }
    }
}
