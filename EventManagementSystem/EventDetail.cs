using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace EventManagementSystem
{
    public partial class EventDetail : Form
    {
        private MySqlConnection connection;
        ActionType actionType;
        string eventID;
        public EventDetail()
        {
            InitializeComponent();
            connection = Program.db.GetConnection();
            LoadManagers();
            ConfigureVisibleElements();
        }

        public EventDetail(ActionType action, DataGridViewRow row = null) : this()
        {
            if (action == ActionType.Add)
            {
                comboBoxValid.SelectedIndex = 0;
                comboBoxValid.Enabled = false;
            }
            else if (action == ActionType.Edit)
            {
                if (row != null)
                {
                    string eventName = row.Cells["EventName"].Value.ToString();
                    string date = row.Cells["Date"].Value.ToString();
                    string capacity = row.Cells["Capacity"].Value.ToString();
                    string location = row.Cells["Location"].Value.ToString();
                    string organizer = row.Cells["Organizer"].Value.ToString();
                    string managerName = row.Cells["ManagerName"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    string id = row.Cells["EventId"].Value.ToString();
                    string valid = row.Cells["Valid"].Value.ToString();

                    txtEventName.Text = eventName;
                    dateTimePickerEvent.Value = DateTime.Parse(date);
                    txtEventCapacity.Text = capacity;
                    txtBoxtLocation.Text = location;
                    comboBoxManager.Text = managerName;
                    txtEventOragnizer.Text = organizer;
                    comboBoxValid.Text = valid;
                    richTextBoxEventDesc.Text = description;
                    eventID = id;
                }
            }
            actionType = action;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NameValidate() && ManagerValidate() && CapacityValidate() && LocationValidate() && OrganizerValidate() && ValidValidate())
            {
                string eventName = txtEventName.Text;
                string date = dateTimePickerEvent.Value.ToString("yyyy-MM-dd");
                string capacity = txtEventCapacity.Text;
                string location = txtBoxtLocation.Text;
                string managerName = comboBoxManager.Text;
                string organizer = txtEventOragnizer.Text;
                string valid = comboBoxValid.Text;
                string description = richTextBoxEventDesc.Text;

                if (actionType == ActionType.Add)
                {
                    try
                    {
                        string qStr = $"INSERT INTO Events(EventName, Date, Capacity, Location, Organizer, ManagerName, Description, Valid)  VALUES " +
                            $"('{eventName}','{date}',{capacity},'{location}','{organizer}','{managerName}','{description}', '{valid}')";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" New event added successfully!!!", "New Event", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

                    }

                }
                else if (actionType == ActionType.Edit)
                {
                    try
                    {
                        string qStr = $"UPDATE Events SET EventName = '{eventName}', Date = '{date}', Capacity = '{capacity}', " +
                            $"Location = '{location}', Organizer = '{organizer}', ManagerName = '{managerName}', Description = '{description}', Valid = '{valid}'" +
                            $" WHERE EventId = '{eventID}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" Event updated!!!", "Edit Event", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }
                }
                AllEvents form = new AllEvents();
                form.Show();
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Close();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(ActionType.Add);
            userDetail.Show();
            Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
            Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            this.Close();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents registForEvents = new AllEvents();
            registForEvents.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void attendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void registForEventsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void LoadManagers()
        {
            string sql = """
                SELECT UserName
                FROM User
                WHERE RoleId = 1002;
                """;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            comboBoxManager.Items.Clear();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        comboBoxManager.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }

        // validate eventname not null and less than 45
        private bool NameValidate()
        {
            if (string.IsNullOrEmpty(txtEventName.Text))
            {
                MessageBox.Show("Name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEventName.Text.Length > 45)
            {
                MessageBox.Show("Name length can't exceed 45!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // validate manager not null
        private bool ManagerValidate()
        {
            if (comboBoxManager.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Manager can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // validate capacity is int and not null
        private bool CapacityValidate()
        {
            if (string.IsNullOrEmpty(txtEventCapacity.Text))
            {
                MessageBox.Show("Please enter a value for capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Return false indicating validation failure
            }
            
            int i;

            if (!int.TryParse(txtEventCapacity.Text, out i))
            {
                MessageBox.Show("Input a number for capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        // validate location is not null
        private bool LocationValidate()
        {
            if (string.IsNullOrEmpty(txtBoxtLocation.Text))
            {
                MessageBox.Show("Location can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtBoxtLocation.Text.Length > 45)
            {
                MessageBox.Show("Location length can't exceed 45!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // validate organizer is not null
        private bool OrganizerValidate()
        {
            if (string.IsNullOrEmpty(txtEventOragnizer.Text))
            {
                MessageBox.Show("Organizer can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEventOragnizer.Text.Length > 45)
            {
                MessageBox.Show("Organizer length can't exceed 45!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // validate valid not null
        private bool ValidValidate()
        {
            if (comboBoxValid.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Valid can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void ConfigureVisibleElements()
        {
            bool isAdmin = CurrentUser.User.Role == Role.Administrator;
            comboBoxManager.Enabled = isAdmin;
            usersToolStripMenuItem.Visible = isAdmin;
            addEventToolStripMenuItem.Visible = isAdmin;
        }

        private void EventDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
