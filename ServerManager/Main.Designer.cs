namespace ServerManager
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathBtn = new System.Windows.Forms.Button();
            this.ServerSaves_List = new System.Windows.Forms.ListView();
            this.ServerSaves_Group = new System.Windows.Forms.GroupBox();
            this.move_to_minecraft_Btn = new System.Windows.Forms.Button();
            this.ServerSaves_RefreshBtn = new System.Windows.Forms.Button();
            this.ServerSaves_SetmainBtn = new System.Windows.Forms.Button();
            this.ServerSaves_DelBtn = new System.Windows.Forms.Button();
            this.ServerSaves_AddBtn = new System.Windows.Forms.Button();
            this.MinecraftSaves_Group = new System.Windows.Forms.GroupBox();
            this.MinecraftSaves_RefreshBtn = new System.Windows.Forms.Button();
            this.move_to_server_Btn = new System.Windows.Forms.Button();
            this.MinecraftSaves_List = new System.Windows.Forms.ListView();
            this.server_StartBtn = new System.Windows.Forms.Button();
            this.Plugins_Group = new System.Windows.Forms.GroupBox();
            this.plugin_InactiveBtn = new System.Windows.Forms.Button();
            this.plugin_ActiveBtn = new System.Windows.Forms.Button();
            this.plugin_DelBtn = new System.Windows.Forms.Button();
            this.plugin_AddBtn = new System.Windows.Forms.Button();
            this.plugin_RefreshBtn = new System.Windows.Forms.Button();
            this.plugin_List = new System.Windows.Forms.ListView();
            this.Jar_Group = new System.Windows.Forms.GroupBox();
            this.jar_SetmainBtn = new System.Windows.Forms.Button();
            this.JarsList = new System.Windows.Forms.ListView();
            this.ServerOutput = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.CommitBtn = new System.Windows.Forms.Button();
            this.log_group = new System.Windows.Forms.GroupBox();
            this.server_CloseBtn = new System.Windows.Forms.Button();
            this.Properties_Group = new System.Windows.Forms.GroupBox();
            this.leveltypebox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.hardcoreBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.commandblockBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.properties_RefreshBtn = new System.Windows.Forms.Button();
            this.properties_ApplyBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.forcegamemodeBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.spawnnpcBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.spawnmonsterBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pvpBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.oplevelBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.spawnanimalBox = new System.Windows.Forms.ComboBox();
            this.onlinemodeBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.viewdistanceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxplayerBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.initalgamemodeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpawnProtectionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Memory_Group = new System.Windows.Forms.GroupBox();
            this.memory_SetBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.MaxMemoryBox = new System.Windows.Forms.TextBox();
            this.MinMemoryBox = new System.Windows.Forms.TextBox();
            this.OtherSettings_Group = new System.Windows.Forms.GroupBox();
            this.nogui_checkbox = new System.Windows.Forms.CheckBox();
            this.server_ReloadBtn = new System.Windows.Forms.Button();
            this.ServerSaves_Group.SuspendLayout();
            this.MinecraftSaves_Group.SuspendLayout();
            this.Plugins_Group.SuspendLayout();
            this.Jar_Group.SuspendLayout();
            this.log_group.SuspendLayout();
            this.Properties_Group.SuspendLayout();
            this.Memory_Group.SuspendLayout();
            this.OtherSettings_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버 JAR 경로";
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.White;
            this.PathBox.Location = new System.Drawing.Point(91, 13);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(766, 21);
            this.PathBox.TabIndex = 1;
            this.PathBox.Click += new System.EventHandler(this.PathBox_Click);
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            this.PathBox.DoubleClick += new System.EventHandler(this.PathBox_DoubleClick);
            // 
            // PathBtn
            // 
            this.PathBtn.Location = new System.Drawing.Point(863, 12);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(75, 23);
            this.PathBtn.TabIndex = 2;
            this.PathBtn.Text = "경로";
            this.PathBtn.UseVisualStyleBackColor = true;
            this.PathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // ServerSaves_List
            // 
            this.ServerSaves_List.AllowDrop = true;
            this.ServerSaves_List.BackColor = System.Drawing.Color.White;
            this.ServerSaves_List.HideSelection = false;
            this.ServerSaves_List.Location = new System.Drawing.Point(6, 20);
            this.ServerSaves_List.Name = "ServerSaves_List";
            this.ServerSaves_List.Size = new System.Drawing.Size(456, 147);
            this.ServerSaves_List.TabIndex = 3;
            this.ServerSaves_List.UseCompatibleStateImageBehavior = false;
            this.ServerSaves_List.View = System.Windows.Forms.View.List;
            this.ServerSaves_List.SelectedIndexChanged += new System.EventHandler(this.ServerSaves_List_SelectedIndexChanged);
            this.ServerSaves_List.DragDrop += new System.Windows.Forms.DragEventHandler(this.ServerSaves_List_DragDrop);
            this.ServerSaves_List.DragEnter += new System.Windows.Forms.DragEventHandler(this.ServerSaves_List_DragEnter);
            // 
            // ServerSaves_Group
            // 
            this.ServerSaves_Group.Controls.Add(this.move_to_minecraft_Btn);
            this.ServerSaves_Group.Controls.Add(this.ServerSaves_RefreshBtn);
            this.ServerSaves_Group.Controls.Add(this.ServerSaves_SetmainBtn);
            this.ServerSaves_Group.Controls.Add(this.ServerSaves_DelBtn);
            this.ServerSaves_Group.Controls.Add(this.ServerSaves_AddBtn);
            this.ServerSaves_Group.Controls.Add(this.ServerSaves_List);
            this.ServerSaves_Group.Enabled = false;
            this.ServerSaves_Group.Location = new System.Drawing.Point(12, 40);
            this.ServerSaves_Group.Name = "ServerSaves_Group";
            this.ServerSaves_Group.Size = new System.Drawing.Size(468, 205);
            this.ServerSaves_Group.TabIndex = 5;
            this.ServerSaves_Group.TabStop = false;
            this.ServerSaves_Group.Text = "맵 리스트";
            // 
            // move_to_minecraft_Btn
            // 
            this.move_to_minecraft_Btn.Enabled = false;
            this.move_to_minecraft_Btn.Location = new System.Drawing.Point(6, 173);
            this.move_to_minecraft_Btn.Name = "move_to_minecraft_Btn";
            this.move_to_minecraft_Btn.Size = new System.Drawing.Size(89, 23);
            this.move_to_minecraft_Btn.TabIndex = 10;
            this.move_to_minecraft_Btn.Text = "마크 맵에 추가";
            this.move_to_minecraft_Btn.UseVisualStyleBackColor = true;
            this.move_to_minecraft_Btn.Click += new System.EventHandler(this.move_to_minecraft_Btn_Click);
            // 
            // ServerSaves_RefreshBtn
            // 
            this.ServerSaves_RefreshBtn.Location = new System.Drawing.Point(263, 173);
            this.ServerSaves_RefreshBtn.Name = "ServerSaves_RefreshBtn";
            this.ServerSaves_RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerSaves_RefreshBtn.TabIndex = 9;
            this.ServerSaves_RefreshBtn.Text = "새로고침";
            this.ServerSaves_RefreshBtn.UseVisualStyleBackColor = true;
            this.ServerSaves_RefreshBtn.Click += new System.EventHandler(this.ServerSaves_RefreshBtn_Click);
            // 
            // ServerSaves_SetmainBtn
            // 
            this.ServerSaves_SetmainBtn.Enabled = false;
            this.ServerSaves_SetmainBtn.Location = new System.Drawing.Point(359, 173);
            this.ServerSaves_SetmainBtn.Name = "ServerSaves_SetmainBtn";
            this.ServerSaves_SetmainBtn.Size = new System.Drawing.Size(103, 23);
            this.ServerSaves_SetmainBtn.TabIndex = 8;
            this.ServerSaves_SetmainBtn.Text = "메인으로 지정";
            this.ServerSaves_SetmainBtn.UseVisualStyleBackColor = true;
            this.ServerSaves_SetmainBtn.Click += new System.EventHandler(this.ServerSaves_SetmainBtn_Click);
            // 
            // ServerSaves_DelBtn
            // 
            this.ServerSaves_DelBtn.Enabled = false;
            this.ServerSaves_DelBtn.Location = new System.Drawing.Point(182, 173);
            this.ServerSaves_DelBtn.Name = "ServerSaves_DelBtn";
            this.ServerSaves_DelBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerSaves_DelBtn.TabIndex = 7;
            this.ServerSaves_DelBtn.Text = "삭제";
            this.ServerSaves_DelBtn.UseVisualStyleBackColor = true;
            this.ServerSaves_DelBtn.Click += new System.EventHandler(this.ServerSaves_DelBtn_Click);
            // 
            // ServerSaves_AddBtn
            // 
            this.ServerSaves_AddBtn.Location = new System.Drawing.Point(101, 173);
            this.ServerSaves_AddBtn.Name = "ServerSaves_AddBtn";
            this.ServerSaves_AddBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerSaves_AddBtn.TabIndex = 6;
            this.ServerSaves_AddBtn.Text = "추가";
            this.ServerSaves_AddBtn.UseVisualStyleBackColor = true;
            this.ServerSaves_AddBtn.Click += new System.EventHandler(this.ServerSaves_AddBtn_Click);
            // 
            // MinecraftSaves_Group
            // 
            this.MinecraftSaves_Group.Controls.Add(this.MinecraftSaves_RefreshBtn);
            this.MinecraftSaves_Group.Controls.Add(this.move_to_server_Btn);
            this.MinecraftSaves_Group.Controls.Add(this.MinecraftSaves_List);
            this.MinecraftSaves_Group.Enabled = false;
            this.MinecraftSaves_Group.Location = new System.Drawing.Point(486, 41);
            this.MinecraftSaves_Group.Name = "MinecraftSaves_Group";
            this.MinecraftSaves_Group.Size = new System.Drawing.Size(452, 204);
            this.MinecraftSaves_Group.TabIndex = 6;
            this.MinecraftSaves_Group.TabStop = false;
            this.MinecraftSaves_Group.Text = "마인크래프트 맵";
            // 
            // MinecraftSaves_RefreshBtn
            // 
            this.MinecraftSaves_RefreshBtn.Location = new System.Drawing.Point(114, 172);
            this.MinecraftSaves_RefreshBtn.Name = "MinecraftSaves_RefreshBtn";
            this.MinecraftSaves_RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.MinecraftSaves_RefreshBtn.TabIndex = 11;
            this.MinecraftSaves_RefreshBtn.Text = "새로고침";
            this.MinecraftSaves_RefreshBtn.UseVisualStyleBackColor = true;
            this.MinecraftSaves_RefreshBtn.Click += new System.EventHandler(this.MinecraftSaves_RefreshBtn_Click);
            // 
            // move_to_server_Btn
            // 
            this.move_to_server_Btn.Location = new System.Drawing.Point(6, 172);
            this.move_to_server_Btn.Name = "move_to_server_Btn";
            this.move_to_server_Btn.Size = new System.Drawing.Size(102, 23);
            this.move_to_server_Btn.TabIndex = 10;
            this.move_to_server_Btn.Text = "서버 맵에 추가";
            this.move_to_server_Btn.UseVisualStyleBackColor = true;
            this.move_to_server_Btn.Click += new System.EventHandler(this.move_to_server_Btn_Click);
            // 
            // MinecraftSaves_List
            // 
            this.MinecraftSaves_List.HideSelection = false;
            this.MinecraftSaves_List.Location = new System.Drawing.Point(6, 20);
            this.MinecraftSaves_List.Name = "MinecraftSaves_List";
            this.MinecraftSaves_List.Size = new System.Drawing.Size(440, 147);
            this.MinecraftSaves_List.TabIndex = 9;
            this.MinecraftSaves_List.UseCompatibleStateImageBehavior = false;
            this.MinecraftSaves_List.View = System.Windows.Forms.View.List;
            this.MinecraftSaves_List.SelectedIndexChanged += new System.EventHandler(this.MinecraftSaves_List_SelectedIndexChanged);
            this.MinecraftSaves_List.DragDrop += new System.Windows.Forms.DragEventHandler(this.MinecraftSaves_List_DragDrop);
            this.MinecraftSaves_List.DragEnter += new System.Windows.Forms.DragEventHandler(this.MinecraftSaves_List_DragEnter);
            // 
            // server_StartBtn
            // 
            this.server_StartBtn.Location = new System.Drawing.Point(6, 240);
            this.server_StartBtn.Name = "server_StartBtn";
            this.server_StartBtn.Size = new System.Drawing.Size(453, 23);
            this.server_StartBtn.TabIndex = 7;
            this.server_StartBtn.Text = "시작";
            this.server_StartBtn.UseVisualStyleBackColor = true;
            this.server_StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Plugins_Group
            // 
            this.Plugins_Group.Controls.Add(this.plugin_InactiveBtn);
            this.Plugins_Group.Controls.Add(this.plugin_ActiveBtn);
            this.Plugins_Group.Controls.Add(this.plugin_DelBtn);
            this.Plugins_Group.Controls.Add(this.plugin_AddBtn);
            this.Plugins_Group.Controls.Add(this.plugin_RefreshBtn);
            this.Plugins_Group.Controls.Add(this.plugin_List);
            this.Plugins_Group.Location = new System.Drawing.Point(12, 251);
            this.Plugins_Group.Name = "Plugins_Group";
            this.Plugins_Group.Size = new System.Drawing.Size(468, 203);
            this.Plugins_Group.TabIndex = 11;
            this.Plugins_Group.TabStop = false;
            this.Plugins_Group.Text = "플러그인 및 모드";
            // 
            // plugin_InactiveBtn
            // 
            this.plugin_InactiveBtn.Enabled = false;
            this.plugin_InactiveBtn.Location = new System.Drawing.Point(387, 173);
            this.plugin_InactiveBtn.Name = "plugin_InactiveBtn";
            this.plugin_InactiveBtn.Size = new System.Drawing.Size(75, 23);
            this.plugin_InactiveBtn.TabIndex = 17;
            this.plugin_InactiveBtn.Text = "비활성화";
            this.plugin_InactiveBtn.UseVisualStyleBackColor = true;
            this.plugin_InactiveBtn.EnabledChanged += new System.EventHandler(this.plugin_InactiveBtn_EnabledChanged);
            this.plugin_InactiveBtn.Click += new System.EventHandler(this.plugin_InactiveBtn_Click);
            // 
            // plugin_ActiveBtn
            // 
            this.plugin_ActiveBtn.Enabled = false;
            this.plugin_ActiveBtn.Location = new System.Drawing.Point(306, 173);
            this.plugin_ActiveBtn.Name = "plugin_ActiveBtn";
            this.plugin_ActiveBtn.Size = new System.Drawing.Size(75, 23);
            this.plugin_ActiveBtn.TabIndex = 16;
            this.plugin_ActiveBtn.Text = "활성화";
            this.plugin_ActiveBtn.UseVisualStyleBackColor = true;
            this.plugin_ActiveBtn.EnabledChanged += new System.EventHandler(this.plugin_ActiveBtn_EnabledChanged);
            this.plugin_ActiveBtn.Click += new System.EventHandler(this.plugin_ActiveBtn_Click);
            // 
            // plugin_DelBtn
            // 
            this.plugin_DelBtn.Enabled = false;
            this.plugin_DelBtn.Location = new System.Drawing.Point(87, 173);
            this.plugin_DelBtn.Name = "plugin_DelBtn";
            this.plugin_DelBtn.Size = new System.Drawing.Size(75, 23);
            this.plugin_DelBtn.TabIndex = 11;
            this.plugin_DelBtn.Text = "삭제";
            this.plugin_DelBtn.UseVisualStyleBackColor = true;
            this.plugin_DelBtn.Click += new System.EventHandler(this.plugin_DelBtn_Click);
            // 
            // plugin_AddBtn
            // 
            this.plugin_AddBtn.Location = new System.Drawing.Point(6, 173);
            this.plugin_AddBtn.Name = "plugin_AddBtn";
            this.plugin_AddBtn.Size = new System.Drawing.Size(75, 23);
            this.plugin_AddBtn.TabIndex = 11;
            this.plugin_AddBtn.Text = "추가";
            this.plugin_AddBtn.UseVisualStyleBackColor = true;
            this.plugin_AddBtn.Click += new System.EventHandler(this.plugin_AddBtn_Click);
            // 
            // plugin_RefreshBtn
            // 
            this.plugin_RefreshBtn.Location = new System.Drawing.Point(168, 173);
            this.plugin_RefreshBtn.Name = "plugin_RefreshBtn";
            this.plugin_RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.plugin_RefreshBtn.TabIndex = 11;
            this.plugin_RefreshBtn.Text = "새로고침";
            this.plugin_RefreshBtn.UseVisualStyleBackColor = true;
            this.plugin_RefreshBtn.Click += new System.EventHandler(this.plugin_RefreshBtn_Click);
            // 
            // plugin_List
            // 
            this.plugin_List.AllowDrop = true;
            this.plugin_List.BackColor = System.Drawing.Color.White;
            this.plugin_List.HideSelection = false;
            this.plugin_List.Location = new System.Drawing.Point(6, 20);
            this.plugin_List.Name = "plugin_List";
            this.plugin_List.Size = new System.Drawing.Size(456, 147);
            this.plugin_List.TabIndex = 11;
            this.plugin_List.UseCompatibleStateImageBehavior = false;
            this.plugin_List.View = System.Windows.Forms.View.List;
            this.plugin_List.SelectedIndexChanged += new System.EventHandler(this.plugin_List_SelectedIndexChanged);
            this.plugin_List.DragDrop += new System.Windows.Forms.DragEventHandler(this.plugin_List_DragDrop);
            this.plugin_List.DragEnter += new System.Windows.Forms.DragEventHandler(this.plugin_List_DragEnter);
            // 
            // Jar_Group
            // 
            this.Jar_Group.Controls.Add(this.jar_SetmainBtn);
            this.Jar_Group.Controls.Add(this.JarsList);
            this.Jar_Group.Location = new System.Drawing.Point(486, 251);
            this.Jar_Group.Name = "Jar_Group";
            this.Jar_Group.Size = new System.Drawing.Size(452, 203);
            this.Jar_Group.TabIndex = 12;
            this.Jar_Group.TabStop = false;
            this.Jar_Group.Text = "jar파일";
            // 
            // jar_SetmainBtn
            // 
            this.jar_SetmainBtn.Enabled = false;
            this.jar_SetmainBtn.Location = new System.Drawing.Point(6, 173);
            this.jar_SetmainBtn.Name = "jar_SetmainBtn";
            this.jar_SetmainBtn.Size = new System.Drawing.Size(96, 23);
            this.jar_SetmainBtn.TabIndex = 11;
            this.jar_SetmainBtn.Text = "실행 jar로 지정";
            this.jar_SetmainBtn.UseVisualStyleBackColor = true;
            this.jar_SetmainBtn.Click += new System.EventHandler(this.jar_SetmainBtn_Click);
            // 
            // JarsList
            // 
            this.JarsList.AllowDrop = true;
            this.JarsList.BackColor = System.Drawing.Color.White;
            this.JarsList.HideSelection = false;
            this.JarsList.Location = new System.Drawing.Point(6, 20);
            this.JarsList.Name = "JarsList";
            this.JarsList.Size = new System.Drawing.Size(439, 147);
            this.JarsList.TabIndex = 11;
            this.JarsList.UseCompatibleStateImageBehavior = false;
            this.JarsList.View = System.Windows.Forms.View.List;
            this.JarsList.SelectedIndexChanged += new System.EventHandler(this.JarsList_SelectedIndexChanged);
            // 
            // ServerOutput
            // 
            this.ServerOutput.BackColor = System.Drawing.Color.White;
            this.ServerOutput.Location = new System.Drawing.Point(6, 20);
            this.ServerOutput.Multiline = true;
            this.ServerOutput.Name = "ServerOutput";
            this.ServerOutput.ReadOnly = true;
            this.ServerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ServerOutput.Size = new System.Drawing.Size(913, 187);
            this.ServerOutput.TabIndex = 0;
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.White;
            this.InputBox.Enabled = false;
            this.InputBox.Location = new System.Drawing.Point(6, 213);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(832, 21);
            this.InputBox.TabIndex = 1;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // CommitBtn
            // 
            this.CommitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CommitBtn.Enabled = false;
            this.CommitBtn.Location = new System.Drawing.Point(844, 212);
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(75, 23);
            this.CommitBtn.TabIndex = 2;
            this.CommitBtn.Text = "전송";
            this.CommitBtn.UseVisualStyleBackColor = true;
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // log_group
            // 
            this.log_group.Controls.Add(this.CommitBtn);
            this.log_group.Controls.Add(this.InputBox);
            this.log_group.Controls.Add(this.server_CloseBtn);
            this.log_group.Controls.Add(this.ServerOutput);
            this.log_group.Controls.Add(this.server_StartBtn);
            this.log_group.Location = new System.Drawing.Point(12, 460);
            this.log_group.Name = "log_group";
            this.log_group.Size = new System.Drawing.Size(926, 269);
            this.log_group.TabIndex = 12;
            this.log_group.TabStop = false;
            this.log_group.Text = "서버 명령";
            // 
            // server_CloseBtn
            // 
            this.server_CloseBtn.Enabled = false;
            this.server_CloseBtn.Location = new System.Drawing.Point(466, 240);
            this.server_CloseBtn.Name = "server_CloseBtn";
            this.server_CloseBtn.Size = new System.Drawing.Size(454, 23);
            this.server_CloseBtn.TabIndex = 14;
            this.server_CloseBtn.Text = "서버 닫기";
            this.server_CloseBtn.UseVisualStyleBackColor = true;
            this.server_CloseBtn.Click += new System.EventHandler(this.servercloseBtn_Click);
            // 
            // Properties_Group
            // 
            this.Properties_Group.Controls.Add(this.leveltypebox);
            this.Properties_Group.Controls.Add(this.label22);
            this.Properties_Group.Controls.Add(this.hardcoreBox);
            this.Properties_Group.Controls.Add(this.label18);
            this.Properties_Group.Controls.Add(this.commandblockBox);
            this.Properties_Group.Controls.Add(this.label17);
            this.Properties_Group.Controls.Add(this.properties_RefreshBtn);
            this.Properties_Group.Controls.Add(this.properties_ApplyBtn);
            this.Properties_Group.Controls.Add(this.label16);
            this.Properties_Group.Controls.Add(this.forcegamemodeBox);
            this.Properties_Group.Controls.Add(this.label15);
            this.Properties_Group.Controls.Add(this.spawnnpcBox);
            this.Properties_Group.Controls.Add(this.label14);
            this.Properties_Group.Controls.Add(this.spawnmonsterBox);
            this.Properties_Group.Controls.Add(this.label13);
            this.Properties_Group.Controls.Add(this.pvpBox);
            this.Properties_Group.Controls.Add(this.label12);
            this.Properties_Group.Controls.Add(this.oplevelBox);
            this.Properties_Group.Controls.Add(this.label11);
            this.Properties_Group.Controls.Add(this.spawnanimalBox);
            this.Properties_Group.Controls.Add(this.onlinemodeBox);
            this.Properties_Group.Controls.Add(this.label10);
            this.Properties_Group.Controls.Add(this.label9);
            this.Properties_Group.Controls.Add(this.viewdistanceBox);
            this.Properties_Group.Controls.Add(this.label8);
            this.Properties_Group.Controls.Add(this.label7);
            this.Properties_Group.Controls.Add(this.maxplayerBox);
            this.Properties_Group.Controls.Add(this.label6);
            this.Properties_Group.Controls.Add(this.initalgamemodeBox);
            this.Properties_Group.Controls.Add(this.label5);
            this.Properties_Group.Controls.Add(this.label4);
            this.Properties_Group.Controls.Add(this.SpawnProtectionBox);
            this.Properties_Group.Controls.Add(this.label3);
            this.Properties_Group.Controls.Add(this.difficultyBox);
            this.Properties_Group.Controls.Add(this.label2);
            this.Properties_Group.Location = new System.Drawing.Point(945, 7);
            this.Properties_Group.Name = "Properties_Group";
            this.Properties_Group.Size = new System.Drawing.Size(215, 478);
            this.Properties_Group.TabIndex = 13;
            this.Properties_Group.TabStop = false;
            this.Properties_Group.Text = "서버 설정";
            // 
            // leveltypebox
            // 
            this.leveltypebox.BackColor = System.Drawing.Color.White;
            this.leveltypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leveltypebox.FormattingEnabled = true;
            this.leveltypebox.Items.AddRange(new object[] {
            "평지",
            "일반",
            "레거시"});
            this.leveltypebox.Location = new System.Drawing.Point(104, 410);
            this.leveltypebox.Name = "leveltypebox";
            this.leveltypebox.Size = new System.Drawing.Size(81, 22);
            this.leveltypebox.TabIndex = 35;
            this.leveltypebox.Tag = "level-type";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 413);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 14);
            this.label22.TabIndex = 34;
            this.label22.Text = "기본 생성 지형";
            // 
            // hardcoreBox
            // 
            this.hardcoreBox.BackColor = System.Drawing.Color.White;
            this.hardcoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardcoreBox.FormattingEnabled = true;
            this.hardcoreBox.Items.AddRange(new object[] {
            "활성화",
            "비활성화"});
            this.hardcoreBox.Location = new System.Drawing.Point(104, 382);
            this.hardcoreBox.Name = "hardcoreBox";
            this.hardcoreBox.Size = new System.Drawing.Size(81, 22);
            this.hardcoreBox.TabIndex = 33;
            this.hardcoreBox.Tag = "hardcore";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 385);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 14);
            this.label18.TabIndex = 32;
            this.label18.Text = "하드코어";
            // 
            // commandblockBox
            // 
            this.commandblockBox.BackColor = System.Drawing.Color.White;
            this.commandblockBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commandblockBox.FormattingEnabled = true;
            this.commandblockBox.Items.AddRange(new object[] {
            "허용",
            "제한"});
            this.commandblockBox.Location = new System.Drawing.Point(104, 354);
            this.commandblockBox.Name = "commandblockBox";
            this.commandblockBox.Size = new System.Drawing.Size(81, 22);
            this.commandblockBox.TabIndex = 31;
            this.commandblockBox.Tag = "enable-command-block";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 14);
            this.label17.TabIndex = 30;
            this.label17.Text = "커맨드 블럭 사용";
            // 
            // properties_RefreshBtn
            // 
            this.properties_RefreshBtn.Location = new System.Drawing.Point(110, 445);
            this.properties_RefreshBtn.Name = "properties_RefreshBtn";
            this.properties_RefreshBtn.Size = new System.Drawing.Size(99, 23);
            this.properties_RefreshBtn.TabIndex = 29;
            this.properties_RefreshBtn.Text = "새로고침";
            this.properties_RefreshBtn.UseVisualStyleBackColor = true;
            this.properties_RefreshBtn.Click += new System.EventHandler(this.properties_RefreshBtn_Click);
            // 
            // properties_ApplyBtn
            // 
            this.properties_ApplyBtn.Location = new System.Drawing.Point(6, 445);
            this.properties_ApplyBtn.Name = "properties_ApplyBtn";
            this.properties_ApplyBtn.Size = new System.Drawing.Size(99, 23);
            this.properties_ApplyBtn.TabIndex = 28;
            this.properties_ApplyBtn.Text = "적용";
            this.properties_ApplyBtn.UseVisualStyleBackColor = true;
            this.properties_ApplyBtn.Click += new System.EventHandler(this.properties_ApplyBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 14);
            this.label16.TabIndex = 27;
            this.label16.Text = "칸";
            // 
            // forcegamemodeBox
            // 
            this.forcegamemodeBox.BackColor = System.Drawing.Color.White;
            this.forcegamemodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forcegamemodeBox.FormattingEnabled = true;
            this.forcegamemodeBox.Items.AddRange(new object[] {
            "활성화",
            "비활성화"});
            this.forcegamemodeBox.Location = new System.Drawing.Point(104, 102);
            this.forcegamemodeBox.Name = "forcegamemodeBox";
            this.forcegamemodeBox.Size = new System.Drawing.Size(81, 22);
            this.forcegamemodeBox.TabIndex = 26;
            this.forcegamemodeBox.Tag = "force-gamemode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "강제 게임 모드";
            // 
            // spawnnpcBox
            // 
            this.spawnnpcBox.BackColor = System.Drawing.Color.White;
            this.spawnnpcBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spawnnpcBox.FormattingEnabled = true;
            this.spawnnpcBox.Items.AddRange(new object[] {
            "활성화",
            "비활성화"});
            this.spawnnpcBox.Location = new System.Drawing.Point(104, 298);
            this.spawnnpcBox.Name = "spawnnpcBox";
            this.spawnnpcBox.Size = new System.Drawing.Size(81, 22);
            this.spawnnpcBox.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "npc 생성";
            // 
            // spawnmonsterBox
            // 
            this.spawnmonsterBox.BackColor = System.Drawing.Color.White;
            this.spawnmonsterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spawnmonsterBox.FormattingEnabled = true;
            this.spawnmonsterBox.Items.AddRange(new object[] {
            "활성화",
            "비활성화"});
            this.spawnmonsterBox.Location = new System.Drawing.Point(104, 270);
            this.spawnmonsterBox.Name = "spawnmonsterBox";
            this.spawnmonsterBox.Size = new System.Drawing.Size(81, 22);
            this.spawnmonsterBox.TabIndex = 22;
            this.spawnmonsterBox.Tag = "spawn-monsters";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "몬스터 생성";
            // 
            // pvpBox
            // 
            this.pvpBox.BackColor = System.Drawing.Color.White;
            this.pvpBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pvpBox.FormattingEnabled = true;
            this.pvpBox.Items.AddRange(new object[] {
            "허용",
            "제한"});
            this.pvpBox.Location = new System.Drawing.Point(104, 242);
            this.pvpBox.Name = "pvpBox";
            this.pvpBox.Size = new System.Drawing.Size(81, 22);
            this.pvpBox.TabIndex = 20;
            this.pvpBox.Tag = "pvp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "pvp";
            // 
            // oplevelBox
            // 
            this.oplevelBox.BackColor = System.Drawing.Color.White;
            this.oplevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oplevelBox.FormattingEnabled = true;
            this.oplevelBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.oplevelBox.Location = new System.Drawing.Point(104, 214);
            this.oplevelBox.Name = "oplevelBox";
            this.oplevelBox.Size = new System.Drawing.Size(81, 22);
            this.oplevelBox.TabIndex = 18;
            this.oplevelBox.Tag = "op-permission-level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "op권한 레벨";
            // 
            // spawnanimalBox
            // 
            this.spawnanimalBox.BackColor = System.Drawing.Color.White;
            this.spawnanimalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spawnanimalBox.FormattingEnabled = true;
            this.spawnanimalBox.Items.AddRange(new object[] {
            "활성화",
            "비활성화"});
            this.spawnanimalBox.Location = new System.Drawing.Point(104, 326);
            this.spawnanimalBox.Name = "spawnanimalBox";
            this.spawnanimalBox.Size = new System.Drawing.Size(81, 22);
            this.spawnanimalBox.TabIndex = 16;
            this.spawnanimalBox.Tag = "spawn-animals";
            // 
            // onlinemodeBox
            // 
            this.onlinemodeBox.BackColor = System.Drawing.Color.White;
            this.onlinemodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onlinemodeBox.FormattingEnabled = true;
            this.onlinemodeBox.Items.AddRange(new object[] {
            "허용",
            "제한"});
            this.onlinemodeBox.Location = new System.Drawing.Point(104, 186);
            this.onlinemodeBox.Name = "onlinemodeBox";
            this.onlinemodeBox.Size = new System.Drawing.Size(81, 22);
            this.onlinemodeBox.TabIndex = 15;
            this.onlinemodeBox.Tag = "online-mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "동물 생성";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "정품만 접속";
            // 
            // viewdistanceBox
            // 
            this.viewdistanceBox.BackColor = System.Drawing.Color.White;
            this.viewdistanceBox.Location = new System.Drawing.Point(104, 158);
            this.viewdistanceBox.Multiline = true;
            this.viewdistanceBox.Name = "viewdistanceBox";
            this.viewdistanceBox.Size = new System.Drawing.Size(81, 22);
            this.viewdistanceBox.TabIndex = 11;
            this.viewdistanceBox.Tag = "view-distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "시야 범위";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "명";
            // 
            // maxplayerBox
            // 
            this.maxplayerBox.BackColor = System.Drawing.Color.White;
            this.maxplayerBox.Location = new System.Drawing.Point(104, 130);
            this.maxplayerBox.Multiline = true;
            this.maxplayerBox.Name = "maxplayerBox";
            this.maxplayerBox.Size = new System.Drawing.Size(81, 22);
            this.maxplayerBox.TabIndex = 8;
            this.maxplayerBox.Tag = "max-players";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "최대 인원";
            // 
            // initalgamemodeBox
            // 
            this.initalgamemodeBox.BackColor = System.Drawing.Color.White;
            this.initalgamemodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.initalgamemodeBox.FormattingEnabled = true;
            this.initalgamemodeBox.Items.AddRange(new object[] {
            "서바이벌",
            "크레이티브",
            "모험자",
            "관전자"});
            this.initalgamemodeBox.Location = new System.Drawing.Point(104, 74);
            this.initalgamemodeBox.Name = "initalgamemodeBox";
            this.initalgamemodeBox.Size = new System.Drawing.Size(81, 22);
            this.initalgamemodeBox.TabIndex = 6;
            this.initalgamemodeBox.Tag = "gamemode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "기본 게임 모드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "칸";
            // 
            // SpawnProtectionBox
            // 
            this.SpawnProtectionBox.BackColor = System.Drawing.Color.White;
            this.SpawnProtectionBox.Location = new System.Drawing.Point(104, 46);
            this.SpawnProtectionBox.Multiline = true;
            this.SpawnProtectionBox.Name = "SpawnProtectionBox";
            this.SpawnProtectionBox.Size = new System.Drawing.Size(81, 22);
            this.SpawnProtectionBox.TabIndex = 3;
            this.SpawnProtectionBox.Tag = "spawn-protection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "스폰 지점 보호";
            // 
            // difficultyBox
            // 
            this.difficultyBox.BackColor = System.Drawing.Color.White;
            this.difficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "평화로움",
            "쉬움",
            "보통",
            "어려움"});
            this.difficultyBox.Location = new System.Drawing.Point(104, 19);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(81, 22);
            this.difficultyBox.TabIndex = 1;
            this.difficultyBox.Tag = "difficulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "기본 난이도";
            // 
            // Memory_Group
            // 
            this.Memory_Group.Controls.Add(this.memory_SetBtn);
            this.Memory_Group.Controls.Add(this.label21);
            this.Memory_Group.Controls.Add(this.label20);
            this.Memory_Group.Controls.Add(this.label19);
            this.Memory_Group.Controls.Add(this.MaxMemoryBox);
            this.Memory_Group.Controls.Add(this.MinMemoryBox);
            this.Memory_Group.Location = new System.Drawing.Point(944, 491);
            this.Memory_Group.Name = "Memory_Group";
            this.Memory_Group.Size = new System.Drawing.Size(215, 122);
            this.Memory_Group.TabIndex = 15;
            this.Memory_Group.TabStop = false;
            this.Memory_Group.Text = "메모리 설정";
            // 
            // memory_SetBtn
            // 
            this.memory_SetBtn.Location = new System.Drawing.Point(6, 91);
            this.memory_SetBtn.Name = "memory_SetBtn";
            this.memory_SetBtn.Size = new System.Drawing.Size(203, 23);
            this.memory_SetBtn.TabIndex = 5;
            this.memory_SetBtn.Text = "설정";
            this.memory_SetBtn.UseVisualStyleBackColor = true;
            this.memory_SetBtn.Click += new System.EventHandler(this.memory_SetBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(124, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 14);
            this.label21.TabIndex = 4;
            this.label21.Text = "최대(MB)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(98, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 14);
            this.label20.TabIndex = 3;
            this.label20.Text = "~";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 14);
            this.label19.TabIndex = 2;
            this.label19.Text = "최소(MB)";
            // 
            // MaxMemoryBox
            // 
            this.MaxMemoryBox.Location = new System.Drawing.Point(120, 51);
            this.MaxMemoryBox.Name = "MaxMemoryBox";
            this.MaxMemoryBox.Size = new System.Drawing.Size(65, 21);
            this.MaxMemoryBox.TabIndex = 1;
            this.MaxMemoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinMemoryBox
            // 
            this.MinMemoryBox.Location = new System.Drawing.Point(27, 51);
            this.MinMemoryBox.Name = "MinMemoryBox";
            this.MinMemoryBox.Size = new System.Drawing.Size(65, 21);
            this.MinMemoryBox.TabIndex = 0;
            this.MinMemoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OtherSettings_Group
            // 
            this.OtherSettings_Group.Controls.Add(this.nogui_checkbox);
            this.OtherSettings_Group.Controls.Add(this.server_ReloadBtn);
            this.OtherSettings_Group.Location = new System.Drawing.Point(945, 619);
            this.OtherSettings_Group.Name = "OtherSettings_Group";
            this.OtherSettings_Group.Size = new System.Drawing.Size(215, 110);
            this.OtherSettings_Group.TabIndex = 16;
            this.OtherSettings_Group.TabStop = false;
            this.OtherSettings_Group.Text = "서버 관련 설정 및 명령";
            // 
            // nogui_checkbox
            // 
            this.nogui_checkbox.AutoSize = true;
            this.nogui_checkbox.Location = new System.Drawing.Point(26, 37);
            this.nogui_checkbox.Name = "nogui_checkbox";
            this.nogui_checkbox.Size = new System.Drawing.Size(165, 18);
            this.nogui_checkbox.TabIndex = 18;
            this.nogui_checkbox.Text = "서버 실행시 나오는 gui 끄기";
            this.nogui_checkbox.UseVisualStyleBackColor = true;
            // 
            // server_ReloadBtn
            // 
            this.server_ReloadBtn.Location = new System.Drawing.Point(6, 69);
            this.server_ReloadBtn.Name = "server_ReloadBtn";
            this.server_ReloadBtn.Size = new System.Drawing.Size(203, 23);
            this.server_ReloadBtn.TabIndex = 17;
            this.server_ReloadBtn.Text = "서버 다시 불러오기";
            this.server_ReloadBtn.UseVisualStyleBackColor = true;
            this.server_ReloadBtn.Click += new System.EventHandler(this.server_ReloadBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 741);
            this.Controls.Add(this.OtherSettings_Group);
            this.Controls.Add(this.Memory_Group);
            this.Controls.Add(this.Properties_Group);
            this.Controls.Add(this.Jar_Group);
            this.Controls.Add(this.log_group);
            this.Controls.Add(this.Plugins_Group);
            this.Controls.Add(this.MinecraftSaves_Group);
            this.Controls.Add(this.ServerSaves_Group);
            this.Controls.Add(this.PathBtn);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinecarftSeverManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.ServerSaves_Group.ResumeLayout(false);
            this.MinecraftSaves_Group.ResumeLayout(false);
            this.Plugins_Group.ResumeLayout(false);
            this.Jar_Group.ResumeLayout(false);
            this.log_group.ResumeLayout(false);
            this.log_group.PerformLayout();
            this.Properties_Group.ResumeLayout(false);
            this.Properties_Group.PerformLayout();
            this.Memory_Group.ResumeLayout(false);
            this.Memory_Group.PerformLayout();
            this.OtherSettings_Group.ResumeLayout(false);
            this.OtherSettings_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button PathBtn;
        private System.Windows.Forms.ListView ServerSaves_List;
        private System.Windows.Forms.GroupBox ServerSaves_Group;
        private System.Windows.Forms.Button ServerSaves_AddBtn;
        private System.Windows.Forms.Button ServerSaves_SetmainBtn;
        private System.Windows.Forms.Button ServerSaves_DelBtn;
        private System.Windows.Forms.GroupBox MinecraftSaves_Group;
        private System.Windows.Forms.Button ServerSaves_RefreshBtn;
        private System.Windows.Forms.ListView MinecraftSaves_List;
        private System.Windows.Forms.Button move_to_minecraft_Btn;
        private System.Windows.Forms.Button move_to_server_Btn;
        private System.Windows.Forms.Button server_StartBtn;
        private System.Windows.Forms.Button MinecraftSaves_RefreshBtn;
        private System.Windows.Forms.GroupBox Plugins_Group;
        private System.Windows.Forms.ListView plugin_List;
        private System.Windows.Forms.Button plugin_RefreshBtn;
        private System.Windows.Forms.GroupBox Jar_Group;
        private System.Windows.Forms.Button jar_SetmainBtn;
        private System.Windows.Forms.ListView JarsList;
        private System.Windows.Forms.TextBox ServerOutput;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button CommitBtn;
        private System.Windows.Forms.GroupBox log_group;
        private System.Windows.Forms.GroupBox Properties_Group;
        private System.Windows.Forms.ComboBox forcegamemodeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox spawnnpcBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox spawnmonsterBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox pvpBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox oplevelBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox spawnanimalBox;
        private System.Windows.Forms.ComboBox onlinemodeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox viewdistanceBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxplayerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox initalgamemodeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SpawnProtectionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox difficultyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button properties_RefreshBtn;
        private System.Windows.Forms.Button properties_ApplyBtn;
        private System.Windows.Forms.ComboBox commandblockBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox hardcoreBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button server_CloseBtn;
        private System.Windows.Forms.Button plugin_DelBtn;
        private System.Windows.Forms.Button plugin_AddBtn;
        private System.Windows.Forms.GroupBox Memory_Group;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox MaxMemoryBox;
        private System.Windows.Forms.TextBox MinMemoryBox;
        private System.Windows.Forms.Button memory_SetBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button plugin_InactiveBtn;
        private System.Windows.Forms.Button plugin_ActiveBtn;
        private System.Windows.Forms.GroupBox OtherSettings_Group;
        private System.Windows.Forms.Button server_ReloadBtn;
        private System.Windows.Forms.ComboBox leveltypebox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox nogui_checkbox;
    }
}

