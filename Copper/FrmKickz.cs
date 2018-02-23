using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using KickzValue;

namespace Copper
{
    public partial class FrmKickz : MetroFramework.Forms.MetroForm
    {
        public object OBJ_KMainSize { get; set; }
        public object OBJ_KAltSize { get; set; }
        public string Strng_KLink { get; set; }
        public string Strng_KEmail { get; set; }

        public FrmKickz()
        {
            InitializeComponent();
        }

        private void FrmKickz_Load_1(object sender, EventArgs e)
        {
            BuildCombo(cbkickzmainsize);
            BuildCombo(cbkickzaltsize);
        }

        private void BuildCombo(ComboBox PassedBox)
        {
            List<Tuple<string, int>> BoxList = populateComboBox();
            PassedBox.DataSource = BoxList;
            PassedBox.DisplayMember = "Item1";
            PassedBox.ValueMember = "Item2";
            PassedBox.SelectedIndex = 0;
        }

        private List<Tuple<string, int>> populateComboBox()
        {
            List<Tuple<string, int>> ComboList = new List<Tuple<string, int>>();
            ComboList.Add(new Tuple<string, int>("Please Select A Size", 0));
            ComboList.Add(new Tuple<string, int>("Size 40", 1));
            ComboList.Add(new Tuple<string, int>("size 40.5", 2));
            ComboList.Add(new Tuple<string, int>("size 41", 3));
            ComboList.Add(new Tuple<string, int>("size 42", 4));
            ComboList.Add(new Tuple<string, int>("size 42.5", 5));
            ComboList.Add(new Tuple<string, int>("size 43", 6));
            ComboList.Add(new Tuple<string, int>("size 44", 7));
            ComboList.Add(new Tuple<string, int>("size 44.5", 8));
            ComboList.Add(new Tuple<string, int>("size 45", 9));
            ComboList.Add(new Tuple<string, int>("size 45.5", 10));
            ComboList.Add(new Tuple<string, int>("size 46", 11));
            ComboList.Add(new Tuple<string, int>("size 47.5", 12));
            ComboList.Add(new Tuple<string, int>("size 48.5", 13));
            ComboList.Add(new Tuple<string, int>("size 49.5", 14));
            return ComboList;
        }

        private void bttnkickzbot_Click(object sender, EventArgs e)
        {            
            if(chbxkickzchrome.Checked)
            {
                var chrmdriver = new ChromeDriver();
                TimeSpan chrmts = TimeSpan.FromSeconds(560);                                                        //Variable für die TimeSpan Klasse mit einem 560 Sekunden Wert        
                WebDriverWait chrmwait = new WebDriverWait(chrmdriver, chrmts);                                             //Variable für die WebDriverWait Klasse mit driver und ts als Wert

                chrmdriver.Manage().Window.Maximize();
                chrmdriver.Navigate.GoToUrl(tbkickzlink.Text);

                try                                                                                                                 //versucht Hauptgröße hinzuzuügen
                {
                    chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.Id("EU-" + OBJ_KMainSize)));
                    chrmdriver.FindElementById("EU-" + OBJ_KMainSize).Click();                                                       //fügt Hauptgröße hinzu
                }
                catch                                                                                                           //Wenn hauptgröße nicht verfügbar wird abgefangen
                {
                    chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.Id("EU-" + OBJ_KAltSize)));
                    chrmdriver.FindElementById("EU-" + OBJ_KAltSize).Click();                                                          // fügt altwenative größe hinzu
                }

                chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.Id(KickzValues.Strng_addToBasket)));                    //tut was es soll...anscheinend
                chrmdriver.FindElementById(KickzValues.Strng_addToBasket).Click();
                chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(KickzValues.Strng_btnCart)));
                chrmdriver.FindElementByClassName(KickzValues.Strng_btnCart).Click();
                chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(KickzValues.Strng_cartGreenSubmit)));
                chrmdriver.FindElementByClassName(KickzValues.Strng_cartGreenSubmit).Click();

                if (chbxkickzlogin.Checked)                                                                                        //Falls Checked wird der User eingeloggt
                {
                    chrmwait.Until(ExpectedConditions.ElementIsVisible(By.Id(KickzValues.Strng_mailtb)));
                    chrmdriver.FindElementById(KickzValues.Strng_mailtb).SendKeys(Strng_KEmail);                                      //Driver sucht nach Textbox auf Website und gibt den Wert der Texbox von der Anwendung ein
                    chrmdriver.FindElementByName(KickzValues.Strng_psswrdtb).SendKeys(tbkickzpassword.Text);                                    //Driver sucht nach Textbox auf Website und gibt den Wert der Texbox von der Anwendung ein
                    chrmwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(KickzValues.Strng_xLogin)));                      //Driver wartet auf Classname
                    chrmdriver.FindElementByXPath(KickzValues.Strng_xLogin).Click();                                                  //Driver klickt Login Button
                }
            }


            if(chbxkickzfox.Checked)
            {
                var driver = new FirefoxDriver();                                                               //Neue Instanz für die Firefoxdriver Klasse
                TimeSpan ts = TimeSpan.FromSeconds(560);                                                        //Variable für die TimeSpan Klasse mit einem 560 Sekunden Wert        
                WebDriverWait wait = new WebDriverWait(driver, ts);                                             //Variable für die WebDriverWait Klasse mit driver und ts als Wert
                OBJ_KAltSize = cbkickzaltsize.SelectedValue;
                OBJ_KMainSize = cbkickzmainsize.SelectedValue;
                Strng_KEmail = tbkickzmail.Text;
                Strng_KLink = tbkickzlink.Text;

                driver.Manage().Window.Maximize();                                                              //Maximiert Browser
                driver.Navigate().GoToUrl(Strng_KLink);                                                         //Öffnet Seite mit URL aus TextBox

                try                                                                                                                 //versucht Hauptgröße hinzuzuügen
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("EU-" + OBJ_KMainSize)));
                    driver.FindElementById("EU-" + OBJ_KMainSize).Click();                                                       //fügt Hauptgröße hinzu
                }
                catch                                                                                                           //Wenn hauptgröße nicht verfügbar wird abgefangen
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("EU-" + OBJ_KAltSize)));
                    driver.FindElementById("EU-" + OBJ_KAltSize).Click();                                                          // fügt altwenative größe hinzu
                }

                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(KickzValues.Strng_addToBasket)));                    //tut was es soll...anscheinend
                driver.FindElementById(KickzValues.Strng_addToBasket).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(KickzValues.Strng_btnCart)));
                driver.FindElementByClassName(KickzValues.Strng_btnCart).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(KickzValues.Strng_cartGreenSubmit)));
                driver.FindElementByClassName(KickzValues.Strng_cartGreenSubmit).Click();

                if (chbxkickzlogin.Checked)                                                                                        //Falls Checked wird der User eingeloggt
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(KickzValues.Strng_mailtb)));
                    driver.FindElementById(KickzValues.Strng_mailtb).SendKeys(Strng_KEmail);                                      //Driver sucht nach Textbox auf Website und gibt den Wert der Texbox von der Anwendung ein
                    driver.FindElementByName(KickzValues.Strng_psswrdtb).SendKeys(tbkickzpassword.Text);                                    //Driver sucht nach Textbox auf Website und gibt den Wert der Texbox von der Anwendung ein
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(KickzValues.Strng_xLogin)));                      //Driver wartet auf Classname
                    driver.FindElementByXPath(KickzValues.Strng_xLogin).Click();                                                  //Driver klickt Login Button
                }
            }
        }        
    }
}
