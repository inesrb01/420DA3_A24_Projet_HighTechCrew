
using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views {
    public partial class RoleView : Form {
        private readonly App application;
        private ViewActionsEnum currentAction;
        private Role? currentInstance;

        public RoleView(App application) {
            this.application = application;
            this.currentAction = ViewActionsEnum.Visualization; // Default action
            this.InitializeComponent();
        }

        private void InitializeComponent() {
            throw new NotImplementedException();
        }

        // Get the current Role instance
        public Role? GetCurrentInstance() {
            return this.currentInstance;
        }

        // Open the view for different actions: Creation, Edition, Visualization, Deletion
        public DialogResult OpenFor(ViewActionsEnum currentAction, Role? role = null) {
            this.currentAction = currentAction;
            this.LoadInstanceInControls(role);

            switch (currentAction) {
                case ViewActionsEnum.Creation:
                    this.viewModeValueLabel.Text = "Creation";
                    this.actionButton.Text = "Create";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Visualization:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Visualization";
                    this.actionButton.Text = "OK";
                    this.DisableEditableControls();
                    break;
                case ViewActionsEnum.Edition:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Edition";
                    this.actionButton.Text = "Save Changes";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Deletion:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
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

        // Load Role data into controls
        private void LoadInstanceInControls(Role? role) {
            if (role != null) {
                this.roleNameTextBox.Text = role.RoleName;
                this.roleDescriptionTextBox.Text = role.RoleDescription;
                this.dateCreatedDTPicker.Value = role.DateCreated;
                this.dateModifiedDTPicker.Value = role.DateModified ?? DateTime.Now;
                this.dateDeletedDTPicker.Value = role.DateDeleted ?? DateTime.Now;
            } else {
                this.roleNameTextBox.Text = string.Empty;
                this.roleDescriptionTextBox.Text = string.Empty;
                this.dateCreatedDTPicker.Value = DateTime.Now;
                this.dateModifiedDTPicker.Value = DateTime.Now;
                this.dateDeletedDTPicker.Value = DateTime.Now;
            }

            this.currentInstance = role;
        }

        // Enable controls for editing
        private void EnableEditableControls() {
            this.roleNameTextBox.Enabled = true;
            this.roleDescriptionTextBox.Enabled = true;
        }

        // Disable controls to make them read-only
        private void DisableEditableControls() {
            this.roleNameTextBox.Enabled = false;
            this.roleDescriptionTextBox.Enabled = false;
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
                    Role newRole = new Role {
                        RoleName = this.roleNameTextBox.Text.Trim(),
                        RoleDescription = this.roleDescriptionTextBox.Text.Trim(),
                        DateCreated = DateTime.Now
                    };
                    this.currentInstance = this.application.RoleService.Create(newRole);
                    break;
                case ViewActionsEnum.Visualization:
                    // No action needed in visualization mode
                    break;
                case ViewActionsEnum.Edition:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [Role] loaded.");
                    }
                    this.currentInstance.RoleName = this.roleNameTextBox.Text.Trim();
                    this.currentInstance.RoleDescription = this.roleDescriptionTextBox.Text.Trim();
                    this.currentInstance.DateModified = DateTime.Now;
                    this.currentInstance = this.application.RoleService.Update(this.currentInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [Role] loaded.");
                    }
                    this.application.RoleService.Delete(this.currentInstance);
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
                if (string.IsNullOrEmpty(this.roleNameTextBox.Text.Trim())) {
                    message += Environment.NewLine + "\t- The role name cannot be empty.";
                }

                if (this.roleNameTextBox.Text.Trim().Length > Role.RoleNameMaxLength) {
                    message += Environment.NewLine + $"\t- The role name cannot exceed {Role.RoleNameMaxLength} characters.";
                }

                if (string.IsNullOrEmpty(this.roleDescriptionTextBox.Text.Trim())) {
                    message += Environment.NewLine + "\t- The role description cannot be empty.";
                }

                if (this.roleDescriptionTextBox.Text.Trim().Length > Role.RoleDescriptionMaxLength) {
                    message += Environment.NewLine + $"\t- The role description cannot exceed {Role.RoleDescriptionMaxLength} characters.";
                }
            }

            if (!string.IsNullOrEmpty(message)) {
                throw new ValidationException(message);
            }
        }
    }
}
using System;
using System.Windows.Forms;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views {
    public partial class RoleView : Form {
        private readonly App application;
        private ViewActionsEnum currentAction;
        private Role? currentInstance;

        public RoleView(App application) {
            this.application = application;
            this.currentAction = ViewActionsEnum.Visualization; // Default action
            this.InitializeComponent();
        }

        private void InitializeComponent() {
            throw new NotImplementedException();
        }

        // Get the current Role instance
        public Role? GetCurrentInstance() {
            return this.currentInstance;
        }

        // Open the view for different actions: Creation, Edition, Visualization, Deletion
        public DialogResult OpenFor(ViewActionsEnum currentAction, Role? role = null) {
            this.currentAction = currentAction;
            this.LoadInstanceInControls(role);

            switch (currentAction) {
                case ViewActionsEnum.Creation:
                    this.viewModeValueLabel.Text = "Creation";
                    this.actionButton.Text = "Create";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Visualization:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Visualization";
                    this.actionButton.Text = "OK";
                    this.DisableEditableControls();
                    break;
                case ViewActionsEnum.Edition:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
                    }
                    this.viewModeValueLabel.Text = "Edition";
                    this.actionButton.Text = "Save Changes";
                    this.EnableEditableControls();
                    break;
                case ViewActionsEnum.Deletion:
                    if (role is null) {
                        throw new ArgumentException($"Parameter [role] cannot be null for view action [{currentAction}].");
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

        // Load Role data into controls
        private void LoadInstanceInControls(Role? role) {
            if (role != null) {
                this.roleNameTextBox.Text = role.RoleName;
                this.roleDescriptionTextBox.Text = role.RoleDescription;
                this.dateCreatedDTPicker.Value = role.DateCreated;
                this.dateModifiedDTPicker.Value = role.DateModified ?? DateTime.Now;
                this.dateDeletedDTPicker.Value = role.DateDeleted ?? DateTime.Now;
            } else {
                this.roleNameTextBox.Text = string.Empty;
                this.roleDescriptionTextBox.Text = string.Empty;
                this.dateCreatedDTPicker.Value = DateTime.Now;
                this.dateModifiedDTPicker.Value = DateTime.Now;
                this.dateDeletedDTPicker.Value = DateTime.Now;
            }

            this.currentInstance = role;
        }

        // Enable controls for editing
        private void EnableEditableControls() {
            this.roleNameTextBox.Enabled = true;
            this.roleDescriptionTextBox.Enabled = true;
        }

        // Disable controls to make them read-only
        private void DisableEditableControls() {
            this.roleNameTextBox.Enabled = false;
            this.roleDescriptionTextBox.Enabled = false;
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
                    Role newRole = new Role {
                        RoleName = this.roleNameTextBox.Text.Trim(),
                        RoleDescription = this.roleDescriptionTextBox.Text.Trim(),
                        DateCreated = DateTime.Now
                    };
                    this.currentInstance = this.application.RoleService.Create(newRole);
                    break;
                case ViewActionsEnum.Visualization:
                    // No action needed in visualization mode
                    break;
                case ViewActionsEnum.Edition:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [Role] loaded.");
                    }
                    this.currentInstance.RoleName = this.roleNameTextBox.Text.Trim();
                    this.currentInstance.RoleDescription = this.roleDescriptionTextBox.Text.Trim();
                    this.currentInstance.DateModified = DateTime.Now;
                    this.currentInstance = this.application.RoleService.Update(this.currentInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    if (this.currentInstance == null) {
                        throw new Exception("No current instance of [Role] loaded.");
                    }
                    this.application.RoleService.Delete(this.currentInstance);
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
                if (string.IsNullOrEmpty(this.roleNameTextBox.Text.Trim())) {
                    message += Environment.NewLine + "\t- The role name cannot be empty.";
                }

                if (this.roleNameTextBox.Text.Trim().Length > Role.RoleNameMaxLength) {
                    message += Environment.NewLine + $"\t- The role name cannot exceed {Role.RoleNameMaxLength} characters.";
                }

                if (string.IsNullOrEmpty(this.roleDescriptionTextBox.Text.Trim())) {
                    message += Environment.NewLine + "\t- The role description cannot be empty.";
                }

                if (this.roleDescriptionTextBox.Text.Trim().Length > Role.RoleDescriptionMaxLength) {
                    message += Environment.NewLine + $"\t- The role description cannot exceed {Role.RoleDescriptionMaxLength} characters.";
                }
            }

            if (!string.IsNullOrEmpty(message)) {
                throw new ValidationException(message);
            }
        }
    }
}
