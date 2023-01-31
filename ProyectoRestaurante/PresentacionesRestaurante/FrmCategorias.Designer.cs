
namespace PresentacionesRestaurante
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnSalir = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dtgCategorias = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNuevo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveImage = null;
            this.btnSalir.AllowAnimations = true;
            this.btnSalir.AllowBuffering = false;
            this.btnSalir.AllowToggling = false;
            this.btnSalir.AllowZooming = true;
            this.btnSalir.AllowZoomingOnFocus = false;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ErrorImage")));
            this.btnSalir.FadeWhenInactive = false;
            this.btnSalir.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageActive = null;
            this.btnSalir.ImageLocation = null;
            this.btnSalir.ImageMargin = 20;
            this.btnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSalir.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnSalir.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.InitialImage")));
            this.btnSalir.Location = new System.Drawing.Point(747, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0;
            this.btnSalir.ShowActiveImage = true;
            this.btnSalir.ShowCursorChanges = true;
            this.btnSalir.ShowImageBorders = true;
            this.btnSalir.ShowSizeMarkers = false;
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.ToolTipText = "";
            this.btnSalir.WaitOnLoad = false;
            this.btnSalir.Zoom = 20;
            this.btnSalir.ZoomSpeed = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtBuscar.BorderRadius = 1;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.FillColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = null;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 10;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(32, 95);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Orange;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnIdleState = stateProperties8;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.PlaceholderText = "Enter text";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(736, 41);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 3;
            this.txtBuscar.TextMarginTop = 0;
            this.txtBuscar.TextPlaceholder = "Enter text";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            this.txtBuscar.TextChange += new System.EventHandler(this.txtBuscar_TextChange);
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AllowCustomTheming = false;
            this.dtgCategorias.AllowUserToAddRows = false;
            this.dtgCategorias.AllowUserToDeleteRows = false;
            this.dtgCategorias.AllowUserToResizeColumns = false;
            this.dtgCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtgCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCategorias.ColumnHeadersHeight = 40;
            this.dtgCategorias.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgCategorias.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCategorias.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCategorias.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCategorias.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgCategorias.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgCategorias.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCategorias.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCategorias.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgCategorias.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCategorias.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgCategorias.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCategorias.CurrentTheme.Name = null;
            this.dtgCategorias.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCategorias.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCategorias.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCategorias.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCategorias.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCategorias.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCategorias.EnableHeadersVisualStyles = false;
            this.dtgCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCategorias.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCategorias.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgCategorias.HeaderForeColor = System.Drawing.Color.White;
            this.dtgCategorias.Location = new System.Drawing.Point(32, 152);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.ReadOnly = true;
            this.dtgCategorias.RowHeadersVisible = false;
            this.dtgCategorias.RowHeadersWidth = 51;
            this.dtgCategorias.RowTemplate.Height = 40;
            this.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategorias.Size = new System.Drawing.Size(736, 232);
            this.dtgCategorias.TabIndex = 3;
            this.dtgCategorias.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowAnimations = true;
            this.btnEliminar.AllowMouseEffects = true;
            this.btnEliminar.AllowToggling = false;
            this.btnEliminar.AnimationSpeed = 200;
            this.btnEliminar.AutoGenerateColors = false;
            this.btnEliminar.AutoRoundBorders = false;
            this.btnEliminar.AutoSizeLeftIcon = true;
            this.btnEliminar.AutoSizeRightIcon = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor1 = System.Drawing.Color.Orange;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.ButtonTextMarginLeft = 0;
            this.btnEliminar.ColorContrastOnClick = 45;
            this.btnEliminar.ColorContrastOnHover = 45;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnEliminar.CustomizableEdges = borderEdges3;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEliminar.IconMarginLeft = 11;
            this.btnEliminar.IconPadding = 10;
            this.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.IdleBorderRadius = 1;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.Orange;
            this.btnEliminar.IdleIconLeftImage = null;
            this.btnEliminar.IdleIconRightImage = null;
            this.btnEliminar.IndicateFocus = false;
            this.btnEliminar.Location = new System.Drawing.Point(658, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.OnDisabledState.BorderRadius = 1;
            this.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnDisabledState.BorderThickness = 1;
            this.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.OnDisabledState.IconLeftImage = null;
            this.btnEliminar.OnDisabledState.IconRightImage = null;
            this.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEliminar.onHoverState.BorderRadius = 1;
            this.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.onHoverState.BorderThickness = 1;
            this.btnEliminar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.onHoverState.IconLeftImage = null;
            this.btnEliminar.onHoverState.IconRightImage = null;
            this.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.OnIdleState.BorderRadius = 1;
            this.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnIdleState.BorderThickness = 1;
            this.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnIdleState.IconLeftImage = null;
            this.btnEliminar.OnIdleState.IconRightImage = null;
            this.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEliminar.OnPressedState.BorderRadius = 1;
            this.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnPressedState.BorderThickness = 1;
            this.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnPressedState.IconLeftImage = null;
            this.btnEliminar.OnPressedState.IconRightImage = null;
            this.btnEliminar.Size = new System.Drawing.Size(110, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.TextMarginLeft = 0;
            this.btnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEliminar.UseDefaultRadiusAndThickness = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AllowAnimations = true;
            this.btnNuevo.AllowMouseEffects = true;
            this.btnNuevo.AllowToggling = false;
            this.btnNuevo.AnimationSpeed = 200;
            this.btnNuevo.AutoGenerateColors = false;
            this.btnNuevo.AutoRoundBorders = false;
            this.btnNuevo.AutoSizeLeftIcon = true;
            this.btnNuevo.AutoSizeRightIcon = true;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackColor1 = System.Drawing.Color.Orange;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.ButtonTextMarginLeft = 0;
            this.btnNuevo.ColorContrastOnClick = 45;
            this.btnNuevo.ColorContrastOnHover = 45;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnNuevo.CustomizableEdges = borderEdges4;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNuevo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNuevo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNuevo.IconMarginLeft = 11;
            this.btnNuevo.IconPadding = 10;
            this.btnNuevo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.IdleBorderRadius = 1;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.Orange;
            this.btnNuevo.IdleIconLeftImage = null;
            this.btnNuevo.IdleIconRightImage = null;
            this.btnNuevo.IndicateFocus = false;
            this.btnNuevo.Location = new System.Drawing.Point(532, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevo.OnDisabledState.BorderRadius = 1;
            this.btnNuevo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnDisabledState.BorderThickness = 1;
            this.btnNuevo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNuevo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNuevo.OnDisabledState.IconLeftImage = null;
            this.btnNuevo.OnDisabledState.IconRightImage = null;
            this.btnNuevo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNuevo.onHoverState.BorderRadius = 1;
            this.btnNuevo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.onHoverState.BorderThickness = 1;
            this.btnNuevo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNuevo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.onHoverState.IconLeftImage = null;
            this.btnNuevo.onHoverState.IconRightImage = null;
            this.btnNuevo.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.OnIdleState.BorderRadius = 1;
            this.btnNuevo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnIdleState.BorderThickness = 1;
            this.btnNuevo.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btnNuevo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnIdleState.IconLeftImage = null;
            this.btnNuevo.OnIdleState.IconRightImage = null;
            this.btnNuevo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNuevo.OnPressedState.BorderRadius = 1;
            this.btnNuevo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnPressedState.BorderThickness = 1;
            this.btnNuevo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNuevo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnPressedState.IconLeftImage = null;
            this.btnNuevo.OnPressedState.IconRightImage = null;
            this.btnNuevo.Size = new System.Drawing.Size(110, 38);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.TextMarginLeft = 0;
            this.btnNuevo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNuevo.UseDefaultRadiusAndThickness = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar:";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btnSalir;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgCategorias;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEliminar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}