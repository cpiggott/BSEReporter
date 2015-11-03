using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSEReport
{
    public partial class FormAggregateData : Form
    {
        Dictionary<string, bool> files;
        string saveFileLocation = "";


        public FormAggregateData()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            InitializeSaveFileDialog();
            InitializeListView();
            files = new Dictionary<string, bool>();
        }

        /// <summary>
        /// Sets the parameters for the OpenFileDialog
        /// </summary>
        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for CSV files.
            this.openFileDialog.Filter =
                "CSV files(*.csv; *.CSV) | *.csv; *.CSV ";

            // Allow the user to select multiple images.
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "CSV Selector";
        }

        private void InitializeSaveFileDialog()
        {
            this.saveFileDialog.Filter = "CSV files(*.csv; *.CSV) | *.csv; *.CSV ";
            this.saveFileDialog.Title = "Save File To: ";
        }

        /// <summary>
        /// Set parameters for the ListView
        /// </summary>
        private void InitializeListView()
        {
            this.listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Descending;
            listView1.AllowColumnReorder = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Checked");
            listView1.Columns.Add("File Name", -2);
            listView1.BeginUpdate();
        }

        /// <summary>
        /// Upon click, user can select multiple files to add to be merged. These will show up in a ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonSelectFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    if (!files.ContainsKey(file))
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(file);
                        listViewItem.Checked = true;
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
        }

        /// <summary>
        /// When an Items checked or unchecked, this will set the boolean in the dicitonary whether it needs to get run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                files[this.listView1.Items[e.Index].SubItems[1].Text] = true;
            }
            else
            {
                files[this.listView1.Items[e.Index].SubItems[1].Text] = false;

            }

        }

        private void uxButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.saveFileDialog.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                saveFileLocation = this.saveFileDialog.FileName;
                this.uxLabelFileLocation.Text = saveFileLocation;
            }
        }
    }
}
