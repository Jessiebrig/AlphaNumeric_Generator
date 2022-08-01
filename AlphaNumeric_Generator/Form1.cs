using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlphaNumeric_Generator
{
    public partial class AlpaNumeric_Generator : Form
    {
        public delegate void DELETEGATE();
        public static TextBox[] ThreadI;
        public AlpaNumeric_Generator()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            ThreadI = new TextBox[] { Threadi0, Threadi1, Threadi2, Threadi3, Threadi4 };
        }
        private void AlpaNumeric_Generator_Load(object sender, EventArgs e)
        {
            Get_Config("Profile", "loadprofiles");
            Profile.SelectedIndex = 0;
            Panel_Custom_H = Panel_Custom.Height;
            Panel_Custom.Visible = false;
            this.Height -= Panel_Custom_H;
            textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            Expand_Click(new object(), new EventArgs());
            ConfigPath = Directory + "\\Configs.txt";
            Config_Backup = Directory + "\\Configs_Backup.txt";
            Gen_Backup = Directory + "\\Generated_Backup.txt";
            Working = Directory + "\\Working_Link.txt";
            Empty = Directory + "\\Empty_Link.txt";
            Generated = Directory + "\\Generated.txt";
            Load_Defaults();
        }
//Resise_Window_____
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style = (cp.Style | 262144);
                return cp;
            }
        }
        //
//Drag_Window_____
        int mov, movX, movY;
        private void Panel_Body_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Panel_Body_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void Panel_Body_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        //Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____
        //
