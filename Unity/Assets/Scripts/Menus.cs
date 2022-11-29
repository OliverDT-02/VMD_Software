using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menus : MonoBehaviour
{
    public static bool Paused = false;

    [SerializeField]
    GameObject PauseMenuUI;

    [SerializeField]
    GameObject OptionsMenuUI;

    [SerializeField]
    GameObject CasesMenuUI;

    [SerializeField]
    GameObject MoleculesMenuUI;

    [SerializeField]
    GameObject PressButton1;

    [SerializeField]
    GameObject PressButton2;

    [SerializeField]
    GameObject PressButton3;

    [SerializeField]
    GameObject PressButton4;

    [SerializeField]
    GameObject case1;

    [SerializeField]
    GameObject case2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // método para quitar la pausa
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(false);
        CasesMenuUI.SetActive(false);
        MoleculesMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
    // método para poner pausa
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(PressButton1);

    }

    public void Options()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(PressButton2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Cases()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(false);
        CasesMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(PressButton3);
    }

    public void Molecules()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(false);
        CasesMenuUI.SetActive(false);
        MoleculesMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(PressButton4);
    }

    public void Case1()
    {
        case1.SetActive(true);
        case2.SetActive(false);

    }

    public void Case2()
    {
        case1.SetActive(false);
        case2.SetActive(true);

    }

    public void CarbonSelection()
    {
        GameObject[] carbonAtoms = GameObject.FindGameObjectsWithTag("Carbon");
        if (carbonAtoms != null)
        {
            foreach (GameObject carbonAtom in carbonAtoms)
            {
                carbonAtom.GetComponent<Renderer>().enabled = !carbonAtom.GetComponent<Renderer>().enabled;
            }
        }
    }

    public void HydrogenSelection()
    {
        GameObject[] hydrogenAtoms = GameObject.FindGameObjectsWithTag("Hydrogen");
        if (hydrogenAtoms != null)
        {
            foreach (GameObject hydrogenAtom in hydrogenAtoms)
            {
                hydrogenAtom.GetComponent<Renderer>().enabled = !hydrogenAtom.GetComponent<Renderer>().enabled;
            }
        }
    }

    public void OxygenSelection()
    {

        GameObject[] oxygenAtoms = GameObject.FindGameObjectsWithTag("Oxygen");
        if (oxygenAtoms != null)
        {
            foreach (GameObject oxygenAtom in oxygenAtoms)
            {
                oxygenAtom.GetComponent<Renderer>().enabled = !oxygenAtom.GetComponent<Renderer>().enabled;
            }
        }
    }

    public void NitrogenSelection()
    {

        GameObject[] nitrogenAtoms = GameObject.FindGameObjectsWithTag("Nitrogen");
        if (nitrogenAtoms != null)
        {
            foreach (GameObject nitrogenAtom in nitrogenAtoms)
            {
                nitrogenAtom.GetComponent<Renderer>().enabled = !nitrogenAtom.GetComponent<Renderer>().enabled;
            }
        }
    }
}