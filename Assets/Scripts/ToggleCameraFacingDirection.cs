using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class ToggleCameraFacingDirection : MonoBehaviour
    {
        [SerializeField]
        ARCameraManager m_CameraManager;
        [SerializeField] GameObject GaragePrefab;
        [SerializeField] DoorScript doorScript;
        public bool openDoor=false;
        public ARCameraManager cameraManager
        {
            get => m_CameraManager;
            set => m_CameraManager = value;
        }

        [SerializeField]
        ARSession m_Session;

        public ARSession session
        {
            get => m_Session;
            set => m_Session = value;
        }

        void Update()
        {
            //if (m_CameraManager == null || m_Session == null)
            //    return;

            //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            //{
            //    if (m_CameraManager.requestedFacingDirection == CameraFacingDirection.User)
            //    {
            //        m_CameraManager.requestedFacingDirection = CameraFacingDirection.World;
            //    }
            //    else
            //    {
            //        m_CameraManager.requestedFacingDirection = CameraFacingDirection.User;
            //    }
            //}
        }
        public void SwitchCamera()
        {
            if (m_CameraManager == null || m_Session == null)
                return;

            if (m_CameraManager.requestedFacingDirection == CameraFacingDirection.User)
            {
                GaragePrefab.SetActive(true);
                //InvisibleGarage(true);
                m_CameraManager.requestedFacingDirection = CameraFacingDirection.World;
                if(openDoor)
                    doorScript.OpenDoor();
            }
            else
            {
                GaragePrefab.SetActive(false);
                //InvisibleGarage(false);
                m_CameraManager.requestedFacingDirection = CameraFacingDirection.User;
            }
        }
        private void InvisibleGarage(bool Bool)
        {
            if (GameObject.FindGameObjectWithTag("Garage"))
            {
                GameObject.FindGameObjectWithTag("Garage").SetActive(Bool);
            }
        }
    }
}