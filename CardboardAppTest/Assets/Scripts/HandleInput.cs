using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class HandleInput : MonoBehaviour, IGvrGazeResponder
{
    private Vector3 startingPosition;
    public GameObject ghostModel;

    void Start()
    {
        startingPosition = transform.localPosition;
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt)
    {
        ghostModel.GetComponent<Renderer>().material.color = gazedAt ? Color.red : Color.white;
    }

    public void ToggleVRMode()
    {
        GvrViewer.Instance.VRModeEnabled = !GvrViewer.Instance.VRModeEnabled;
    }

    public void ToggleDistortionCorrection()
    {
        switch (GvrViewer.Instance.DistortionCorrection)
        {
            case GvrViewer.DistortionCorrectionMethod.Unity:
                GvrViewer.Instance.DistortionCorrection = GvrViewer.DistortionCorrectionMethod.Native;
                break;
            case GvrViewer.DistortionCorrectionMethod.Native:
                GvrViewer.Instance.DistortionCorrection = GvrViewer.DistortionCorrectionMethod.None;
                break;
            case GvrViewer.DistortionCorrectionMethod.None:
            default:
                GvrViewer.Instance.DistortionCorrection = GvrViewer.DistortionCorrectionMethod.Unity;
                break;
        }
    }

    public void ToggleDirectRender()
    {
        GvrViewer.Controller.directRender = !GvrViewer.Controller.directRender;
    }

    public void Triggered()
    {
        //transform.position = startingPosition;
        GameObject.Find("GameController").GetComponent<GameController>().UpdateScore(1);
        Destroy(this.gameObject, 0.1f);
    }

    #region IGvrGazeResponder implementation

    public void OnGazeEnter()
    {
        SetGazedAt(true);
    }

    public void OnGazeExit()
    {
        SetGazedAt(false);
    }

    public void OnGazeTrigger()
    {
        Triggered();
    }

    #endregion
}
