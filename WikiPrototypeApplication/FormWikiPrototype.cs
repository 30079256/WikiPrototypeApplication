using System;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

/* Student Name: Olga Selezneva
 * Student ID: 30079256
 * Date: 30/08/2023
 */

namespace WikiPrototypeApplication
{
    public partial class FormWikiPrototype : Form
    {
        public FormWikiPrototype()
        {
            InitializeComponent();
        }
        // 9.1. Create a global 2D string array, use static variables for the dimensions(row = 12, column = 4)
        static int totalRecords = 12;
        static int attributes = 4;
        string[,] dataStructures = new string[totalRecords, attributes];
        int currentRecord = 0;

        #region INITIALISE
        // Initialization method to replace empty array items with ~ sign
        private void InitialiseDSArray()
        {
            for (int i = 0; i < totalRecords; i++)
            {
                dataStructures[i, 0] = "~"; // Name
                dataStructures[i, 1] = "~"; // Category
                dataStructures[i, 2] = "~"; // Structure
                dataStructures[i, 3] = "~"; // Definition
            }
            DisplayDataStructures();
        }
        // Initialization method launch on form load
        private void FormWikiPrototype_Load(object sender, EventArgs e)
        {
            InitialiseDSArray();
        }
        #endregion
        // 9.2. Create an ADD button that will store the information from the 4 text boxes into the 2D array
        #region ADD
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                if (currentRecord < totalRecords)
                {
                    // Assign textbox texts to array items
                    dataStructures[currentRecord, 0] = TextBoxName.Text;
                    dataStructures[currentRecord, 1] = TextBoxCategory.Text;
                    dataStructures[currentRecord, 2] = TextBoxStructure.Text;
                    dataStructures[currentRecord, 3] = TextBoxDefinition.Text;

                    // Replace empty array entries with ~ sign
                    for (int i = 1; i < attributes; i++)
                    {
                        if (string.IsNullOrEmpty(dataStructures[currentRecord, i]))
                        {
                            dataStructures[currentRecord, i] = "~";
                        }
                    }
                }
                else
                {
                    ToolStripStatusLabelFeedback.Text = "Error: The array is full";
                }

