/***************************************************************
* Name: Zubaidah Alqaisi                                       *
* ZID: Z1786977                                                * 
* Course: CSCI 473 Section 2 Spring 2018                       *
* Assignment: assign2                                          *
* Due Date: Friday, Feb. 16.                                   *
* Program goal: Practice using some features of C# using Visual* 
*               Studio IDE. Introduction to using forms.       *
***************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assign2
{
    public partial class assign2 : Form
    {
        //declaring a list of string type value
        public static List<Person> otherPerson = new List<Person>();

/***************************************************************** 
 * Function: ReadFile()                                          * 
 * Purpose: This function reads inputs from the file 'data1';    *
 * It contains three lines for each person lines with one string *
 * per line (name followed by office number followed by telephone*
 * number).                                                      *
 * Arguments: none                                               *
 * Return: none (void)                                           *
 *****************************************************************/ 

        private void ReadFile()
        {
            using (StreamReader SR = new StreamReader("data1.txt"))
            {
                //declaring variables
                String name;
                String officeNum;
                String teleNum;

                //first read
                name = SR.ReadLine();
                officeNum = SR.ReadLine();
                teleNum = SR.ReadLine();

                //looping through the file and read the inputs 
                while (name != null)
                {
                    otherPerson.Add(new Person(name, officeNum, teleNum));
                    //second read
                    name = SR.ReadLine();
                    officeNum = SR.ReadLine();
                    teleNum = SR.ReadLine();
                }
            }

        } // end of ReadFile() function

        public assign2()
        {
            InitializeComponent();
        }

/*********************************************************
 * Function: Form1_load()                                *
 * Purpose: calling the ReadFile() method to read the    *
 *          supplied file. Allocating resources used by  *
 *          the user.                                    *
 * Arguments: object sender, EventArgs                   *
 * Return: none (void)                                   *
 * ******************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
        }

/*******************************************************
 * Function: radioButton_CheckedChanged()              *
 * Purpose: This function or event checks each of the  *
 *          included radio buttons if it is being      *
 *          checked by the user. If the radio button   *
 *          is being checked by the user, it will      *
 *          disable or enable the text boxs based on   *
 *          radio button checked's requirments.        *
 * Arguments: object sender, EventArgs                 *
 * Return: none (void)                                 *
 * ****************************************************/

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (printTheList.Checked)
            {
                nameTextBox.Enabled = false;       //disable the name textbox 
                officeNumTextBox.Enabled = false;   //disable the office num textbox
                teleNumTextBox.Enabled = false;     //disable the tele num textbox 
            }
            if (addAnEntry.Checked)
            {
                nameTextBox.Enabled = true;   // enable the name textbox 
                officeNumTextBox.Enabled = true;    // enable the office num textbox
                teleNumTextBox.Enabled = true;      // enable the tele num textbox 

            }
            if (searchForName.Checked)
            {
                nameTextBox.Enabled = true;
                officeNumTextBox.Enabled = false;
                teleNumTextBox.Enabled = false;

            }
            if (searchAnOfficeNum.Checked)
            {
                nameTextBox.Enabled = false;
                officeNumTextBox.Enabled = true;
                teleNumTextBox.Enabled = false;

            }            if (searchForTeleNum.Checked)
            {
                nameTextBox.Enabled = false;
                officeNumTextBox.Enabled = false;
                teleNumTextBox.Enabled = true;

            }
            if (changeNum.Checked)
            {
                nameTextBox.Enabled = true;
                officeNumTextBox.Enabled = true;
                teleNumTextBox.Enabled = false;
            }
            if (sortTheListName.Checked)
            {
                nameTextBox.Enabled = false;
                officeNumTextBox.Enabled = false;
                teleNumTextBox.Enabled = false;
            }
            if (quit.Checked)
            {
                nameTextBox.Enabled = false;
                officeNumTextBox.Enabled = false;
                teleNumTextBox.Enabled = false;
            }

        } // end of radioButton_checkedChanged()

/******************************************************
 * Function: Submit_Click()                           *
 * Purpose: this function acts as a switch statement  *
 *          and chekcs if a particular radio button is*
 *          checked then calls a method associated    *
 *          that radio button and makes that radio    *
 *          button active.                            *
 * Arguments: object sender, EventArgs                *      
 * Return: none (void)                                *
 * ***************************************************/

        private void Submit_Click(object sender, EventArgs e)
        {
            if (printTheList.Checked)       // if the printTheList radio button is checked,         
            {
                DisplayList();                // call the method DisplayList()
            }
            if (addAnEntry.Checked)
            {
                AddEntry();
            }
            if (searchForName.Checked)
            {
                SearchName();
            }
            if (searchAnOfficeNum.Checked)
            {
                SearchOfficeNum();
            }
            if (searchForTeleNum.Checked)
            {
                SearchTeleNumber();
            }
            if (changeNum.Checked)
            {
                ChangeOfficeNum();
            }
            if (sortTheListName.Checked)
            {
                SortName();
            }
            if (quit.Checked)
            {
                Application.Exit();
            }

        } // End of Submit_Click method

