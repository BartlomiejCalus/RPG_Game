using System.IO;

namespace gierka_UI
{
    public partial class Form1 : Form
    {

        int i=0;
        bool autoSave;
        int action = 0;

        StreamWriter sw;

        Posta� gracz = new Posta�();

        string[] fabula = new string[] {
            "Rok 1274, zosta�e� wezwany do kr�la Zygmunta Czwartego na powa�n� rozmowe. Podczas rozmowy, dowiadujesz si� o powa�nym problemie owego kr�lestwa. Kr�l prosi ci� o pomoc z pokonaniem pot�nego potwora, kt�ry n�ka okoliczne wioski. Znajduje si� on w Jaskini Mroku, gdzie spoczywa przez wi�kszo�� czasu. Czy przyjmujesz propozycj�?",
             "Kr�l ucieszy� si� s�ysz�c twoj� zgode na pokonanie okropnej bestii.Przekazujesz mu �e potrzebujesz czasu na przygotowanie i mo�esz wyruszy� w tras�.  3 dni p�niejPrzygotowany ruszasz na wypraw�, wiesz, �e nie b�dzie to prosta misja lecz jeste� zdeterminowany aby pom�c okolicznej ludno�ci.Kr�l przekaza� ci map�, z tras� do Jaskini Mroku.",
            "Gdy jeste� ju� pod jaskini� mroku zwracasz uwag� na os�upiaj�c� cisz�, kt�ra cie niepokoi.Zanim jednak zd��y�e� si� nad tym zastanowi�, z krzak�w atakuje ci� jaskiniowy goblin. ",
           "Po pokonaniu parszywego goblina, zaczynasz zag��bia� si� w jaskini�, obserwujesz mn�stwo porozrzucanych ludzi, a bardziej to co z nich zosta�o. Smr�d jaki by� odczuwany jest nie do por�wnania z czymkolwiek innym. Z przera�eniem obserwujesz jak dewastuj�c� si�� posiada bestia kt�ra nawiedza ca�e kr�lestwo, wsz�dzie porozrzucane s� szcz�tki dom�w i ich mieszka�c�w.Natrafiasz na dwie r�ne �cie�ki, id�ca w praw� stron� wygl�da na rzadziej u�ywan�, druga natomiast wydaje si� �e by�a wykorzystana niedawno co rozponzajesz po �wie�ych �ladach nienaturalnych st�p.",          
            "Udajesz si� w praw� stron�. Otaczaj�ca ci� ciemno�� budzi tw�j niepok�j. Mimo tego, �e �cie�ka nie wydaje si� by� zbytnio ucz�szczana masz obawy z powodu potencjalnych zagro�e�. Eksploruj�c dalej droge s�yszysz niespodziewane klikni�cie pod swoimi nogami. Nadepn��e� na p�ytk� naciskow�, kt�ra aktywuje pu�apk�.",
             "Kontynuujesz swoj� podr� w g��b ciemnej jaskini. Okazuje si�, �e jest to gniazdo nietoperzy, w kt�rym przesiaduje nietoperz matka.",
            "Orientujesz si�, �e tunel kt�rym zmierzasz powoli zmierza ku ko�cowi. Po ci�kich przeprawach postanawiasz wr�ci� do drugiego tunelu, kt�ry musi prowadzi� do straszliwej bestii",
            "Po godzinach w�dr�wki docierasz do lasu. Szelest li�ci ko�ysanych na wietrze dzia�a na Ciebie uspokajaj�co. Powoli zag��biasz si� w las, robi si� coraz ciemniej. Jakie� uczucie nie daje Ci spokoju.",
            "Na twojej drodze pojawi� si� goblin.",
            "Po wyj�ciu z lasu docierasz na ��k�. Rozci�ga si� ona po horyzont. Zapach kwiat�w jest tutaj bardzo intensywny. W ko�cu docierasz do jaskini bossa. Postanawiasz wej�� do �rodka. Twoim oczom ukazuje si� ogromny ork. Przedstawia si� jako Norbert Gierczak."
        };

        string[] choose_1 = new string[] { "Orzu� oferte", "OK","Atak frontalny","Ide w prawo", 
            "Padnij", "Zajdz od tylu","OK", //prawo
            "OK","Atak","Atak","Atak" //lewo
        };

        string[] choose_2 = new string[] { "Przyjmij oferte", "OK", "Cichy atak","Ide w lewo", 
            "Odskocz w bok", "Zaatakuj frontalnie", "OK", //prawo
            "OK","Atak od ty�u/ucieczka","Rozmowa","Ucieczka" //lewo
        };