                currentRecord++;
                SortDataStructures();
                Clear();
                TextBoxName.Focus();
            }
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: Empty textbox";
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBoxName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBoxName.Text);
            TextBoxCategory.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBoxCategory.Text);
            TextBoxStructure.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBoxStructure.Text);
            TextBoxSearch.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBoxSearch.Text);
        }
        #endregion
        // 9.3. Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array
        #region EDIT
        private void ButtonEdit_Click(object sender, EventArgs e)
        {              
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                // Assign selected index to variable
                int selectedItem = ListViewDataStructures.SelectedIndices[0];
                // Assign textbox texts to array elements
                dataStructures[selectedItem, 0] = TextBoxName.Text;
                dataStructures[selectedItem, 1] = TextBoxCategory.Text;
                dataStructures[selectedItem, 2] = TextBoxStructure.Text;
                dataStructures[selectedItem, 3] = TextBoxDefinition.Text;
                SortDataStructures();
                Clear();
                TextBoxName.Focus();
            }
            else ToolStripStatusLabelFeedback.Text = "Error: No record selected";
        }
        #endregion
        // 9.4. Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs
        #region DELETE
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                int selectedItem = ListViewDataStructures.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Loop through column values, swap last entered record with selected record
                    for (int j = 0; j < attributes; j++)
                    {
                        string temp = dataStructures[selectedItem, j];
                        dataStructures[selectedItem, j] = dataStructures[currentRecord - 1, j];
                        dataStructures[currentRecord - 1, j] = temp;
                    }

                    // Loop through the column values of the last record, replace them with ~ sign
                    for (int j = 0; j < attributes; j++)
                    {
                        dataStructures[currentRecord - 1, j] = "~";
                    }

                    currentRecord--;
                    SortDataStructures();
                    Clear();
                    TextBoxName.Focus();
                }
            }
            else ToolStripStatusLabelFeedback.Text = "Error: No record selected";
        }
        #endregion
        // 9.5. Create a CLEAR method to clear the four text boxes so a new definition can be added
        #region CLEAR
        // Method to clear textboxes and focus the cursor
        private void Clear()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();            
        }

        private void TextBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clear();
            TextBoxName.Focus();
        }
        #endregion
        // 9.6. Write the code for a Bubble Sort method to sort the 2D array by Name ascending,
        // ensure you use a separate swap method that passes the array element to be swapped
        // (do not use any built-in array methods)
        #region SORT
        // Method to sort the array by swapping records
        private void SortDataStructures()
        {
            // Outer and inner loops
            for (int i = 0; i < totalRecords; i++)
            {
                for (int j = 0; j < totalRecords - 1; j++)
                {
                    // Check if adjacent Name values are not ~, compare if the first value is greater than the second
                    if (dataStructures[j, 0] != "~" && dataStructures[j + 1, 0] != "~" && string.Compare(dataStructures[j, 0], dataStructures[j + 1, 0]) == 1)
                    {
                        SwapDataStructures(j);
                    }
                }
            }
            DisplayDataStructures();
        }

        // Method to swap the adjacent record values
        private void SwapDataStructures(int item)
        {
            string swap;
            // Loop through the column values
            for (int x = 0; x < attributes; x++)
            {
                // Reassign column values of adjacent records
                swap = dataStructures[item, x];
                dataStructures[item, x] = dataStructures[item + 1, x];
                dataStructures[item + 1, x] = swap;
            }
        }
        #endregion
        // 9.7. Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        // add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods)
        #region SEARCH
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSearch.Text))
            {
                bool found = false;
                int min = 0;
                int max = totalRecords - 1;
                string searchItem = TextBoxSearch.Text;

                // Binary search loop
                while (min <= max)
                {
                    int mid = (min + max) / 2; // Calculate middle index
                    // Check if the search item is at the current middle index
                    if (searchItem.CompareTo(dataStructures[mid, 0]) == 0)
                    {
                        found = true;
                        ListViewDataStructures.Items[mid].Selected = true; // Select the found item in the listview

                        // Check if the found item is not empty
                        if (dataStructures[mid, 0] != "~")
                        {
                            // Show the attributes of the found item in textboxes
                            TextBoxName.Text = dataStructures[mid, 0];
                            TextBoxCategory.Text = dataStructures[mid, 1];
                            TextBoxStructure.Text = dataStructures[mid, 2];
                            TextBoxDefinition.Text = dataStructures[mid, 3];
                        }

                        break;
                    }
                    // Check if the search item precedes the value at the middle index
                    else if (searchItem.CompareTo(dataStructures[mid, 0]) < 0)
                    {
                        max = mid - 1; // Assign a new index to max variable for a new search loop
                    }
                    else
                    {
                        min = mid + 1; // Assign a new index to max variable for a new search loop
                    }
                }
                if (!found)
                {
                    ToolStripStatusLabelFeedback.Text = "Search failed: item not found";
                }
                else
                {
                    ToolStripStatusLabelFeedback.Text = "Search successful: item found";
                }
                TextBoxSearch.Clear();
                TextBoxSearch.Focus();
            } 
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: Empty textbox";
            }
        }
        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        // 9.8. Create a display method that will show the following information in a ListView: Name and Category
        #region DISPLAY
        // Method to display array values in the listview
        private void DisplayDataStructures()
        {
            ListViewDataStructures.Items.Clear();
            // Loop through all the records
            for (int i = 0; i < totalRecords; i++)
            {
                ListViewItem item = new ListViewItem(dataStructures[i, 0]); // Name
                item.SubItems.Add(dataStructures[i, 1]); // Category
                ListViewDataStructures.Items.Add(item); // Add item and its subitem to the listview
            }
        }
        #endregion
        // 9.9. Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes
        #region SELECT
        private void ListViewDataStructures_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedItem = ListViewDataStructures.SelectedIndices[0]; // Assign selected index to variable
            ToolStripStatusLabelFeedback.Text = ""; 
            // Check if selected item is not empty
            if (dataStructures[selectedItem, 0] != "~")
            {
                // Show the selected item attributes in textboxes
                TextBoxName.Text = dataStructures[selectedItem, 0];
                TextBoxCategory.Text = dataStructures[selectedItem, 1];
                TextBoxStructure.Text = dataStructures[selectedItem, 2];
                TextBoxDefinition.Text = dataStructures[selectedItem, 3];
            }
        }
        #endregion
        // 9.10. Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file
        #region SAVE
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Initialize a file save dialog
            saveFileDialog.Filter = "dat file|*.dat"; // Set filtering of the files that can be viewed
            saveFileDialog.Title = "Save a DAT file";
            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath; // Set initial directory as the application startup folder
            saveFileDialog.DefaultExt = "dat"; // Save files with default extension if not specified
            saveFileDialog.ShowDialog(); // Open the file browser for user navigation
            string defaultFileName = "definitions.dat";
            string fileName = saveFileDialog.FileName;            
            // Check if file name is specified
            if (saveFileDialog.FileName != "")
            {
                SaveRecord(fileName); // Trigger the SaveRecord method with specified file name
            }
            else
            {
                SaveRecord(defaultFileName); // Trigger the SaveRecord method with default file name
            }
        }
        // Method to save data to a file
        private void SaveRecord(string saveFileName)
        {
            try
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create)) // Open a file stream for writing
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false)) // Create a binary writer
                    {
                        for (int x = 0; x < totalRecords; x++) // Loop through the records
                        {
                            for (int y = 0; y < attributes; y++) // Loop through the attributes of each record
                            {
                                writer.Write(dataStructures[x, y]); // Write data to the file
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                ToolStripStatusLabelFeedback.Text = ex.ToString();
            }
        }
        #endregion
        // 9.11. Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array,
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryReader to complete this task.
        #region LOAD
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
            OpenFileDialog openFile = new OpenFileDialog(); // Initialize a file open dialog
            openFile.InitialDirectory = System.Windows.Forms.Application.StartupPath; // Set initial directory as the application startup folder
            openFile.Filter = "DAT FILES|*.dat"; // Set filtering of the files that can be viewed
            openFile.Title = "Open a DAT file"; 
            // Check if button OK clicked
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                OpenFileRecord(openFile.FileName); // Trigger method to open the selected file
            }
        }
        // Method to read from the selected file
        private void OpenFileRecord(string openFileName)
        {
            try
            {
                using (Stream stream = File.Open(openFileName, FileMode.Open)) // Open a file stream for reading
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false)) // Create a binary reader
                    {
                        {
                            currentRecord = 0;
                            Array.Clear(dataStructures, 0, dataStructures.Length);
                            // Loop through the file
                            while (stream.Position < stream.Length)
                            {
                                for (int j = 0; j < attributes; j++) // Loop through the attributes
                                {
                                    dataStructures[currentRecord, j] = reader.ReadString(); // Read each attribute value into the array
                                }
                                currentRecord++;
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                ToolStripStatusLabelFeedback.Text = ex.ToString();
            }
            SortDataStructures();
        }
        #endregion
    }
}
