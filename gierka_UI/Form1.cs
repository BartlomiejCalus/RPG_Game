using System.IO;

namespace gierka_UI
{
    public partial class Form1 : Form
    {

        int i=0;
        bool autoSave;
        int action = 0;

        StreamWriter sw;

        Postaæ gracz = new Postaæ();

        string[] fabula = new string[] {
            "Rok 1274, zosta³eœ wezwany do króla Zygmunta Czwartego na powa¿n¹ rozmowe. Podczas rozmowy, dowiadujesz siê o powa¿nym problemie owego królestwa. Król prosi ciê o pomoc z pokonaniem potê¿nego potwora, który nêka okoliczne wioski. Znajduje siê on w Jaskini Mroku, gdzie spoczywa przez wiêkszoœæ czasu. Czy przyjmujesz propozycjê?",
             "Król ucieszy³ siê s³ysz¹c twoj¹ zgode na pokonanie okropnej bestii.Przekazujesz mu ¿e potrzebujesz czasu na przygotowanie i mo¿esz wyruszyæ w trasê.  3 dni póŸniejPrzygotowany ruszasz na wyprawê, wiesz, ¿e nie bêdzie to prosta misja lecz jesteœ zdeterminowany aby pomóc okolicznej ludnoœci.Król przekaza³ ci mapê, z tras¹ do Jaskini Mroku.",
            "Gdy jesteœ ju¿ pod jaskini¹ mroku zwracasz uwagê na os³upiaj¹c¹ ciszê, która cie niepokoi.Zanim jednak zd¹¿y³eœ siê nad tym zastanowiæ, z krzaków atakuje ciê jaskiniowy goblin. ",
           "Po pokonaniu parszywego goblina, zaczynasz zag³êbiaæ siê w jaskiniê, obserwujesz mnóstwo porozrzucanych ludzi, a bardziej to co z nich zosta³o. Smród jaki by³ odczuwany jest nie do porównania z czymkolwiek innym. Z przera¿eniem obserwujesz jak dewastuj¹c¹ si³ê posiada bestia która nawiedza ca³e królestwo, wszêdzie porozrzucane s¹ szcz¹tki domów i ich mieszkañców.Natrafiasz na dwie ró¿ne œcie¿ki, id¹ca w praw¹ stronê wygl¹da na rzadziej u¿ywan¹, druga natomiast wydaje siê ¿e by³a wykorzystana niedawno co rozponzajesz po œwie¿ych œladach nienaturalnych stóp.",          
            "Udajesz siê w praw¹ stronê. Otaczaj¹ca ciê ciemnoœæ budzi twój niepokój. Mimo tego, ¿e œcie¿ka nie wydaje siê byæ zbytnio uczêszczana masz obawy z powodu potencjalnych zagro¿eñ. Eksploruj¹c dalej droge s³yszysz niespodziewane klikniêcie pod swoimi nogami. Nadepn¹³eœ na p³ytkê naciskow¹, która aktywuje pu³apkê.",
             "Kontynuujesz swoj¹ podró¿ w g³¹b ciemnej jaskini. Okazuje siê, ¿e jest to gniazdo nietoperzy, w którym przesiaduje nietoperz matka.",
            "Orientujesz siê, ¿e tunel którym zmierzasz powoli zmierza ku koñcowi. Po ciê¿kich przeprawach postanawiasz wróciæ do drugiego tunelu, który musi prowadziæ do straszliwej bestii",
            "Po godzinach wêdrówki docierasz do lasu. Szelest liœci ko³ysanych na wietrze dzia³a na Ciebie uspokajaj¹co. Powoli zag³êbiasz siê w las, robi siê coraz ciemniej. Jakieœ uczucie nie daje Ci spokoju.",
            "Na twojej drodze pojawi³ siê goblin.",
            "Po wyjœciu z lasu docierasz na ³¹kê. Rozci¹ga siê ona po horyzont. Zapach kwiatów jest tutaj bardzo intensywny. W koñcu docierasz do jaskini bossa. Postanawiasz wejœæ do œrodka. Twoim oczom ukazuje siê ogromny ork. Przedstawia siê jako Norbert Gierczak."
        };

        string[] choose_1 = new string[] { "Orzuæ oferte", "OK","Atak frontalny","Ide w prawo", 
            "Padnij", "Zajdz od tylu","OK", //prawo
            "OK","Atak","Atak","Atak" //lewo
        };

