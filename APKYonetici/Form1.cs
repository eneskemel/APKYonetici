using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;


namespace APKYonetici
{
    public partial class Form1 : Form
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
        }
        public AndroidDriver<AppiumWebElement> driver;
        string emi1ServiceInfo = "http://127.0.0.1:4723/wd/hub";
        string subPackage = "sub4sub.subchat";
        string subActivity = "sub4sub.subchat.ManHinhDauTienActivity";
        string uChannalPackage = "cptstudio.sub4sub";
        string uChannalActivity = "cptstudio.sub4sub.activity.FirstActivity";
        string sub4subPackage = "com.tubeforces.get_sub";
        string sub4subActivity = "com.tubeforces.get_sub.ui.launcher.LauncherActivity";
        string instagramPackage = "com.instagram.android";
        string instagramActivity = "com.c.mainactivity.MainActivity";
        string service = "";
        string deviceID = "";
        string deviceName = "";
        int projectErrorCount = 0;
        int timeErrorCount = 0;
        int playErrorCount = 0;
        int typeSubChat1 = 1;
        int typeChannel2 = 2;
        int typeSub43 = 3;
        int subChatProccesCount = 100;
        int uChannelProccesCount = 30;
        int sub4subProccesCount = 20;
        int islemYapCoinCheck = 999999999;



        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            adbKiller();
            settingsWrite();
            service = txtService.Text;
            deviceID = txtDeviceID.Text;
            deviceName = txtDeviceName.Text;
            int projectType = Settings.Default.ProjeType;
            this.Text = deviceID;
            if (projectType == 1)
            {
                tmrTime.Start();
                this.Text += "Sub4";
            }
            if (projectType == 2)
            {
                tmrTimeU.Start();
                this.Text += "Uchan";
            }
            if (projectType == 3)
            {
                tmrTimeSub.Start();
                this.Text += "Sub4 New";
            }
            emiConnection(deviceID);
        }
        private void appiumServerStart()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/ C C:\\Appium\node.exe C:\\Appium\node_modules\appium\bin\appium.js--address 127.0.0.1--port 4723--automation - name Appium--log - no - color";
            startInfo.Arguments = "/ C C:\\Program Files\nodejs\\node.exe C:\\Appium\node_modules\appium\bin\appium.js--address 127.0.0.1--port 4723--automation - name Appium--log - no - color";
            process.StartInfo = startInfo;
            process.Start();
        }
        private int emiConnection(string service)
        {
            string cmdstr = "adb connect " + service;
            try
            {
                Process pr = new Process();
                pr.StartInfo.Arguments = "/c DIR";
                pr.StartInfo.UseShellExecute = false;
                pr.StartInfo.RedirectStandardOutput = true;
                pr.StartInfo.RedirectStandardError = true;
                pr.StartInfo.FileName = "cmd.exe";
                pr.StartInfo.Arguments = "/c " + cmdstr;
                pr.Start();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return 0;

        }
        private int emiOpeningCheck(string emiCode)
        {

            //string cmdstr = "adb -s " + emiCode + " get-state";
            try
            {
                //Process pr = new Process();
                //pr.StartInfo.Arguments = "/c DIR";
                //pr.StartInfo.UseShellExecute = false;
                //pr.StartInfo.RedirectStandardOutput = true;
                //pr.StartInfo.RedirectStandardError = true;
                //pr.StartInfo.FileName = "cmd.exe";
                //pr.StartInfo.Arguments = "/c " + cmdstr;
                //pr.Start();
                //string a = pr.StandardOutput.ReadToEnd().Trim();
                //if (a.Equals("device"))
                //{
                //    return 1;
                //}
                //else
                //{
                //    return 0;
                //}
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return 0;
        }
        [Obsolete]
        private void emilatorEtkinlestir(string serviceInfo, string deviceID, string deviceName, string package, string activity)
        {
            try
            {
                listLog.Items.Add("Etkinleştiriliyor.");
                AppiumOptions capabilities = new AppiumOptions();
                //capabilities.AddAdditionalCapability("avd", "Pixel_2_API_30");
                capabilities.AddAdditionalCapability("device", "Android");
                capabilities.AddAdditionalCapability("skipUnlock", "false");
                capabilities.AddAdditionalCapability("noReset", "true");
                capabilities.AddAdditionalCapability("idleTimeout", 600000);
                capabilities.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, "600000");
                capabilities.AddAdditionalAppiumOption("DeviceName", deviceName);
                capabilities.AddAdditionalAppiumOption("platformName", "Android");
                capabilities.AddAdditionalAppiumOption("udid", deviceID);
                capabilities.AddAdditionalAppiumOption("PlatformVersion", "11.0");
                //capabilities.AddAdditionalAppiumOption("appPackage", package);
                //capabilities.AddAdditionalAppiumOption("appActivity", activity);
                capabilities.AddAdditionalAppiumOption("appPackage", package);
                capabilities.AddAdditionalAppiumOption("appActivity", activity);

                driver = new AndroidDriver<AppiumWebElement>(new Uri(serviceInfo), capabilities);

                //driver = new RemoteWebDriver(new Uri(serviceInfo), capabilities);
                listLog.Items.Add("Etkinleştirildi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Etkinlştir");
            }
        }

        [Obsolete]
        private void emuStart(string deviceName, string deviceID, string serviceName)
        {
            try
            {
                //AppiumOptions capabilities = new AppiumOptions();
                //capabilities.AddAdditionalCapability("avd", deviceName);
                //capabilities.AddAdditionalAppiumOption("DeviceName", "Pixel 2 API 30");
                //capabilities.AddAdditionalAppiumOption("platformName", "Android");
                //capabilities.AddAdditionalAppiumOption("udid", deviceID);
                //capabilities.AddAdditionalAppiumOption("PlatformVersion", "11.0");
                //capabilities.AddAdditionalCapability("idleTimeout", 900000);
                //capabilities.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, "900000");
                //driver = new RemoteWebDriver(new Uri(serviceName), capabilities);
                //listLog.Items.Add("emu start");
            }
            catch (Exception ex)
            {
                listLog.Items.Add("emu Start işini bitiremedi. Yinede devam ediliyor.");
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            service = txtService.Text;
            deviceID = txtDeviceID.Text;
            deviceName = txtDeviceName.Text;
            tmrTimeU.Start();

        }
        int deger = 0;
        int sure = 0;
        int videoClickCount = 0;
        int freeLap = 0;
        [Obsolete]
        private void tmrIslem_Tick(object sender, EventArgs e)
        {
            deger++;
            lblDeger.Text = deger.ToString();
            if (deger == 2)
            {
                int kontrol = reloadCheck("sub4sub.subchat:id/btn_reload");
                if (kontrol == 0)
                {
                    deger = -10;
                    freeLap++;
                    if (freeLap > 5)
                    {
                        projectChange(typeChannel2);
                    }
                }
            }
            if (deger == 3)
            {
                coinGetRef(1);
                islemYap(1);
            }
            if (deger == 4)
            {
                listLog.SelectedIndex = listLog.Items.Count - 1;
                videoClick();
                videoClickCount++;
                lblVideoCount.Text = "Tıklanan Video Sayısı = " + videoClickCount;
            }
            if (deger == (sure - 5))
            {
                int kontrol = reloadCheck("sub4sub.subchat:id/txt_time_required");
                if (kontrol == 0)
                {
                    if (videoClickCount > subChatProccesCount)
                    {
                        projectChange(typeChannel2);
                    }
                    freeLap = 0;
                    playErrorCount = 0;
                    timeErrorCount = 0;
                    deger = 0;
                    sure = 9999;
                }
            }
            if (deger == sure)
            {
                if (videoClickCount > subChatProccesCount)
                {
                    projectChange(typeChannel2);
                }
                playErrorCount = 0;
                timeErrorCount = 0;
                deger = 0;
                sure = 9999;
                freeLap = 0;
            }
        }

        [Obsolete]
        private void videoClick()
        {
            try
            {
                IWebElement playClick = driver.FindElement(By.Id("com.google.android.youtube:id/bottom_bar_container"));
                playClick.Click();
                listLog.Items.Add("Play basıldı.");
            }
            catch (Exception ex)
            {
                playErrorCount++;
                listLog.Items.Add("Play basılıyor Hata " + playErrorCount);
                if (playErrorCount > 2)
                {
                    projectErrorCount++;
                    tmrTime.Start();
                    Console.WriteLine(ex.ToString() + "videocick FNC");
                    listLog.Items.Add("Hata Alındı" + ex);
                    deger = 0;
                    tmrIslem.Stop();
                }
                else
                {
                    deger = 0;
                }
            }
        }
        private int reloadCheck(string element)
        {
            try
            {
                IWebElement reloadBtn = driver.FindElement(By.Id(element));
                reloadBtn.Click();
            }
            catch (Exception ex)
            {
                return 1;
            }
            return 0;
        }

        [Obsolete]
        private void islemYap(int tur)
        {
            if (tur == 1)
            {
                try
                {
                    sure = Convert.ToInt16(driver.FindElement(By.Id("sub4sub.subchat:id/txt_time_required")).Text) + 25;
                    textBox1.Text = sure.ToString();
                    listLog.Items.Add("Süre çekildi." + sure);
                }
                catch (Exception e)
                {
                    timeErrorCount++;
                    listLog.Items.Add("Süre çekiliyor hata " + timeErrorCount);
                    if (timeErrorCount > 2)
                    {
                        projectErrorCount++;
                        tmrTime.Start();
                        Console.WriteLine(e.ToString() + "islemYap FNC");
                        listLog.Items.Add("Hata Alındı" + e);
                        deger = 0;
                        tmrIslem.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }
                }
            }
            if (tur == 2)
            {
                try
                {
                    sure = Convert.ToInt16(driver.FindElement(By.Id("cptstudio.sub4sub:id/txt_time_required")).Text) + 25;
                    textBox1.Text = sure.ToString();
                    listLog.Items.Add("Süre çekildi." + sure);
                }
                catch (Exception e)
                {
                    timeErrorCount++;
                    listLog.Items.Add("Süre çekiliyor hata " + timeErrorCount);
                    if (timeErrorCount > 2)
                    {
                        projectErrorCount++;
                        tmrTimeU.Start();
                        Console.WriteLine(e.ToString() + "islemYap FNC");
                        listLog.Items.Add("Hata Alındı" + e);
                        deger = 0;
                        tmrIslemU.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }

                }
            }
            if (tur == 3)
            {
                try
                {
                    sure = Convert.ToInt16(driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[3]/android.widget.TextView[1]")).Text) + 15;
                    textBox1.Text = sure.ToString();
                    listLog.Items.Add("Süre çekildi." + sure);
                }
                catch (Exception e)
                {
                    timeErrorCount++;
                    listLog.Items.Add("Süre çekiliyor hata " + timeErrorCount);
                    if (timeErrorCount > 2)
                    {
                        projectErrorCount++;
                        tmrTimeSub.Start();
                        Console.WriteLine(e.ToString() + "islemYap FNC");
                        listLog.Items.Add("Hata Alındı" + e);
                        deger = 0;
                        tmrIslemSub.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }

                }
            }

        }
        int girisDeger = 0;


        private void tmrGiris_Tick(object sender, EventArgs e)
        {
            girisDeger++;
            if (girisDeger == 2)
            {
                IWebElement skipClick = driver.FindElement(By.Id("sub4sub.subchat:id/txt_ftu_skip"));
                skipClick.Click();
            }
            if (girisDeger == 5)
            {
                IWebElement singIn = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.Button"));
                singIn.Click();
            }
            if (girisDeger == 7)
            {
                IWebElement userSelected = driver.FindElement(By.Id("com.google.android.gms:id/account_display_name"));
                userSelected.Click();
            }
            if (girisDeger == 15)
            {
                deger = 0;
                girisDeger = 0;
                tmrIslem.Start();
                tmrGiris.Stop();
            }
        }

        int time = 0;
        [Obsolete]
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
            lblDeger.Text = time.ToString();
            if (time == 1)
            {
                time = 70;
                listLog.Items.Clear();
                playErrorCount = 0;
                timeErrorCount = 0;
                lblProjectError.Text = "Hata Sayısı = " + projectErrorCount.ToString();
                if (projectErrorCount > 3)
                {
                    emiCloseFNC();
                    time = 70;
                }
                else
                {
                    time = 70;
                }
            }
            if (time == 6)
            {
                emuStart(deviceName, deviceID, service);

            }
            if (time == 79)
            {
                int check = emiOpeningCheck(deviceID);
                if (check == 0)
                {
                    time = 0;
                }
            }
            else if (time == 80)
            {
                emilatorEtkinlestir(emi1ServiceInfo, deviceID, deviceName, subPackage, subActivity);
            }
            else if (time == 105)
            {
                coinGet(1);
            }

        }
        private void settingsWrite()
        {
            txtService.Text = Settings.Default.appiumService;
            txtDeviceID.Text = Settings.Default.deviceID;
            txtVideoLink.Text = Settings.Default.videoLink;
            txtDeviceName.Text = Settings.Default.deviceName;
        }
        int getCoinError = 0;
        private void coinGet(int tur)

        {
            if (tur == 1)
            {
                try
                {
                    string coinS = driver.FindElement(By.Id("sub4sub.subchat:id/coin")).Text;
                    int coin = Convert.ToInt32(coinS);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslem.Stop();
                        deger = 0;
                        tmrCamp.Start();
                        tmrTime.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                    else
                    {
                        listLog.Items.Add("işlem başlatılıyor.");
                        tmrIslem.Start();
                        tmrTime.Stop();
                        time = 0;
                        deger = 0;
                        getCoinError = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        time = 0;
                        Console.WriteLine(e.ToString() + "Coin Çekilemedi.");
                        listLog.Items.Add("Hata Alındı Coin Çekilemedi" + e);
                        deger = 0;
                        tmrIslem.Stop();
                    }
                    else
                    {
                        listLog.Items.Add("get Coin Error " + getCoinError);
                        time = 0;
                    }
                }
            }
            if (tur == 2)
            {
                try
                {
                    int coin = Convert.ToInt32(driver.FindElement(By.Id("cptstudio.sub4sub:id/coin")).Text);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslemU.Stop();
                        deger = 0;
                        tmrCampU.Start();
                        tmrTimeU.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                    else
                    {
                        listLog.Items.Add("işlem başlatılıyor.");
                        tmrIslemU.Start();
                        tmrTimeU.Stop();
                        time = 0;
                        deger = 0;
                        getCoinError = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        time = 0;
                        Console.WriteLine(e.ToString() + "Coin Çekilemedi.");
                        listLog.Items.Add("Hata Alındı Coin Çekilemedi" + e);
                        deger = 0;
                        tmrIslemU.Stop();
                    }
                    else
                    {
                        listLog.Items.Add("get Coin Error " + getCoinError);
                        time = 0;
                    }
                }
            }
            if (tur == 3)
            {
                try
                {
                    string coinS = driver.FindElement(By.Id("com.tubeforces.get_sub:id/user_coin_text")).Text;
                    int coin = Convert.ToInt32(coinS);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslemSub.Stop();
                        deger = 0;
                        tmrCampSub.Start();
                        tmrTimeSub.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                    else
                    {
                        listLog.Items.Add("işlem başlatılıyor.");
                        tmrIslemSub.Start();
                        tmrTimeSub.Stop();
                        time = 0;
                        deger = 0;
                        getCoinError = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        time = 0;
                        Console.WriteLine(e.ToString() + "Coin Çekilemedi.");
                        listLog.Items.Add("Hata Alındı Coin Çekilemedi" + e);
                        deger = 0;
                        tmrIslemSub.Stop();
                    }
                    else
                    {
                        listLog.Items.Add("get Coin Error " + getCoinError);
                        time = 0;
                    }
                }
            }

        }

        private void coinGetRef(int tur)
        {
            if (tur == 1)
            {
                try
                {
                    int coin = Convert.ToInt32(driver.FindElement(By.Id("sub4sub.subchat:id/coin")).Text);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslem.Stop();
                        deger = 0;
                        tmrCamp.Start();
                        tmrTime.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        deger = 0;
                        time = 0;
                        tmrTime.Start();
                        tmrIslem.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }
                }
            }
            if (tur == 2)
            {
                try
                {
                    int coin = Convert.ToInt32(driver.FindElement(By.Id("cptstudio.sub4sub:id/coin")).Text);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslemU.Stop();
                        deger = 0;
                        tmrCampU.Start();
                        tmrTimeU.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        time = 0;
                        deger = 0;
                        tmrTimeU.Start();
                        tmrIslemU.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }
                }
            }
            if (tur == 3)
            {
                try
                {
                    int coin = Convert.ToInt32(driver.FindElement(By.Id("com.tubeforces.get_sub:id/user_coin_text")).Text);
                    listLog.Items.Add("Coin Çekildi." + coin);
                    if (coin > islemYapCoinCheck)
                    {
                        tmrIslemSub.Stop();
                        deger = 0;
                        tmrCampSub.Start();
                        tmrTimeSub.Stop();
                        getCoinError = 0;
                        time = 0;
                    }
                }
                catch (Exception e)
                {
                    getCoinError++;
                    listLog.Items.Add("get Coin Error " + getCoinError);
                    if (getCoinError > 2)
                    {
                        projectErrorCount++;
                        time = 0;
                        deger = 0;
                        tmrTimeSub.Start();
                        tmrIslemSub.Stop();
                    }
                    else
                    {
                        deger = -5;
                    }
                }
            }
        }
        private void adbKiller()
        {
            foreach (var process in Process.GetProcessesByName("adb"))
            {
                listLog.Items.Add(process.ProcessName);
                process.Kill();
            }
        }
        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {





            //AppiumOptions capabilities = new AppiumOptions();
            //capabilities.AddAdditionalCapability("device", "127.0.0.1:6800");
            //capabilities.AddAdditionalAppiumOption("platformName", "Android");
            //capabilities.AddAdditionalCapability("DeviceName", "127.0.0.1:6800");
            //capabilities.AddAdditionalCapability("appPackage", subPackage);
            //capabilities.AddAdditionalCapability("appActivity", subActivity);

            //driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723" + "/wd/hub"), capabilities);

            //{
            //                "udid": "emulator-5554",
            //"deviceName": "OnePlus5",
            //"platformName": "Android"
            //}
            //)


            //emilatorEtkinlestir(txtService.Text, deviceID, deviceName, subPackage, subActivity);
            //Settings.Default.ProjeType = Convert.ToInt16(txtProjectType.Text);
            //Settings.Default.Save();
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "APKYonetici.exe");
            //Environment.Exit(0);
        }

        int campsDeger = 0;
        private void tmrCamp_Tick(object sender, EventArgs e)
        {
            campsDeger++;
            if (campsDeger == 2)
            {
                clickEventXPFNC("//android.widget.FrameLayout[@content-desc=\"Campaign\"]/android.widget.ImageView"); // Campaign gate
            }
            if (campsDeger == 4)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[3]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.ImageView[2]"); //Remove first click
            }
            if (campsDeger == 6)
            {
                clickEventIDFNC("sub4sub.subchat:id/title"); //second
            }
            if (campsDeger == 8)
            {
                clickEventIDFNC("android:id/button1"); //third
            }
            if (campsDeger == 11)
            {
                clickEventIDFNC("sub4sub.subchat:id/fab");
            }
            if (campsDeger == 14)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.TextView");
            }
            if (campsDeger == 17)
            {
                IWebElement userSelected = driver.FindElement(By.Id("sub4sub.subchat:id/edittext_yt_url"));
                userSelected.SendKeys(txtVideoLink.Text);
            }
            if (campsDeger == 20)
            {
                clickEventIDFNC("sub4sub.subchat:id/btn_add");
                listLog.Items.Add("Add finish");
            }
            if (campsDeger == 25)
            {
                clickEventIDFNC("sub4sub.subchat:id/btn_time_required");
            }
            if (campsDeger == 27)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 29)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 31)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 33)
            {
                clickEventIDFNC("sub4sub.subchat:id/btnSelect");
            }
            if (campsDeger == 35)
            {
                clickEventIDFNC("sub4sub.subchat:id/btn_order_done");
                listLog.Items.Add("done finish");
            }
            //if (campsDeger == 38)
            //{
            //    clickEventXPFNC("//android.widget.FrameLayout[@content-desc=\"View\"]/android.widget.ImageView");
            //    listLog.Items.Add("Play Ekranına Geçti.");
            //}
            if (campsDeger == 36)
            {
                campsDeger = 0;
                tmrCamp.Stop();
                tmrTime.Start();
            }
        }
        private void clickEventIDFNC(string element)
        {
            try
            {

                IWebElement userSelected = driver.FindElement(By.Id(element));
                userSelected.Click();
            }
            catch (Exception ex)
            {
                projectErrorCount++;
                listLog.Items.Add("Click Event ID Error " + ex.ToString());
            }

        }
        private void clickEventXPFNC(string element)
        {
            try
            {
                IWebElement userSelected = driver.FindElement(By.XPath(element));
                userSelected.Click();
            }
            catch (Exception ex)
            {
                projectErrorCount++;
                listLog.Items.Add("Click Event XP Error " + ex.ToString());
            }
        }

        private void emiClose(string emiCode)
        {
            //driver.Close();
            //string cmdstr = "adb -s " + emiCode + " emu kill";
            //try
            //{
            //    Process pr = new Process();
            //    pr.StartInfo.FileName = "cmd.exe";
            //    pr.StartInfo.Arguments = "/c " + cmdstr;
            //    pr.Start();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            emiConnection(deviceID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            service = txtService.Text;
            deviceID = txtDeviceID.Text;
            deviceName = txtDeviceName.Text;

            Settings.Default.appiumService = service;
            Settings.Default.deviceID = deviceID;
            Settings.Default.videoLink = txtVideoLink.Text;
            Settings.Default.deviceName = txtDeviceName.Text;
            Settings.Default.ProjeType = Convert.ToInt16(txtProjectType.Text);
            Settings.Default.adbConnection = false;
            Settings.Default.Save();
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "APKYonetici.exe");
            Environment.Exit(0);
        }

        [Obsolete]
        private void tmrTimeU_Tick(object sender, EventArgs e)
        {
            time++;
            lblDeger.Text = time.ToString();
            if (time == 1)
            {
                time = 70;
                listLog.Items.Clear();
                playErrorCount = 0;
                timeErrorCount = 0;
                lblProjectError.Text = "Hata Sayısı = " + projectErrorCount.ToString();
                if (projectErrorCount > 5)
                {
                    emiCloseFNC();
                    time = 70;
                }
                else
                {
                    time = 70;
                }
            }
            if (time == 6)
            {
                emuStart(deviceName, deviceID, service);

            }
            if (time == 79)
            {
                int check = emiOpeningCheck(deviceID);
                if (check == 0)
                {
                    time = 0;
                }
            }
            else if (time == 80)
            {
                emilatorEtkinlestir(service, deviceID, deviceName, uChannalPackage, uChannalActivity);
            }
            else if (time == 105)
            {
                coinGet(2);
            }
        }

        [Obsolete]
        private void tmrIslemU_Tick(object sender, EventArgs e)
        {
            deger++;
            lblDeger.Text = deger.ToString();
            if (deger == 2)
            {
                int kontrol = reloadCheck("cptstudio.sub4sub:id/btn_reload");
                if (kontrol == 0)
                {
                    deger = -10;
                    freeLap++;
                    if (freeLap > 2)
                    {
                        projectChange(typeSub43);
                    }
                }
            }
            if (deger == 3)
            {
                coinGetRef(2);
                islemYap(2);

            }
            if (deger == 4)
            {
                listLog.SelectedIndex = listLog.Items.Count - 1;
                videoClick();
                videoClickCount++;
                lblVideoCount.Text = "Tıklanan Video Sayısı = " + videoClickCount;
            }
            if (deger == (sure - 5))
            {
                int kontrol = reloadCheck("cptstudio.sub4sub:id/txt_time_required");
                if (kontrol == 0)
                {
                    if (videoClickCount > uChannelProccesCount)
                    {
                        projectChange(typeSub43);
                    }
                    playErrorCount = 0;
                    timeErrorCount = 0;
                    deger = 0;
                    sure = 9999;
                    freeLap = 0;
                }
            }
            if (deger == sure)
            {
                if (videoClickCount > uChannelProccesCount)
                {
                    projectChange(typeSub43);
                }
                playErrorCount = 0;
                timeErrorCount = 0;
                deger = 0;
                sure = 9999;
                freeLap = 0;
            }
        }

        private void tmrCampU_Tick(object sender, EventArgs e)
        {
            campsDeger++;
            if (campsDeger == 2)
            {
                clickEventXPFNC("//android.widget.FrameLayout[@content-desc=\"Campaign\"]/android.widget.ImageView"); // Campaign gate
            }
            if (campsDeger == 4)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[3]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.ImageView[2]"); //Remove first click
            }
            if (campsDeger == 6)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/title"); //second
            }
            if (campsDeger == 8)
            {
                clickEventIDFNC("android:id/button1"); //third
            }
            if (campsDeger == 11)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/fab");
            }
            if (campsDeger == 14)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.TextView");
            }
            if (campsDeger == 17)
            {
                IWebElement userSelected = driver.FindElement(By.Id("cptstudio.sub4sub:id/edittext_yt_url"));
                userSelected.SendKeys(txtVideoLink.Text);
            }
            if (campsDeger == 20)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/btn_add");
                listLog.Items.Add("Add finish");
            }
            if (campsDeger == 25)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/btn_time_required");
            }
            if (campsDeger == 27)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 29)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 31)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 33)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/btnSelect");
            }
            if (campsDeger == 35)
            {
                clickEventIDFNC("cptstudio.sub4sub:id/btn_order_done");
                listLog.Items.Add("done finish");
            }
            //if (campsDeger == 38)
            //{
            //    clickEventXPFNC("//android.widget.FrameLayout[@content-desc=\"View\"]/android.widget.ImageView");
            //    listLog.Items.Add("Play Ekranına Geçti.");
            //}
            if (campsDeger == 36)
            {
                campsDeger = 0;
                tmrCampU.Stop();
                tmrTimeU.Start();
            }
        }
        private void projectChange(int type)
        {
            foreach (var process in Process.GetProcessesByName("adb"))
            {
                process.Kill();
            }
            Settings.Default.ProjeType = type;
            Settings.Default.Save();
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "APKYonetici.exe");
            Environment.Exit(0);
        }

        [Obsolete]
        private void tmrTimeSub_Tick(object sender, EventArgs e)
        {
            time++;
            lblDeger.Text = time.ToString();
            if (time == 1)
            {
                time = 70;
                listLog.Items.Clear();
                playErrorCount = 0;
                timeErrorCount = 0;
                lblProjectError.Text = "Hata Sayısı = " + projectErrorCount.ToString();
                if (projectErrorCount > 5)
                {
                    emiCloseFNC();
                    time = 70;
                }
                else
                {
                    time = 70;
                }
            }
            if (time == 6)
            {
                emuStart(deviceName, deviceID, service);

            }
            if (time == 79)
            {
                int check = emiOpeningCheck(deviceID);
                if (check == 0)
                {
                    time = 0;
                }
            }
            else if (time == 80)
            {
                emilatorEtkinlestir(service, deviceID, deviceName, sub4subPackage, sub4subActivity);
            }
            else if (time == 103)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ImageView");
            }
            else if (time == 107)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.cardview.widget.CardView[3]/android.widget.ImageView");
            }
            else if (time == 111)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ImageView");
            }
            else if (time == 113)
            {
                coinGet(3);
            }
        }

        private void tmrCampSub_Tick(object sender, EventArgs e)
        {
            campsDeger++;
            if (campsDeger == 2)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/fabMore");
            }
            if (campsDeger == 4)
            {
                IWebElement userSelected = driver.FindElement(By.Id("com.tubeforces.get_sub:id/linkEditTextId"));
                userSelected.SendKeys(txtVideoLink.Text);
            }
            if (campsDeger == 6)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/linkAddBtnId");
            }
            if (campsDeger == 8)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/like_radio_btn");
            }
            if (campsDeger == 10)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/timeNumberPickerId");
            }
            if (campsDeger == 12)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.cardview.widget.CardView/android.widget.LinearLayout/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 14)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.cardview.widget.CardView/android.widget.LinearLayout/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 16)
            {
                clickEventXPFNC("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.cardview.widget.CardView/android.widget.LinearLayout/android.widget.NumberPicker/android.widget.Button[2]");
            }
            if (campsDeger == 18)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/dialogSelectBtnId");
            }
            if (campsDeger == 20)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/viewCampaignDoneBtnId");

            }
            if (campsDeger == 22)
            {

            }
            if (campsDeger == 25)
            {
                clickEventIDFNC("android:id/button1");
            }
            if (campsDeger == 35)
            {
                campsDeger = 0;
                tmrCampSub.Stop();
                tmrTimeSub.Start();
            }
        }

        [Obsolete]
        private void tmrIslemSub_Tick(object sender, EventArgs e)
        {
            deger++;
            lblDeger.Text = deger.ToString();
            if (deger == 2)
            {
                int kontrol = reloadCheck("cptstudio.sub4sub:id/btn_reload");
                if (kontrol == 0)
                {
                    deger = -10;
                    freeLap++;
                    if (freeLap > 2)
                    {
                        projectChange(typeSubChat1);
                    }
                }
            }
            if (deger == 3)
            {
                coinGetRef(3);
                islemYap(3);

            }
            if (deger == 4)
            {
                listLog.SelectedIndex = listLog.Items.Count - 1;
                videoClick();
                videoClickCount++;
                lblVideoCount.Text = "Tıklanan Video Sayısı = " + videoClickCount;
            }
            if (deger == (sure - 5))
            {
                //sure = Convert.ToInt16(driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[3]/android.widget.TextView[1]")).Text) + 15;
                //int sureX = Convert.ToInt16(driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[3]/android.widget.TextView[1]")).Text) + 10;
                //listLog.Items.Add(sureX);
                //if (sureX == 0)
                //{
                //    if (videoClickCount > sub4subProccesCount)
                //    {
                //        projectChange(typeSubChat1);
                //    }
                //    playErrorCount = 0;
                //    timeErrorCount = 0;
                //    deger = 0;
                //    sure = 9999;
                //    freeLap = 0;
                //}
                //clickEventIDFNC("com.tubeforces.get_sub:id/button2");
                //int kontrol = reloadCheck("cptstudio.sub4sub:id/txt_time_required");
                //if (kontrol == 0)
                //{
                //    if (videoClickCount > sub4subProccesCount)
                //    {
                //        projectChange(typeSubChat1);
                //    }
                //    playErrorCount = 0;
                //    timeErrorCount = 0;
                //    deger = 0;
                //    sure = 9999;
                //    freeLap = 0;
                //}
            }
            if (deger == sure)
            {
                clickEventIDFNC("com.tubeforces.get_sub:id/button2");
                if (videoClickCount > sub4subProccesCount)
                {
                    projectChange(typeSubChat1);
                }
                playErrorCount = 0;
                timeErrorCount = 0;
                deger = 0;
                sure = 9999;
                freeLap = 0;
            }
        }
        private void emiCloseFNC()
        {
            emiClose(deviceID);
            projectErrorCount = 0;
            tmrCamp.Stop();
            tmrCampSub.Stop();
            tmrCampU.Stop();
            tmrIslem.Stop();
            tmrIslemSub.Stop();
            tmrIslemU.Stop();
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            emilatorEtkinlestir(emi1ServiceInfo, deviceID, deviceName, instagramPackage, instagramActivity);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TouchActions action = new TouchActions(driver);
            //IWebElement playClick = driver.FindElement(By.XPath("//android.widget.FrameLayout[@content-desc=\"Close friends\"]/android.widget.TextView"));
            //IWebElement elem2 = driver.FindElement(By.Id("com.instagram.android:id/quick_capture_top_shadow_overlay"));
            //for (int i = 0; i < 99; i++)
            //{
            //    action.LongPress(playClick);
            //    action.ClickAndHold(playClick);
            //    action.Move(417, 175);
            //}
            for (int i = 0; i < 6; i++)
            {
                //new TouchAction(driver).Press(x:536, y:1588).Wait(1000).MoveTo(x: 540, y: 397).Release().Perform();
                new TouchActions(driver).Down(536, 1588).Up(548, 397).Perform();
            }


            //TouchAction action = new TouchAction(driver);
            ////action.Scroll(playClick, 10, 100);
            ////action.Perform();

            //action.Press(playClick).MoveTo(elem2).Release();

            //TouchAction action = new TouchAction(driver);


            //          (new TouchAction(driver))
            //.press({ x: 536, y: 1588})
            //.moveTo({ x: 540: y: 397})
            //.release()
            //.perform()







        }
    }
}
