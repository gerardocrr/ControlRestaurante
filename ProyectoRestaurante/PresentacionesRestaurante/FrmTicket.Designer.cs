namespace PresentacionesRestaurante
{
    partial class FrmTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicket));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicket = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnRecogerTicket = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 76;
            this.label1.Text = "Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.AcceptsReturn = false;
            this.txtTicket.AcceptsTab = false;
            this.txtTicket.AnimationSpeed = 200;
            this.txtTicket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTicket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTicket.BackColor = System.Drawing.Color.Transparent;
            this.txtTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTicket.BackgroundImage")));
            this.txtTicket.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTicket.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTicket.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTicket.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTicket.BorderRadius = 1;
            this.txtTicket.BorderThickness = 1;
            this.txtTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicket.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.DefaultText = "";
            this.txtTicket.FillColor = System.Drawing.Color.White;
            this.txtTicket.HideSelection = true;
            this.txtTicket.IconLeft = null;
            this.txtTicket.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicket.IconPadding = 10;
            this.txtTicket.IconRight = null;
            this.txtTicket.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicket.Lines = new string[0];
            this.txtTicket.Location = new System.Drawing.Point(74, 100);
            this.txtTicket.MaxLength = 32767;
            this.txtTicket.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTicket.Modified = false;
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTicket.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTicket.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTicket.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTicket.OnIdleState = stateProperties4;
            this.txtTicket.Padding = new System.Windows.Forms.Padding(3);
            this.txtTicket.PasswordChar = '\0';
            this.txtTicket.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTicket.PlaceholderText = "Enter text";
            this.txtTicket.ReadOnly = false;
            this.txtTicket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicket.SelectedText = "";
            this.txtTicket.SelectionLength = 0;
            this.txtTicket.SelectionStart = 0;
            this.txtTicket.ShortcutsEnabled = true;
            this.txtTicket.Size = new System.Drawing.Size(715, 279);
            this.txtTicket.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTicket.TabIndex = 77;
            this.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTicket.TextMarginBottom = 0;
            this.txtTicket.TextMarginLeft = 3;
            this.txtTicket.TextMarginTop = 0;
            this.txtTicket.TextPlaceholder = "Enter text";
            this.txtTicket.UseSystemPasswordChar = false;
            this.txtTicket.WordWrap = true;
            // 
            // btnRecogerTicket
            // 
            this.btnRecogerTicket.AllowAnimations = true;
            this.btnRecogerTicket.AllowMouseEffects = true;
            this.btnRecogerTicket.AllowToggling = false;
            this.btnRecogerTicket.AnimationSpeed = 200;
            this.btnRecogerTicket.AutoGenerateColors = false;
            this.btnRecogerTicket.AutoRoundBorders = false;
            this.btnRecogerTicket.AutoSizeLeftIcon = true;
            this.btnRecogerTicket.AutoSizeRightIcon = true;
            this.btnRecogerTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnRecogerTicket.BackColor1 = System.Drawing.Color.Orange;
            this.btnRecogerTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecogerTicket.BackgroundImage")));
            this.btnRecogerTicket.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecogerTicket.ButtonText = "Recoger ticket";
            this.btnRecogerTicket.ButtonTextMarginLeft = 0;
            this.btnRecogerTicket.ColorContrastOnClick = 45;
            this.btnRecogerTicket.ColorContrastOnHover = 45;
            this.btnRecogerTicket.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRecogerTicket.CustomizableEdges = borderEdges1;
            this.btnRecogerTicket.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecogerTicket.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRecogerTicket.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRecogerTicket.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRecogerTicket.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRecogerTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecogerTicket.ForeColor = System.Drawing.Color.White;
            this.btnRecogerTicket.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecogerTicket.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRecogerTicket.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRecogerTicket.IconMarginLeft = 11;
            this.btnRecogerTicket.IconPadding = 10;
            this.btnRecogerTicket.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecogerTicket.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRecogerTicket.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRecogerTicket.IconSize = 25;
            this.btnRecogerTicket.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnRecogerTicket.IdleBorderRadius = 1;
            this.btnRecogerTicket.IdleBorderThickness = 1;
            this.btnRecogerTicket.IdleFillColor = System.Drawing.Color.Orange;
            this.btnRecogerTicket.IdleIconLeftImage = null;
            this.btnRecogerTicket.IdleIconRightImage = null;
            this.btnRecogerTicket.IndicateFocus = false;
            this.btnRecogerTicket.Location = new System.Drawing.Point(353, 418);
            this.btnRecogerTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecogerTicket.Name = "btnRecogerTicket";
            this.btnRecogerTicket.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRecogerTicket.OnDisabledState.BorderRadius = 1;
            this.btnRecogerTicket.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecogerTicket.OnDisabledState.BorderThickness = 1;
            this.btnRecogerTicket.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRecogerTicket.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRecogerTicket.OnDisabledState.IconLeftImage = null;
            this.btnRecogerTicket.OnDisabledState.IconRightImage = null;
            this.btnRecogerTicket.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRecogerTicket.onHoverState.BorderRadius = 1;
            this.btnRecogerTicket.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecogerTicket.onHoverState.BorderThickness = 1;
            this.btnRecogerTicket.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRecogerTicket.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRecogerTicket.onHoverState.IconLeftImage = null;
            this.btnRecogerTicket.onHoverState.IconRightImage = null;
            this.btnRecogerTicket.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRecogerTicket.OnIdleState.BorderRadius = 1;
            this.btnRecogerTicket.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecogerTicket.OnIdleState.BorderThickness = 1;
            this.btnRecogerTicket.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btnRecogerTicket.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRecogerTicket.OnIdleState.IconLeftImage = null;
            this.btnRecogerTicket.OnIdleState.IconRightImage = null;
            this.btnRecogerTicket.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRecogerTicket.OnPressedState.BorderRadius = 1;
            this.btnRecogerTicket.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRecogerTicket.OnPressedState.BorderThickness = 1;
            this.btnRecogerTicket.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRecogerTicket.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRecogerTicket.OnPressedState.IconLeftImage = null;
            this.btnRecogerTicket.OnPressedState.IconRightImage = null;
            this.btnRecogerTicket.Size = new System.Drawing.Size(160, 47);
            this.btnRecogerTicket.TabIndex = 78;
            this.btnRecogerTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecogerTicket.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecogerTicket.TextMarginLeft = 0;
            this.btnRecogerTicket.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRecogerTicket.UseDefaultRadiusAndThickness = true;
            this.btnRecogerTicket.Click += new System.EventHandler(this.btnRecogerTicket_Click);
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 504);
            this.Controls.Add(this.btnRecogerTicket);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRecogerTicket;
        public Bunifu.UI.WinForms.BunifuTextBox txtTicket;
    }
}