        string[] choose_2 = new string[] { "Przyjmij oferte", "OK", "Cichy atak","Ide w lewo", 
            "Odskocz w bok", "Zaatakuj frontalnie", "OK", //prawo
            "OK","Atak od ty³u/ucieczka","Rozmowa","Ucieczka" //lewo
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
                MessageBox.Show("Przed rozpoczêciem gry stwórz postaæ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StreamReader sr = File.OpenText(path);
                gracz.podaj_imie(sr.ReadLine());
                hero_klas = sr.ReadLine();
                gracz.podaj_wygl¹d(Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()), hero_klas);
                sr.Close();

                Klasa_label.Text = gracz.wyœwietl_klasa();
                IMIE_label.Text = gracz.wyœwietl_imie();
                Waga_label.Text = "WAGA: " + gracz.wyœwietl_waga().ToString();
                Wiek_label.Text = "WIEK: " + gracz.wyœwietl_wiek().ToString();
                Wzrost_label.Text = "WZROST: " + gracz.wyœwietl_wzrost().ToString();


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
                MessageBox.Show("Przeszkody napotkane okaza³y siê dla ciebie za trudne, starci³eœ ca³e swoje HP", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("BRAWO PRZEGRA£EŒ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Przeszkody napotkane okaza³y siê dla ciebie za trudne, starci³eœ ca³e swoje HP", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("BRAWO PRZEGRA£EŒ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        void my_fab()
        {
            
            switch (i) {
                case 0:
                    if(action == 1)
                    {
                        MessageBox.Show("Nie zaakceptowa³eœ oferty, król Ciê wypêdzi³ z wioski.\n GAME OVER", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        MessageBox.Show("Przeciwnik okaza³a siê za mocny", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda³o Ci siê go pokonaæ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        MessageBox.Show("Strza³y z kuszy przelecia³y nad tob¹, lecz by³o blisko tragicznego zakoñczenia.Wiesz, ¿e musisz bardziej uwa¿aæ na kroki.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Podczas odskakiwania obrywasz jedn¹ strza³¹ w ramie.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        action = 0;
                    }
                    break;

                case 5:

                    if (action == 1)
                    {

                        MessageBox.Show("By³ to nieop³acalny ruch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda³o Ci siê pokon¹c nietoperz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    break;

                case 6:

                    if (action == 1)
                    {

                        MessageBox.Show("By³ to nieop³acalny ruch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 15;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Uda³o Ci siê pokon¹c nietoperz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    break;

                case 7:
                    
                   
                    if (widzenie_Check.Checked)
                    {

                        MessageBox.Show("Po chwili go dostrzegasz, samotny goblin stoi na obranej przez Ciebie œcie¿ce.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;

                    }
                    else if (!widzenie_Check.Checked)
                    {

                        MessageBox.Show("Z bij¹cym sercem postanawiasz kontynuowaæ wêdrówkê", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ++i;
                        action = 0;
                    }
                    
                    break;

                case 8:

                    if (action == 1)
                    {

                        MessageBox.Show("Atak frontalny siê powiód³. Goblin zszed³ na Hitaaa. To wielkie zwyciêstwo, bêdziesz je d³ugo wspomina³. Niestety odnios³eœ w walce rany.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
                            MessageBox.Show("Postanawiasz obejœæ przeciwnika na oko³o. Niestety po drodze potkn¹³eœ siê o ga³¹Ÿ i rozci¹³eœ sobie kolano. Starasz siê zatamowaæ krwotok.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gracz.hp = gracz.hp - 10;

                            HP_label.Text = gracz.hp.ToString();
                        }else if (widzenie_Check.Checked)
                        {
                            MessageBox.Show("Nie da³eœ przeciwnikowi szansy na jak¹kolwiek reakcjê. Twoje ostrze bezszelestnie wyjête z nadgarstka przejecha³o po jego kratani. Przeszukuj¹c jego zw³oki znajdujesz miksturê ¿ycia i postanawiasz j¹ wypiæ.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                        MessageBox.Show("Ork okaza³ siê silniejszy ni¿ pocz¹tkoowo zak³da³eœ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gracz.hp = gracz.hp - 25;
                        HP_label.Text = gracz.hp.ToString();
                        ++i;
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Po d³ugiej i wyczerpuj¹cej rozmowie uda³o Ci siê przekonac orka, ¿e granie w lola to nie jest najlepszy sposób na spêdzanie wolnego czasu. Ork wyjecha³ na mazury i ju¿ nigdy nie by³ widziany w tej krainie.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO WYGRA£EŒ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;
                    }
                    break;

                case 10:

                    if (action == 1)
                    {

                        MessageBox.Show("Wbi³eœ miecz w cia³o orka, a¿ po sam¹ rêkojeœæ. Posoka krwi rozla³a siê po pod³odze. Z wielkim trudem wyj¹³eœ miecz i stan¹³eœ triumfalnie na zw³okach wroga.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO WYGRA£EŒ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        action = 0;

                    }
                    else if (action == 2)
                    {

                        MessageBox.Show("Zaczynasz uciekaæ w pop³ochu. Niestety Norbert jest szybszy. £apie Ciê za nogi i rozrywa na pó³. Umierasz w mêczarniach.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("BRAWO PRZEGRA£EŒ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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