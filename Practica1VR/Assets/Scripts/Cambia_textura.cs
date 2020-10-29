using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambia_textura : MonoBehaviour
{
    //public MeshRenderer meshRenderer;
    
    public GameObject esfera;
    public Material materialA;
    public Material materialB;
    public Material materialC;

    public int casoMaterial = 1;
    // Start is called before the first frame update
    void Start()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer rend = esfera.GetComponent<Renderer>();
        if (Input.touches.Length<=0)
        {
            //Si no lo tocamos, no hace nada
        }
        else
        {
            if (casoMaterial == 1)
            {
                casoMaterial = 2;
            }else if (casoMaterial == 2)
            {
                casoMaterial = 3;
            }
            else
            {
                casoMaterial = 1;
            }

            switch (casoMaterial)
            {
                case 1:
                    rend.material = materialB;
                    break;
                case 2:
                    rend.material = materialC;
                    break;
                case 3:
                    rend.material = materialA;
                    break;
            }
            
        }
    }
}
