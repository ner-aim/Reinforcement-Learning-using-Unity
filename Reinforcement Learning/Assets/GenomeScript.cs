using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static int genomeValue = 0;

    TextMeshProUGUI Genome;


    // public int genomeValue = 0;
    //Text Genome;

    void Start()
    {
        Genome = this.GetComponent<TextMeshProUGUI>();
        //Genome = GameObject.FindGameObjectWithTag("Genome");
    }

    void Update()
    {
        Genome.text = "Genome: " + genomeValue;
        //Genome.Text = "Genome: " + genomeValue;
    }
}
