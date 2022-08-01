using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class InfoFacePose : MonoBehaviour
{
    [SerializeField] private Text ParamFace1;
    [SerializeField] private Text ParamFace2;
    [SerializeField] private Text ParamFace3;
    [SerializeField] private Text ParamFace4;
    GameObject ARFaceObject;
    ARFace _ARFace;
    bool face = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("ARFacePrefab")&&!face)
        {
            Debug.Log("Лицо найдено");
            ParamFace1.text = "Лицо найдено";
            ARFaceObject = GameObject.FindGameObjectWithTag("ARFacePrefab");
            _ARFace = ARFaceObject.GetComponent<ARFace>();
            face = true;
        }

        if (face)
        {
            ParamFace1.text = _ARFace.leftEye.localPosition.ToString();
            ParamFace2.text = _ARFace.leftEye.position.ToString();
            ParamFace3.text = "trackableId:" + _ARFace.trackableId.ToString();
            ParamFace4.text = "vertices:" + _ARFace.vertices.Length;

            //ParamFace1.text = ARFaceObject.GetComponent<ARFace>().leftEye.localPosition.ToString();
            //ParamFace2.text = ARFaceObject.GetComponent<ARFace>().leftEye.position.ToString();
            //ParamFace3.text = "trackableId:" + ARFaceObject.GetComponent<ARFace>().trackableId.ToString();
            //ParamFace4.text = "vertices:" + ARFaceObject.GetComponent<ARFace>().vertices.Length;

            //ParamFace.text = "Правый глаз:" + _ARFace.rightEye.position + "\nЛевый глаз:" + _ARFace.leftEye.position + "\nfixationPoint:" + _ARFace.fixationPoint.position;
            //Debug.Log(_ARFace.rightEye.position.ToString());
            //Debug.Log("Левый глаз:" + _ARFace.leftEye.position);
            //ParamFace.text = _ARFace.rightEye.position.ToString() + "\n" + _ARFace.leftEye.position;
        }
    }
}
