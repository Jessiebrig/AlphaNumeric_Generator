using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlphaNumeric_Generator
{
    public partial class AlpaNumeric_Generator
    {
        public String Empty;
        public String Working;
        public String Generated;
        public String ConfigPath;
        public String Gen_Backup;
        public String Config_Backup;
        public String Directory = Environment.CurrentDirectory;
        public String Myurl;
        public static String value;
        public static String FindElementType;
        public static String ElementMethod;
        int Panel_Custom_H; //Store Panel_Custom Height
        //-------------------------------------
        public String Webtext;
        public String Modem;
        public String Modem_Block;
        public String Google;
        //
        //String Methods//
        //
        public string Date_Time(string type)
        {
            string DOR = DateTime.Now.ToString();
            string[] DT = DOR.Split(' ');
            if (type == "T") { DOR = DT[1]; }
            else if (type == "DT") { DOR = DT[0] + " " + DT[1] + " " + DT[2]; }
            return DOR;
        }
        public static String Input_T_M_V(String Type, String Method, String value1)
        {
            FindElementType = Type;
            ElementMethod = Method;
            value = value1;
            return FindElementType + ElementMethod + value;
        }
        public String Type_Method_value()
        {
            string Type_Method_value = "FindElement By." + FindElementType + "_" + ElementMethod + "  Value: " + value;
            return Type_Method_value;
        }
//Get Current URL_____
        public string URL;
        public String Curl()
        {
            try { URL = Chrome.Url; }
            catch (Exception ex) { AddMsg("General Exception under Curl()"); AddMsg(ex.ToString()); }
            if (URL == null) { return "Url Not Found/Window not Active"; }
            else { return URL; }
        }
        //
//Chrome Driver_____
        IWebDriver Chrome;
        public String Profile_Selected;
        public void Load_WebDriver()
        {
            try { Chrome.Quit(); }
            catch (NullReferenceException) { AddMsg("Opening Custom Profile"); }
            string[] Profile_array = Profile_Selected.Split(' ');
            string Profile_Path = Profile_array[1];
            Profile_Path = Profile_Path.Trim();
            Delegate DMode = new DELETEGATE(() => { Mode(); });
            this.Invoke(DMode);
            AddMsg(headless + Profile_Path);
            Chrome_Profile(Profile_Path);
        }
        //
//Chrome Options_____
        bool Headless = false;
        public void Chrome_Profile(string profile)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("user-data-dir=" + profile);
                if (Headless) { options.AddArguments("--headless"); }
                Chrome = new ChromeDriver(options);
                AddMsg("Profile Path: " + profile);
            }
            catch (Exception ex)
            {
                AddMsg("General Exception under Chrome Options");
                AddMsg(ex.ToString());
            }
        }
        //
//WinSwitch_____
        public string WinString;
        public void Windows()
        {
            WinString = null;
            try
            {
                AddMsg(Chrome.WindowHandles.Count().ToString() + " Window");
                for (int i = 0; i < Chrome.WindowHandles.Count(); i++)
                {
                    Chrome.SwitchTo().Window(Chrome.WindowHandles[i]);
                    WinString += "Index: " + i + " _ " + Curl() + " __ " + Chrome.CurrentWindowHandle;
                    if (i < Chrome.WindowHandles.Count() - 1) { WinString += Environment.NewLine; }
                }
            }
            catch (Exception ex) { AddMsg(ex.ToString()); }
            AddMsg(WinString);
        }
        public void WinSwitch(int tab)
        {
            try
            {
                Chrome.SwitchTo().Window(Chrome.WindowHandles[tab]);
                AddMsg("Switch to: " + WinArray[tab]);
            }
            catch (Exception ex) { AddMsg("General Exception under WinSwitch()/Tab_Index not Found"); AddMsg(ex.ToString()); }
        }
        //
        //Methods//
        //
//Navigate_____
        Thread Navig;
        bool loading = true;
        public void Navi(string url)
        {
            loading = true;
            Navig = new Thread(() => {

                AddMsg("Loading.....");
                Myurl = url; Navigate();
                try { URL = Chrome.Url; } catch (Exception ex) { AddMsg(ex.ToString()); }
            wait:
                if (loading) { goto wait; }
                AddMsg("Current URL: " + URL);
            });
            Navig.Start();
            loading = false;
        }
        public void Navigate()
        {
        Again:
            try { Chrome.Navigate().GoToUrl(Myurl); }
            catch (WebDriverTimeoutException)
            {
                AddMsg("WebDriver Timeout Exception in Navi()");
                Thread.Sleep(10000);
                goto Again;
            }
            catch (Exception ex)
            {
                AddMsg("General Exception under Navi()");
                AddMsg(ex.ToString());
            }
        }
        //
        //Find_element_____
        public void Find_element(string Find)
        {
        Again:
            try
            {
                if (FindElementType == "XPath") { Finder(Chrome, Chrome.FindElement(By.XPath(value))); }
                else if (FindElementType == "Id") { Finder(Chrome, Chrome.FindElement(By.Id(value))); }
                else if (FindElementType == "Name") { Finder(Chrome, Chrome.FindElement(By.Name(value))); }
                else { }
            }
            catch (NoSuchElementException) { AddMsg("No Such Element Exception under Find_element()"); }
            catch (WebDriverTimeoutException)
            {
                AddMsg("WebDriver Timeout Exception under Find_element()");
                Thread.Sleep(10000);
                goto Again;
            }
            catch (ElementNotInteractableException)
            {
                AddMsg("Element Not Interactable Exception under Find_element| Will try again after 10 Seconds..");
                Thread.Sleep(10000);
                goto Again;
            }
            catch (UnhandledAlertException)
            {
                AddMsg("Unhandled Alert Exception Occur_in Find_element");
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                AddMsg("General Exception under Find_element()");
                AddMsg(ex.ToString());
            }
        }
//Finder_____
        public void Finder(IWebDriver chrome, IWebElement element)  //IWebDriver chrome is just reserve
        {
            AddMsg(Type_Method_value());
            string X = element.Location.X.ToString();
            string Y = element.Location.Y.ToString();
            AddMsg("Element X Coordinates: " + X + "  |  Element X Coordinates: " + Y);
            try
            {
                if (ElementMethod == "Click") { element.Click(); AddMsg("Click Successful"); } else { }
            }
            catch (Exception ex)
            {
                AddMsg("General Exception under Finder()");
                AddMsg(ex.ToString());
            }
            Value.Text = value;
        }
    }
}
