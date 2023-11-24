using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneToonTeen
{
public class blendshapesshow : MonoBehaviour
{
    public GameObject Char;
    GameObject GOHead;
    float time;
    public float timelapse;
    public int blendshapesnumber;
    int counter;
    public GUIStyle newGUIStyle;
    public bool showUI;
    string[] names = new string[30] { "","browR_DOWN","browL_DOWN","browR_UP","browL_UP", "browR_SAD", "browL_SAD" ,
                                      "smile", "sad", "disgust", "open", "M", "E", "U", "F",
                                      "lipUP_UP", "lipDOWN_DOWN", "jawUP",
                                      "blinkR", "blinkL","wideR","wideL", "lidRDOWN_UP","lidLDOWN_UP",
                                      "look_UP", "look_DOWN","look_RIGHT","look_LEFT","look_cross","look_crazy" };

    void Start()
    {
        if (transform.childCount > 0) DestroyImmediate(transform.GetChild(0).gameObject);
        time = 0f;
        counter = 0;
        GameObject GOAUX;
        GOAUX = Instantiate(Char, transform.position, transform.rotation, transform);
        foreach (Renderer compAUX in GOAUX.transform.GetComponentsInChildren<Renderer>())
        {
            compAUX.gameObject.SetActive(false);
        }
        GOHead = GOAUX.transform.Find("HEAD").gameObject;
        GOHead.SetActive(true);
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > timelapse && counter < blendshapesnumber)
        {
            StartCoroutine("ToBS", counter);
            counter++;
            time = 0f;
        }
        if (time > timelapse && counter == blendshapesnumber)
        {
            GOHead.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(blendshapesnumber - 1, 0f);

            //UnityEditor.EditorApplication.isPlaying = false;

            Application.Quit();
        }
    }

    void OnGUI()
    {
        if (showUI)
        {
            //GUI.Label(new Rect(800, 300, 300, 300), names[counter], newGUIStyle);
            GUI.Label(new Rect(800, 500, 300, 300), names[counter], newGUIStyle);

        }
    }

    IEnumerator ToBS(int BSN)
    {
        float fase = 0;
        while (fase < 100f)
        {
            GOHead.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(BSN, fase);
            fase += 2f;
            yield return false;
        }
        GOHead.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(BSN, 100f);

        yield return new WaitForSeconds(0.5f);

        while (fase > 0f)
        {
            GOHead.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(BSN, fase);
            fase -= 2f;
            yield return false;
        }
        GOHead.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(BSN, 0);

        yield return false;

    }
}
}