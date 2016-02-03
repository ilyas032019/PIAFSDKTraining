namespace PIWebAPIPractice1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.GetArchive = new System.Windows.Forms.Button();
            this.AttributeList = new System.Windows.Forms.ListView();
            this.AttributeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListView = new System.Windows.Forms.ListView();
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.piServerPicker1 = new OSIsoft.AF.UI.PIServerPicker();
            this.PITagSearch = new System.Windows.Forms.Button();
            this.TagList = new System.Windows.Forms.ListView();
            this.TagName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Val = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TagClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateView = new System.Windows.Forms.ListView();
            this.TagName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timecolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valuecolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StopButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TagUpdateView = new System.Windows.Forms.ListView();
            this.PIPointName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateElement = new System.Windows.Forms.Button();
            this.ELementName_TextBox = new System.Windows.Forms.TextBox();
            this.CreateAttribute_Button = new System.Windows.Forms.Button();
            this.Attribute_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MonitoringLabel = new System.Windows.Forms.Label();
            this.PITagEditHistoryClearButton = new System.Windows.Forms.Button();
            this.TagNameLabel = new System.Windows.Forms.Label();
            this.ElementTemplateComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectedTagNameLabel = new System.Windows.Forms.Label();
            this.CreateAttributewithoutTagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI Systemの選択";
            this.piSystemPicker1.AccessibleName = "PI Systemの選択";
            this.piSystemPicker1.Caption = "エラー";
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.Location = new System.Drawing.Point(12, 10);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowImages = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowNoEntries = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.ShowProperties = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(211, 20);
            this.piSystemPicker1.TabIndex = 0;
            this.piSystemPicker1.ConnectionChange += new OSIsoft.AF.UI.ConnectionChangeEventHandler(this.piSystemPicker1_ConnectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.Location = new System.Drawing.Point(12, 69);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(211, 298);
            this.afTreeView1.TabIndex = 1;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "データベースの指定";
            this.afDatabasePicker1.AccessibleName = "データベースの指定";
            this.afDatabasePicker1.Caption = "エラー";
            this.afDatabasePicker1.Location = new System.Drawing.Point(12, 41);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowImages = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowNoEntries = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(211, 20);
            this.afDatabasePicker1.TabIndex = 2;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker1_SelectionChange);
            // 
            // GetArchive
            // 
            this.GetArchive.Location = new System.Drawing.Point(821, 221);
            this.GetArchive.Name = "GetArchive";
            this.GetArchive.Size = new System.Drawing.Size(89, 23);
            this.GetArchive.TabIndex = 3;
            this.GetArchive.Text = "Get Archive";
            this.GetArchive.UseVisualStyleBackColor = true;
            this.GetArchive.Click += new System.EventHandler(this.GetArchive_Click);
            // 
            // AttributeList
            // 
            this.AttributeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AttributeName,
            this.AttributeValue});
            this.AttributeList.Location = new System.Drawing.Point(229, 69);
            this.AttributeList.MultiSelect = false;
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(267, 298);
            this.AttributeList.TabIndex = 41;
            this.AttributeList.UseCompatibleStateImageBehavior = false;
            this.AttributeList.View = System.Windows.Forms.View.Details;
            // 
            // AttributeName
            // 
            this.AttributeName.Text = "Attrubute";
            this.AttributeName.Width = 120;
            // 
            // AttributeValue
            // 
            this.AttributeValue.Text = "Value";
            this.AttributeValue.Width = 120;
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(574, 223);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(72, 19);
            this.StartTimeTextBox.TabIndex = 42;
            this.StartTimeTextBox.Text = "*-2h";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(733, 223);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(72, 19);
            this.EndTimeTextBox.TabIndex = 43;
            this.EndTimeTextBox.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "End Time";
            // 
            // ValuesListView
            // 
            this.ValuesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Timestamp,
            this.Value});
            this.ValuesListView.Location = new System.Drawing.Point(505, 248);
            this.ValuesListView.Name = "ValuesListView";
            this.ValuesListView.Size = new System.Drawing.Size(405, 222);
            this.ValuesListView.TabIndex = 46;
            this.ValuesListView.UseCompatibleStateImageBehavior = false;
            this.ValuesListView.View = System.Windows.Forms.View.Details;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 200;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 156;
            // 
            // piServerPicker1
            // 
            this.piServerPicker1.AccessibleDescription = "PI Serverの選択";
            this.piServerPicker1.AccessibleName = "PI Serverの選択";
            this.piServerPicker1.Caption = "エラー";
            this.piServerPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piServerPicker1.EnableBegin = false;
            this.piServerPicker1.EnableDelete = false;
            this.piServerPicker1.EnableEnd = false;
            this.piServerPicker1.EnableList = false;
            this.piServerPicker1.EnableNavigation = false;
            this.piServerPicker1.EnableNew = false;
            this.piServerPicker1.EnableNext = false;
            this.piServerPicker1.EnablePrevious = false;
            this.piServerPicker1.EnableProperties = false;
            this.piServerPicker1.Location = new System.Drawing.Point(505, 10);
            this.piServerPicker1.Name = "piServerPicker1";
            this.piServerPicker1.ShowBegin = false;
            this.piServerPicker1.ShowDelete = false;
            this.piServerPicker1.ShowEnd = false;
            this.piServerPicker1.ShowFind = false;
            this.piServerPicker1.ShowImages = false;
            this.piServerPicker1.ShowList = false;
            this.piServerPicker1.ShowNavigation = false;
            this.piServerPicker1.ShowNew = false;
            this.piServerPicker1.ShowNext = false;
            this.piServerPicker1.ShowNoEntries = false;
            this.piServerPicker1.ShowPrevious = false;
            this.piServerPicker1.ShowProperties = false;
            this.piServerPicker1.Size = new System.Drawing.Size(247, 20);
            this.piServerPicker1.TabIndex = 47;
            this.piServerPicker1.ConnectionChange += new OSIsoft.AF.UI.ConnectionChangeEventHandler(this.piServerPicker1_ConnectionChange);
            // 
            // PITagSearch
            // 
            this.PITagSearch.Location = new System.Drawing.Point(505, 37);
            this.PITagSearch.Name = "PITagSearch";
            this.PITagSearch.Size = new System.Drawing.Size(102, 23);
            this.PITagSearch.TabIndex = 48;
            this.PITagSearch.Text = "PITagSearch";
            this.PITagSearch.UseVisualStyleBackColor = true;
            this.PITagSearch.Click += new System.EventHandler(this.PITagSearch_Click);
            // 
            // TagList
            // 
            this.TagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TagName,
            this.Descriptor,
            this.Time,
            this.Val});
            this.TagList.Location = new System.Drawing.Point(505, 69);
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(405, 131);
            this.TagList.TabIndex = 50;
            this.TagList.UseCompatibleStateImageBehavior = false;
            this.TagList.View = System.Windows.Forms.View.Details;
            this.TagList.Click += new System.EventHandler(this.TagList_Click_1);
            // 
            // TagName
            // 
            this.TagName.Text = "TagName";
            this.TagName.Width = 85;
            // 
            // Descriptor
            // 
            this.Descriptor.Text = "Descriptor";
            this.Descriptor.Width = 100;
            // 
            // Time
            // 
            this.Time.Text = "TimeStamp";
            this.Time.Width = 120;
            // 
            // Val
            // 
            this.Val.Text = "Value";
            this.Val.Width = 85;
            // 
            // TagClearButton
            // 
            this.TagClearButton.Location = new System.Drawing.Point(638, 38);
            this.TagClearButton.Name = "TagClearButton";
            this.TagClearButton.Size = new System.Drawing.Size(75, 23);
            this.TagClearButton.TabIndex = 51;
            this.TagClearButton.Text = "TagClear";
            this.TagClearButton.UseVisualStyleBackColor = true;
            this.TagClearButton.Click += new System.EventHandler(this.TagClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(919, 220);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 52;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateView
            // 
            this.UpdateView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TagName2,
            this.Timecolum,
            this.Valuecolum});
            this.UpdateView.Location = new System.Drawing.Point(918, 248);
            this.UpdateView.Name = "UpdateView";
            this.UpdateView.Size = new System.Drawing.Size(343, 222);
            this.UpdateView.TabIndex = 53;
            this.UpdateView.UseCompatibleStateImageBehavior = false;
            this.UpdateView.View = System.Windows.Forms.View.Details;
            // 
            // TagName2
            // 
            this.TagName2.Text = "TagName";
            this.TagName2.Width = 100;
            // 
            // Timecolum
            // 
            this.Timecolum.Text = "Timestamp";
            this.Timecolum.Width = 130;
            // 
            // Valuecolum
            // 
            this.Valuecolum.Text = "Value";
            this.Valuecolum.Width = 100;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(1000, 220);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 54;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1082, 220);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 55;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TagUpdateView
            // 
            this.TagUpdateView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PIPointName,
            this.Action,
            this.Timestamp1});
            this.TagUpdateView.Location = new System.Drawing.Point(918, 69);
            this.TagUpdateView.Name = "TagUpdateView";
            this.TagUpdateView.Size = new System.Drawing.Size(343, 131);
            this.TagUpdateView.TabIndex = 56;
            this.TagUpdateView.UseCompatibleStateImageBehavior = false;
            this.TagUpdateView.View = System.Windows.Forms.View.Details;
            // 
            // PIPointName
            // 
            this.PIPointName.Text = "TagName";
            this.PIPointName.Width = 100;
            // 
            // Action
            // 
            this.Action.Text = "Action";
            this.Action.Width = 100;
            // 
            // Timestamp1
            // 
            this.Timestamp1.Text = "Timestamp";
            this.Timestamp1.Width = 130;
            // 
            // CreateElement
            // 
            this.CreateElement.Location = new System.Drawing.Point(118, 447);
            this.CreateElement.Name = "CreateElement";
            this.CreateElement.Size = new System.Drawing.Size(105, 23);
            this.CreateElement.TabIndex = 57;
            this.CreateElement.Text = "Create Element";
            this.CreateElement.UseVisualStyleBackColor = true;
            this.CreateElement.Click += new System.EventHandler(this.CreateElement_Click);
            // 
            // ELementName_TextBox
            // 
            this.ELementName_TextBox.Location = new System.Drawing.Point(12, 422);
            this.ELementName_TextBox.Name = "ELementName_TextBox";
            this.ELementName_TextBox.Size = new System.Drawing.Size(211, 19);
            this.ELementName_TextBox.TabIndex = 58;
            this.ELementName_TextBox.Text = "New Element Name";
            // 
            // CreateAttribute_Button
            // 
            this.CreateAttribute_Button.Location = new System.Drawing.Point(294, 427);
            this.CreateAttribute_Button.Name = "CreateAttribute_Button";
            this.CreateAttribute_Button.Size = new System.Drawing.Size(202, 23);
            this.CreateAttribute_Button.TabIndex = 59;
            this.CreateAttribute_Button.Text = "Create Attribute with Selected Tag";
            this.CreateAttribute_Button.UseVisualStyleBackColor = true;
            this.CreateAttribute_Button.Click += new System.EventHandler(this.CreateAttribute_Button_Click);
            // 
            // Attribute_TextBox
            // 
            this.Attribute_TextBox.Location = new System.Drawing.Point(229, 402);
            this.Attribute_TextBox.Name = "Attribute_TextBox";
            this.Attribute_TextBox.Size = new System.Drawing.Size(267, 19);
            this.Attribute_TextBox.TabIndex = 60;
            this.Attribute_TextBox.Text = "New Attribute Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "DataPipe (Select tags from left Tag List)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "Get Archive Values :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 12);
            this.label5.TabIndex = 63;
            this.label5.Text = "PI Tag Edit History";
            // 
            // MonitoringLabel
            // 
            this.MonitoringLabel.AutoSize = true;
            this.MonitoringLabel.Location = new System.Drawing.Point(1032, 18);
            this.MonitoringLabel.Name = "MonitoringLabel";
            this.MonitoringLabel.Size = new System.Drawing.Size(84, 12);
            this.MonitoringLabel.TabIndex = 64;
            this.MonitoringLabel.Text = "Monitoring OFF";
            // 
            // PITagEditHistoryClearButton
            // 
            this.PITagEditHistoryClearButton.Location = new System.Drawing.Point(919, 41);
            this.PITagEditHistoryClearButton.Name = "PITagEditHistoryClearButton";
            this.PITagEditHistoryClearButton.Size = new System.Drawing.Size(75, 23);
            this.PITagEditHistoryClearButton.TabIndex = 65;
            this.PITagEditHistoryClearButton.Text = "Clear";
            this.PITagEditHistoryClearButton.UseVisualStyleBackColor = true;
            this.PITagEditHistoryClearButton.Click += new System.EventHandler(this.PITagEditHistoryClearButton_Click);
            // 
            // TagNameLabel
            // 
            this.TagNameLabel.AutoSize = true;
            this.TagNameLabel.Location = new System.Drawing.Point(627, 205);
            this.TagNameLabel.Name = "TagNameLabel";
            this.TagNameLabel.Size = new System.Drawing.Size(57, 12);
            this.TagNameLabel.TabIndex = 66;
            this.TagNameLabel.Text = "Tag Name";
            // 
            // ElementTemplateComboBox
            // 
            this.ElementTemplateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementTemplateComboBox.FormattingEnabled = true;
            this.ElementTemplateComboBox.Location = new System.Drawing.Point(12, 395);
            this.ElementTemplateComboBox.MaxDropDownItems = 20;
            this.ElementTemplateComboBox.Name = "ElementTemplateComboBox";
            this.ElementTemplateComboBox.Size = new System.Drawing.Size(211, 20);
            this.ElementTemplateComboBox.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "Element Template";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "Select tag name from right tag list";
            // 
            // SelectedTagNameLabel
            // 
            this.SelectedTagNameLabel.AutoSize = true;
            this.SelectedTagNameLabel.Location = new System.Drawing.Point(229, 387);
            this.SelectedTagNameLabel.Name = "SelectedTagNameLabel";
            this.SelectedTagNameLabel.Size = new System.Drawing.Size(55, 12);
            this.SelectedTagNameLabel.TabIndex = 70;
            this.SelectedTagNameLabel.Text = "Selected: ";
            // 
            // CreateAttributewithoutTagButton
            // 
            this.CreateAttributewithoutTagButton.Location = new System.Drawing.Point(294, 456);
            this.CreateAttributewithoutTagButton.Name = "CreateAttributewithoutTagButton";
            this.CreateAttributewithoutTagButton.Size = new System.Drawing.Size(202, 23);
            this.CreateAttributewithoutTagButton.TabIndex = 71;
            this.CreateAttributewithoutTagButton.Text = "Create Attribute without Tag";
            this.CreateAttributewithoutTagButton.UseVisualStyleBackColor = true;
            this.CreateAttributewithoutTagButton.Click += new System.EventHandler(this.CreateAttributewithoutTagButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 482);
            this.Controls.Add(this.CreateAttributewithoutTagButton);
            this.Controls.Add(this.SelectedTagNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ElementTemplateComboBox);
            this.Controls.Add(this.TagNameLabel);
            this.Controls.Add(this.PITagEditHistoryClearButton);
            this.Controls.Add(this.MonitoringLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attribute_TextBox);
            this.Controls.Add(this.CreateAttribute_Button);
            this.Controls.Add(this.ELementName_TextBox);
            this.Controls.Add(this.CreateElement);
            this.Controls.Add(this.TagUpdateView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.UpdateView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TagClearButton);
            this.Controls.Add(this.TagList);
            this.Controls.Add(this.PITagSearch);
            this.Controls.Add(this.piServerPicker1);
            this.Controls.Add(this.ValuesListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndTimeTextBox);
            this.Controls.Add(this.StartTimeTextBox);
            this.Controls.Add(this.AttributeList);
            this.Controls.Add(this.GetArchive);
            this.Controls.Add(this.afDatabasePicker1);
            this.Controls.Add(this.afTreeView1);
            this.Controls.Add(this.piSystemPicker1);
            this.Name = "Form1";
            this.Text = "PI AF SDK Training";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private System.Windows.Forms.Button GetArchive;
        internal System.Windows.Forms.ListView AttributeList;
        internal System.Windows.Forms.ColumnHeader AttributeName;
        internal System.Windows.Forms.ColumnHeader AttributeValue;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ValuesListView;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader Value;
        private OSIsoft.AF.UI.PIServerPicker piServerPicker1;
        private System.Windows.Forms.Button PITagSearch;
        private System.Windows.Forms.ListView TagList;
        private System.Windows.Forms.ColumnHeader TagName;
        private System.Windows.Forms.ColumnHeader Descriptor;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Val;
        private System.Windows.Forms.Button TagClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ListView UpdateView;
        private System.Windows.Forms.ColumnHeader Timecolum;
        private System.Windows.Forms.ColumnHeader Valuecolum;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ListView TagUpdateView;
        private System.Windows.Forms.ColumnHeader PIPointName;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.Button CreateElement;
        private System.Windows.Forms.TextBox ELementName_TextBox;
        private System.Windows.Forms.Button CreateAttribute_Button;
        private System.Windows.Forms.TextBox Attribute_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader TagName2;
        private System.Windows.Forms.ColumnHeader Timestamp1;
        private System.Windows.Forms.Label MonitoringLabel;
        private System.Windows.Forms.Button PITagEditHistoryClearButton;
        private System.Windows.Forms.Label TagNameLabel;
        private System.Windows.Forms.ComboBox ElementTemplateComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SelectedTagNameLabel;
        private System.Windows.Forms.Button CreateAttributewithoutTagButton;
    }
}