        string path = @"MyHero.txt";

        public Form1()
        {
            InitializeComponent();
            
            widzenie_Check.Enabled = false;
            tarcza_check.Enabled = false;
            magia_check.Enabled = false;

            action_panel.Hide();
            hero_panel.Hide();
            stats_panel.Hide();

            Action_2.Hide();
            Acion_1.Hide();

            LoadGAME_button.Hide();

            exit_button.Show();

        }

        private void HP_label_Click(object sender, EventArgs e)
        {

        }

        private void POWER_label_Click(object sender, EventArgs e)
        {

        }

        private void action_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SATART_button_Click(object sender, EventArgs e)
        {
            string hero_klas = "";
            
            
          
            if (!File.Exists(path))
            {
                MessageBox.Show("Przed rozpocz�ciem gry stw�rz posta�", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StreamReader sr = File.OpenText(path);
                gracz.podaj_imie(sr.ReadLine());
                hero_klas = sr.ReadLine();
                gracz.podaj_wygl�d(Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()), hero_klas);
                sr.Close();

                Klasa_label.Text = gracz.wy�wietl_klasa();
                IMIE_label.Text = gracz.wy�wietl_imie();
                Waga_label.Text = "WAGA: " + gracz.wy�wietl_waga().ToString();
                Wiek_label.Text = "WIEK: " + gracz.wy�wietl_wiek().ToString();
                Wzrost_label.Text = "WZROST: " + gracz.wy�wietl_wzrost().ToString();


                switch (hero_klas)
                {
                    case "Wojownik":

                        tarcza_check.Checked = true;
                        gracz.power = 75;
                        pictureBox1.Image = Image.FromFile(@"woj1.jpeg");

                        break;

                    case "Mag":

                        magia_check.Checked = true;
                        gracz.intel = 75;
                        pictureBox1.Image = Image.FromFile(@"mag1.jpeg");

                        break;

                    case "Ninja":

                        widzenie_Check.Checked = true;
                        gracz.agility = 75;
                        pictureBox1.Image = Image.FromFile(@"ninja1.jpg");

                        break; ;
                    }

                 HP_label.Text = gracz.hp.ToString();
                 POWER_label.Text = gracz.power.ToString();
                 AGIL_label.Text = gracz.agility.ToString();
                 INTEL_label.Text = gracz.intel.ToString();

                 action_panel.Show();
                 hero_panel.Show();
                 stats_panel.Show();

                 HERO_button.Hide();
                 SATART_button.Hide();

                 LoadGAME_button.Show();
                 Action_2.Show();
                 Acion_1.Show();
               
                 Fab.Text = fabula[i];
                Acion_1.Text = choose_1[i];
                Action_2.Text = choose_2[i];
            }
          
        }

        private void Klasa_label_Click(object sender, EventArgs e)
        {

        }


        private void Fab_TextChanged(object sender, EventArgs e)
        {

        }

        private void HERO_button_Click(object sender, EventArgs e)
        {
            HERO_button.Hide();
            Hero home_vr = new Hero();
            home_vr.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            autoSave = !checkBox1.Checked;
        }

