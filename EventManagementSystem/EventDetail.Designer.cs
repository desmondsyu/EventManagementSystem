﻿namespace EventManagementSystem
{
    partial class EventDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            eventsToolStripMenuItem = new ToolStripMenuItem();
            viewEventsToolStripMenuItem = new ToolStripMenuItem();
            addEventToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            allUsersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            attendeeToolStripMenuItem = new ToolStripMenuItem();
            myEventsToolStripMenuItem = new ToolStripMenuItem();
            registForEventsToolStripMenuItem = new ToolStripMenuItem();
            txtEventName = new TextBox();
            label1 = new Label();
            richTextBoxEventDesc = new RichTextBox();
            label6 = new Label();
            txtEventOragnizer = new TextBox();
            txtEventCapacity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBoxEventLocation = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerEvent = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem, attendeeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(56, 28);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(158, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(81, 28);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(199, 34);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(199, 34);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(72, 28);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(190, 34);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(190, 34);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // attendeeToolStripMenuItem
            // 
            attendeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myEventsToolStripMenuItem, registForEventsToolStripMenuItem });
            attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            attendeeToolStripMenuItem.Size = new Size(106, 28);
            attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // myEventsToolStripMenuItem
            // 
            myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            myEventsToolStripMenuItem.Size = new Size(253, 34);
            myEventsToolStripMenuItem.Text = "My Events";
            myEventsToolStripMenuItem.Click += myEventsToolStripMenuItem_Click;
            // 
            // registForEventsToolStripMenuItem
            // 
            registForEventsToolStripMenuItem.Name = "registForEventsToolStripMenuItem";
            registForEventsToolStripMenuItem.Size = new Size(253, 34);
            registForEventsToolStripMenuItem.Text = "Regist for Events";
            registForEventsToolStripMenuItem.Click += registForEventsToolStripMenuItem_Click;
            // 
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(171, 84);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(243, 30);
            txtEventName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 86);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // richTextBoxEventDesc
            // 
            richTextBoxEventDesc.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxEventDesc.Location = new Point(49, 266);
            richTextBoxEventDesc.Name = "richTextBoxEventDesc";
            richTextBoxEventDesc.Size = new Size(893, 142);
            richTextBoxEventDesc.TabIndex = 26;
            richTextBoxEventDesc.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 226);
            label6.Name = "label6";
            label6.Size = new Size(109, 24);
            label6.TabIndex = 25;
            label6.Text = "Description";
            // 
            // txtEventOragnizer
            // 
            txtEventOragnizer.BorderStyle = BorderStyle.FixedSingle;
            txtEventOragnizer.Location = new Point(691, 178);
            txtEventOragnizer.Name = "txtEventOragnizer";
            txtEventOragnizer.Size = new Size(243, 30);
            txtEventOragnizer.TabIndex = 24;
            // 
            // txtEventCapacity
            // 
            txtEventCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEventCapacity.Location = new Point(691, 134);
            txtEventCapacity.Name = "txtEventCapacity";
            txtEventCapacity.Size = new Size(243, 30);
            txtEventCapacity.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 180);
            label5.Name = "label5";
            label5.Size = new Size(96, 24);
            label5.TabIndex = 22;
            label5.Text = "Oragnizer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 136);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 21;
            label4.Text = "Capacity";
            // 
            // comboBoxEventLocation
            // 
            comboBoxEventLocation.FormattingEnabled = true;
            comboBoxEventLocation.Items.AddRange(new object[] { "Toronto", "Etobicoke", "Scarborough", "North York", "East York", "York" });
            comboBoxEventLocation.Location = new Point(171, 174);
            comboBoxEventLocation.Name = "comboBoxEventLocation";
            comboBoxEventLocation.Size = new Size(243, 32);
            comboBoxEventLocation.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 177);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 19;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 135);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 18;
            label2.Text = "Date / Time";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(171, 130);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(243, 30);
            dateTimePickerEvent.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(191, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(53, 431);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(567, 86);
            label7.Name = "label7";
            label7.Size = new Size(88, 24);
            label7.TabIndex = 27;
            label7.Text = "Manager";
            label7.Click += label7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(691, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 32);
            comboBox1.TabIndex = 28;
            // 
            // EventDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 517);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(richTextBoxEventDesc);
            Controls.Add(label6);
            Controls.Add(txtEventOragnizer);
            Controls.Add(txtEventCapacity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxEventLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerEvent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "EventDetail";
            Text = "Event Detail";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem eventsToolStripMenuItem;
        private ToolStripMenuItem viewEventsToolStripMenuItem;
        private ToolStripMenuItem addEventToolStripMenuItem;
        private TextBox txtEventName;
        private Label label1;
        private RichTextBox richTextBoxEventDesc;
        private Label label6;
        private TextBox txtEventOragnizer;
        private TextBox txtEventCapacity;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxEventLocation;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerEvent;
        private Button btnCancel;
        private Button btnSave;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem attendeeToolStripMenuItem;
        private ToolStripMenuItem myEventsToolStripMenuItem;
        private ToolStripMenuItem registForEventsToolStripMenuItem;
        private Label label7;
        private ComboBox comboBox1;
    }
}