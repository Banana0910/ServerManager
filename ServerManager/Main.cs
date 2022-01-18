using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ServerManager
{
    public partial class Main : Form
    {
        public Main() { InitializeComponent(); }

         //                                     //
        //             정의 파트               //
       //                                    //

        Process p = new Process();
        string ServerPath = "";
        string RunJarpath = "";
        string pluginspath = "";
        string server_properties_path = "";
        string level_name = "";

        bool gamemodenumbering = false;
        bool difficultynumbering = false;
        string MinecraftSavesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft\\saves");

        string maxmemory = "";
        string minmemory = "";

        //             함수 파트               //

        // 목적 : properties에 원하는 key가 없을 경우, 추가를 해야함
        // 목적을 이룰려면 리스트로 미리 불러오는게 맞나..?

        // 문제 : 각 property 형식마다 반환하는 value가 다름
       
        // 프로퍼티 관리 함수
        private List<string> return_property(List<string> list)
        {
            /* textbox 형식
                SpawnProtectionBox
                maxplayerBox
                viewdistanceBox
            */
            Control[] properties = new Control[]
            { 
                difficultyBox, SpawnProtectionBox, initalgamemodeBox, forcegamemodeBox, maxplayerBox,
                viewdistanceBox, onlinemodeBox, oplevelBox, pvpBox, spawnmonsterBox, spawnnpcBox,
                spawnanimalBox, commandblockBox, hardcoreBox, leveltypebox 
            };
            foreach (Control cb in properties)
            {
            }
            return null;
        }

        // 확인 함수
        private bool CheckWorldDir(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach(FileInfo file in directoryInfo.GetFiles())
                if (file.Name == "level.dat")
                    return true;
            return false;
        }
        private bool CheckSeverDir(string path) //11/15 기존에는 properties파일 유무로 서버 폴더인지 감별했으나, 생각해보면 아무것도 안한 초기 서버 폴더의 상태에는 properties파일이 없기에 jar로 구별
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo i in di.GetFiles())
                if (i.Extension == ".jar")
                    return true;
            return false;
        }
        private void CheckPluginDir()
        {
            DirectoryInfo di = new DirectoryInfo(ServerPath);
            foreach (DirectoryInfo i in di.GetDirectories())
                if (i.Name == "plugins" || i.Name == "mods")
                    pluginspath = i.FullName;
        }
        private void CheckProperties()
        {
            string temp_path = Path.Combine(ServerPath, "server.properties");
            if (File.Exists(temp_path))
                server_properties_path = temp_path;
        }

        //새로고침 함수들
        private void RefreshJarFiles()
        {
            JarsList.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(ServerPath);
            foreach (FileInfo i in di.GetFiles())
            {
                if (i.Extension == ".jar")
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileNameWithoutExtension(i.FullName));
                    lvi.SubItems.Add(i.FullName);
                    JarsList.Items.Add(lvi);
                }
            }
            if (JarsList.Items.Count < 1)
            {
                RunJarpath = JarsList.Items[0].SubItems[1].Text;
                JarsList.Items[0].BackColor = Color.Red;
                JarsList.Items[0].ForeColor = Color.White;
            }
        }
        private void RefreshPlugins()
        {
            plugin_List.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(pluginspath);
            foreach (FileInfo i in di.GetFiles())
            {
                if (i.Extension == ".jar") //활성화된 모드 또는 플러그인 일때
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileNameWithoutExtension(i.FullName));
                    lvi.SubItems.Add(i.FullName);
                    plugin_List.Items.Add(lvi);
                }
                else if (i.Extension == ".sleep") // 비활성화 된것일때
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileNameWithoutExtension(i.FullName));
                    lvi.SubItems.Add(i.FullName);
                    lvi.ForeColor = Color.Gray;
                    plugin_List.Items.Add(lvi);
                }
            }
        }
        private void RefreshServerSaves()
        {
            ServerSaves_List.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(ServerPath);
            foreach (DirectoryInfo i in di.GetDirectories())
            {
                foreach (FileInfo j in i.GetFiles())
                {
                    if (j.Name == "level.dat")
                    {
                        string name = i.Name;
                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(i.FullName);
                        lvi.BackColor = (name == level_name) ? Color.Red : Color.White; //level-name에 해당되는 맵이면 빨간줄 칠하기
                        lvi.ForeColor = (name == level_name) ? Color.White : Color.Black; //위와 동일
                        ServerSaves_List.Items.Add(lvi);
                    }
                }
            }
        }
        private void RefreshProperties()
        { 
            if (!string.IsNullOrWhiteSpace(server_properties_path))
            {
                FileStream fs = new FileStream(server_properties_path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (true)
                {
                    string Readline = sr.ReadLine();
                    if (Readline == null)
                    {
                        sr.Close();
                        fs.Close();
                        break;
                    }  //자~ 11/15 지금 부터 간략히 코드 수정하겠슴당
                    else if (Readline.StartsWith("level-name"))level_name = Readline.Split('=')[1];
                    else if (Readline.StartsWith("difficulty"))difficultyBox.SelectedIndex = OutputDifficulty(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("spawn-protection")) SpawnProtectionBox.Text = Readline.Split('=')[1];
                    else if (Readline.StartsWith("gamemode")) initalgamemodeBox.SelectedIndex = OutputGamemode(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("force-gamemode")) forcegamemodeBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("max-players")) maxplayerBox.Text = Readline.Split('=')[1];
                    else if (Readline.StartsWith("view-distance")) viewdistanceBox.Text = Readline.Split('=')[1];
                    else if (Readline.StartsWith("online-mode")) onlinemodeBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("op-permission-level")) oplevelBox.Text = Readline.Split('=')[1];
                    else if (Readline.StartsWith("pvp")) pvpBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("spawn-monsters")) spawnmonsterBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("spawn-npcs")) spawnnpcBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("spawn-animals")) spawnanimalBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("enable-command-block"))  commandblockBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("hardcore"))  hardcoreBox.SelectedIndex = OutputCondition(Readline.Split('=')[1]);
                    else if (Readline.StartsWith("level-type"))  leveltypebox.SelectedIndex = OutputLeveltype(Readline.Split('=')[1]);
                    //엄.. 수정하니까 겁나 복잡해보이네
                }
            }
        }
        private void RefreshMinecraftSaves()
        {
            MinecraftSaves_List.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(MinecraftSavesPath);
            foreach (DirectoryInfo i in di.GetDirectories())
            {
                ListViewItem lvi = new ListViewItem(i.Name);
                lvi.SubItems.Add(i.FullName);
                MinecraftSaves_List.Items.Add(lvi);
            }
        }
        private void RefreshAll()
        {
            RefreshProperties();
            RefreshServerSaves();
            RefreshJarFiles();
            RefreshPlugins();
            RefreshMinecraftSaves();
        }

        //조건 출력 함수들
        private int OutputDifficulty(string text)
        {
            int temp;
            if (!int.TryParse(text, out temp))
            {
                difficultynumbering = false;
                switch(text)
                {
                    case "peaceful" : return 0;
                    case "easy" : return 1;
                    case "normal" : return 2;
                    case "hard" : return 3;
                }
            }
            difficultynumbering = true;
            return temp;
        }
        private int OutputGamemode(string text)
        {
            int temp;
            if (!int.TryParse(text, out temp)) //text가 숫자로 변환안되면 text는 숫자가 아닌것이니 텍스트로 출력
            {
                gamemodenumbering = false;
                switch(text)
                {
                    case "survival" : return 0;
                    case "creative" : return 1;
                    case "adventure" : return 2;
                    case "spectator" : return 3;
                    default : return 0;
                }
            }
            gamemodenumbering = true;
            return temp;
        }
        private int OutputLeveltype (string text)
        {
            switch(text)
            {
                case "FLAT" : return 0;
                case "DEFAULT" : return 1;
                case "LEGACY" : return 2;
                default : return -1;
            }
        }
        private int OutputCondition(string value)
        {
            if (value == "true")
                return 0;
            return 1;
        }

        private string ReturnDifficulty (int value)
        {
            if (!difficultynumbering)
            {
                switch(value)
                {
                    case 0 : return "peaceful";
                    case 1 : return "easy";
                    case 2 : return "normal";
                    case 3 : return "hard";
                }
            }
            return value.ToString();
        }
        private string ReturnGamemode (int value)
        {
            if (!gamemodenumbering) //gamemode가 숫자로 되있는버전, 텍스트로 되있는 버전이 따로따로있어서 이걸 추가해놓은것
            {
                switch(value)
                {
                    case 0 : return "survival";
                    case 1 : return "creative";
                    case 2 : return "adventure";
                    case 3 : return "spectator";
                    default : return "survival";
                }
            }
            return value.ToString();
        }
        private string ReturnLeveltype(int value)
        {
            switch(value)
            {
                case 0 : return "FLAT";
                case 1 : return "DEFAULT";
                case 2 : return "LEGACY";
                default : return "None";
            }
        }
        private string ReturnCondition(int value)
        {
            if (value == 0)
                return "true";
            return "false";
        }

        //그룹 활성화 함수들
        private void ActiveManage(string path)
        {
            //일단 요소들 전부 리프레쉬
            PathBox.Text = path;
            CheckPluginDir();
            CheckProperties();
            RefreshAll();
            //Group들 Enable조정
            ServerSaves_Group.Enabled = (ServerPath != "") ? true : false;
            MinecraftSaves_Group.Enabled = (MinecraftSavesPath != "") ? true : false;
            Plugins_Group.Enabled = (pluginspath != "") ? true : false;
            Jar_Group.Enabled = (ServerPath != "") ? true : false;
            Properties_Group.Enabled = (server_properties_path != "") ? true : false;
            Memory_Group.Enabled = true;
            OtherSettings_Group.Enabled = true;
            log_group.Enabled = true;
        }
        private void InactiveManage()
        {
            //InactiveManage를 쓰는 구간중에 config에있는 값 삭제하는게 공통으로 들어가있어서 넣음
            Properties.Settings.Default.ServerPath = "";
            Properties.Settings.Default.Save();
            //그룹 enable을 다 false로 지정
            ServerSaves_Group.Enabled = false;
            MinecraftSaves_Group.Enabled = false;
            Plugins_Group.Enabled = false;
            Jar_Group.Enabled = false;
            Memory_Group.Enabled = false;
            OtherSettings_Group.Enabled = false;
            Properties_Group.Enabled = false;
            log_group.Enabled = false;
        }

        //기타 함수들
        private void SelectMinecraftFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.GetDirectories(fbd.SelectedPath).Contains(fbd.SelectedPath))
                {
                    MessageBox.Show("선택하신 폴더는 마인크래프트 폴더가 아닌듯합니다", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SelectMinecraftFolder(); //곧바로 재귀 ㅋㅋ
                }
                else
                {
                    MinecraftSavesPath = fbd.SelectedPath;
                    Properties.Settings.Default.MinecraftSavePath = MinecraftSavesPath;
                }
            }
            else
            {
                MessageBox.Show("어딜 도망가시려고 하려고 한 건 다하셔야지", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectMinecraftFolder(); //곧바로 붙잡고 재귘ㅋ
            }
        }
        private void Change_able_logging(bool status)
        {
            server_StartBtn.Enabled = !status;
            server_ReloadBtn.Enabled = status;
            InputBox.Enabled = status;
            server_CloseBtn.Enabled = status;
            CommitBtn.Enabled = status;
        }
        private void WriteProperties()
        {
            //string properties = "";
            List<string> properties = new List<string>();
            FileStream fs = new FileStream(server_properties_path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (true)
            {
                string Readline = sr.ReadLine();
                if (Readline == null)
                {
                    sr.Close();
                    fs.Close();
                    break;
                }

                properties.Add(Readline);
                /*else if (Readline.StartsWith("level-name")) Readline = $"level-name={level_name}";
                else if (Readline.StartsWith("difficulty")) Readline = $"difficulty={ReturnDifficulty(difficultyBox.SelectedIndex)}";
                else if (Readline.StartsWith("spawn-protection")) Readline = $"spawn-protection={SpawnProtectionBox.Text}";
                else if (Readline.StartsWith("gamemode")) Readline = $"gamemode={ReturnGamemode(initalgamemodeBox.SelectedIndex)}";
                else if (Readline.StartsWith("force-gamemode")) Readline = $"force-gamemode={ReturnCondition(forcegamemodeBox.SelectedIndex)}";
                else if (Readline.StartsWith("max-players")) Readline = $"max-players={maxplayerBox.Text}";
                else if (Readline.StartsWith("view-distance")) Readline = $"view-distance={viewdistanceBox.Text}";
                else if (Readline.StartsWith("online-mode")) Readline = $"online-mode={ReturnCondition(onlinemodeBox.SelectedIndex)}";
                else if (Readline.StartsWith("op-permission-level")) Readline = $"op-permission-level={oplevelBox.SelectedIndex}";
                else if (Readline.StartsWith("pvp")) Readline = $"pvp={ReturnCondition(pvpBox.SelectedIndex)}";
                else if (Readline.StartsWith("spawn-monsters")) Readline = $"spawn-monsters={ReturnCondition(spawnmonsterBox.SelectedIndex)}";
                else if (Readline.StartsWith("spawn-npcs")) Readline = $"spawn-npcs={ReturnCondition(spawnnpcBox.SelectedIndex)}";
                else if (Readline.StartsWith("spawn-animals")) Readline = $"spawn-animals={ReturnCondition(spawnanimalBox.SelectedIndex)}";
                else if (Readline.StartsWith("enable-command-block")) Readline = $"enable-command-block={ReturnCondition(commandblockBox.SelectedIndex)}";
                else if (Readline.StartsWith("hardcore")) Readline = $"hardcore={ReturnCondition(hardcoreBox.SelectedIndex)}";
                else if (Readline.StartsWith("level-type")) Readline = $"level-type={ReturnLeveltype(leveltypebox.SelectedIndex)}";
                properties += Readline + "\n";*/
            }

            return_property(properties);

            fs = new FileStream(server_properties_path, FileMode.Create); //리사이클링을 코딩에서도 제대로 실현중 ㅋㅋ
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(properties);
            sw.Close();
            fs.Close();

        }

        //                상호작용 파트                 //

        //ServerSaves 관련 이벤트
        private void ServerSaves_AddBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Directory.Move(fbd.SelectedPath, Path.Combine(ServerPath, Path.GetFileName(fbd.SelectedPath)));
                RefreshServerSaves();
            }
        }
        private void ServerSaves_RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshServerSaves();
        }
        private void ServerSaves_SetmainBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(server_properties_path))
            {
                MessageBox.Show("서버 폴더에 Properties파일이 감지 되지 않았습니다", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            level_name = ServerSaves_List.SelectedItems[0].Text;
            WriteProperties();
            RefreshServerSaves();
            MessageBox.Show($"{level_name}(이)가 메인으로 지정됨", "SeverManager", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void ServerSaves_DelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 당신이 선택한 맵들을 삭제하시겠습니까?", "SeverManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;

            foreach (ListViewItem s in ServerSaves_List.SelectedItems)
                Directory.Delete(s.SubItems[1].Text, true);
            RefreshServerSaves();
            MessageBox.Show("삭제 성공", "SeverManager", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void ServerSaves_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServerSaves_List.SelectedIndices.Count < 1)
            {
                move_to_minecraft_Btn.Enabled = false;
                ServerSaves_DelBtn.Enabled = false;
                ServerSaves_SetmainBtn.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(MinecraftSavesPath))
                    move_to_minecraft_Btn.Enabled = true;
                ServerSaves_DelBtn.Enabled = true;
                ServerSaves_SetmainBtn.Enabled = false;
            }

            if (ServerSaves_List.SelectedIndices.Count == 1)
            {
                if (!string.IsNullOrWhiteSpace(MinecraftSavesPath))
                    move_to_minecraft_Btn.Enabled = true;
                ServerSaves_DelBtn.Enabled = true;
                ServerSaves_SetmainBtn.Enabled = true;
            }
        }
        private void move_to_minecraft_Btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem s in ServerSaves_List.SelectedItems)
                Directory.Move(s.SubItems[1].Text, Path.Combine(MinecraftSavesPath, Path.GetFileName(s.SubItems[1].Text)));
            RefreshServerSaves();
            RefreshMinecraftSaves();
            ServerSaves_List_SelectedIndexChanged(sender, e);
            MessageBox.Show("이동 성공", "SeverManager", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //MinecraftSaves 관련 이벤트
        private void MinecraftSaves_RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshMinecraftSaves();
        }
        private void MinecraftSaves_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            move_to_server_Btn.Enabled = (MinecraftSaves_List.SelectedItems.Count > 0) ? true : false;
        }
        private void move_to_server_Btn_Click(object sender, EventArgs e)
        {
            if (RunJarpath == "")
            {
                MessageBox.Show("서버 경로를 먼저 지정해주세요", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            foreach (ListViewItem s in MinecraftSaves_List.SelectedItems)
                Directory.Move(s.SubItems[1].Text, Path.Combine(ServerPath, Path.GetFileName(s.SubItems[1].Text)));
            RefreshServerSaves();
            RefreshMinecraftSaves();
            MinecraftSaves_List_SelectedIndexChanged(sender, e);
            MessageBox.Show("이동 성공", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //plugin 관련 이벤트
        private void plugin_RefreshBtn_Click(object sender, EventArgs e) 
        { 
            RefreshPlugins(); 
        }
        private void plugin_AddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jar files(*.jar)|*.jar";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
                foreach (string filepath in ofd.FileNames)
                    File.Move(filepath, Path.Combine(pluginspath, Path.GetFileName(filepath)));
            RefreshPlugins();
        }
        private void plugin_List_DragEnter(object sender, DragEventArgs e) 
        { 
            e.Effect = DragDropEffects.Move; 
        }
        private void plugin_DelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 당신이 선택한 플러그인들을 삭제하시겠습니까?", "SeverManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;

            foreach (ListViewItem s in plugin_List.SelectedItems)
                File.Delete(s.SubItems[1].Text);
            RefreshPlugins();
            MessageBox.Show("삭제 성공", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void plugin_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plugin_List.SelectedItems.Count > 1 || plugin_List.SelectedItems.Count < 1) //pluginlist에서 2개이상 또는 1개 미만으로 선택했을때
            {
                plugin_ActiveBtn.Enabled = false;
                plugin_InactiveBtn.Enabled = false;
                return;
            }

            if (plugin_List.SelectedItems[0].ForeColor == Color.Gray) //선택한 항목이 비활성화된 항목일때
                plugin_ActiveBtn.Enabled = true;
            else
                plugin_InactiveBtn.Enabled = true;
        }
        private void plugin_ActiveBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = plugin_List.SelectedItems[0];
            File.Move(item.SubItems[1].Text, Path.ChangeExtension(item.SubItems[1].Text, ".jar"));
            RefreshPlugins();
            plugin_ActiveBtn.Enabled = false;
            MessageBox.Show($"{item.SubItems[0].Text}(을)를 활성화 시켰습니다", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void plugin_InactiveBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = plugin_List.SelectedItems[0];
            File.Move(item.SubItems[1].Text, Path.ChangeExtension(item.SubItems[1].Text, ".sleep"));
            RefreshPlugins();
            plugin_InactiveBtn.Enabled = false;
            MessageBox.Show($"{item.SubItems[0].Text}(을)를 비활성화 시켰습니다", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void plugin_ActiveBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (plugin_ActiveBtn.Enabled == true)
                plugin_InactiveBtn.Enabled = false;
        }
        private void plugin_InactiveBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (plugin_InactiveBtn.Enabled == true)
                plugin_ActiveBtn.Enabled = false;
        }

        //jar 관련 이벤트
        private void jar_SetmainBtn_Click(object sender, EventArgs e)
        {
            RunJarpath = JarsList.SelectedItems[0].SubItems[1].Text;
            JarsList.SelectedItems[0].BackColor = Color.Red;
            JarsList.SelectedItems[0].ForeColor = Color.White;
            MessageBox.Show($"{JarsList.SelectedItems[0].SubItems[0].Text}(이)가 실행 Jar로 지정되었습니다", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void JarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            jar_SetmainBtn.Enabled = (JarsList.SelectedItems.Count == 1) ? true : false;
        }

        //properties 관련 이벤트
        private void properties_RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshProperties();
        }
        private void properties_ApplyBtn_Click(object sender, EventArgs e)
        {
            WriteProperties();
            MessageBox.Show("Properties 파일에 위 설정들이 적용 됨", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //드래그 앤 드롭
        private void ServerSaves_List_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
                if(CheckWorldDir(path))
                    Directory.Move(path, Path.Combine(ServerPath, Path.GetFileName(path)));
            RefreshServerSaves();
        }
        private void ServerSaves_List_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void MinecraftSaves_List_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
                if (CheckWorldDir(path))
                    Directory.Move(path, Path.Combine(MinecraftSavesPath, Path.GetFileName(path)));
            RefreshMinecraftSaves();
        }
        private void MinecraftSaves_List_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void plugin_List_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
                if (Path.GetExtension(path) == "jar")
                    File.Move(path, Path.Combine(pluginspath, Path.GetFileName(path)));
            RefreshPlugins();
        }

        //경로 관련 이벤트
        private void PathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string selectedpath = fbd.SelectedPath;
                if (CheckSeverDir(selectedpath))
                    ActiveManage(selectedpath);
                else
                    MessageBox.Show("서버폴더가 아닌듯 함", "SeverManager", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void PathBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PathBox.Text))
                Clipboard.SetText(ServerPath);
        }
        private void PathBox_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PathBox.Text))
                Process.Start(ServerPath);
        }
        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            ServerPath = PathBox.Text;
            Properties.Settings.Default.ServerPath = ServerPath;
            Properties.Settings.Default.Save();
        }

        //서버 러닝 관련
        private void StartBtn_Click(object sender, EventArgs e)
        {
            ServerOutput.Clear();
            Change_able_logging(true);
            try
            {
                p.StartInfo.FileName = "java.exe";
                p.StartInfo.Arguments = $"-Xms{minmemory}M -Xmx{maxmemory}M -jar \"{RunJarpath}\"{((nogui_checkbox.Checked) ? " nogui" : "")}"; //nogui_checkbox가 체크됬으면 nogui인수 추가 아니면 그냥 ㄱㄱ
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.EnableRaisingEvents = true;
                p.Start();
                p.OutputDataReceived += getOutput;
                p.ErrorDataReceived += getError;
                p.Exited += exited;
                p.BeginOutputReadLine();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void CommitBtn_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine(InputBox.Text);
            InputBox.Clear();
        }
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CommitBtn_Click(sender, e);
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { p.StandardInput.WriteLine("stop"); }
            catch { return; }
        }
        private void servercloseBtn_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine("stop");
        }
        private void getOutput(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                ServerOutput.AppendText(e.Data + "\r\n");
        }
        private void getError(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                ServerOutput.AppendText(e.Data + "\r\n");
        }
        private void exited(object sender, EventArgs e)
        {
            InputBox.Clear();
            Change_able_logging(false);
            p = new Process(); //초기화
        }

        //기타 이벤트들
        private void memory_SetBtn_Click(object sender, EventArgs e)
        {
            minmemory = MinMemoryBox.Text;
            maxmemory = MaxMemoryBox.Text;
            Properties.Settings.Default.MinMemory = minmemory;
            Properties.Settings.Default.MaxMemory = maxmemory;
            Properties.Settings.Default.Save();
            MessageBox.Show("메모리 값이 설정 됨", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void server_ReloadBtn_Click(object sender, EventArgs e) 
        { 
            p.StandardInput.WriteLine("reload"); 
        }
        private void Main_Load(object sender, EventArgs e)
        {
            string temp_path = Properties.Settings.Default.ServerPath;
            if (temp_path != "") //저장된 서버 경로가 있다면?
            {
                if (Directory.Exists(temp_path))
                {
                    if (CheckSeverDir(temp_path))
                        ActiveManage(temp_path);
                    else
                    {
                        MessageBox.Show("전에 설정해놓은 서버 폴더가 이상해진 듯?\n일단 초기화 할게용", "ServerManager",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        InactiveManage();
                    }
                }
                else
                {
                    MessageBox.Show("설정한 서버 폴더 어디감?? 다시 설정 ㄱ", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InactiveManage();
                }
            }
            else
            {
                string path = Application.StartupPath; //왠만하면 이 프로그램은 서버 폴더 안에서 동작해야하기 때문에
                if (CheckSeverDir(path)) 
                    ActiveManage(path);
                else
                {
                    MessageBox.Show("서버 매니저는 서버 폴더 내에서 작동되는 걸 지극히 권장 드립니다!", "SeverManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InactiveManage();
                }
            }

            if (Properties.Settings.Default.MinecraftSavePath != "")
                MinecraftSavesPath = Properties.Settings.Default.MinecraftSavePath;

            minmemory = Properties.Settings.Default.MinMemory;
            maxmemory = Properties.Settings.Default.MaxMemory;

            minmemory = (string.IsNullOrWhiteSpace(minmemory)) ? "512" : minmemory;
            maxmemory = (string.IsNullOrWhiteSpace(maxmemory)) ? "1024" : maxmemory;

            MinMemoryBox.Text = minmemory;
            MaxMemoryBox.Text = maxmemory;
        }
        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                if (MessageBox.Show("초기화 시키시겠습니까?", "ServerManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    InitializeComponent();
        }
    }
    public class property
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}

//이런 개 망할 스파게뤼 코드 같은;

//2021/11/16 00:31 망할 스파게뤼 코드 하나하나 다 폈고, 구조적으로 디버깅 해야겠네;

//2021/11/16 01:58 미안 내가 졌다 디버깅 오늘 학교 갔다와서 해야겠;
/*문제점 : activeManage에서 false값일때 group들이 minecraftsaves, serversaves만 적용되고
 * 다른 그룹들은 반응이 없음 */
