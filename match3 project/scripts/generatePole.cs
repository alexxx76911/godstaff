using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class generatePole : MonoBehaviour
{
    public InputField columns;
    public InputField raws;
    public GameObject cell;
    public GameObject[] spheres;
    public static GameObject[,] curSpheres;
    
    
    
    public static int selectedSph1_j = -1;
    public static int selectedSph1_i = -1;
    public static int selectedSph2_j = -1;
    public static int selectedSph2_i = -1;

    public static bool noCreate = true;
    private bool canCreate = false;
    private bool autoMatches = true;
    private bool move = false;
    private bool matched = false;
    public static bool createSph;
    public static bool checkPos = false;
    private GameObject tempSphere;
    private Vector3 temp;
    private Vector3 target1;
    private Vector3 target2;

    private GameObject curobj;

    public static int Height;
    

    public int width;

    
    public  int height;


    
    // Start is called before the first frame update
    void Start()
    {
           
        Vector3 camPos;
        camPos = new Vector3(width / 2, height / 2, -1);
        
        transform.position = camPos;
        Height = height;
        
        curSpheres = new GameObject[width, height];
        
        



       

        
                
                


            
         
    }

    public void createBoard()
    {
        canCreate = false;
        autoMatches = true;
        height = Convert.ToInt32(raws.text);
        width = Convert.ToInt32(columns.text);
        if (height < 3) height = 3;
        if (width < 3) width = 3;
        curSpheres = new GameObject[width, height];
        while (!canCreate || autoMatches)
            checkMove();
        if (canCreate && !autoMatches)
        {


            

            Debug.Log("work board");

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {

                    Instantiate(cell, new Vector3(j, i, 1), Quaternion.identity);


                    curSpheres[j, i] = Instantiate(curSpheres[j, i], new Vector3(j, i, 0), Quaternion.identity) as GameObject;
                    curSpheres[j, i].GetComponent<Sphere>().j = j;
                    curSpheres[j, i].GetComponent<Sphere>().i = i;


                }
            }
        }
    }


    //проверка наличия хода
    void checkMove()
    {
        Debug.Log("work");
        
        for (int i = 0; i < height; i++)
        {

            for (int j = 0; j < width; j++)
            {

                

                curobj = spheres[UnityEngine.Random.Range(0, 6)];
                


                curSpheres[j, i] = curobj;
                
                

            }
        }

        autoMatches = checkMatch(curSpheres);
        if (autoMatches) return;




        for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width-1; j++)
                    {

                        tempSphere = curSpheres[j, i];
                        curSpheres[j, i] = curSpheres[j + 1, i];
                        curSpheres[j + 1, i] = tempSphere;

                        canCreate = checkMatch(curSpheres);

                        tempSphere = curSpheres[j, i];
                        curSpheres[j, i] = curSpheres[j + 1, i];
                        curSpheres[j + 1, i] = tempSphere;

                        if (canCreate)
                            return;
                    }
                }



                for (int i = 0; i < height-1; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        tempSphere = curSpheres[j, i];
                        curSpheres[j, i] = curSpheres[j, i + 1];
                        curSpheres[j, i + 1] = tempSphere;

                        canCreate = checkMatch(curSpheres);

                        tempSphere = curSpheres[j, i];
                        curSpheres[j, i] = curSpheres[j, i + 1];
                        curSpheres[j, i + 1] = tempSphere;
                        if (canCreate)
                            return;

                    }
                }



    }
        
    
    

    //проверка на матчи
    bool checkMatch(GameObject[,] objects)
    {
        matched = false;
        Debug.Log("checkMatch");
        
        for (int i = 0; i < height; i++)
        {
            for (int j = 1; j < width-1; j++)
            {
                if(objects[j,i] != null && objects[j+1, i] != null && objects[j-1, i] != null)
                if (objects[j, i].tag == objects [j - 1, i].tag && objects[j, i].tag == objects[j + 1, i].tag)
                {
                     objects[j, i].GetComponent<Sphere>().isMatched = true;
                     objects[j+1, i].GetComponent<Sphere>().isMatched = true;
                     objects[j-1, i].GetComponent<Sphere>().isMatched = true;
                    matched = true;
                }
            }
        }

        for (int i = 1; i < height-1; i++)
        {
            for (int j = 0; j < width; j++)
            {

                if (objects[j, i] != null && objects[j, i+1] != null && objects[j, i-1] != null)
                if (objects[j, i].tag == objects[j, i + 1].tag && objects[j, i].tag == objects[j, i - 1].tag)
                {
                     objects[j, i].GetComponent<Sphere>().isMatched = true;
                     objects[j, i+1].GetComponent<Sphere>().isMatched = true;
                     objects[j, i-1].GetComponent<Sphere>().isMatched = true;
                    matched = true;
                }
            }

            
        }

        if (matched)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }


     


    void NewSpheres()
    {
        canCreate = false;
        Debug.Log("createSpheres");
        createSph = false;
        
        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (curSpheres[j, i] == null)
                {
                    curSpheres[j, i] = spheres[UnityEngine.Random.Range(0, 6)];

                    
                   

                }
            }
        }

        autoMatches = checkMatchVirtual(curSpheres);
        if (autoMatches)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (curSpheres[j, i].GetComponent<Sphere>().newSphere == true)
                    {
                        Debug.Log("newsphere");
                        curSpheres[j, i] = null;
                    }
                }
            }


                        
                        
            Debug.Log("true");
            NewSpheres();
            
        }

        else
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {

                    tempSphere = curSpheres[j, i];
                    curSpheres[j, i] = curSpheres[j + 1, i];
                    curSpheres[j + 1, i] = tempSphere;

                    canCreate = checkMatchVirtual(curSpheres);

                    tempSphere = curSpheres[j, i];
                    curSpheres[j, i] = curSpheres[j + 1, i];
                    curSpheres[j + 1, i] = tempSphere;

                    if (canCreate)
                    {
                        for (int k = 0; k < height; k++)
                        {
                            for (int l = 0; l < width; l++)
                            {
                                if (curSpheres[l, k].GetComponent<Sphere>().newSphere == true)
                                {
                                    
                                    Debug.Log("inst");
                                    curSpheres[l, k] = Instantiate(curSpheres[l, k], new Vector3(l, height + 3, 0), Quaternion.identity) as GameObject;
                                    curSpheres[l, k].GetComponent<Sphere>().j = l;
                                    curSpheres[l, k].GetComponent<Sphere>().i = k;
                                }
                            }
                        }
                        return;

                    }
                        
                }
            }



            for (int i = 0; i < height - 1; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    tempSphere = curSpheres[j, i];
                    curSpheres[j, i] = curSpheres[j, i + 1];
                    curSpheres[j, i + 1] = tempSphere;

                    canCreate = checkMatchVirtual(curSpheres);

                    tempSphere = curSpheres[j, i];
                    curSpheres[j, i] = curSpheres[j, i + 1];
                    curSpheres[j, i + 1] = tempSphere;
                    if (canCreate)
                    {
                        for (int k = 0; k < height; k++)
                        {
                            for (int l = 0; l < width; l++)
                            {
                                if (curSpheres[l, k].GetComponent<Sphere>().newSphere == true)
                                {
                                    
                                    Debug.Log("inst");
                                    curSpheres[l, k] = Instantiate(curSpheres[l, k], new Vector3(l, height + 3, 0), Quaternion.identity) as GameObject;
                                    curSpheres[l, k].GetComponent<Sphere>().j = l;
                                    curSpheres[l, k].GetComponent<Sphere>().i = k;
                                }
                            }
                        }
                        return;
                    }
                       

                }
            }

            
            if (!canCreate)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (curSpheres[j, i].GetComponent<Sphere>().newSphere == true)
                        {
                            Debug.Log("newsphere");
                            curSpheres[j, i] = null;
                        }
                    }
                }

                NewSpheres();
            }
            


        }





        


    }



   bool checkMatchVirtual(GameObject[,] objects)
    {
        matched = false;
        

        for (int i = 0; i < height; i++)
        {
            for (int j = 1; j < width - 1; j++)
            {
                if (objects[j, i].tag == objects[j - 1, i].tag && objects[j, i].tag == objects[j + 1, i].tag)
                {
                    
                    matched = true;
                    
                }
            }
        }

        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 0; j < width; j++)
            {

                if (objects[j, i].tag == objects[j, i + 1].tag && objects[j, i].tag == objects[j, i - 1].tag)
                {
                    
                    matched = true;
                    
                }
            }


        }

        if (matched)
        {

            return true;
        }
        else
        {
            return false;
        }

    }


    IEnumerator waitNewSph()
    {

        
        yield return new WaitForSeconds(1.5f);
        NewSpheres();
    }
           
    
    
    // Update is called once per frame
            void Update()
    {
        if (move)
        {
            if (curSpheres[selectedSph1_j, selectedSph1_i].transform.position == new Vector3(selectedSph1_j, selectedSph1_i, 0))
            {
                move = false;
                selectedSph1_j = -1;
                selectedSph1_i = -1;
                selectedSph2_j = -1;
                selectedSph2_i = -1;
                checkMatch(curSpheres);
            }
        }

        
        if (createSph)
        {
            noCreate = false;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (curSpheres[j, i] != null)
                        if (curSpheres[j, i].transform.position.y != curSpheres[j, i].GetComponent<Sphere>().i)
                        {



                            noCreate = true;
                            

                        }
                        
                }
            }
            if (!noCreate)
            {
                noCreate = true;
                if (!checkMatch(curSpheres))
                    StartCoroutine(waitNewSph());


                
            }


        }
        else
        {
            noCreate = false;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (curSpheres[j, i] != null)
                        if (curSpheres[j, i].transform.position.y != curSpheres[j, i].GetComponent<Sphere>().i)
                        {



                            noCreate = true;


                        }

                }
            }


        }

        
        
        

        if(selectedSph1_j >= 0 && selectedSph2_j >= 0 && move == false)
        {
            
            
            if((Mathf.Abs(selectedSph2_j - selectedSph1_j) < 2) && (Mathf.Abs(selectedSph2_i - selectedSph1_i) < 2))
                {
                  if (selectedSph2_j == selectedSph1_j || selectedSph2_i == selectedSph1_i)
                    {
                    
                    


                        tempSphere = curSpheres[selectedSph1_j, selectedSph1_i];
                        curSpheres[selectedSph1_j, selectedSph1_i] = curSpheres[selectedSph2_j, selectedSph2_i];
                        curSpheres[selectedSph2_j, selectedSph2_i] = tempSphere;

                        if (checkMatchVirtual(curSpheres))
                    {

                    
                        curSpheres[selectedSph1_j, selectedSph1_i].GetComponent<Sphere>().j = selectedSph1_j;
                        curSpheres[selectedSph1_j, selectedSph1_i].GetComponent<Sphere>().i = selectedSph1_i;
                        curSpheres[selectedSph2_j, selectedSph2_i].GetComponent<Sphere>().j = selectedSph2_j;
                        curSpheres[selectedSph2_j, selectedSph2_i].GetComponent<Sphere>().i = selectedSph2_i;
                        curSpheres[selectedSph2_j, selectedSph2_i].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);






                        move = true;
                        
                    }
                        else
                    {
                        tempSphere = curSpheres[selectedSph1_j, selectedSph1_i];
                        curSpheres[selectedSph1_j, selectedSph1_i] = curSpheres[selectedSph2_j, selectedSph2_i];
                        curSpheres[selectedSph2_j, selectedSph2_i] = tempSphere;
                        Debug.Log("reload");
                        curSpheres[selectedSph2_j, selectedSph2_i].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                        curSpheres[selectedSph1_j, selectedSph1_i].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                        selectedSph1_j = -1;
                        selectedSph1_i = -1;
                        selectedSph2_j = -1;
                        selectedSph2_i = -1;

                    }
                }
                }
            }




        }

        
        
        

    
}