//Load_Defaults_____
        public void Load_Defaults()
        {
            Get_Config(null, "all");//Store Configs to Config[]
            string[] defaults = new string[] { "Google:", "Modem:", "Modem_Block:"};
            for (Config_Index = 0; Config_Index < Configs.Length; Config_Index++)//Get Value of the first keyword
            {
                foreach (string values in defaults)
                {
                    try
                    {
                        if (Configs[Config_Index].Contains(values))
                        {
                            TextValue = Configs[Config_Index].ToString();
                            TextValue = TextValue.Replace(values, "");
                            TextValue = TextValue.Remove(0, 1);
                            TextValue = TextValue.Trim();
                            AddMsg(values + " " + TextValue);
                            if (values == "Google:") { Google = TextValue; }
                            else if (values == "Modem:") { Modem = TextValue; }
                            else if (values == "Modem_Block:") { Modem_Block = TextValue; }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
//Set_Config_____
        public void Set_Config(string keyword, string NewText, string FileName)//, int Line_to_Edit
        {
            Get_Config(keyword, null);
            string[] Lines = File.ReadAllLines(FileName);
            Lines[Config_Index] = keyword + " " + NewText;
            File.WriteAllLines(FileName, Lines);
        }
        //
//Get_Config_____
        int Config_Index;
        string TextValue;
        string[] Configs;
        public string Get_Config(string keyword, string method)
        {
            StreamReader Value = new StreamReader("Configs.txt");
            TextValue = Value.ReadToEnd();
            Configs = TextValue.Split('\n');
            if (method == null)
            {
                for (Config_Index = 0; Config_Index < Configs.Length; Config_Index++)//Get Value of the first keyword
                {
                    if (Configs[Config_Index].Contains(keyword))
                    {
                        TextValue = Configs[Config_Index].ToString();
                        TextValue = TextValue.Replace(keyword, "");
                        TextValue = TextValue.Remove(0, 1);
                        break;
                    }
                }
                Value.Close();
            }
            else if (method == "all")
            {
                TextValue = null;
                foreach (string configs in Configs) { TextValue += configs + Environment.NewLine; }
            }
            else
            {
                if (method == "loadprofiles")//Get all the Values of the same keyword
                {
                    Profile.Items.Clear();
                    foreach (string profiles in Configs)
                    {
                        if (profiles.Contains(keyword))
                        {
                            TextValue = profiles.Remove(0, 10);
                            Profile.Items.Add(TextValue);
                        }
                    }
                    TextValue = null;
                }
            }
            return TextValue;
        }
        //
//AddMsg_____
        public void AddMsg(String Addmsg) //This Method is to access Resources from a new Thread to Main Thread like TextBox//Can only be called directly from main Threa//
        {
            Delegate addMsg = new DELETEGATE(() => 
            {
                textScripts.Text += (Addmsg);
                textScripts.AppendText(Environment.NewLine);
            });
            this.Invoke(addMsg);
        }
        //
//Show_Status()
        public void Show_Status()
        {
            string Status = "Version 3.0" + Environment.NewLine
                + "Profile: " + Profile_Selected + Environment.NewLine;
            AddMsg(Status);
        }
//ReWrite_____
        Thread ReWrite;
        public static string WRITE;
        public void Rewrite(int Amount)
        {
            ReWrite = new Thread(() => {
                Orig = Get_Link("Generated");
                string[] write = Orig.Split('\n');
                for (int i = 0; i <= Amount; i++) { WRITE += write[i] + Environment.NewLine; }
                string[] Lines = WRITE.Split('\n');
                AddMsg(Date_Time("T") + " Start Rewriting " + Lines.Length + " AlphaNumeric Chars..");
                File.WriteAllLines(Generated, Lines);
                AddMsg(Date_Time("T") + " Rewriting Complete..");
            });
            ReWrite.Start();
        }
//Generate_____
        int Counter;
        public string CharSet;
        public static string Orig;
        public void Generate(int length)
        {
        again:
            Counter += 1;
            string newchar = Random22(15);
            CharSet += newchar + Environment.NewLine;
            if (Counter >= length)
            {
                AddMsg(Date_Time("T") + " Accessing Generated.txt please wait..");
                Orig = Get_Link("Generated");
                generated = Orig.Split('\n');
                string verified = Verifytest(CharSet);
                AddMsg(Date_Time("T") + " Compiling..");
                Orig = Orig.Remove(Orig.Length - 1, 1);
                Orig += verified;
                string[] Lines = Orig.Split('\n');
                AddMsg(Date_Time("T") + " Start Rewriting " + Lines.Length + " AlphaNumeric Chars..");
                File.WriteAllLines(Generated, Lines);
                AddMsg(Date_Time("T") + " Rewriting Complete..");
            }
            else { goto again; }
            Counter = 0;
            CharSet = null;
        }
        static object _lock = new object();
        public static int startindex;
        public static int lastindex;
        public static int threadnum;
        public static int sleep;
        public static int numofthread;
        public static int Trunning;//Total Running
        public static int[] ThreadON = new int[5];//Store 1 to assisgn thread[index] if running
        Thread thread0; Thread thread1; Thread thread2; Thread thread3; Thread thread4;
        public AlpaNumeric_Generator(string[] generatedv, string[] newchar, int startindexv, int lastindexv, int threadnumv, int sleepv)
        {
            generated = generatedv;
            NewChars = newchar;
            startindex = startindexv;
            lastindex = lastindexv;
            sleep = sleepv;
            ThreadON[threadnumv] = 1;
            lock (_lock) { threadnum = threadnumv; }
        }
        //Verifytest_____
        public static string[] generated;//Store all generateds
        public static string[] NewChars;//Must be as Global string[]
        string verified;
        int set2L;
        int set3L;
        int set4L;
        public string Verifytest(string toverify)
        {
            AddMsg("Running in " + threads.ToString() + " Threads");
            NewChars = toverify.Split('\n');
            int length = generated.Length;
            numofthread = length / threads;
            AddMsg(Date_Time("T" + " Verification Started.."));
            if (threads >= 1)
            {
                if (ThreadON[0] == 0)
                {
                    AlpaNumeric_Generator Verification_0 = new AlpaNumeric_Generator(generated, NewChars, 0, numofthread, 0, 0);
                    thread0 = new Thread(Verification);
                    thread0.Start();
                }
                if (threads >= 2)
                {
                    if (ThreadON[1] == 0)
                    {
                        Thread.Sleep(20);
                        int set2S = numofthread + 1;
                        set2L = set2S + numofthread;
                        if (threads == 2) { set2L = length; }
                        AlpaNumeric_Generator Verification_1 = new AlpaNumeric_Generator(generated, NewChars, set2S, set2L, 1, 0);
                        thread1 = new Thread(Verification);
                        thread1.Start();
                    }
                    if (threads >= 3)
                    {
                        if (ThreadON[2] == 0)
                        {
                            Thread.Sleep(20);
                            int set3S = set2L + 1;
                            set3L = set3S + numofthread;
                            if (threads == 3) { set3L = length; }
                            AlpaNumeric_Generator Verification_2 = new AlpaNumeric_Generator(generated, NewChars, set3S, set3L, 2, 0);
                            thread2 = new Thread(Verification);
                            thread2.Start();
                        }
                        if (threads >= 4)
                        {
                            if (ThreadON[3] == 0)
                            {
                                Thread.Sleep(20);
                                int set4S = set3L + 1;
                                set4L = set4S + numofthread;
                                if (threads == 4) { set4L = length; }
                                AlpaNumeric_Generator Verification_3 = new AlpaNumeric_Generator(generated, NewChars, set4S, set4L, 3, 0);
                                thread3 = new Thread(Verification);
                                thread3.Start();
                            }
                            if (threads == 5)
                            {
                                if (ThreadON[4] == 0)
                                {
                                    Thread.Sleep(20);
                                    int set5S = set4L + 1;
                                    AlpaNumeric_Generator Verification_4 = new AlpaNumeric_Generator(generated, NewChars, set5S, length, 4, 0);
                                    thread4 = new Thread(Verification);
                                    thread4.Start();
                                }
                            }
                        }
                    }
                }
            }
        again:
            foreach (int T in ThreadON) { Trunning += T; }
            if (Trunning != 0)
            {
                Trunning = 0;
                Thread.Sleep(5000); goto again;
            }
            AddMsg(Date_Time("T") + " Compiling Started..");
            foreach (string ok in NewChars) { if (ok != null) { verified += ok + Environment.NewLine; } }
            NewChars = verified.Split('\n');
            verified = null;
            try
            {
                for (int i = 0; i < NewChars.Length - 1; i++)
                {
                    int num = generated.Length - 2 + i;
                    string index = num.ToString();
                    verified += index + " " + NewChars[i] + Environment.NewLine;
                }
            }
            catch (Exception ex) { AddMsg(ex.ToString()); }
            verified = verified.Remove(verified.Length - 5, 5);//Remove the last extra line//using (verified.Length - 6, 6) will remove already the last letter
            //AddMsg("cutted>" + verified + "<cutted");
            duplicate = 0;//Clear Duplicate Counter
            AddMsg(Date_Time("T") + " Compiling Finish..");
            return verified;
        }
        //Verification_____
        int duplicate = 0;
        public void Verification()
        {
            int local = threadnum;//Store local threadnum for every Thread
            string starttime = Date_Time("T");
            AddMsg("Thread " + local + " Start: at Index _" + startindex + "_ ends at Index _" + lastindex + "_");
            ThreadI[local].BackColor = Color.Red;
            Thread.Sleep(sleep);
            verified = null;
            try
            {
                for (int i = startindex; i < lastindex; i++)
                {
                    for (int Nindex = 0; Nindex < NewChars.Length - 1; Nindex++)
                    {
                        if (generated[startindex].Equals(NewChars[Nindex]))
                        {
                            //AddMsg("Duplicate: >" + generated[startindex] + "< _at Index: " + startindex.ToString() + " _of Generated.txt and Index: " + Nindex.ToString() + " _of NewChars");
                            NewChars[Nindex] = null;
                            Delegate addMsg = new DELETEGATE(() => { duplicate += 1; Duplicate.Text = duplicate.ToString(); });
                            this.Invoke(addMsg);
                        }
                    }
                }
            }
            catch (Exception ex) { AddMsg(ex.ToString()); }
            ThreadON[local] = 0;
            ThreadI[local].BackColor = Color.SpringGreen;
            
            AddMsg("Thread: _" + local + "_ Start at "+ starttime + " End at " + Date_Time("T"));
        }
        //
        //Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____
        //
//Start_____
        bool start = false;
        Thread Char_Gen;
        int Set;
        private void Start_Click(object sender, EventArgs e)
        {
            if (start)
            {
                try { Char_Gen.Abort(); }
                catch (Exception ex) { AddMsg(ex.ToString()); }
                Start.Text = "Start";
                start = false;
                Start.BackColor = Color.DeepSkyBlue;
                panel_Body.BackColor = Color.LightSkyBlue;
                foreach (TextBox I in ThreadI) { I.BackColor = Color.SpringGreen;}
            }
            else  //Start Checking the Brower
            {
                Set = int.Parse(Sets.Text);
                AddMsg("Generating: " + Set + " Per Set");
                Start.Text = "Stop";
                start = true;
                Start.BackColor = Color.Red;
                panel_Body.BackColor = Color.LightGreen;
                Char_Gen = new Thread(() => {
                //again:
                    Generate(Set);
                    //goto again;
                });
                Char_Gen.Start();
            }
        }
        //
//Load Chrome_Profile_____
        private void Load_Profile_Click(object sender, EventArgs e)
        {
            //Headless = true;
            try
            {
                Thread Load_Profile = new Thread(() => { Load_WebDriver(); });
                Load_Profile.Start();
                Show_Status();//need to put here since not working under Task_Grabber_Load()
            }
            catch (Exception ex)
            {
                AddMsg("General Exception under Load_Profile_Click");
                AddMsg(ex.ToString());
            }
            foreach (Process p in Process.GetProcessesByName("chromedriver")) { p.CloseMainWindow(); }
        }
        //
        private void Clear_Scripts_Click(object sender, EventArgs e)
        {
            Delegate Clear = new DELETEGATE(() => { textScripts.Clear(); Value.Clear(); });
            this.Invoke(Clear);
        }
        private void Find_Element_Click(object sender, EventArgs e)
        {
            Input_T_M_V("XPath", "Find", value);
            Find_element(null);
        }
        private void Click_Element_Click(object sender, EventArgs e)
        {
            Input_T_M_V("XPath", "Click", value);
            Find_element(null);
        }
        //
//Always on Top_____
        bool top = false;
        private void Always_Top_Click(object sender, EventArgs e)
        {
            if (top)
            {
                Always_Top.Text = "T";
                top = false;
                this.TopMost = false;
            }
            else  //Lock Window
            {
                Always_Top.Text = "U";
                top = true;
                this.TopMost = true;
            }
        }
        private void Minimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void Close_Click(object sender, EventArgs e)
        {
            Thread[] Running = new Thread[] { Char_Gen, Navig };
            foreach (var thread in Running)
            {
                try { thread.Abort(); } catch (Exception ex) { AddMsg(ex.ToString()); }
            }
            foreach (Process p in Process.GetProcessesByName("chromedriver")) { p.CloseMainWindow(); }
            Application.Exit();
        }
        //
//Expand_Window_____
        bool Expand = false;
        private void Expand_Click(object sender, EventArgs e)
        {
            if (Expand)
            {
                Xpand.Text = "Xpand";
                Expand = false;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                Panel_Custom.Visible = false;
                this.Height -= Panel_Custom_H;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            }
            else //Expand
            {
                Xpand.Text = "Hide";
                Expand = true;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                this.Height += Panel_Custom_H;
                Panel_Custom.Visible = true;
                Panel_Custom.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            }
        }
        //
//Help_____
        private void Help_Click(object sender, EventArgs e)
        {
            string Help = "Show Status : Show Current Configuration//" + Environment.NewLine
                + "Show Configs : Show Configs From Configs.txt//" + Environment.NewLine
                + "Set Q : Set LiDAR Queue Link//" + Environment.NewLine
                + "Set Sound : Set Background Sound//" + Environment.NewLine
                + "Set Profile : Set Chrome Custome Profile//" + Environment.NewLine
                + "Show Xpaths : Show Xpaths Samples From Xpath_Notes.txt//" + Environment.NewLine
                + "Config_Editor : Run Config Editor//" + Environment.NewLine
                + "Values : Show Current Variabe Values//" + Environment.NewLine
                + "Backup_Config : Backup Current Config to //" + Config_Backup + Environment.NewLine
                + "Stop : Stop all Running Threads//";
            AddMsg(Help);
        }
        //
//Window_Check_____
        public string[] WinArray;
        private async void WinCheck_Click(object sender, EventArgs e)//private void Window_Click
        {
            await Task.Run(new Action(Windows));
            try
            {
                WinArray = WinString.Split('\n');
                for (int i = 0; i < Chrome.WindowHandles.Count(); i++)
                {
                    if (WinArray[i].Contains(Chrome.CurrentWindowHandle)) { AddMsg("Current Window: " + WinArray[i]); }
                }
            }
            catch (Exception ex) { AddMsg(ex.ToString()); }
        }
//Mode_____
        string headless = "Running in Headless Mode: ";
        public void Mode()
        {
            if (Headless)
            {
                Head.ForeColor = Color.Red;
                Head.Text = "Headless_Mode";
                Head.BackColor = Color.Lime;
            }
            else
            {
                headless = "Running in Normal Mode: ";
                Head.ForeColor = Color.Black;
                Head.Text = "Normal_Mode";
                Head.BackColor = Color.DarkCyan;
            }
        }
        //TextBox & ComboBox_____
//Console_____
            private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMsg(Date_Time("T") + " Executing Command from Console..");
                try
                {
                    string[] Inputarray = Console.Text.Split(' ');
                    if (Inputarray[0] == "Show")
                    {
                        if (Inputarray[1] == "Status") { Show_Status(); }
                        else if (Inputarray[1] == "Configs")
                        {
                            StreamReader Value = new StreamReader("Configs.txt");
                            TextValue = Value.ReadToEnd();
                            AddMsg(TextValue);
                        }
                        else if (Inputarray[1] == "Xpaths")//Show Xpath Samples
                        {
                            StreamReader Value = new StreamReader("Xpath_Notes.txt");
                            TextValue = Value.ReadToEnd();
                            AddMsg(TextValue);
                        }
                    }
                    else if (Inputarray[0] == "Stop")
                    {
                        try
                        {
                            Thread[] Running = new Thread[] { Char_Gen, Navig , ReWrite };
                            foreach (var thread in Running) { thread.Abort(); }
                        }
                        catch (Exception ex) { AddMsg(ex.ToString()); }
                    }
                    else if (Inputarray[0] == "Backup_Config")
                    {
                        string[] Lines = Get_Config(null, "all").Split('\n');
                        File.WriteAllLines(Config_Backup, Lines);
                        AddMsg("Backup Complete to " + Config_Backup);
                        Lines = Get_Link("Generated").Split('\n');
                        File.WriteAllLines(Gen_Backup, Lines);
                        AddMsg("Backup Complete to " + Gen_Backup);
                    }
                    else if (Inputarray[0] == "Config_Editor") { new Config_Editor(this).Show(); }
                    else if (Inputarray[0] == "Values") { Load_Defaults(); }
                    else if ((Inputarray[0] == "Headless_ON")) { Headless = true; Mode(); }
                    else if ((Inputarray[0] == "Headless_OFF")) { Headless = false; Mode(); }
                    else if ((Inputarray[0] == "Rewrite"))
                    {
                        Set = int.Parse(Sets.Text);
                        AddMsg("Rewriting to " + Set + " Chars..");
                        Rewrite(Set);
                        AddMsg("Rewriting Complete..");
                    }
                    else if ((Inputarray[0] == "2"))
                    {
                        string Chars = "lqm6gvif6ss8zn9";
                        Get_Link("Empty");
                        LinkValue += Chars;
                        string[] Lines = LinkValue.Split('\n');
                        File.WriteAllLines(Empty, Lines);
                    }
                    else { AddMsg("Command not Recognoezd.."); }
                }
                catch (Exception ex)
                {
                    AddMsg("General Exception under Console_KeyDown()");
                    AddMsg(ex.ToString());
                }
                AddMsg("Always Backup new Configs");
            }
        }
        //Console_END_____
        //
        //Event_Listeners_____
        //
//Windows_Index_____
        int tabindex;
        string number;
        string[] num;
        private void Win_Index_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    number = Win_Index.Text;
                    num = new string[] { number };
                    number = num.Last();
                    number = number.Trim();
                    tabindex = int.Parse(number);
                    AddMsg(tabindex.ToString());
                    Win_Index.Clear();
                    Win_Index.Text = number;
                }
                catch (Exception ex) { AddMsg(ex.ToString()); }
                WinSwitch(tabindex);
            }
        }
//Theads_____
        int threads = 1;
        private void Threadnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string number = Threadnum.Text;
                string[] num = new string[] { number };
                number = num.Last();
                number = number.Trim();
                threads = int.Parse(number);
                AddMsg("Thread Set to: " + threads.ToString() + " Threads");
                Threadnum.Clear();
                Threadnum.Text = number;
            }
        }
        //
        private void Value_TextChanged(object sender, EventArgs e) { value = Value.Text; }
        private void Profile_SelectedIndexChanged(object sender, EventArgs e) { Profile_Selected = Profile.SelectedItem.ToString().Trim(); }
    }
}
