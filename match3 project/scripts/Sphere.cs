using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int j = -1;
    public int i = -1;
    public bool isMatched;
    
    
    public bool newSphere = true;

    

    // Start is called before the first frame update
    void Start()
    {
        newSphere = false;
         
         
         isMatched = false;
    }

    

    




    // Update is called once per frame
    void Update()
    {
        
         if(transform.position != new Vector3(j,i,0))
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(j, i, 0), 4 * Time.deltaTime);


        if (isMatched)
        {
            
            generatePole.createSph = true;
            

            
            
            
            Destroy(gameObject);

        }

        

        
        

        if (i!=0)
        if(generatePole.curSpheres[j,i-1] == null) 
        {
                
                generatePole.curSpheres[j, i - 1] = gameObject;
                i--;
                generatePole.curSpheres[j, i + 1] = null;
                
                



                


        }
            
      
            
    }


    void OnMouseDown()
    {
        
        
        Debug.Log("selected");

        if(!generatePole.noCreate)
        if (generatePole.selectedSph1_j == -1)
        {
            generatePole.selectedSph1_j = j;
            generatePole.selectedSph1_i = i;
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }

        else
        {
            
            generatePole.selectedSph2_j = j;
            generatePole.selectedSph2_i = i;

        }

        
    }

}


    


