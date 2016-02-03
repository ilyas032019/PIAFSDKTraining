using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.UI;
using OSIsoft.AF.Time;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Data;
using OSIsoft.AF.PI;
using System.Threading;
using System.Threading.Tasks;

namespace PIWebAPIPractice1
{

    public partial class Form1 : Form
    {
        public AFDatabase myAFDatabase;
        public PISystem myAFServer;
        public AFElement myElement;
        public PIServer myPIServer;
        public AFElementTemplates myElementTemplates;
        public AFElementTemplate myElementTemplate;
        public int updateval = 0;
        public int updateval2 = 0;
        public int monitval = 0;
        public Form1()
        {
            InitializeComponent();
            afDatabasePicker1.SystemPicker = piSystemPicker1;
        }

        public void piSystemPicker1_ConnectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {

            //Set the AF Server to the current selected object
            myAFServer = (PISystem)e.SelectedObject;
            AFDatabases databaseList = myAFServer.Databases;
        }

        public void afDatabasePicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            afTreeView1.AFRoot = null;
            myAFDatabase = (AFDatabase)e.SelectedObject;
            if (myAFDatabase != null)
            {
                //Populate the AF Treeview with Elements only.
                afTreeView1.AFRoot = myAFDatabase.Elements;
                //Put Element Template Name to ComboBox
                myElementTemplates = myAFDatabase.ElementTemplates;
                foreach(AFElementTemplate myElementTemplate in myElementTemplates)
                {
                       ElementTemplateComboBox.Items.Add(myElementTemplate.Name);
                }
            }
        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (afTreeView1.AFSelectedPath == afTreeView1.AFRootPath)
            {
                //MessageBox.Show("Please Select Element from ElementTree");
            }
            else
            {
                myElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                AFAttributes myAFAttributes = myElement.Attributes;
                AttributeList.Items.Clear();
                if (myAFAttributes.Count == 0)
                {
                    //MessageBox.Show("No Attribute Found");
                }
                else
                {
                    foreach (AFAttribute at in myAFAttributes)
                    {
                        try
                        {
                            string[] displayvalues = new string[2];
                            displayvalues[0] = at.Name;
                            displayvalues[1] = at.GetValue().Value.ToString();
                            ListViewItem lvi = new ListViewItem(displayvalues);
                            lvi.Text = at.Name;
                            AttributeList.Items.Add(lvi);
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
        }

        private void PITagSearch_Click(object sender, EventArgs e)
        {
            List<PIPoint> ptlist = AFOperations.FindPIPoints(this, myPIServer.Name, "", true, false);
            if (ptlist != null)
            {
                foreach (PIPoint pt in ptlist)
                {
                    string[] displayvalues = new string[4];
                    displayvalues[0] = pt.Name;
                    displayvalues[1] = pt.GetAttribute("Descriptor").ToString();
                    displayvalues[2] = pt.CurrentValue().Timestamp.ToString();
                    displayvalues[3] = pt.CurrentValue().Value.ToString();
                    ListViewItem lvi = new ListViewItem(displayvalues);
                    TagList.Items.Add(lvi);
                }
            }
        }

        private void TagClearButton_Click(object sender, EventArgs e)
        {
            TagList.Items.Clear();
            SelectedTagNameLabel.Text = "Selected: ";
        }

        private void GetArchive_Click(object sender, EventArgs e)
        {
            ValuesListView.Items.Clear();
            if (TagList.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Please select one tag from list");
                return;
            }
            string tagname = TagList.SelectedItems[0].Text;
            TagNameLabel.Text = tagname;
            PIPoint pt = PIPoint.FindPIPoint(myPIServer, tagname);
            AFTimeRange timerange = new AFTimeRange();
            timerange.StartTime = new AFTime(StartTimeTextBox.Text);
            timerange.EndTime = new AFTime(EndTimeTextBox.Text);
            AFValues vals = pt.RecordedValues(timerange, OSIsoft.AF.Data.AFBoundaryType.Inside, "", true);
            foreach (AFValue val in vals)
            {
                string[] displayvalues = new string[2];
                displayvalues[0] = val.Timestamp.LocalTime.ToString();
                displayvalues[1] = val.Value.ToString();
                ListViewItem lvi = new ListViewItem(displayvalues);
                ValuesListView.Items.Add(lvi);
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            //UpdateView.Items.Clear();
            if (TagList.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Please select one tag from list");
                return;
            }
            await AsyncTask();
        }

        public async Task AsyncTask()
        {
            IList<PIPoint> list = new List<PIPoint>();
            for (int i = 0; i < TagList.SelectedItems.Count; ++i)
            {
                string tagname = TagList.SelectedItems[i].Text;
                PIPoint pt = PIPoint.FindPIPoint(myPIServer, tagname);
                list.Add(pt);
            }
            PIDataPipe pipe = new PIDataPipe(AFDataPipeType.Snapshot);
            pipe.AddSignups(list);
            Action asyncJob = () =>
            {
                while (updateval == 0)
                {
                    var pipeContents = pipe.GetUpdateEvents(50000);
                    foreach (AFDataPipeEvent pipeEvent in pipeContents)
                    {
                        string[] displayvalues = new string[3];
                        displayvalues[0] = pipeEvent.Value.PIPoint.Name;
                        displayvalues[1] = pipeEvent.Value.Timestamp.LocalTime.ToString();
                        displayvalues[2] = pipeEvent.Value.Value.ToString();
                        ListViewItem lvi = new ListViewItem(displayvalues);
                        UpdListView(lvi);
                    }
                }
            };
            await Task.Run(asyncJob);
        }

        private void UpdListView(ListViewItem lvi)
        {
            if (UpdateView.InvokeRequired)
            {
                UpdateView.Invoke(new Action<ListViewItem>(UpdListView), new object[] { lvi });
            }
            else
            {
                UpdateView.Items.Add(lvi);
                UpdateView.Refresh();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            updateval = 1;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UpdateView.Items.Clear();
            TagUpdateView.Items.Clear();
        }

        private void CreateElement_Click(object sender, EventArgs e)
        {
            String ElementName = ELementName_TextBox.Text.Trim();
            if (ElementName == "")
            {
                MessageBox.Show("No Element name defined");
            }
            else
            {
                CreateElementfromTemplate(ElementName, ElementTemplateComboBox.SelectedItem);   
            }
        }

        private void CreateElementfromTemplate(string ElementName, object ElementTemplate)
        {
            try
            {
                AFElement myCreateElement;
                if (ElementTemplate == null)
                {
                    //Not use ElementTemplate
                    if (afTreeView1.AFSelectedPath == afTreeView1.AFRootPath)
                    {
                        myAFDatabase.Elements.Add(ElementName);
                    }
                    else
                    {
                        myCreateElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                        myCreateElement.Elements.Add(ElementName);
                    }
                }
                else
                {
                    //Use ElementTemplate
                    myElementTemplate = myAFDatabase.ElementTemplates[ElementTemplate.ToString()];
                    if (afTreeView1.AFSelectedPath == afTreeView1.AFRootPath)
                    {
                        myAFDatabase.Elements.Add(ElementName,myElementTemplate);
                    }
                    else
                    {
                        myCreateElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                        myCreateElement.Elements.Add(ElementName,myElementTemplate);
                    }
                }
                myAFDatabase.CheckIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void CreateAttribute_Button_Click(object sender, EventArgs e)
        {
            String AttributeName = Attribute_TextBox.Text.Trim();
            if (AttributeName == "")
            {
                MessageBox.Show("No Attribute Name defined");
            }
            else
            {
                if (afTreeView1.AFSelectedPath == afTreeView1.AFRootPath)
                {
                    MessageBox.Show("You have not selected an element", "Exception");
                }
                else
                {
                    try
                    {
                        if (TagList.SelectedIndices.Count < 1)
                        {
                            //tag is not selected
                            MessageBox.Show("There is no selected tag");
                            //myElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                            //myElement.Attributes.Add(AttributeName);
                        }
                        else
                        {
                            //one or more tag is selected
                            myElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                            AFAttribute myAttribute = myElement.Attributes.Add(AttributeName);
                            AFPlugIn PI_Point = myAFDatabase.PISystem.DataReferencePlugIns["PI Point"];
                            myAttribute.DataReferencePlugIn = PI_Point;
                            myAttribute.ConfigString = @"\\" + myPIServer.Name + @"\" + TagList.SelectedItems[0].Text;
                        }
                        myElement.CheckIn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CreateAttributewithoutTagButton_Click(object sender, EventArgs e)
        {
            String AttributeName = Attribute_TextBox.Text.Trim();
            if (AttributeName == "")
            {
                MessageBox.Show("No Attribute Name defined");
            }
            else
            {
                if (afTreeView1.AFSelectedPath == afTreeView1.AFRootPath)
                {
                    MessageBox.Show("Exception:", "You did not select an element");
                }
                else
                {
                    try
                    {
                            //Don't use Selected tag
                        myElement = myAFDatabase.Elements[afTreeView1.AFSelectedPath];
                        myElement.Attributes.Add(AttributeName);
                        myElement.CheckIn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            updateval2 = 0;
            await AsyncTask_updateinfo();
        }

        public async Task AsyncTask_updateinfo()
        {
            IList<PIPointChangeInfo> clist = new List<PIPointChangeInfo>();
            Action asyncJobupdateinfo = () =>
            {
                PIPointChangesCookie cookie = null;
                while (updateval2 == 0)
                {
                    if (myPIServer != null)
                    {
                        if (monitval == 0)
                        {
                            monitval = 1;
                            cookie = null;
                            UpdMonitorLabel("Monitoring ON (" + myPIServer.Name + ")");
                        }
                        if (ReferenceEquals(cookie, null))
                        {
                            clist = myPIServer.FindChangedPIPoints(int.MaxValue, null, out cookie);
                        }
                        else
                        {
                            clist = myPIServer.FindChangedPIPoints(int.MaxValue, cookie, out cookie);
                        }
                        if (clist != null)
                        {
                            foreach (PIPointChangeInfo change in clist)
                            {
                                //MessageBox.Show(change.ID + " : " + change.Action);
                                string[] displayvalues = new string[3];
                                if (change.Action.ToString() == "Removed")
                                {
                                    displayvalues[0] = change.ID.ToString();
                                }
                                else
                                {
                                    PIPoint mypt = PIPoint.FindPIPoint(myPIServer, change.ID);
                                    displayvalues[0] = mypt.Name;
                                }
                                displayvalues[1] = change.Action.ToString();
                                displayvalues[2] = DateTime.Now.ToString();
                                ListViewItem lvi = new ListViewItem(displayvalues);
                                UpdListView2(lvi);
                            }
                        } 
                    }
                }
            };
            await Task.Run(asyncJobupdateinfo);
        }

        private void UpdListView2(ListViewItem lvi)
        {
            if (TagUpdateView.InvokeRequired)
            {
                TagUpdateView.Invoke(new Action<ListViewItem>(UpdListView2), new object[] { lvi });
            }
            else
            {
                TagUpdateView.Items.Add(lvi);
                TagUpdateView.Refresh();
            }
        }

        private void UpdMonitorLabel(string text)
        {
            if (MonitoringLabel.InvokeRequired)
            {
                MonitoringLabel.Invoke(new Action<String>(UpdMonitorLabel), new object[] { text });
            }
            else
            {
                MonitoringLabel.Text = text;
                MonitoringLabel.Refresh();
            }
        }

        private void piServerPicker1_ConnectionChange(object sender, SelectionChangeEventArgs e)
        {
            myPIServer = (PIServer)piServerPicker1.AFSelection;
            monitval = 0;
        }

        private void PITagEditHistoryClearButton_Click(object sender, EventArgs e)
        {
            TagUpdateView.Items.Clear();
        }

        private void TagList_Click(object sender, EventArgs e)
        {

        }

        private void TagList_Click_1(object sender, EventArgs e)
        {
            if (TagList.SelectedIndices.Count < 1)
            {
                SelectedTagNameLabel.Text = "Selected: ";
                return;
            }
            else
            {
                SelectedTagNameLabel.Text = "Selected: " + TagList.SelectedItems[0].Text;
            }
        }

        
    }
}