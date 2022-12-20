using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerationScript : MonoBehaviour
{
    public static int generationValue = 0;

     TextMeshProUGUI Generation;

   // public int genomeValue = 0;
    //Text Genome;

    void Start()
    {
        Generation = this.GetComponent<TextMeshProUGUI>();
            //Genome = GameObject.FindGameObjectWithTag("Genome");
    }

    void Update()
    {
        Generation.text = "Generation: " + generationValue;
        //Genome.Text = "Genome: " + genomeValue;
    }
}