/*************************************************************
* Function: DisplayList()                                    *
* Purpose: This function loops through 'otherPerson' list    *
*          and display a list of names, office numbers, and  *
*          telephone numbers for the user.                   *
* Arguments: none                                            *
* Return: none (void)                                        *
*************************************************************/

        private void DisplayList()
        {
            //display columns header 
            output.Items.Add("Name".PadRight(20) + "Office Number".PadRight(20) + "Telephone Number");

            foreach (Person person in otherPerson)
            {
                //display recoreds or entries in the list
                output.Items.Add(person.Name.PadRight(20) + person.OfficeNum.PadRight(20) +
                   person.TeleNum);
            }
        } // end of DisplayList() function

/**************************************************************
* Function: AddEntry()                                        *
* Purpose: This function loops through the list to make sure  *
*          that the list does not contain the same entry added*
*          by the user in the appropriate textboxes. if the   *
*          the info added by the user exist, print a message  *
*          to inform the user.                                *
* Arguments: none                                             *
* Return: none (void)                                         *
**************************************************************/

        private void AddEntry()
        {
            string name = "";
            // if the textboxes are not empty
            if (nameTextBox.Text != "" && officeNumTextBox.Text != "" && teleNumTextBox.Text != "")
                {
                // lopping through the list to find the name entered by the user 
                foreach (Person person in otherPerson)
                {      //string Equal method to compare two strings values 
                    if (String.Equals(nameTextBox.Text.ToLower(), person.Name.ToLower()))
                    {
                        output.Items.Add("The name already exits");
                        name = person.Name.ToLower();
                        break;
                    }
                }

                // if the info added by the user does not exist, add it to the list
                if (name != nameTextBox.Text.ToLower())
                {
                    otherPerson.Add(new Person(nameTextBox.Text.ToLower(), officeNumTextBox.Text, teleNumTextBox.Text));
                    output.Items.Add("The information has been added to the list");
                }
            }
            else
            { // if empty print the user a messege 
                output.Items.Add("Please fill out the textboxes below with a valid value.");
            }
            nameTextBox.Clear();
            officeNumTextBox.Clear();
            teleNumTextBox.Clear();

        } // end of AddEntry() function 

        /***************************************************************
        * Function: SearchName()                                       *
        * Purpose: This function searchs the list for a name based on  *
        *          the user's input name. Once it finds it, it prints  *
        *          out the name and the info associated with it to the *
        *          listbox.                                            *
        * Arguments: none                                              *
        * Return: none (void)                                          *
        ***************************************************************/

        private void SearchName()
        {
            bool foundName = false;

            if (nameTextBox.Text != "")
            {
                foreach (Person person in otherPerson)
                {
                    // String Equal() method to compare two string values 
                    if (String.Equals(nameTextBox.Text.ToLower(), person.Name.ToLower()))
                    {
                        //if found, print the name and it's info to the listbox
                        output.Items.Add(person.Name.PadRight(20) +
                            person.OfficeNum.PadRight(20) + person.TeleNum);
                        foundName = true;
                        break;
                    }

                }
                // if the name entered by the user not found display a message
                if (!foundName)
                    output.Items.Add("The name " + nameTextBox.Text + " not found");
            }
            else
            {
                output.Items.Add("Please enter a valid name in the textbox below.");
            }

            nameTextBox.Clear();

        } // end of SearchName() function

/**************************************************************
* Function: SearchOfficeNum()                                 *
* Purpose: This function loops through the list to find a     *
*          match to the office number typed by the user in    *
*          the text box. Once it finds it, it will print out  *
*          the info associated with that office number.       *
* Arguments: none                                             *
* Return: none (void)                                         *
**************************************************************/

        private void SearchOfficeNum()
        {
            //declaring a flag 
            bool foundNum = false;

            if (officeNumTextBox.Text != "")
            {
                foreach (Person person in otherPerson)
                {       //comparing two strings to find a match 
                    if (String.Equals(officeNumTextBox.Text, person.OfficeNum))
                    {
                        // if found, write it to output
                        output.Items.Add(person.Name.PadRight(20) + person.OfficeNum.PadRight(20) +
                            person.TeleNum);

                        foundNum = true;
                    }

                }
                // if not found, print a message let the user know
                if (!foundNum)
                    output.Items.Add("The office number " + officeNumTextBox.Text + " was not found");

            }
            else
            {
                output.Items.Add("Please enter a valid office number in the textbox below.");
            }

            officeNumTextBox.Clear();

        } // end of SearchOfficeNum() function

        /***************************************************************
        * Function: SearchTeleNumber()                                 *
        * Purpose:This function loops through the list to find the tele*
        *         number added by the user in the tele textbox. once   *
        *         it finds it, it will print out the info of the person*
        *         associated with that number                          *
        * Arguments: none                                              *
        * Return: none (void)                                          *
        ***************************************************************/

        private void SearchTeleNumber()
        {
            bool foundTele = false;

            if (teleNumTextBox.Text != "")
            {
                foreach (Person person in otherPerson)
                {
                    //String Equal method for comparing tow string values 
                    if (String.Equals(teleNumTextBox.Text, person.TeleNum))
                    {
                        // if found, print the info of the person in the listbox 
                        output.Items.Add(person.Name.PadRight(20) + person.OfficeNum.PadRight(20) + person.TeleNum);
                        foundTele = true;
                        break;
                    }

                }
                // if the telephone number is not found print a message to the user 
                if (!foundTele)
                    output.Items.Add("The telephone number " + teleNumTextBox.Text + " was not found");
            }
            else
            {
                output.Items.Add("Please enter a valid telephone number in the textbox below.");
            }

            teleNumTextBox.Clear();

        } // end of SearchTeleNumber() function

