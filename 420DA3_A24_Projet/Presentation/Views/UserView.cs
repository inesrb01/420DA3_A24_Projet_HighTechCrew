using System;
using System.Windows.Forms;

using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views {
    public partial class UserView : Form {
        private readonly App application;
        private ViewActionsEnum currentAction;
        private User? currentInstance;

        public UserView(App application) {
            this.application = application;
            this.currentAction = ViewActionsEnum.Visualization; // default action
            this.InitializeComponent();
        }

        // Get the current User instance
        public User? GetCurrentInstance() {
            return this.currentInstance;
        }

        // Open the view for different actions: Creation, Edition, Visualization, Deletion
        public DialogResult OpenFor(ViewActionsEnum currentAction, User? user = null) {
            this.currentAction = currentAction;
            this.LoadInstanceInControls(user);

            switch (currentAction) {
                case ViewActionsEnum.Creation:
                    this.viewModeValueLabel.Text = "Creation";
                    this.actionButton.Text = "Create";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Visualization:
                    if (user is null) {
                        throw new ArgumentException($"Parameter [user] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Visualization";
                    this.actionButton.Text = "OK";
                    this.DisableEditableControls();
                    break;
                case ViewActionsEnum.Edition:
                    if (user is null) {
                        throw new ArgumentException($"Parameter [user] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Edition";
                    this.actionButton.Text = "Save Changes";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Deletion:
                    if (user is null) {
                        throw new ArgumentException($"Parameter [user] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Deletion";
                    this.actionButton.Text = "Delete";
                    this.DisableEditableControls();
                    break;
                default:
                    throw new NotImplementedException($"View action [{currentAction}] is not implemented.");
            }

            return this.ShowDialog();
        }

        // Load User data into controls
        private void LoadInstanceInControls(User? user) {
            if (user != null) {
                this.usernameTextBox.Text = user.Username;
                this.dateCreatedDTPicker.Value = user.DateCreated;
                this.dateModifiedDTPicker.Value = user.DateModified ?? DateTime.Now;
                this.dateDeletedDTPicker.Value = user.DateDeleted ?? DateTime.Now;
            } else {
                this.usernameTextBox.Text = string.Empty;
                this.dateCreatedDTPicker.Value = DateTime.Now;
                this.dateModifiedDTPicker.Value = DateTime.Now;
                this.dateDeletedDTPicker.Value = DateTime.Now;
            }

            this.currentInstance = user;
        }

        // Enable controls for editing
        private void EnableEditableControls() {
            this.usernameTextBox.Enabled = true;
        }

        // Disable controls to make them read-only
        private void DisableEditableControls() {
            this.usernameTextBox.Enabled = false;
        }

        // Handle the Cancel button click event
        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        // Handle the Action button click event (Create, Update, Delete)
        private void ActionButton_Click(object sender, EventArgs e) {
            try {
                this.ProcessAction();
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                this.application.HandleException(ex);
            }
        }

        // Process the current action based on `currentAction`
        private void ProcessAction() {
            this.ValidateControlsForAction();

            switch (this.currentAction) {
                case ViewActionsEnum.Creation:
                    User newUser = new User {
                        Username = this.usernameTextBox.Text.Trim(),
                        DateCreated = DateTime.Now
                    };
                    this.currentInstance = this.application.UserService.Create(newUser);
                    break;
                case ViewActionsEnum.Visualization:
                    // No action needed in visualization mode
                    break;
                case ViewActionsEnum.Edition:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [User] loaded.");
                    }
                    this.currentInstance.Username = this.usernameTextBox.Text.Trim();
                    this.currentInstance.DateModified = DateTime.Now;
                    this.currentInstance = this.application.UserService.Update(this.currentInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [User] loaded.");
                    }
                    this.application.UserService.Delete(this.currentInstance);
                    this.currentInstance = null;
                    break;
                default:
                    throw new NotImplementedException($"View action [{this.currentAction}] is not implemented.");
            }
        }

        // Validate controls before processing actions
        private void ValidateControlsForAction() {
            string message = string.Empty;

            if (this.currentAction == ViewActionsEnum.Creation || this.currentAction == ViewActionsEnum.Edition) {
                if (string.IsNullOrEmpty(this.usernameTextBox.Text.Trim())) {
                    message += Environment.NewLine + "\t- The username cannot be empty.";
                }

                if (this.usernameTextBox.Text.Trim().Length > User.UsernameMaxLength) {
                    message += Environment.NewLine + $"\t- The username cannot exceed {User.UsernameMaxLength} characters.";
                }
            }

            if (!string.IsNullOrEmpty(message)) {
                throw new ValidationException(message);
            }
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // UserView
            // 
            this.ClientSize = new Size(914, 570);
            this.Name = "UserView";
            this.ResumeLayout(false);
        }

        public DialogResult OpenFo(ViewActionsEnum viewAction, User? user) {
            throw new NotImplementedException();
        }
    }
}
