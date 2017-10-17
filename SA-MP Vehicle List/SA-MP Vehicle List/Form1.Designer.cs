namespace SA_MP_Vehicle_List
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.StatusStrip_Stats = new System.Windows.Forms.StatusStrip();
            this.GroupBox_Preview = new System.Windows.Forms.GroupBox();
            this.Label_VehicleAnimation = new System.Windows.Forms.Label();
            this.Label_VehicleClass = new System.Windows.Forms.Label();
            this.Label_VehicleType = new System.Windows.Forms.Label();
            this.Label_VehicleModelID = new System.Windows.Forms.Label();
            this.Label_Class = new System.Windows.Forms.Label();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_Animation = new System.Windows.Forms.Label();
            this.Label_ModelID = new System.Windows.Forms.Label();
            this.Label_VehicleName = new System.Windows.Forms.Label();
            this.PictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.ListBox_List = new System.Windows.Forms.ListBox();
            this.GroupBox_Navigation = new System.Windows.Forms.GroupBox();
            this.Button_Last = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_First = new System.Windows.Forms.Button();
            this.Label_Version = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox_ExtendedOptions = new System.Windows.Forms.GroupBox();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.Button_Filter = new System.Windows.Forms.Button();
            this.GroupBox_FilterByAnimation = new System.Windows.Forms.GroupBox();
            this.ComboBox_FilterByAnimation = new System.Windows.Forms.ComboBox();
            this.GroupBox_FilterByClass = new System.Windows.Forms.GroupBox();
            this.ComboBox_FilterByClass = new System.Windows.Forms.ComboBox();
            this.GroupBox_FilterByType = new System.Windows.Forms.GroupBox();
            this.ComboBox_FilterByType = new System.Windows.Forms.ComboBox();
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.RadioButton_SearchByName = new System.Windows.Forms.RadioButton();
            this.RadioButton_SearchByID = new System.Windows.Forms.RadioButton();
            this.RadioButton_SearchByModelID = new System.Windows.Forms.RadioButton();
            this.GroupBox_SearchByName = new System.Windows.Forms.GroupBox();
            this.TextBox_SearchByName = new System.Windows.Forms.TextBox();
            this.GroupBox_SearchByID = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_SearchByID = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_SearchByModelID = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_SearchByModelID = new System.Windows.Forms.NumericUpDown();
            this.Button_Copy = new System.Windows.Forms.Button();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Import = new System.Windows.Forms.Button();
            this.Button_Random = new System.Windows.Forms.Button();
            this.SaveFileDialog_Export = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog_Import = new System.Windows.Forms.OpenFileDialog();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox_Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Preview)).BeginInit();
            this.GroupBox_Navigation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GroupBox_ExtendedOptions.SuspendLayout();
            this.GroupBox_Filter.SuspendLayout();
            this.GroupBox_FilterByAnimation.SuspendLayout();
            this.GroupBox_FilterByClass.SuspendLayout();
            this.GroupBox_FilterByType.SuspendLayout();
            this.GroupBox_Search.SuspendLayout();
            this.GroupBox_SearchByName.SuspendLayout();
            this.GroupBox_SearchByID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SearchByID)).BeginInit();
            this.GroupBox_SearchByModelID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SearchByModelID)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip_Stats
            // 
            this.StatusStrip_Stats.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip_Stats.Location = new System.Drawing.Point(0, 699);
            this.StatusStrip_Stats.Name = "StatusStrip_Stats";
            this.StatusStrip_Stats.Size = new System.Drawing.Size(488, 22);
            this.StatusStrip_Stats.TabIndex = 0;
            this.StatusStrip_Stats.Text = "statusStrip1";
            // 
            // GroupBox_Preview
            // 
            this.GroupBox_Preview.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_Preview.Controls.Add(this.Label_VehicleAnimation);
            this.GroupBox_Preview.Controls.Add(this.Label_VehicleClass);
            this.GroupBox_Preview.Controls.Add(this.Label_VehicleType);
            this.GroupBox_Preview.Controls.Add(this.Label_VehicleModelID);
            this.GroupBox_Preview.Controls.Add(this.Label_Class);
            this.GroupBox_Preview.Controls.Add(this.Label_Type);
            this.GroupBox_Preview.Controls.Add(this.Label_Animation);
            this.GroupBox_Preview.Controls.Add(this.Label_ModelID);
            this.GroupBox_Preview.Controls.Add(this.Label_VehicleName);
            this.GroupBox_Preview.Controls.Add(this.PictureBox_Preview);
            this.GroupBox_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Preview.Location = new System.Drawing.Point(12, 32);
            this.GroupBox_Preview.Name = "GroupBox_Preview";
            this.GroupBox_Preview.Size = new System.Drawing.Size(271, 334);
            this.GroupBox_Preview.TabIndex = 1;
            this.GroupBox_Preview.TabStop = false;
            this.GroupBox_Preview.Text = "Preview";
            // 
            // Label_VehicleAnimation
            // 
            this.Label_VehicleAnimation.AutoSize = true;
            this.Label_VehicleAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VehicleAnimation.Location = new System.Drawing.Point(180, 302);
            this.Label_VehicleAnimation.Name = "Label_VehicleAnimation";
            this.Label_VehicleAnimation.Size = new System.Drawing.Size(11, 13);
            this.Label_VehicleAnimation.TabIndex = 8;
            this.Label_VehicleAnimation.Text = "-";
            this.Label_VehicleAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_VehicleClass
            // 
            this.Label_VehicleClass.AutoSize = true;
            this.Label_VehicleClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VehicleClass.Location = new System.Drawing.Point(180, 271);
            this.Label_VehicleClass.Name = "Label_VehicleClass";
            this.Label_VehicleClass.Size = new System.Drawing.Size(11, 13);
            this.Label_VehicleClass.TabIndex = 7;
            this.Label_VehicleClass.Text = "-";
            this.Label_VehicleClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_VehicleType
            // 
            this.Label_VehicleType.AutoSize = true;
            this.Label_VehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VehicleType.Location = new System.Drawing.Point(180, 240);
            this.Label_VehicleType.Name = "Label_VehicleType";
            this.Label_VehicleType.Size = new System.Drawing.Size(11, 13);
            this.Label_VehicleType.TabIndex = 6;
            this.Label_VehicleType.Text = "-";
            this.Label_VehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_VehicleModelID
            // 
            this.Label_VehicleModelID.AutoSize = true;
            this.Label_VehicleModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VehicleModelID.Location = new System.Drawing.Point(180, 209);
            this.Label_VehicleModelID.Name = "Label_VehicleModelID";
            this.Label_VehicleModelID.Size = new System.Drawing.Size(11, 13);
            this.Label_VehicleModelID.TabIndex = 5;
            this.Label_VehicleModelID.Text = "-";
            this.Label_VehicleModelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Class
            // 
            this.Label_Class.AutoSize = true;
            this.Label_Class.Location = new System.Drawing.Point(13, 271);
            this.Label_Class.Name = "Label_Class";
            this.Label_Class.Size = new System.Drawing.Size(32, 13);
            this.Label_Class.TabIndex = 4;
            this.Label_Class.Text = "Class";
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Location = new System.Drawing.Point(13, 240);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(31, 13);
            this.Label_Type.TabIndex = 3;
            this.Label_Type.Text = "Type";
            // 
            // Label_Animation
            // 
            this.Label_Animation.AutoSize = true;
            this.Label_Animation.Location = new System.Drawing.Point(13, 302);
            this.Label_Animation.Name = "Label_Animation";
            this.Label_Animation.Size = new System.Drawing.Size(53, 13);
            this.Label_Animation.TabIndex = 3;
            this.Label_Animation.Text = "Animation";
            // 
            // Label_ModelID
            // 
            this.Label_ModelID.AutoSize = true;
            this.Label_ModelID.Location = new System.Drawing.Point(13, 209);
            this.Label_ModelID.Name = "Label_ModelID";
            this.Label_ModelID.Size = new System.Drawing.Size(50, 13);
            this.Label_ModelID.TabIndex = 2;
            this.Label_ModelID.Text = "Model ID";
            // 
            // Label_VehicleName
            // 
            this.Label_VehicleName.AutoSize = true;
            this.Label_VehicleName.BackColor = System.Drawing.Color.Transparent;
            this.Label_VehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VehicleName.Location = new System.Drawing.Point(12, 166);
            this.Label_VehicleName.Name = "Label_VehicleName";
            this.Label_VehicleName.Size = new System.Drawing.Size(124, 20);
            this.Label_VehicleName.TabIndex = 1;
            this.Label_VehicleName.Text = "Vehicle_Name";
            // 
            // PictureBox_Preview
            // 
            this.PictureBox_Preview.Image = global::SA_MP_Vehicle_List.Properties.Resources.Vehicle_611;
            this.PictureBox_Preview.Location = new System.Drawing.Point(16, 19);
            this.PictureBox_Preview.Name = "PictureBox_Preview";
            this.PictureBox_Preview.Size = new System.Drawing.Size(238, 144);
            this.PictureBox_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Preview.TabIndex = 0;
            this.PictureBox_Preview.TabStop = false;
            // 
            // ListBox_List
            // 
            this.ListBox_List.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_List.FormattingEnabled = true;
            this.ListBox_List.ItemHeight = 16;
            this.ListBox_List.Location = new System.Drawing.Point(306, 38);
            this.ListBox_List.Name = "ListBox_List";
            this.ListBox_List.Size = new System.Drawing.Size(170, 276);
            this.ListBox_List.TabIndex = 2;
            this.ListBox_List.SelectedIndexChanged += new System.EventHandler(this.ListBox_List_SelectedIndexChanged);
            // 
            // GroupBox_Navigation
            // 
            this.GroupBox_Navigation.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_Navigation.Controls.Add(this.Button_Last);
            this.GroupBox_Navigation.Controls.Add(this.Button_Next);
            this.GroupBox_Navigation.Controls.Add(this.Button_Back);
            this.GroupBox_Navigation.Controls.Add(this.Button_First);
            this.GroupBox_Navigation.Location = new System.Drawing.Point(306, 318);
            this.GroupBox_Navigation.Name = "GroupBox_Navigation";
            this.GroupBox_Navigation.Size = new System.Drawing.Size(170, 48);
            this.GroupBox_Navigation.TabIndex = 3;
            this.GroupBox_Navigation.TabStop = false;
            this.GroupBox_Navigation.Text = "Navigation";
            // 
            // Button_Last
            // 
            this.Button_Last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Last.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Last.Location = new System.Drawing.Point(129, 16);
            this.Button_Last.Name = "Button_Last";
            this.Button_Last.Size = new System.Drawing.Size(35, 26);
            this.Button_Last.TabIndex = 7;
            this.Button_Last.Text = ">>";
            this.Button_Last.UseVisualStyleBackColor = true;
            this.Button_Last.Click += new System.EventHandler(this.Button_Last_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Next.Location = new System.Drawing.Point(88, 16);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(35, 26);
            this.Button_Next.TabIndex = 6;
            this.Button_Next.Text = ">";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(47, 16);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(35, 26);
            this.Button_Back.TabIndex = 5;
            this.Button_Back.Text = "<";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_First
            // 
            this.Button_First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_First.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_First.Location = new System.Drawing.Point(6, 16);
            this.Button_First.Name = "Button_First";
            this.Button_First.Size = new System.Drawing.Size(35, 26);
            this.Button_First.TabIndex = 4;
            this.Button_First.Text = "<<";
            this.Button_First.UseVisualStyleBackColor = true;
            this.Button_First.Click += new System.EventHandler(this.Button_First_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.BackColor = System.Drawing.Color.Transparent;
            this.Label_Version.Location = new System.Drawing.Point(444, 703);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(28, 13);
            this.Label_Version.TabIndex = 4;
            this.Label_Version.Text = "v0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesToolStripMenuItem,
            this.descriptionToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // GroupBox_ExtendedOptions
            // 
            this.GroupBox_ExtendedOptions.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_ExtendedOptions.Controls.Add(this.GroupBox_Filter);
            this.GroupBox_ExtendedOptions.Controls.Add(this.GroupBox_Search);
            this.GroupBox_ExtendedOptions.Controls.Add(this.Button_Copy);
            this.GroupBox_ExtendedOptions.Controls.Add(this.Button_Export);
            this.GroupBox_ExtendedOptions.Controls.Add(this.Button_Reset);
            this.GroupBox_ExtendedOptions.Controls.Add(this.Button_Import);
            this.GroupBox_ExtendedOptions.Controls.Add(this.Button_Random);
            this.GroupBox_ExtendedOptions.Location = new System.Drawing.Point(12, 372);
            this.GroupBox_ExtendedOptions.Name = "GroupBox_ExtendedOptions";
            this.GroupBox_ExtendedOptions.Size = new System.Drawing.Size(464, 311);
            this.GroupBox_ExtendedOptions.TabIndex = 6;
            this.GroupBox_ExtendedOptions.TabStop = false;
            this.GroupBox_ExtendedOptions.Text = "Extended Options";
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.Button_Filter);
            this.GroupBox_Filter.Controls.Add(this.GroupBox_FilterByAnimation);
            this.GroupBox_Filter.Controls.Add(this.GroupBox_FilterByClass);
            this.GroupBox_Filter.Controls.Add(this.GroupBox_FilterByType);
            this.GroupBox_Filter.Location = new System.Drawing.Point(238, 62);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(209, 234);
            this.GroupBox_Filter.TabIndex = 8;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "SearchFilter";
            // 
            // Button_Filter
            // 
            this.Button_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Filter.Location = new System.Drawing.Point(45, 199);
            this.Button_Filter.Name = "Button_Filter";
            this.Button_Filter.Size = new System.Drawing.Size(97, 26);
            this.Button_Filter.TabIndex = 2;
            this.Button_Filter.Text = "Filter";
            this.Button_Filter.UseVisualStyleBackColor = true;
            this.Button_Filter.Click += new System.EventHandler(this.Button_Filter_Click);
            // 
            // GroupBox_FilterByAnimation
            // 
            this.GroupBox_FilterByAnimation.Controls.Add(this.ComboBox_FilterByAnimation);
            this.GroupBox_FilterByAnimation.Location = new System.Drawing.Point(9, 136);
            this.GroupBox_FilterByAnimation.Name = "GroupBox_FilterByAnimation";
            this.GroupBox_FilterByAnimation.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_FilterByAnimation.TabIndex = 1;
            this.GroupBox_FilterByAnimation.TabStop = false;
            this.GroupBox_FilterByAnimation.Text = "by animation";
            // 
            // ComboBox_FilterByAnimation
            // 
            this.ComboBox_FilterByAnimation.FormattingEnabled = true;
            this.ComboBox_FilterByAnimation.Location = new System.Drawing.Point(6, 18);
            this.ComboBox_FilterByAnimation.Name = "ComboBox_FilterByAnimation";
            this.ComboBox_FilterByAnimation.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_FilterByAnimation.TabIndex = 2;
            // 
            // GroupBox_FilterByClass
            // 
            this.GroupBox_FilterByClass.Controls.Add(this.ComboBox_FilterByClass);
            this.GroupBox_FilterByClass.Location = new System.Drawing.Point(9, 83);
            this.GroupBox_FilterByClass.Name = "GroupBox_FilterByClass";
            this.GroupBox_FilterByClass.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_FilterByClass.TabIndex = 1;
            this.GroupBox_FilterByClass.TabStop = false;
            this.GroupBox_FilterByClass.Text = "by class";
            // 
            // ComboBox_FilterByClass
            // 
            this.ComboBox_FilterByClass.FormattingEnabled = true;
            this.ComboBox_FilterByClass.Location = new System.Drawing.Point(6, 18);
            this.ComboBox_FilterByClass.Name = "ComboBox_FilterByClass";
            this.ComboBox_FilterByClass.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_FilterByClass.TabIndex = 1;
            // 
            // GroupBox_FilterByType
            // 
            this.GroupBox_FilterByType.Controls.Add(this.ComboBox_FilterByType);
            this.GroupBox_FilterByType.Location = new System.Drawing.Point(9, 30);
            this.GroupBox_FilterByType.Name = "GroupBox_FilterByType";
            this.GroupBox_FilterByType.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_FilterByType.TabIndex = 0;
            this.GroupBox_FilterByType.TabStop = false;
            this.GroupBox_FilterByType.Text = "by type";
            // 
            // ComboBox_FilterByType
            // 
            this.ComboBox_FilterByType.FormattingEnabled = true;
            this.ComboBox_FilterByType.Location = new System.Drawing.Point(6, 16);
            this.ComboBox_FilterByType.Name = "ComboBox_FilterByType";
            this.ComboBox_FilterByType.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_FilterByType.TabIndex = 0;
            // 
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.Button_Search);
            this.GroupBox_Search.Controls.Add(this.RadioButton_SearchByName);
            this.GroupBox_Search.Controls.Add(this.RadioButton_SearchByID);
            this.GroupBox_Search.Controls.Add(this.RadioButton_SearchByModelID);
            this.GroupBox_Search.Controls.Add(this.GroupBox_SearchByName);
            this.GroupBox_Search.Controls.Add(this.GroupBox_SearchByID);
            this.GroupBox_Search.Controls.Add(this.GroupBox_SearchByModelID);
            this.GroupBox_Search.Location = new System.Drawing.Point(16, 62);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(209, 234);
            this.GroupBox_Search.TabIndex = 7;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search";
            // 
            // Button_Search
            // 
            this.Button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search.Enabled = false;
            this.Button_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.Location = new System.Drawing.Point(53, 200);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(97, 26);
            this.Button_Search.TabIndex = 2;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // RadioButton_SearchByName
            // 
            this.RadioButton_SearchByName.AutoSize = true;
            this.RadioButton_SearchByName.Location = new System.Drawing.Point(15, 140);
            this.RadioButton_SearchByName.Name = "RadioButton_SearchByName";
            this.RadioButton_SearchByName.Size = new System.Drawing.Size(96, 17);
            this.RadioButton_SearchByName.TabIndex = 2;
            this.RadioButton_SearchByName.TabStop = true;
            this.RadioButton_SearchByName.Text = "by model name";
            this.RadioButton_SearchByName.UseVisualStyleBackColor = true;
            this.RadioButton_SearchByName.CheckedChanged += new System.EventHandler(this.RadioButton_SearchByName_CheckedChanged);
            // 
            // RadioButton_SearchByID
            // 
            this.RadioButton_SearchByID.AutoSize = true;
            this.RadioButton_SearchByID.Location = new System.Drawing.Point(15, 76);
            this.RadioButton_SearchByID.Name = "RadioButton_SearchByID";
            this.RadioButton_SearchByID.Size = new System.Drawing.Size(78, 17);
            this.RadioButton_SearchByID.TabIndex = 1;
            this.RadioButton_SearchByID.TabStop = true;
            this.RadioButton_SearchByID.Text = "by entity ID";
            this.RadioButton_SearchByID.UseVisualStyleBackColor = true;
            this.RadioButton_SearchByID.CheckedChanged += new System.EventHandler(this.RadioButton_SearchByID_CheckedChanged);
            // 
            // RadioButton_SearchByModelID
            // 
            this.RadioButton_SearchByModelID.AutoSize = true;
            this.RadioButton_SearchByModelID.Location = new System.Drawing.Point(17, 16);
            this.RadioButton_SearchByModelID.Name = "RadioButton_SearchByModelID";
            this.RadioButton_SearchByModelID.Size = new System.Drawing.Size(81, 17);
            this.RadioButton_SearchByModelID.TabIndex = 0;
            this.RadioButton_SearchByModelID.TabStop = true;
            this.RadioButton_SearchByModelID.Text = "by model ID";
            this.RadioButton_SearchByModelID.UseVisualStyleBackColor = true;
            this.RadioButton_SearchByModelID.CheckedChanged += new System.EventHandler(this.RadioButton_SearchByModelID_CheckedChanged);
            // 
            // GroupBox_SearchByName
            // 
            this.GroupBox_SearchByName.Controls.Add(this.TextBox_SearchByName);
            this.GroupBox_SearchByName.Location = new System.Drawing.Point(9, 154);
            this.GroupBox_SearchByName.Name = "GroupBox_SearchByName";
            this.GroupBox_SearchByName.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_SearchByName.TabIndex = 1;
            this.GroupBox_SearchByName.TabStop = false;
            // 
            // TextBox_SearchByName
            // 
            this.TextBox_SearchByName.Enabled = false;
            this.TextBox_SearchByName.Location = new System.Drawing.Point(6, 18);
            this.TextBox_SearchByName.Name = "TextBox_SearchByName";
            this.TextBox_SearchByName.Size = new System.Drawing.Size(177, 20);
            this.TextBox_SearchByName.TabIndex = 3;
            // 
            // GroupBox_SearchByID
            // 
            this.GroupBox_SearchByID.Controls.Add(this.NumericUpDown_SearchByID);
            this.GroupBox_SearchByID.Location = new System.Drawing.Point(6, 90);
            this.GroupBox_SearchByID.Name = "GroupBox_SearchByID";
            this.GroupBox_SearchByID.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_SearchByID.TabIndex = 1;
            this.GroupBox_SearchByID.TabStop = false;
            // 
            // NumericUpDown_SearchByID
            // 
            this.NumericUpDown_SearchByID.Enabled = false;
            this.NumericUpDown_SearchByID.Location = new System.Drawing.Point(7, 19);
            this.NumericUpDown_SearchByID.Maximum = new decimal(new int[] {
            212,
            0,
            0,
            0});
            this.NumericUpDown_SearchByID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_SearchByID.Name = "NumericUpDown_SearchByID";
            this.NumericUpDown_SearchByID.Size = new System.Drawing.Size(181, 20);
            this.NumericUpDown_SearchByID.TabIndex = 2;
            this.NumericUpDown_SearchByID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GroupBox_SearchByModelID
            // 
            this.GroupBox_SearchByModelID.Controls.Add(this.NumericUpDown_SearchByModelID);
            this.GroupBox_SearchByModelID.Location = new System.Drawing.Point(9, 29);
            this.GroupBox_SearchByModelID.Name = "GroupBox_SearchByModelID";
            this.GroupBox_SearchByModelID.Size = new System.Drawing.Size(194, 45);
            this.GroupBox_SearchByModelID.TabIndex = 0;
            this.GroupBox_SearchByModelID.TabStop = false;
            // 
            // NumericUpDown_SearchByModelID
            // 
            this.NumericUpDown_SearchByModelID.Enabled = false;
            this.NumericUpDown_SearchByModelID.Location = new System.Drawing.Point(7, 17);
            this.NumericUpDown_SearchByModelID.Maximum = new decimal(new int[] {
            611,
            0,
            0,
            0});
            this.NumericUpDown_SearchByModelID.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NumericUpDown_SearchByModelID.Name = "NumericUpDown_SearchByModelID";
            this.NumericUpDown_SearchByModelID.Size = new System.Drawing.Size(181, 20);
            this.NumericUpDown_SearchByModelID.TabIndex = 1;
            this.NumericUpDown_SearchByModelID.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // Button_Copy
            // 
            this.Button_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Copy.Location = new System.Drawing.Point(372, 19);
            this.Button_Copy.Name = "Button_Copy";
            this.Button_Copy.Size = new System.Drawing.Size(75, 28);
            this.Button_Copy.TabIndex = 3;
            this.Button_Copy.Text = "Copy";
            this.Button_Copy.UseVisualStyleBackColor = true;
            this.Button_Copy.Click += new System.EventHandler(this.Button_Copy_Click);
            // 
            // Button_Export
            // 
            this.Button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.Location = new System.Drawing.Point(194, 19);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(75, 28);
            this.Button_Export.TabIndex = 2;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reset.Location = new System.Drawing.Point(105, 19);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 28);
            this.Button_Reset.TabIndex = 1;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_Import
            // 
            this.Button_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Import.Location = new System.Drawing.Point(283, 19);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Size = new System.Drawing.Size(75, 28);
            this.Button_Import.TabIndex = 1;
            this.Button_Import.Text = "Import";
            this.Button_Import.UseVisualStyleBackColor = true;
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Random.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Random.Location = new System.Drawing.Point(16, 19);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(75, 28);
            this.Button_Random.TabIndex = 0;
            this.Button_Random.Text = "Random";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // OpenFileDialog_Import
            // 
            this.OpenFileDialog_Import.FileName = "openFileDialog1";
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SA_MP_Vehicle_List.Properties.Resources.abstract_white_desktop_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 721);
            this.Controls.Add(this.GroupBox_ExtendedOptions);
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.GroupBox_Navigation);
            this.Controls.Add(this.ListBox_List);
            this.Controls.Add(this.GroupBox_Preview);
            this.Controls.Add(this.StatusStrip_Stats);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA-MP Vehicle List";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.GroupBox_Preview.ResumeLayout(false);
            this.GroupBox_Preview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Preview)).EndInit();
            this.GroupBox_Navigation.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBox_ExtendedOptions.ResumeLayout(false);
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_FilterByAnimation.ResumeLayout(false);
            this.GroupBox_FilterByClass.ResumeLayout(false);
            this.GroupBox_FilterByType.ResumeLayout(false);
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            this.GroupBox_SearchByName.ResumeLayout(false);
            this.GroupBox_SearchByName.PerformLayout();
            this.GroupBox_SearchByID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SearchByID)).EndInit();
            this.GroupBox_SearchByModelID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SearchByModelID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip_Stats;
        private System.Windows.Forms.GroupBox GroupBox_Preview;
        private System.Windows.Forms.PictureBox PictureBox_Preview;
        private System.Windows.Forms.Label Label_VehicleName;
        private System.Windows.Forms.Label Label_Class;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Label Label_Animation;
        private System.Windows.Forms.Label Label_ModelID;
        private System.Windows.Forms.Label Label_VehicleModelID;
        private System.Windows.Forms.Label Label_VehicleAnimation;
        private System.Windows.Forms.Label Label_VehicleClass;
        private System.Windows.Forms.Label Label_VehicleType;
        private System.Windows.Forms.ListBox ListBox_List;
        private System.Windows.Forms.GroupBox GroupBox_Navigation;
        private System.Windows.Forms.Button Button_Last;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_First;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBox_ExtendedOptions;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_Import;
        private System.Windows.Forms.Button Button_Random;
        private System.Windows.Forms.Button Button_Copy;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.GroupBox GroupBox_SearchByName;
        private System.Windows.Forms.GroupBox GroupBox_SearchByID;
        private System.Windows.Forms.GroupBox GroupBox_SearchByModelID;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.Button Button_Filter;
        private System.Windows.Forms.GroupBox GroupBox_FilterByAnimation;
        private System.Windows.Forms.GroupBox GroupBox_FilterByClass;
        private System.Windows.Forms.GroupBox GroupBox_FilterByType;
        private System.Windows.Forms.RadioButton RadioButton_SearchByName;
        private System.Windows.Forms.RadioButton RadioButton_SearchByID;
        private System.Windows.Forms.RadioButton RadioButton_SearchByModelID;
        private System.Windows.Forms.TextBox TextBox_SearchByName;
        private System.Windows.Forms.NumericUpDown NumericUpDown_SearchByID;
        private System.Windows.Forms.NumericUpDown NumericUpDown_SearchByModelID;
        private System.Windows.Forms.ComboBox ComboBox_FilterByAnimation;
        private System.Windows.Forms.ComboBox ComboBox_FilterByClass;
        private System.Windows.Forms.ComboBox ComboBox_FilterByType;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_Export;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_Import;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
    }
}

