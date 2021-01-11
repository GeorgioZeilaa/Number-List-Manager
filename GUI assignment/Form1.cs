//17014182
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_assignment
{
    public partial class Form1 : Form
    {
        //sorted and unsorted check
        int sorted = 0;

        int min = 0;
        int maxvalue = 100;
        int maxentry = 30;//the max entry always has to be less than maxvalue so the duplicate function runs

        struct SearchStruct
        {
            public bool found;
            public int position;
            public int comparisons;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //enables and disabled objects according to the listbox and sorted situation.
            Updates();

            //disable all textboxes for stats
            txtCount.ReadOnly = Enabled;
            txtFirstValue.ReadOnly = Enabled;
            txtLastValue.ReadOnly = Enabled;
            txtMinimum.ReadOnly = Enabled;
            txtMaximumValues.ReadOnly = Enabled;
            txtMaxiumEnteries.ReadOnly = Enabled;

            //disable maximize and resize of form
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //drag and drop
            picRecycle.AllowDrop = true;
        }
        private void btnInitialise_Click(object sender, EventArgs e)
        {
            lstbox_30int.Items.Clear();//this clears the list first to not top up the integers already in the list
            RandomIntGenerator();//generates random integers between 0 and 100
            sorted = 0;//sets sorted to be 0 

            if (radSorted.Checked == true)//if the sorted radio button is selected 
            {
                //adds it to being sorted and runs bubble sort
                sorted = BubbleSort();
            }
            Updates();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the list, sets sorted to 0 and runs updates funtion
            lstbox_30int.Items.Clear();
            Updates();
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //runs the shuffle function if there are 2 or more integers in the list and sets sorted to 0
            Shuffle();
            sorted = 0;
            Updates();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string integer = txtInsert.Text.Replace(" ","");//this is to ignore spaces when entered

            if (CheckEmpty(integer) == 0)
            {
                if (IntCheck(integer) == 0)
                {
                    if (RangeCheck(integer) == 0)
                    {
                        if (Duplicate(integer) == 0)
                        {
                            if (sorted == 0)
                            {
                                InsertIntAtEnd(int.Parse(integer));//runs insertintatend if the  list is not sorted 
                            }
                            if (sorted == 1)
                            {
                                InsertSorted(integer);//inserts an integer at correct position if sorted
                            }
                        }
                        else MessageBox.Show("Duplicate has been found!");
                    }
                    else MessageBox.Show("ERROR!: Input only integers between " + min + " and " + maxvalue + "!");
                }
                else MessageBox.Show("ERROR!: Input only integer!");
            }
            else MessageBox.Show("ERROR!: Input a value!");

            Updates();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string integer = txtSearch.Text.Replace(" ","");

            if (CheckEmpty(integer) == 0)
            {
                if (IntCheck(integer) == 0)
                {
                    if (RangeCheck(integer) == 0)
                    {
                        if (radLinear.Checked == true)
                        {
                            SearchStruct search = LinearSearch(integer);//this is a struct so we can pass on variables to functions
                            if (search.found == true)//if the search found a value then it will output the messagebox below
                            {
                                MessageBox.Show("Linear Search: \n\nInteger " + integer + 
                                    " Found! \nNumber of comparisons = " + search.comparisons.ToString() + 
                                    "\n" + "Position Index: " + search.position);
                            }//if it did not find a value then it will outpu the messagebox below
                            else MessageBox.Show("Linear Search: \n\nERROR!: Integer " + integer + 
                                " not Found! \nNumber of comparisons = " + search.comparisons.ToString() + 
                                "\n" + "Position Index not found!");
                        }
                        if (radBinary.Checked == true)
                        {
                            SearchStruct search = BinarySearch(integer);
                            if(search.found == true)
                            {
                                MessageBox.Show("Binary Search: \n\nInteger " + integer + " Found! \nNumber of comparisons = " + search.comparisons.ToString() + "\n" + "Position Index: " + search.position.ToString());
                            }
                            else MessageBox.Show("Binary Search: \n\nERROR!: Integer " + integer + " not found! \nNumber of comparisons = " + search.comparisons.ToString() + "\n" + "Position Index Not Found!");
                        }
                    }
                    else MessageBox.Show("ERROR!: Input only integers between " + min + " and " + maxvalue + "!");
                }
                else MessageBox.Show("ERROR!: Input only integer!");
            }
            else MessageBox.Show("ERROR!: Input a value!");

            Updates();
        }
        private void radUnsorted_Click(object sender, EventArgs e)
        {
            if (sorted == 1)//if it is sorted before clicking unsorted radio button
            {
                //runs shuffle and  it will then change sorted to 0 so the rest of the program will treat it as an unsorted list
                sorted = 0;
                Updates();
            }
        }
        private void radSorted_Click(object sender, EventArgs e)
        {
            if (sorted == 0)//if the  list is not sorted before clicking sorted radio button
            {
                //runs bubble sort and sets sorted to whatever the outcome of bubble sort is 
                sorted = BubbleSort();
                Updates();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //an integer will be deleted if selected
            if (lstbox_30int.SelectedIndex != -1)
            {
                DeleteInt();//runs the delete function
                Updates();
            }
            else MessageBox.Show("ERROR: Select an item first!");
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);//this is for clicking enter on the textboxes it will run the button specified
            }
        }
        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInsert_Click(sender, e);//this is for clicking enter on the textboxes it will run the button specified
            }
        }
        private void lstbox_30int_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstbox_30int.Items.Count > 0)//if there are values in the listbox
            {
                lstbox_30int.DoDragDrop(lstbox_30int.SelectedIndex, DragDropEffects.Move);//this will select the index value of the item that is selected for drag drop
            }
        }
        private void picRecycle_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void picRecycle_DragDrop(object sender, DragEventArgs e)
        {
            btnDelete_Click(sender, e);//runs delete button when dropping the integer from the listbox to the recycle bin picture
        }
        private void Updates()
        {
            int lastindex = lstbox_30int.Items.Count - 1;
            //if the list has at least one value else empty
            if (lstbox_30int.Items.Count > 0)
            {
                txtSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                //stats textboxes
                txtFirstValue.Text = Convert.ToString(lstbox_30int.Items[0]);
                txtLastValue.Text = Convert.ToString(lstbox_30int.Items[lastindex]);
                txtMinimum.Text = Convert.ToString(Min());
                txtMaximumValues.Text = Convert.ToString(Max());
            }
            else
            {
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;
                btnClear.Enabled = false;
                btnDelete.Enabled = false;
                
                txtSearch.Text = string.Empty;//resets the textbox insert

                //stats textboxes
                txtFirstValue.Text = "";
                txtLastValue.Text = "";//question
                txtMinimum.Text = string.Empty;
                txtMaximumValues.Text = string.Empty;
            }
            
            if (lstbox_30int.Items.Count < maxentry)//if the list is not full else is full
            {
                txtInsert.Enabled = true;
                btnInsert.Enabled = true;
            }
            else
            {
                txtInsert.Enabled = false;
                btnInsert.Enabled = false;

                txtInsert.Text = string.Empty;//resets the textbox insert
            }
            
            if (lstbox_30int.Items.Count >= 2 && sorted == 0)//if the list has at least 2 or more values and is unsorted else is sorted or less than 2 values in list
            {
                btnShuffle.Enabled = true;
            }
            else
            {
                btnShuffle.Enabled = false;
            }
           
            if(sorted == 0) //if the list is unsorted else sorted
            {
                radBinary.Enabled = false;
                radLinear.Checked = true;
                radUnsorted.Checked = true;
            }
            else if(sorted == 1)
            {
                radBinary.Enabled = true;
            }
            txtCount.Text = Convert.ToString(lstbox_30int.Items.Count);//a variable integer that changes according to the active entries in the list
            txtMaxiumEnteries.Text = Convert.ToString(maxentry);//a static value of maxentry to be displayed
        }
        private int Min()
        {
            if (lstbox_30int.Items.Count > 0)
            {
                int MinInt = int.Parse(lstbox_30int.Items[0].ToString());

                for (int i = 0; i < lstbox_30int.Items.Count; i++)
                {
                    int Value = int.Parse(lstbox_30int.Items[i].ToString());

                    if (Value < MinInt)//it compares the first value in the list to others in the list
                    {
                        MinInt = Value;//if it is found that the value is less than the original set minimum integer then it will change the minimum integer to value.
                    }
                }
                return MinInt;
            }
            return 0;
        }
        private int Max()
        {
            if (lstbox_30int.Items.Count > 0)
            {
                int MaxInt = int.Parse(lstbox_30int.Items[0].ToString());

                for (int i = 0; i < lstbox_30int.Items.Count; i++)
                {
                    int Value = int.Parse(lstbox_30int.Items[i].ToString());

                    if (Value > MaxInt)//compares the original value of maxint that was first set which is just the first value in the list to value which is from the loop
                    {
                        MaxInt = Value;//if the value is greater then maxint that was originaly set then it will set the maxint to value so this way it will keep the maxint up to date.
                    }
                }
                return MaxInt;
            }
            return 0;
        }
        private int Duplicate(string integer)
        {
            for (int i = 0; i < lstbox_30int.Items.Count; i++)
            {
                if (int.Parse(integer) == int.Parse(lstbox_30int.Items[i].ToString()))//if there is a value that is equal to the value adding
                {
                    return 1;//return 1 when there is a dubplicate found
                }
            }
            return 0;//return 0 if no dubplicate is found
        }
        private int IntCheck(string integer)
        {
            int Searchinteger = 0;
            if (int.TryParse(integer, out Searchinteger))//checks if there is an integer in variable integer
            {
                return 0;//if it is an integer then returns 0
            }
            else return 1;//returns 1 if not an integer
        }
        private int CheckEmpty(string integer)
        {
            if (integer.ToString() != "")//checks for empty entries in integer
            {
                return 0;//return 0 if it is not empty
            }
            else return 1;//returns 1 if it is empty
        }
        private int RangeCheck(string integer)
        {
            if (int.Parse(integer) >= min && int.Parse(integer) <= maxvalue)//checks if the integer variable is between 0 and 100
            {
                return 0;//returns 0 if it is between 0 and 100
            }
            else return 1;//returns 1 if not
        }
        private void RandomIntGenerator()
        {
            int integer = 0;
            
            Random r = new Random();
            do
            {
                integer = r.Next(min, maxvalue+1);//these are the values that we are generating
                if (Duplicate(integer.ToString()) == 0)//checks if the value generated is unique to the values already in the listbox
                    lstbox_30int.Items.Add(integer);//if no dubplicates found then it will add the value
            }
            while (lstbox_30int.Items.Count < maxentry);//it will loop until the active entries in the listbox is greater than maxentry
        }
        private void InsertIntAtEnd(int integer)
        {
            int size = lstbox_30int.Items.Count;

            lstbox_30int.Items.Insert(size, "");//inserts an empty string to the last value in the list
            lstbox_30int.Items[size] = integer;//then sets the emptry string that we just created to the value we want to add to the list
            lstbox_30int.SetSelected(size, true);//highlights the integer that we just inserted in the listbox
            txtInsert.Text = string.Empty;//resets the textbox insert to empty
        }
        private void InsertSorted(string integer)
        {
            int i = 0;
            bool found = false;
            while (!found && i < lstbox_30int.Items.Count)//this will loop through the list and checks the found until it is true
            {
                if (int.Parse(integer) < int.Parse(lstbox_30int.Items[i].ToString()))//if the integer is less than the value after it
                {
                    lstbox_30int.Items.Insert(i, "");//inserts an empty string to that index location
                    lstbox_30int.Items[i] = int.Parse(integer);//sets that index location to the integer value
                    found = true;//sets found to true so the while loop ends
                    lstbox_30int.SetSelected(i, true);//highlights the index value in the listbox
                    txtInsert.Text = string.Empty;
                }
                i++;
            }
            //if not found, insert integer at end, this is done if the list is empty
            if (found == false)
            {
                InsertIntAtEnd(int.Parse(integer));
            }
        }
        private int BubbleSort()
        {
            int temp;//a temp variable to temporarily store a value when moving integers in the list

            for (int i = 0; i < lstbox_30int.Items.Count; i++)
            {
                for (int j = 0; j < lstbox_30int.Items.Count - i - 1; j++)//the loops are for looping through the listbox enough times to run the if and swap integers
                {
                    if (int.Parse(lstbox_30int.Items[j].ToString()) > int.Parse(lstbox_30int.Items[j + 1].ToString()))//when the first value is greater then the second value
                    {
                        temp = int.Parse(lstbox_30int.Items[j + 1].ToString());//set the second value to the temp variable
                        lstbox_30int.Items[j + 1] = lstbox_30int.Items[j];//set the first value to be the second value
                        lstbox_30int.Items[j] = temp;//then the second value that we stored to be the first value
                    }
                }
            }
            return 1;//returns 1 so we set the sorted variable to 1 when completed
        }
        private SearchStruct LinearSearch(string integer)
        {
            SearchStruct search;
            search.position = 0;
            search.comparisons = 0;
            search.found = false;
            
            for (int i = 0; i < lstbox_30int.Items.Count; i++)//loops through the list
            {
                search.comparisons++;//adds one for comparisons that we will need to show it in the messagebox
                if (integer == lstbox_30int.Items[i].ToString())//if the integer variable is equal to a value in the listbox
                {
                    search.found = true;//set found to true
                    search.position = i;//sets the position index to i
                    lstbox_30int.SetSelected(i, true);//highlights the value in the listbox
                    txtSearch.Text = string.Empty;//sets the textbox to empty
                    return search;//returns the variables from the struct
                }
            }
            return search;
        }
        private SearchStruct BinarySearch(string integer)
        {
            SearchStruct search;
            search.comparisons = 0;
            search.position = 0;
            search.found = false;

            int minimum = 0;
            int maximum = lstbox_30int.Items.Count;
            
            while (minimum < maximum)
            {
                int middle = (minimum + maximum) / 2;//middle value is calculated by adding the first and last values and dividing by 2
                int index = int.Parse(lstbox_30int.Items[middle].ToString());//sets the middle index to the index variable

                if (int.Parse(integer) == index)//if the integer is equal to the middle index in the listbox
                {
                    minimum = maximum;//to end the while loop
                    lstbox_30int.SetSelected(middle, true);//highlights the index in the listbox
                    txtSearch.Text = string.Empty;//resets the textbox search

                    search.comparisons++;
                    search.found = true;
                    search.position = middle;

                    return search;//returns the results
                }
                if (int.Parse(integer) > index)//if the integer is greater than the middle index value
                {
                    search.comparisons++;//add one to comparisons
                    minimum = middle + 1;//sets the minimum value to the middle variable plus 1 to check the right side of the listbox
                }
                else if (int.Parse(integer) < index)//if the integer is less than middle index value
                {
                    search.comparisons++;//add one to comparisons
                    maximum = middle;//sets the maximum value to be the middle index so we can check the left side of the listbox
                }
            }
            return search;//returns the results
        }
        private void DeleteInt()
        {
            for (int i = lstbox_30int.SelectedIndex; i < lstbox_30int.Items.Count - 1; i++)//loop through the listbox from the index value that we can do delete
            {
                lstbox_30int.Items[i] = lstbox_30int.Items[i + 1];//moves all the values after the index value that we want to delete one up
            }
            lstbox_30int.Items.RemoveAt(lstbox_30int.Items.Count - 1);//deletes the last index value in the list because of the duplicate at the end that is leftover
        }
        private void Shuffle()
        {
            int count = lstbox_30int.Items.Count;
            Random r = new Random();

            while (count > 1)
            {
                count--;//takes away one so until we randomised through the full active integers in the listbox
                int i = r.Next(count + 1);//we generate random integers up to the count of the listbox
                int value = int.Parse(lstbox_30int.Items[i].ToString());//the random generated integer is being used to select random values using index
                lstbox_30int.Items[i] = lstbox_30int.Items[count];//we are initialising the random variable that we generated to the number of active entries
                lstbox_30int.Items[count] = value;//we set the active entries variable to the random value that we chose before
            }
        }
    }
}