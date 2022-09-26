using Mapbox.Map;
using Mapbox.Unity.Map;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapZoomController : MonoBehaviour
{
    GameObject placementMarker;
    public AbstractMap map;
    private Transform mapTransform;
    private float zoomAmount;
    public Material placementMaterial;
    public Material placedMaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getPlacedMap()
    {
        map.SetTileMaterial(placedMaterial);
        mapTransform = gameObject.transform;
        zoomAmount = map.Zoom;
    }
}