        private void LoadGAME_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                StreamReader sr_load = File.OpenText("save.txt");
                i = Int32.Parse(sr_load.ReadLine());
                sr_load.Close();
                Fab.Text = fabula[i];
                Acion_1.Text = choose_1[i];
                Action_2.Text = choose_2[i];
            }
            else
            {
                MessageBox.Show("Brak zapisu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Acion_1_Click(object sender, EventArgs e)
        {
            action = 1;
            my_fab();
            Acion_1.Text = choose_1[i];
            Action_2.Text = choose_2[i];

            if (gracz.hp <= 0)
            {
                Fab.Text = "NO DEBIL";
                MessageBox.Show("Przeszkody napotkane okaza�y si� dla ciebie za trudne, starci�e� ca�e swoje HP", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("BRAWO PRZEGRA�E�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Action_2_Click(object sender, EventArgs e)
        {

            if (i == 3)
            {
                i = 7;
                Fab.Text = fabula[i];
                Acion_1.Text = choose_1[i];
                Action_2.Text = choose_2[i];

            }
            action = 2;
            my_fab();
            Acion_1.Text = choose_1[i];
            Action_2.Text = choose_2[i];
            
            if (gracz.hp <= 0)
            {
                MessageBox.Show("Przeszkody napotkane okaza�y si� dla ciebie za trudne, starci�e� ca�e swoje HP", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("BRAWO PRZEGRA�E�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        void my_fab()
        {
            
            switch (i) {
                case 0:
                    if(action == 1)
                    {
                        MessageBox.Show("Nie zaakceptowa�e� oferty, kr�l Ci� wyp�dzi� z wioski.\n GAME OVER", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;

                    }else if (action == 2)
                    {
                        ++i;
                        action = 0;
                    }
                    break;

                case 1:
                    action = 0;
                    ++i;
                    break;

                case 2:

                    if (action == 1)
                    {

                        MessageBox.Show("Przeciwnik okaza�a si� za mocny", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda�o Ci si� go pokona�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    break;
                case 3:
                    action = 0;
                    i++;
                    break;

                case 4:

                    if (action == 1)
                    {

                        MessageBox.Show("Strza�y z kuszy przelecia�y nad tob�, lecz by�o blisko tragicznego zako�czenia.Wiesz, �e musisz bardziej uwa�a� na kroki.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Podczas odskakiwania obrywasz jedn� strza�� w ramie.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        action = 0;
                    }
                    break;

                case 5:

                    if (action == 1)
                    {

                        MessageBox.Show("By� to nieop�acalny ruch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda�o Ci si� pokon�c nietoperz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    break;

                case 6:

                    if (action == 1)
                    {

                        MessageBox.Show("By� to nieop�acalny ruch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda�o Ci si� pokon�c nietoperz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    break;

                case 7:
                    
                   
                    if (widzenie_Check.Checked)
                    {

                        MessageBox.Show("Po chwili go dostrzegasz, samotny goblin stoi na obranej przez Ciebie �cie�ce.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;

                    }
                    else if (!widzenie_Check.Checked)
                    {

                        MessageBox.Show("Z bij�cym sercem postanawiasz kontynuowa� w�dr�wk�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    
                    break;

                case 8:

                    if (action == 1)
                    {

                        MessageBox.Show("Atak frontalny si� powi�d�. Goblin zszed� na Hitaaa. To wielkie zwyci�stwo, b�dziesz je d�ugo wspomina�. Niestety odnios�e� w walce rany.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (tarcza_check.Checked)
                        gracz.hp = gracz.hp - 30;
                        else
                        gracz.hp = gracz.hp - 50;

                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        if (!widzenie_Check.Checked)
                        {
                            MessageBox.Show("Postanawiasz obej�� przeciwnika na oko�o. Niestety po drodze potkn��e� si� o ga��� i rozci��e� sobie kolano. Starasz si� zatamowa� krwotok.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gracz.hp = gracz.hp - 10;

                            HP_label.Text = gracz.hp.ToString();
                        }else if (widzenie_Check.Checked)
                        {
                            MessageBox.Show("Nie da�e� przeciwnikowi szansy na jak�kolwiek reakcj�. Twoje ostrze bezszelestnie wyj�te z nadgarstka przejecha�o po jego kratani. Przeszukuj�c jego zw�oki znajdujesz mikstur� �ycia i postanawiasz j� wypi�.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gracz.hp = gracz.hp + 10;
                            HP_label.Text = gracz.hp.ToString();
                        }


                        ++i;
                        action = 0;
                    }
                    break;

                case 9:

                    if (action == 1)
                    {

                        MessageBox.Show("Ork okaza� si� silniejszy ni� pocz�tkoowo zak�da�e�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 25;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Po d�ugiej i wyczerpuj�cej rozmowie uda�o Ci si� przekonac orka, �e granie w lola to nie jest najlepszy spos�b na sp�dzanie wolnego czasu. Ork wyjecha� na mazury i ju� nigdy nie by� widziany w tej krainie.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO WYGRA�E�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;
                    }
                    break;

                case 10:

                    if (action == 1)
                    {

                        MessageBox.Show("Wbi�e� miecz w cia�o orka, a� po sam� r�koje��. Posoka krwi rozla�a si� po pod�odze. Z wielkim trudem wyj��e� miecz i stan��e� triumfalnie na zw�okach wroga.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO WYGRA�E�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Zaczynasz ucieka� w pop�ochu. Niestety Norbert jest szybszy. �apie Ci� za nogi i rozrywa na p�. Umierasz w m�czarniach.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO PRZEGRA�E�", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;
                    }
                    break;


            }

            if (checkBox1.Checked)
            {
                if (!File.Exists("save.txt"))
                {
                    sw = File.CreateText("save.txt");
                }
                else
                {
                    sw = new StreamWriter("save.txt");
                }

                sw.WriteLine(i);
                sw.Close();
            }

            if (i != 0 && i != 10) 
                Fab.Text = fabula[i];
            if (i == 10)
                Fab.Text = fabula[i - 1];
        }
    }
}