/***************************************************************
* Function: ChangeOfficeNum()                                  *
* Purpose: This function loops through the list to find the    *
*          name added by the user in the name textbox. if      *
*          found, it will change the office number associated  *
*          with that name to the new office number             *
*          entered by the user in the textbox. then it display *
*          a messaege tells the user if the proccess is        *
*          successfully done.                                  *
* Arguments: none                                              *         
* Return:none (void)                                           * 
***************************************************************/

        private void ChangeOfficeNum()
        {
            bool found = false;

            if (nameTextBox.Text != "" && officeNumTextBox.Text != "")
            {
                //looping through the list to find a match
                foreach (Person person in otherPerson)
                {    // string comparison 
                    if (String.Equals(nameTextBox.Text.ToLower(), person.Name.ToLower()))
                    {   // if found, print a message let the user know that the entry has been added 
                        person.OfficeNum = officeNumTextBox.Text;
                        output.Items.Add("The person you chose has been moved to " + officeNumTextBox.Text + " office number");
                        found = true;
                        break;
                    }

                }

                if (!found)
                {   // if not found, let the user know 
                    output.Items.Add("The name you entered was not found.");
                }
            }
            else
            {
                output.Items.Add("Please enter a valid name and office number in the textbox  below.");
            }

            nameTextBox.Clear();
            officeNumTextBox.Clear();

        }// end of ChangeOfficeNum() function 

/********************************************************************
* Function: SortName()                                              *
* Purpose: This function sort the entries in the list by name in    *
*          alphabatical order then prints the new list to the listbox*
* Arguments: none                                                   *
* Return: none (void)                                               *
********************************************************************/

        private void SortName()
        {
            otherPerson.Sort();
            output.Items.Add("The list is sorted successfully");

        } // end of SortName() function

/******************************************************************** 
 * Function: ClearAll_Click()                                       *
 * Purpose: This function clears out the list box items, the        *
 *          name textbox, the office number textbox, and the tele   *
 *          number textbox once clicking on the 'clear all' button. *        
 * Arguments: none                                                  *
 * Return: none (void)                                              *
 ********************************************************************/

        private void ClearAll_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
        }
    } // end of form class

/******************************************************************
* Class: Person                                                   *
*                                                                 *
* Access Modifier Type: Public                                    *
*                                                                 *
* Public Methods: String name, String officeNum, String TeleNum   *
*                 CompareTo                                       *
* Private Members: name, officeNum, teleNum                       *                                                              
* ****************************************************************/

    public class Person : IComparable
    {
        //private members 
        private string name;
        private string officeNum;
        private string teleNum;

        //constructor to initialize Person to three strings values 
        public Person(string name, string officeNum, string teleNum)
        {
            this.name = name;
            this.officeNum = officeNum;
            this.teleNum = teleNum;
        }

/***********************************************************
* Function: Name                                           *
* Purpose: This function has the get and set properties    *
*          that will allow access to the private member of *
*          the Person class 'name'. The get property will  *
*          reads the private member and the set will set   *
*          the private member to a value.                  *
* *********************************************************/

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

/*************************************************************
* Function: OfficeNum                                        *
* Purpose: It allows access to the private instant variable  * 
*          OfficeNum and set it to a value and return a      * 
*          string.                                           *
*************************************************************/

        public string OfficeNum
        {
            get
            {
                return this.officeNum;
            }
            set
            {
                this.officeNum = value;
            }
        }

/*************************************************************
* Function: TeleNum                                          *
* Purpose: It allows access to the private instant variable  * 
*          TeleNum and set it to a value and return a        * 
*          string.                                           *
*************************************************************/

        public string TeleNum
        {
            get
            {
                return this.teleNum;
            }
            set
            {
                this.teleNum = value;
            }
        }

/*************************************************************
* Function: CompareTo                                        *
* Purpose: Compares the current instance with another object *
*          of the same type and returns an integer that      *
*          indicates whether the current instance precedes,  * 
*          follows, or occurs in the same position in the    *
*          sort order as the other object.                   *
* Arguments: object OBJ                                      *
* Return: integer                                            *
*************************************************************/

        public int CompareTo(object OBJ)
        {
            Person NewPerson = (Person)OBJ;

            return String.Compare(this.name, NewPerson.Name);
        } // end of IComparable interface 

    }  // end of puplic class person  

}//end of namespace Assign2

