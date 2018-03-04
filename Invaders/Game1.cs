#region Using Statements
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
#endregion
#region Game1 Class
namespace Invaders
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        #region Variables
        #region Declared Classes of mine
        vkeyboard vk = new vkeyboard();
        savegamestorage storage = new savegamestorage();
        savefilenumst storage2 = new savefilenumst();
        Savegame sg = new Savegame();
        savenumfile snf = new savenumfile();
        Highscoressave hss = new Highscoressave();
        savehighscores storage3 = new savehighscores();
        #endregion
        #region Gamestate
        public bool MainMenu = false;
        public bool Play = false;
        public bool Start = true;
        public bool Options = false;
        public bool Pause = false;
        public bool LevelEnd = false;
        public bool GameEnd = false;
        public bool playerHit = false;
        public bool LevelFailed = false;
        public bool InvaderShipHit = false;
        public bool Shop = false;
        public bool addhigh = false;
        public bool Highscores = false;
        public bool Aus = false;
        #endregion
        #region My Variables
        public bool cakepic = true;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public InvaderShip.type lasttype;
        public string save12 = "Player1";
        public bool playbutton = false;
        public bool optionsbutton = false;
        public bool aboutuss = false;
        public bool quitbutton = false;
        public bool collision = false;
        public bool collision2 = false;
        public bool collision3 = false;
        public bool pcollision = false;
        public bool pcollision2 = false;
        public bool aboutuscoll = false;
        public bool pcollision3 = false;
        public bool quitactive = false;
        public bool aboutactive = false;
        public bool optionsactive = false;
        public bool playactive = false;
        public Vector2 _locationplaybutton;
        public Vector2 _locationoptionsbutton;
        public Vector2 _locationquitbutton;
        public Vector2 _pauseresumelocate;
        public Vector2 _pauseexitlocate;
        public Vector2 _pauseoptionslocate;
        public Texture2D addhighback = null;
        public Texture2D mmback = null;
        public Texture2D mmplay = null;
        public Texture2D mmoptions = null;
        public Texture2D mmquit = null;
        public Texture2D mmplayselect = null;
        public Texture2D mmquitselect = null;
        public Texture2D mmoptionsselect = null;
        public Vector2 origkillerlocation = new Vector2(380, 530);
        public Vector2 pausegunlocate = new Vector2(285, 300);
        public Texture2D screen1 = null;
        public Texture2D screen2 = null;
        public Texture2D screen3 = null;
        public Texture2D screen4 = null;
        public Texture2D screen5 = null;
        public Texture2D screen6 = null;
        public Texture2D screen7 = null;
        public Texture2D screen8 = null;
        public Texture2D screen9 = null;
        public Texture2D screen10 = null;
        public Texture2D screen11 = null;
        public Texture2D screen12 = null;
        public Texture2D screen13 = null;
        public Texture2D screen14 = null;
        public Texture2D screen15 = null;
        public Texture2D screen16 = null;
        public Texture2D screen17 = null;
        public Texture2D screen18 = null;
        public Texture2D screen19 = null;
        public int screeninuse = 30;
        public int money = 0;
        public int moneymult = 5;
        public int bank = 0;
        public Vector2 locat;
        public Vector2 locat2;
        const int levelfive = 5;
        public int levelmulti = 1;
        public int levelmulti2 = 2;
        public int levelmulti3 = 1;
        public bool resumeactive = false;
        public bool exitactive = false;
        public bool poptionsactive = false;
        public Texture2D pauseback = null;
        public Texture2D pauseresume = null;
        public Texture2D pauseoptions = null;
        public Texture2D pauseexit = null;
        public Texture2D pauseresumeselect = null;
        public Texture2D pauseexitselect = null;
        public Texture2D pauseoptionsselect = null;
        public Texture2D opback = null;
        public SpriteFont comicsans = null;
        public SpriteFont comicsans2 = null;
        public Vector2 test = new Vector2(300, 100);
        public bool option1 = false;
        public Vector2 op2 = new Vector2(300, 250);
        public Vector2 op3 = new Vector2(300, 300);
        public Vector2 op4 = new Vector2(300, 400);
        public Vector2 op5 = new Vector2(1, 520);
        public Vector2 moneylocate = new Vector2(1, 560);
        public Vector2 banklocate = new Vector2(70, 560);
        public Vector2 opbackb = new Vector2(0, 0);
        public int volume = 10;
        public bool opcollision = false;
        public bool opcollision2 = false;
        public bool opcollision3 = false;
        public bool opcollision4 = false;
        public bool opcollision5 = false;
        public bool opcollision6 = false;
        public bool opchoice1 = false;
        public bool opchoice2 = false;
        public bool opchoice3 = false;
        public bool opchoice4 = false;
        public bool opchoice5 = false;
        public bool opchoice6 = false;
        public bool opfromplay = false;
        AudioEngine engine;
        SoundBank sound;
        WaveBank wave;
        AudioCategory category;
        StorageContainer savecontain;
        string bankmoney;
        public Texture2D a1 = null;
        public Texture2D a2 = null;
        public Texture2D a3 = null;
        public Texture2D a4 = null;
        public Texture2D a5 = null;
        public Texture2D a7 = null;
        public Texture2D a10 = null;
        public Texture2D x10 = null;
        public Texture2D x20 = null;
        public Texture2D x2s = null;
        public Texture2D x2s2 = null;
        public Texture2D x40 = null;
        public Texture2D x80 = null;
        public Texture2D hose = null;
        public Texture2D n1 = null;
        public Texture2D n2 = null;
        public Texture2D n3 = null;
        public Texture2D n4 = null;
        public Texture2D n5 = null;
        public Texture2D shopback = null;
        public int armorup = 0;
        public int armor = 0;
        public int laserup = 0;
        public int lifeup = 0;
        public int nukelevel = 0;
        public int nukesleft = 0;
        public Vector2 laserlocateshop = new Vector2(100, 200);
        public Vector2 nukelocateshop = new Vector2(300, 200);
        public Vector2 armorlocateshop = new Vector2(500, 200);
        public Vector2 lifelocateshop = new Vector2(700, 200);
        public Vector2 nukinglocate = new Vector2(300, 560);
        public Vector2 nukelocate = new Vector2(375, 560);
        public Vector2 armorlocate = new Vector2(485, 560);
        public Vector2 wordlocate = new Vector2(400, 560);
        string nuky;
        public bool collisionshop1 = false;
        public bool collisionshop2 = false;
        public bool collisionshop3 = false;
        public bool collisionshop4 = false;
        public bool collisionshop5 = false;
        public bool collisionshop6 = false;
        public bool collisionshop7 = false;
        public bool nukeshop = false;
        public bool lasershop = false;
        public bool armorshop = false;
        public Texture2D outof = null;
        public Vector2 savebutton = new Vector2(0, 0);
        public Vector2 quitbuttonshop = new Vector2(700, 550);
        public Vector2 contineuebutton = new Vector2(700, 0);
        public bool save = false;
        public bool continue1 = false;
        public bool quit1 = false;
        public bool life1 = false;
        string bob;
        public bool hit = false;
        public Texture2D l1 = null;
        public Texture2D l2 = null;
        public Texture2D l3 = null;
        public Texture2D l4 = null;
        public Texture2D l7 = null;
        public bool fullshop = false;
        public bool full = false;
        public int loadnum = 1;
        public int highscore1 = 0;
        public int highscore2 = 0;
        public int highscore3 = 0;
        public int highscore4 = 0;
        public int highscore5 = 0;
        public int highscore6 = 0;
        public int highscore7 = 0;
        public int highscore8 = 0;
        public int highscore9 = 0;
        public int highscore10 = 0;
        public int high = 1;
        public SpriteFont comichigh = null;
        public string name1 = "n/a";
        public string name2 = "n/a";
        public string name3 = "n/a";
        public string name4 = "n/a";
        public string name5 = "n/a";
        public string name6 = "n/a";
        public string name7 = "n/a";
        public string name8 = "n/a";
        public string name9 = "n/a";
        public string name10 = "n/a";
        public bool badsave = false;
        public Vector2 name = new Vector2(150, 100);
        public Vector2 highscor = new Vector2(125, 300);
        public Vector2 level = new Vector2(125, 400);
        public Vector2 score = new Vector2(125, 500);
        public bool keypressed = false;
        public Vector2 h1 = new Vector2(50, 200);
        public Vector2 h2 = new Vector2(100, 200);
        public Vector2 h3 = new Vector2(150, 200);
        public Vector2 h4 = new Vector2(200, 200);
        public Vector2 h5 = new Vector2(250, 200);
        public Vector2 h6 = new Vector2(300, 200);
        public Vector2 h7 = new Vector2(350, 200);
        public Vector2 h8 = new Vector2(400, 200);
        public Vector2 h9 = new Vector2(450, 200);
        public Vector2 h10 = new Vector2(500, 200);
        public Vector2 logolocate = new Vector2(10, 400);
        public Vector2 us = new Vector2(40, 450);
        public Texture2D aboutus = null;
        public Texture2D logo = null;

        private Texture2D[] _skin = new Texture2D[16];



        #endregion
        #region Origional Variables
        protected Texture2D m_texAnim = null;
        protected Texture2D m_texTile = null;
        protected Texture2D laserTex = null;
        protected Texture2D explosionTex = null;
        protected Texture2D scoreFont = null;
        protected Texture2D wordScore = null;
        protected Texture2D levelCompleted1 = null;
        protected Texture2D levelCompleted2 = null;
        protected Texture2D levelCompleted3 = null;
        protected Texture2D currentlevelCompleted = null;
        protected Texture2D wordLevel = null;
        protected Texture2D line = null;
        protected Texture2D enemyshotTex = null;
        protected Texture2D playerExplosion = null;
        protected Texture2D levelFailed1 = null;
        protected Texture2D levelFailed2 = null;
        protected Texture2D levelFailed3 = null;
        protected Texture2D trashLidShield = null;
        public Texture2D cake = null;
        public Texture2D lies = null;
        //used for game state calculations
        protected double m_TotalSeconds = 0.0;
        protected double m_starter = 0.0;
        protected double m_ElapsedSeconds = 0.0;
        protected double laser_ElapsedSeconds = 0.0;
        protected double enemyshot_ElapsedSeconds = 0.0;
        public Vector2 playlocate = new Vector2(0, 0);

        //current frame of animation
        protected int m_AnimFrameNum = 0;
        protected double m_AnimFrameElapsed = 0;
        protected double m_CurrentMovemenDelay = 1;
        protected double m_AlienMovementDelay = 1;
        protected double m_ExplosionDelay = 0.1;
        protected double laser_MovementDelay = 0.3;
        //protected double laser_MovementDelay = 0.0;
        protected double enemyshot_Delay = 0.05;
        protected int max_Laser = 5;
        private Army army = new Army();
        private Gun gun = new Gun(new Vector2(380,520));
        private InvaderShip topShip = null;
        private List<Laser> Bullet = new List<Laser>();
        private List<Explosion> explosion = new List<Explosion>();
        private List<Enemyshot> enemyShot = new List<Enemyshot>();

        private List<Shield> shields = new List<Shield>();
        private List<Explosion> ShieldHit = new List<Explosion>();
        private Explosion PlayerHit = null;

        private Random rand = new Random();
        private double bulletcount = 5;
        //private double bulletcount = 9999;

        private int shipCount = 3;
        public bool bobshobo = false;
        int LevelCompletedFrame = 1;
        int GameLevel = 1;

        double newInvaderShipSeconds = 0.0f;
        double newInvaderShipDelay = 0.0f;
        Vector3 shiptype;
        hitView hitview;
        //Color print = new Color(new Vector4(1, 249, 252,255));
        Color print = new Color(new Vector4(0.004f, 0.977f, 1.0f, 255/255));

        KeyboardState keyboardState;
        // constants
        int SCREEN_WIDTH = 800;
        int SCREEN_HEIGHT = 600;
        #endregion
        #region Invader change Variable
        private int Score = 0;
        private int oldScore = 0;
        public int column = 0;
        public int column1 = 1;
        public int column2 = 2;
        public int column3 = 3;
        public int column4 = 4;
        public int column5 = 5;
        public Invader.type type1 = Invader.type.moneybags;
        public Invader.type type5 = Invader.type.hobo;
        public Invader.type type4 = Invader.type.low;
        public Invader.type type3 = Invader.type.middle;
        public Invader.type type2 = Invader.type.high;
        #endregion
        #endregion
        #region Constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        #endregion
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        #region Initialize Screen
        protected override void Initialize()
        {
            InitScreen();
            base.Initialize();
        }
        public void InitScreen()
        {
            // back buffer
            graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            graphics.PreferMultiSampling = false;
            graphics.ApplyChanges();
            m_CurrentMovemenDelay = m_AlienMovementDelay;
            newInvaderShipDelay = (rand.Next(1, 300) / 10) + 10;
            army.invaderupdate(column, type1);
            army.invaderupdate(column1, type2);
            army.invaderupdate(column2, type3);
            army.invaderupdate(column3, type4);
        }
        #endregion
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        #region Content
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            comichigh = Content.Load<SpriteFont>("comichigh");
            m_texAnim = Content.Load<Texture2D>("hobo copy");
            addhighback = Content.Load<Texture2D>("highback");
            gun.gunTexture = Content.Load<Texture2D>("squirtgun");
            lies = Content.Load<Texture2D>("Cakepart2");
            cake = Content.Load<Texture2D>("cake");
            laserTex = Content.Load<Texture2D>("laser");
            comicsans = Content.Load<SpriteFont>("comicsansms");
            comicsans2 = Content.Load<SpriteFont>("comicsansms2");
            aboutus = Content.Load<Texture2D>("about us");
            logo = Content.Load<Texture2D>("logo");
            topShip = new InvaderShip(Vector2.Zero, InvaderShip.type.Lorin);
            army.setTexture(Invader.type.moneybags, Content.Load<Texture2D>("moneybags finished copy"));
            army.setTexture(Invader.type.hobo, Content.Load<Texture2D>("hobo copy"));
            army.setTexture(Invader.type.low, Content.Load<Texture2D>("low income copy"));
            army.setTexture(Invader.type.middle, Content.Load<Texture2D>("middle income copy"));
            army.setTexture(Invader.type.high, Content.Load<Texture2D>("high income copy"));
            _skin[(int)InvaderShip.type.Matt] = Content.Load<Texture2D>("Matt");
            _skin[(int)InvaderShip.type.Matt1] = Content.Load<Texture2D>("Matt");
            _skin[(int)InvaderShip.type.Luke] = Content.Load<Texture2D>("Luke");
            _skin[(int)InvaderShip.type.Luke1] = Content.Load<Texture2D>("Luke");
            _skin[(int)InvaderShip.type.Luke2] = Content.Load<Texture2D>("Luke");
            _skin[(int)InvaderShip.type.Lorin] = Content.Load<Texture2D>("Lorin");
            _skin[(int)InvaderShip.type.Lorin1] = Content.Load<Texture2D>("Lorin");
            _skin[(int)InvaderShip.type.Lorin2] = Content.Load<Texture2D>("Lorin");
            _skin[(int)InvaderShip.type.Andrew] = Content.Load<Texture2D>("Andrew");
            _skin[(int)InvaderShip.type.Andrew1] = Content.Load<Texture2D>("Andrew");
            _skin[(int)InvaderShip.type.Andrew2] = Content.Load<Texture2D>("Andrew");
            _skin[(int)InvaderShip.type.Dan] = Content.Load<Texture2D>("Dan");
            _skin[(int)InvaderShip.type.Dan1] = Content.Load<Texture2D>("Dan");
            _skin[(int)InvaderShip.type.Dan2] = Content.Load<Texture2D>("Dan");
            _skin[(int)InvaderShip.type.Tim] = Content.Load<Texture2D>("Wharrgarbl");
            _skin[(int)InvaderShip.type.Jeff] = Content.Load<Texture2D>("Jeff");
            explosionTex = Content.Load<Texture2D>("explosion");
            screen1 = Content.Load<Texture2D>("Screen1");
            screen2 = Content.Load<Texture2D>("Screen2");
            screen3 = Content.Load<Texture2D>("Screen3");
            screen4 = Content.Load<Texture2D>("Screen4");
            screen5 = Content.Load<Texture2D>("Screen5");
            screen6 = Content.Load<Texture2D>("Screen6");
            screen7 = Content.Load<Texture2D>("Screen7");
            screen8 = Content.Load<Texture2D>("Screen8");
            screen9 = Content.Load<Texture2D>("Screen9");
            screen10 = Content.Load<Texture2D>("Screen10");
            screen11 = Content.Load<Texture2D>("Screen11");
            screen12 = Content.Load<Texture2D>("Screen12");
            screen13 = Content.Load<Texture2D>("Screen13");
            screen14 = Content.Load<Texture2D>("Screen14");
            screen15 = Content.Load<Texture2D>("Screen15");
            screen16 = Content.Load<Texture2D>("Screen16");
            screen17 = Content.Load<Texture2D>("Screen17");
            screen18 = Content.Load<Texture2D>("Screen18");
            screen19 = Content.Load<Texture2D>("Screen19");
            scoreFont = Content.Load<Texture2D>("font10");
            wordScore = Content.Load<Texture2D>("SCORE");
            opback = Content.Load<Texture2D>("opback");
            wordLevel = Content.Load<Texture2D>("Level");
            outof = Content.Load<Texture2D>("out");
            levelCompleted1 = Content.Load<Texture2D>("levelCompleted1");

            levelCompleted2 = Content.Load<Texture2D>("levelCompleted2");

            levelCompleted3 = Content.Load<Texture2D>("levelCompleted3");

            currentlevelCompleted = levelCompleted1;

            line = Content.Load<Texture2D>("line");

            enemyshotTex = Content.Load<Texture2D>("can");

            playerExplosion = Content.Load<Texture2D>("explosion4");

            levelFailed1 = Content.Load<Texture2D>("levelFailed1");

            levelFailed2 = Content.Load<Texture2D>("levelFailed2");

            levelFailed3 = Content.Load<Texture2D>("levelFailed3");

            trashLidShield = Content.Load<Texture2D>("trashlid");

            shields.Add(new Shield(new Vector2(40, 480), trashLidShield));
            shields.Add(new Shield(new Vector2(340, 480), trashLidShield));
            shields.Add(new Shield(new Vector2(640, 480), trashLidShield));


            mmplay = Content.Load<Texture2D>("MainMenuPlaybutton");
            mmplayselect = Content.Load<Texture2D>("MainMenuplaybuttonselect");
            mmquit = Content.Load<Texture2D>("MainMenuQuitbutton");
            mmquitselect = Content.Load<Texture2D>("MainMenuQuitbuttonselect");
            mmoptions = Content.Load<Texture2D>("MainMenuOptionsbutton");
            mmoptionsselect = Content.Load<Texture2D>("MainMenuOptionsbuttonselect");
            mmback = Content.Load<Texture2D>("MainMenuBack");
            pauseback = Content.Load<Texture2D>("pauseback");
            pauseexit = Content.Load<Texture2D>("Exitpause");
            pauseexitselect = Content.Load<Texture2D>("Exitpauseactive");
            pauseoptions = Content.Load<Texture2D>("options pause");
            pauseoptionsselect = Content.Load<Texture2D>("options pauseactive");
            pauseresume = Content.Load<Texture2D>("resumepause");
            pauseresumeselect = Content.Load<Texture2D>("resumepauseactive");

            a1 = Content.Load<Texture2D>("a1");
            a2 = Content.Load<Texture2D>("a2");
            a3 = Content.Load<Texture2D>("a3");
            a4 = Content.Load<Texture2D>("a4");
            a5 = Content.Load<Texture2D>("a5");
            a7 = Content.Load<Texture2D>("a7");
            a10 = Content.Load<Texture2D>("a10");
            x10 = Content.Load<Texture2D>("x10");
            x20 = Content.Load<Texture2D>("x20");
            x2s = Content.Load<Texture2D>("x2s");
            x2s2 = Content.Load<Texture2D>("x2s2");
            x40 = Content.Load<Texture2D>("x40");
            x80 = Content.Load<Texture2D>("x80");
            hose = Content.Load<Texture2D>("hose");
            n1 = Content.Load<Texture2D>("n1");
            n2 = Content.Load<Texture2D>("n2");
            n3 = Content.Load<Texture2D>("n3");
            n4 = Content.Load<Texture2D>("n4");
            n5 = Content.Load<Texture2D>("n5");
            shopback = Content.Load<Texture2D>("shopback");
            l1 = Content.Load<Texture2D>("l1");
            l2 = Content.Load<Texture2D>("l2");
            l3 = Content.Load<Texture2D>("l3");
            l4 = Content.Load<Texture2D>("l4");
            l7 = Content.Load<Texture2D>("l7");
        }
        #endregion
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        #region Empty
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        #endregion
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        #region Update
        protected override void Update(GameTime gameTime)
        {
            #region General Updates
            // track elapsed time since last frame, 
            // and total time that game has been played
            m_ElapsedSeconds = gameTime.ElapsedGameTime.TotalSeconds;
            m_starter ++;
            m_TotalSeconds += m_ElapsedSeconds;
            m_AnimFrameElapsed += m_ElapsedSeconds;
            newInvaderShipSeconds += m_ElapsedSeconds;
            bank = money * moneymult;
            bool done = false;
            keyboardState = Keyboard.GetState();
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            foreach (Enemyshot shot in enemyShot)
            {
                shot.ElapsedSeconds += m_ElapsedSeconds;
                if (shot.ElapsedSeconds >= enemyshot_Delay)
                {
                    shot.ElapsedSeconds = 0;
                }
            }
            if (laserup == 1)
            {
                bulletcount = 10;
                laser_MovementDelay = 0.30;
            }
            if (laserup == 2)
            {
                bulletcount = 20;
                laser_MovementDelay = 0.30;
            }
            if (laserup == 3)
            {
                bulletcount = 20;
                laser_MovementDelay = 0.15;
            }
            if (laserup == 4)
            {
                bulletcount = 40;
                laser_MovementDelay = 0.15;
            }
            if (laserup == 5)
            {
                bulletcount = 80;
                laser_MovementDelay = 0.15;
            }
            if (laserup == 6)
            {
                bulletcount = 80;
                laser_MovementDelay = 0.075;
            }
            if (laserup == 7)
            {
                bulletcount = 9999;
                laser_MovementDelay = 0;
            }
            #region Explosion animations

            foreach (Explosion explode in explosion)
            {
                explode.ElapsedSeconds += m_ElapsedSeconds;
                if (explode.ElapsedSeconds >= m_ExplosionDelay)
                {
                    explode.ElapsedSeconds = 0;
                }
            }

            foreach (Explosion explode in ShieldHit)
            {
                explode.ElapsedSeconds += m_ElapsedSeconds;
                if (explode.ElapsedSeconds >= m_ExplosionDelay)
                {
                    explode.ElapsedSeconds = 0;
                }
            }

            if (explosion.Count > 0)
            {
                done = false;
                while (!done)
                {
                    for (int x = 0; x < explosion.Count; x++)
                    {
                        if (x == explosion.Count - 1)
                        {
                            done = true;
                        }
                        if (explosion[x].FrameCount == (explosionTex.Width / explosionTex.Height) - 1)
                        {
                            explosion.RemoveAt(x);
                            x = explosion.Count;
                        }
                    }
                }
            }

            if (ShieldHit.Count > 0)
            {
                done = false;
                while (!done)
                {
                    for (int x = 0; x < ShieldHit.Count; x++)
                    {
                        if (x == ShieldHit.Count - 1)
                        {
                            done = true;
                        }
                        if (ShieldHit[x].FrameCount == (playerExplosion.Width / playerExplosion.Height) - 1)
                        {
                            ShieldHit.RemoveAt(x);
                            x = ShieldHit.Count;
                        }
                    }
                }
            }
            #endregion  // explosion animations

            #endregion

            #region Start
            if (Start)
            {
                //if (keyboardState.IsKeyDown(Keys.Space))
                //{
                //    MainMenu = true;
                //    Start = false;
                //}
                if (cakepic)
                {
                    if (m_starter == 240.0)
                    {
                        cakepic = false;
                        m_starter = 0.0;
                        screeninuse = 1;
                    }
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        screeninuse = 1;
                        cakepic = false;
                        m_starter = 0.0;
                    }
                }
                if (screeninuse == 1)
                {
                    if (m_starter == 240.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 2;
                    }
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        screeninuse = 2;
                        m_starter = 0.0;
                    }
                }
                if (screeninuse == 2)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 3;
                    }
                }
                if (screeninuse == 3)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 4;
                    }
                }
                if (screeninuse == 4)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 5;
                    }
                }
                if (screeninuse == 5)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 6;
                    }
                }
                if (screeninuse == 6)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 7;
                    }
                }
                if (screeninuse == 7)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 8;
                    }
                }
                if (screeninuse == 8)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 9;
                    }
                }
                if (screeninuse == 9)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 10;
                    }
                }
                if (screeninuse == 10)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 11;
                    }
                }
                if (screeninuse == 11)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 12;
                    }
                }
                if (screeninuse == 12)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 13;
                    }
                }
                if (screeninuse == 13)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 14;
                    }
                }
                if (screeninuse == 14)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 15;
                    }
                }
                if (screeninuse == 15)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 16;
                    }
                }
                if (screeninuse == 16)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 17;
                    }
                }
                if (screeninuse == 17)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 18;
                    }
                }
                if (screeninuse == 18)
                {
                    if (m_starter == 5.0)
                    {
                        m_starter = 0.0;
                        screeninuse = 19;
                    }
                }
                if (screeninuse == 19)
                {
                    if (m_starter == 120.0)
                    {
                        m_starter = 0.0;
                        Start = false;
                        MainMenu = true;
                    }
                }
            }
            #endregion

            #region Game Play

            if (Play)
            {
                if (m_starter == 15)
                {
                    PlayerHit = null;
                }
                laser_ElapsedSeconds += m_ElapsedSeconds;
                //keyboard mode
                if (m_starter >= 10)
                {
                    if (keyboardState.IsKeyDown(Keys.Z))
                    {
                        if (nukesleft > 0)
                        {
                            m_starter = 0;
                            army.nukedamage();
                            nukesleft--;
                        }
                    }
                }
                if (keyboardState.IsKeyDown(Keys.Escape))
                {
                    Play = false;
                    Pause = true;
                    playlocate = gun.Location;
                    gun.Location = pausegunlocate;
                    opfromplay = true;
                }
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    gun.MoveLeft(0.5f);
                }

                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    gun.MoveRight(0.5f);
                }

                if (keyboardState.IsKeyUp(Keys.Right) && keyboardState.IsKeyUp(Keys.Left))
                {
                    gun.Stop();
                }

                if (keyboardState.IsKeyDown(Keys.Space))
                {
                    if (laser_ElapsedSeconds >= laser_MovementDelay && Bullet.Count != bulletcount)
                    {
                        Bullet.Add(new Laser(new Vector2(gun.Location.X + 15, gun.Location.Y - 20), laserTex));
                        laser_ElapsedSeconds = 0;
                    }
                }

                if (newInvaderShipSeconds >= newInvaderShipDelay && !topShip.Active)
                {
                    topShip.Active = true;
                    topShip.Location = new Vector2(1,  5);
                    topShip.Type = (InvaderShip.type)(Math.Round(((float)rand.Next(6, 108) / 6) - 1));
                    if (topShip.Type == InvaderShip.type.Tim && GameLevel <= 10)
                    {
                        topshipnottimorjeff();
                    }
                    if (topShip.Type == InvaderShip.type.Jeff && GameLevel <= 5)
                    {
                        topshipnottimorjeff();
                    }
                    mattt();
                }

                if (topShip.Active)
                {
                    lasttype = topShip.Type;
                    topShip.Move();
                    if (topShip.Location.X > 800)
                    {
                        topShip.Active = false;
                        newInvaderShipDelay = (rand.Next(1, 300) / 10) + 10;
                        newInvaderShipSeconds = 0.0f;
                    }
                }

                foreach (Laser las in Bullet)
                {
                    las.Move();
                }

                foreach (Enemyshot las in enemyShot)
                {
                    las.Move();
                }

                done = false;
                // remove lasers that move off screen
                if (Bullet.Count > 0)
                {
                    while (!done)
                    {
                        for (int x = 0; x < Bullet.Count; x++)
                        {
                            if (x == Bullet.Count - 1)
                            {
                                done = true;
                            }
                            if (Bullet[x].Location.Y < 0)
                            {
                                Bullet.RemoveAt(x);
                                x = Bullet.Count;
                            }

                            // enemy collision
                            if (Bullet.Count != x)
                            {
                                bool shieldcheck = false;
                                foreach (Shield sh in shields)
                                {

                                    if (sh.checkCollision(Bullet[x].Location, Bullet[x].LaserTexture.Width, Bullet[x].LaserTexture.Height))
                                    {
                                        explosion.Add(new Explosion(new Vector2(Bullet[x].Location.X - ((explosionTex.Height / 2) - (Bullet[x].LaserTexture.Width)), Bullet[x].Location.Y - (explosionTex.Height / 4))));
                                        shieldcheck = true;
                                    }

                                }
                                if (shieldcheck)
                                {
                                    Bullet.RemoveAt(x);
                                    x = Bullet.Count;
                                }
                                else
                                {
                                    for (int x1 = 0; x1 < 15; x1++)
                                    {
                                        for (int y = 0; y < 6; y++)
                                        {
                                            if (army.soldier[x1, y].CheckCollision(Bullet[x].Location, Bullet[x].LaserTexture.Width, Bullet[x].LaserTexture.Height))
                                            {
                                                if (army.soldier[x1, y].Type == Invader.type.dead)
                                                {
                                                    m_CurrentMovemenDelay *= 0.995;
                                                }
                                                Score += 5;
                                                explosion.Add(new Explosion(new Vector2(Bullet[x].Location.X - explosionTex.Height / 2, Bullet[x].Location.Y - explosionTex.Height / 2)));
                                                Bullet.RemoveAt(x);
                                                x = Bullet.Count;
                                                y = 6;
                                                x1 = 15;
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }
                }

                done = false;
                if (Bullet.Count > 0)
                {
                    while (!done)
                    {
                        if (Bullet.Count < 1)
                        {
                            done = true;
                        }
                        for (int x = 0; x < Bullet.Count; x++)
                        {
                            if (x >= Bullet.Count - 1)
                            {
                                done = true;
                            }
                            else
                            {
                                if (enemyShot.Count > 0)
                                {


                                    for (int y = 0; y < enemyShot.Count; y++)
                                    {

                                        if (enemyShot[y].checkforCollision(Bullet[x].Location, Bullet[x].LaserTexture.Width, Bullet[x].LaserTexture.Height))
                                        {
                                            //explosion.Add(new Explosion(new Vector2(Bullet[x].Location.X - explosionTex.Height / 2, Bullet[x].Location.Y - explosionTex.Height / 2)));
                                            ShieldHit.Add(new Explosion(new Vector2(enemyShot[y].Location.X - ((playerExplosion.Height / 2) - (enemyshotTex.Height / 2)), enemyShot[y].Location.Y - (playerExplosion.Height / 4))));
                                            Bullet.RemoveAt(x);
                                            x = Bullet.Count - 1;
                                            enemyShot.RemoveAt(y);
                                            y = enemyShot.Count - 1;
                                            money ++;
                                        }

                                    }

                                }
                            }
                        }
                    }

                } 

                done = false;
                if (Bullet.Count > 0)
                {
                    while (!done)
                    {
                        if (Bullet.Count < 1)
                        {
                            done = true;
                        }
                        for (int x = 0; x < Bullet.Count; x++)
                        {
                            if (x >= Bullet.Count - 1)
                            {
                                done = true;
                            }
                            else
                            {
                                if (topShip.checkforCollision(Bullet[x].Location, Bullet[x].LaserTexture.Width, Bullet[x].LaserTexture.Height) && topShip.Active)
                                {
                                    explosion.Add(new Explosion(new Vector2(Bullet[x].Location.X - explosionTex.Height / 2, Bullet[x].Location.Y - explosionTex.Height / 2)));
                                    int bonus = (int)topShip.Type;
                                    bonus = (bonus + 1) * 50 * (int)topShip.Speed;
                                    if (topShip.Type == InvaderShip.type.Matt || topShip.Type == InvaderShip.type.Matt1)
                                    {
                                        bonus = bonus * 2;
                                    }
                                    if (topShip.Type == InvaderShip.type.Jeff)
                                    {
                                        shipCount++;
                                    }
                                    if (topShip.Type == InvaderShip.type.Tim)
                                    {
                                        nukesleft++;
                                    }
                                    Score += bonus;
                                    money = money + 2 * GameLevel;
                                    topShip.Active = false;
                                    newInvaderShipSeconds = 0.0;
                                    InvaderShipHit = true;
                                    Play = false;
                                    hitview = new hitView(topShip.Location);
                                    hitview.Score = bonus;
                                }
                            }
                        }
                    }
                }

                if (hitview != null)
                {
                    hitview.Move();
                    if (hitview.Location.Y < -20)
                    {
                        hitview = null;
                    }
                }

                gun.Move().ToString();

                Window.Title = "Hobo Invaders";


                if (m_AnimFrameElapsed >= m_CurrentMovemenDelay)
                {
                    if (army.moveArmy())
                    {
                        m_CurrentMovemenDelay *= 0.95;
                        if (army.CheckInvaderWin(480))
                        {
                            LevelFailed = true;
                            Play = false;
                            
                        }
                    }
                    m_AnimFrameElapsed = 0;

                    for (int x = 0; x < 2; x++)
                    {
                        int xcol = rand.Next(0, 15);
                        int ycol = rand.Next(0, 5);
                        if (xcol < 15 && ycol < 6)
                        {
                            if (army.soldier[xcol, ycol].Type != Invader.type.dead)
                            {
                                enemyShot.Add(new Enemyshot(new Vector2(army.soldier[xcol, ycol].Location.X + 5, army.soldier[xcol, ycol].Location.Y + 30), enemyshotTex));
                                
                            }

                        }
                    }
                }


                done = false;
                if (enemyShot.Count > 0)
                {
                    while (!done)
                    {

                        for (int x = 0; x < enemyShot.Count; x++)
                        {
                            if (x == enemyShot.Count - 1)
                            {
                                done = true;
                            }

                            if (enemyShot[x].Location.Y > 800)
                            {
                                enemyShot.RemoveAt(x);
                                x = enemyShot.Count;
                            }
                            else
                            {
                                if (gun.checkforCollision(enemyShot[x].Location, enemyshotTex.Height, enemyshotTex.Height))
                                {
                                    m_starter = 0;
                                    PlayerHit = new Explosion(new Vector2(enemyShot[x].Location.X - ((playerExplosion.Height / 2) - (enemyshotTex.Height / 2)), enemyShot[x].Location.Y - (playerExplosion.Height / 4)));
                                    if (armor > 0)
                                    {
                                            armor--;
                                            enemyShot.RemoveAt(x);
                                    }
                                    else
                                    {
                                        playerHit = true;
                                        Play = false;
                                    }
                                }
                                else
                                {
                                    bool shieldcheck = false;
                                    foreach (Shield sh in shields)
                                    {

                                        if (sh.checkCollision(enemyShot[x].Location, enemyshotTex.Height, enemyshotTex.Height))
                                        {
                                            ShieldHit.Add(new Explosion(new Vector2(enemyShot[x].Location.X - ((playerExplosion.Height / 2) - (enemyshotTex.Height / 2)), enemyShot[x].Location.Y - (playerExplosion.Height / 4))));
                                            shieldcheck = true;
                                        }

                                    }
                                    if (shieldcheck)
                                    {
                                        enemyShot.RemoveAt(x);
                                        x = enemyShot.Count;
                                    }
                                }
                            }
                        }
                    }

                }

                if (army.checkInvaderStatus() && LevelEnd != true)
                {
                    LevelEnd = true;
                    
                    Play = false;
                }
            }
            #endregion

            #region player hit
            if (playerHit)
            {
                armor = armorup;
                PlayerHit.ElapsedSeconds += m_ElapsedSeconds;
                if (PlayerHit.ElapsedSeconds >= m_ExplosionDelay)
                {
                    PlayerHit.ElapsedSeconds = 0;
                }

                if (PlayerHit.FrameCount == (playerExplosion.Width / playerExplosion.Height) - 1)
                {
                    PlayerHit = null;
                    
                    shipCount--;
                    if (shipCount > -1)
                    {
                        gun.MovetoX(40);
                        Play = true;
                        
                        playerHit = false;
                        enemyShot.Clear();
                        Bullet.Clear();
                    }
                    else
                    {
                        GameEnd = true;
                        playerHit = false;
                    }
                }
            }

            #endregion

            #region Level End

            if (LevelEnd)
            {
                //update level end graphics
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    if (GameLevel == levelfive * levelmulti)
                    {
                        if (full)
                        {
                            graphics.ToggleFullScreen();
                            graphics.ApplyChanges();
                        }
                        fullshop = true;
                        LevelEnd = false;
                        Shop = true;
                        InitializeLevel(0.9);
                        GameLevel++;
                        topShip.Speed += .5;
                        currentlevelCompleted = levelCompleted1;
                        LevelCompletedFrame = 1;
                        oldScore = Score;
                    }
                    else
                    {
                        Play = true;
                        //Shop = true;
                        LevelEnd = false;
                        InitializeLevel(0.9);
                        GameLevel++;
                        topShip.Speed += .5;
                        currentlevelCompleted = levelCompleted1;
                        LevelCompletedFrame = 1;
                        oldScore = Score;
                    }
                }
            }

            #endregion

            #region Level failed

            if (LevelFailed)
            {
                //update level end graphics
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    shipCount--;
                    Play = true;
                    
                    LevelFailed = false;
                    InitializeLevel(1.0);
                    LevelCompletedFrame = 1;
                    Score = oldScore;
                    currentlevelCompleted = levelFailed1;
                }
            }

            #endregion

            #region InvaderShipHit
            
            if (InvaderShipHit)
            {
                if (newInvaderShipSeconds > 0.5)
                {
                    newInvaderShipSeconds = 0.0;
                    Play = true;
                    InvaderShipHit = false;
                }
            }
            
            #endregion

            #region GameEnd
            if(GameEnd)
            {
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    GameEnd = false;
                    gun.Location = origkillerlocation;
                    shipCount = 3;
                    Score = 0;
                    GameLevel = 1;
                    m_CurrentMovemenDelay = 1;
                    m_AlienMovementDelay = 1;
                    m_ExplosionDelay = 0.1;
                    laser_MovementDelay = 0.00;
                    enemyshot_Delay = 0.05;
                    max_Laser = 5;
                    InitializeLevel(1.0);
                    bulletcount = 5;
                    foreach (Shield sh in shields)
                    {
                        sh.resetsheilds();
                    }
                    topShip.Speed = 2f;
                    newInvaderShipSeconds = 0.0f;
                    laser_MovementDelay = 0.30;
                    money = 0;
                    laserup = 0;
                    armor = 0;
                    armorup = 0;
                    nukesleft = 0;
                    nukelevel = 0;
                    if (bobshobo)
                    {
                        sg = storage.deletegame();
                    }
                    hss = storage3.Load();
                    highscore1 = hss.Highscore1;
                    highscore2 = hss.Highscore2;
                    highscore3 = hss.Highscore3;
                    highscore4 = hss.Highscore4;
                    highscore5 = hss.Highscore5;
                    highscore6 = hss.Highscore6;
                    highscore7 = hss.Highscore7;
                    highscore8 = hss.Highscore8;
                    highscore9 = hss.Highscore9;
                    highscore10 = hss.Highscore10;
                    if (Score > highscore1)
                    {
                        high = 1;
                        highscore1 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore2)
                    {
                        high = 2;
                        highscore2 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore3)
                    {
                        high = 3;
                        highscore3 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore4)
                    {
                        high = 4;
                        highscore4 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore5)
                    {
                        high = 5;
                        highscore5 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore6)
                    {
                        high = 6;
                        highscore6 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore7)
                    {
                        high = 7;
                        highscore7 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore8)
                    {
                        high = 8;
                        highscore8 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore9)
                    {
                        high = 9;
                        highscore9 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                    if (Score > highscore10)
                    {
                        high = 10;
                        highscore10 = Score;
                        addhigh = true;
                    }
                    else
                    {
                        Highscores = true;
                    }
                }
            }
            #endregion

            #region mm
            if (MainMenu)
            {
                collisiondetection();
                collisionaboutus();
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    gun.MoveLeft(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    gun.MoveRight(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Up))
                {
                    gun.MoveUp(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Down))
                {
                    gun.MoveDown(0.5f);
                }
                if (keyboardState.IsKeyUp(Keys.Right) && keyboardState.IsKeyUp(Keys.Left))
                {
                    gun.Stop();
                }
                if (keyboardState.IsKeyUp(Keys.Down) && keyboardState.IsKeyUp(Keys.Up))
                {
                    gun.Stop2();
                }
                gun.move2();
                gun.Move();
                if (playactive)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        MainMenu = false;
                        Play = true;
                        gun.Location = origkillerlocation;
                        playactive = false;
                    }
                }
                if (optionsbutton)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        gun.Location = origkillerlocation;
                        MainMenu = false;
                        Options = true;
                        optionsbutton = false;
                    }
                }
                if (quitactive)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        this.Exit();
                    }
                }
                if (aboutactive)
                {
                    if(keyboardState.IsKeyDown(Keys.Enter))
                    {
                        gun.Location = origkillerlocation;
                        aboutactive = false;
                        Aus = true;
                        MainMenu = false;
                    }
                }
            }
            #endregion

            #region pause
            if (Pause)
            {
                collisiondetect2();
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    gun.MoveLeft(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    gun.MoveRight(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Up))
                {
                    gun.MoveUp(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Down))
                {
                    gun.MoveDown(0.5f);
                }
                if (keyboardState.IsKeyUp(Keys.Right) && keyboardState.IsKeyUp(Keys.Left))
                {
                    gun.Stop();
                }
                if (keyboardState.IsKeyUp(Keys.Down) && keyboardState.IsKeyUp(Keys.Up))
                {
                    gun.Stop2();
                }
                gun.move2();
                gun.Move();
                if (resumeactive)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        gun.Location = playlocate;
                        Play = true;
                        Pause = false;
                        resumeactive = false;
                    }
                }
                if (poptionsactive)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        gun.Location = origkillerlocation;
                        Pause = false;
                        Options = true;
                    }
                }
                if (exitactive)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        this.Exit();
                    }
                }
            }
            #endregion

            #region options
            if (Options)
            {
                collisionoptions();
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    gun.MoveLeft(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    gun.MoveRight(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Up))
                {
                    gun.MoveUp(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Down))
                {
                    gun.MoveDown(0.5f);
                }
                if (keyboardState.IsKeyUp(Keys.Right) && keyboardState.IsKeyUp(Keys.Left))
                {
                    gun.Stop();
                }
                if (keyboardState.IsKeyUp(Keys.Down) && keyboardState.IsKeyUp(Keys.Up))
                {
                    gun.Stop2();
                }
                gun.move2();
                gun.Move();
                if (opchoice1)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        if (option1)
                        {
                            option1 = false;
                        }
                        else
                        {
                            option1 = true;
                        }
                        if (full)
                        {
                            full = false;
                        }
                        else
                        {
                            full = true;
                        }
                        opchoice1 = false;
                        graphics.ToggleFullScreen();
                        graphics.ApplyChanges();
                    }
                }
                if (opchoice2)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        opchoice2 = false;
                        sg = storage.deletegame();
                    }
                }
                if (opchoice3)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        opchoice3 = false;
                    }
                }
                if (opchoice4)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        opchoice4 = false;
                        snf = storage2.Load();
                        loadnum = snf.savenum;
                        loadnum++;
                        if (loadnum == sg.savenum)
                        {
                            sg = storage.Load();
                            save12 = sg.name;
                            GameLevel = sg.level;
                            shipCount = sg.lives;
                            Score = sg.score;
                            laserup = sg.laserupgrade;
                            nukesleft = sg.nukesleft;
                            nukelevel = sg.nukelevel;
                            armorup = sg.armorupgrade;
                            armor = sg.armorleft;
                            m_CurrentMovemenDelay = sg.currentmovedelay;
                            m_AlienMovementDelay = sg.alien_movementdelay;
                            enemyshot_Delay = sg.enemyshotdelay;
                            topShip.Speed = sg.tshipspeed;
                            lifeup = sg.lifeup;
                            levelmulti = sg.levelmulti;
                            levelmulti2 = sg.levelmulti2;
                            levelmulti3 = sg.levelmulti3;
                            money = sg.money;
                            foreach (Shield sh in shields)
                            {
                                sh.loadsheild(sg);
                            }
                        }
                        else
                        {
                            badsave = true;
                            loadnum--;
                        }
                        gun.Location = origkillerlocation;
                        Options = false;
                        //Play = true;
                        Shop = true;
                        bobshobo = true;
                        snf = storage2.deletegame();
                        snf.savenum = loadnum;
                        storage2.save(snf);
                    }
                }
                if (opchoice5)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        opchoice5 = false;
                    }
                }
                if (opchoice6)
                {
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        if (opfromplay)
                        {
                            Play = true;
                            opfromplay = false;
                            Options = false;
                            gun.Location = playlocate;
                        }
                        else
                        {
                            Options = false;
                            MainMenu = true;
                            gun.Location = origkillerlocation;
                        }
                        opchoice6 = false;
                    }
                }
                if (badsave)
                {
                    if(keyboardState.IsKeyDown(Keys.Enter))
                    {
                        badsave = false;
                    }
                }
            }
            #endregion

            #region Shop
            if (Shop)
            {
                collisionshop();
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    gun.MoveLeft(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    gun.MoveRight(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Up))
                {
                    gun.MoveUp(0.5f);
                }
                if (keyboardState.IsKeyDown(Keys.Down))
                {
                    gun.MoveDown(0.5f);
                }
                if (keyboardState.IsKeyUp(Keys.Right) && keyboardState.IsKeyUp(Keys.Left))
                {
                    gun.Stop();
                }
                if (keyboardState.IsKeyUp(Keys.Down) && keyboardState.IsKeyUp(Keys.Up))
                {
                    gun.Stop2();
                }
                gun.move2();
                gun.Move();
                if (life1)
                {
                    if (lifeup == 0)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 500)
                                {
                                    money = money - 100;
                                    lifeup = lifeup + 1;
                                    shipCount++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (lifeup == 1)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 1000)
                                {
                                    money = money - 200;
                                    lifeup = lifeup + 1;
                                    shipCount++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (lifeup == 2)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 1500)
                                {
                                    money = money - 300;
                                    lifeup = lifeup + 1;
                                    shipCount++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (lifeup == 3)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 2000)
                                {
                                    money = money - 400;
                                    lifeup = lifeup + 1;
                                    shipCount++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (lifeup == 4)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 4000)
                                {
                                    money = money - 800;
                                    lifeup = lifeup + 1;
                                    shipCount = shipCount + 3;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                }
                if (lasershop)
                {
                        if (laserup == 0)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 100)
                                    {
                                        money = money - 20;
                                        laserup = laserup + 1;
                                        bulletcount = 10;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        if (laserup == 1)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 200)
                                    {
                                        money = money - 40;
                                        laserup = laserup + 1;
                                        bulletcount = 20;
                                        m_starter = 0;
                                    }
                            }
                            else
                            {

                            }
                            }
                        }
                        if (laserup == 2)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 300)
                                    {
                                        money = money - 60;
                                        laserup = laserup + 1;
                                        laser_MovementDelay = 0.15;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        if (laserup == 3)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 600)
                                    {
                                        money = money - 120;
                                        laserup = laserup + 1;
                                        bulletcount = 40;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        if (laserup == 4)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 800)
                                    {
                                        money = money - 160;
                                        laserup = laserup + 1;
                                        bulletcount = 80;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        if (laserup == 5)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 1000)
                                    {
                                        money = money - 200;
                                        laserup++;
                                        laser_MovementDelay = 0.075;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                        if (laserup == 6)
                        {
                            if (keyboardState.IsKeyDown(Keys.Enter))
                            {
                                if (m_starter >= 60)
                                {
                                    if (bank >= 2000)
                                    {
                                        money = money - 400;
                                        laserup = laserup + 1;
                                        bulletcount = 99999;
                                        laser_MovementDelay = 0.0;
                                        m_starter = 0;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                }
                if (nukeshop)
                {
                    if (nukelevel == 0)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 1000)
                                {
                                    money = money - 200;
                                    nukesleft++;
                                    nukelevel++;
                                    m_starter = 0;
                                }
                            }
                        }

                    }
                    if (nukelevel == 1)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 2000)
                                {
                                    money = money - 400;
                                    nukesleft++;
                                    nukelevel++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (nukelevel == 2)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 4000)
                                {
                                    money = money - 800;
                                    nukesleft++;
                                    nukelevel++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (nukelevel == 3)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 8000)
                                {
                                    money = money - 1600;
                                    nukesleft++;
                                    nukelevel++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (nukelevel == 4)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 12000)
                                {
                                    money = money - 2400;
                                    nukesleft++;
                                    nukelevel++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                }
                if (armorshop)
                {
                    if (armorup == 0)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 100)
                                {
                                    money = money - 20;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 1)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 200)
                                {
                                    money = money - 40;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 2)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 300)
                                {
                                    money = money - 60;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 3)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 400)
                                {
                                    money = money - 80;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 4)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 600)
                                {
                                    money = money - 120;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 5)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 1000)
                                {
                                    money = money - 200;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                    if (armorup == 6)
                    {
                        if (keyboardState.IsKeyDown(Keys.Enter))
                        {
                            if (m_starter >= 60)
                            {
                                if (bank >= 2000)
                                {
                                    money = money - 400;
                                    armor++;
                                    armorup++;
                                    m_starter = 0;
                                }
                            }
                        }
                    }
                }
            }
            if (save)
            {
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    snf = storage2.deletegame();
                    snf.savenum = loadnum;
                    storage2.save(snf);
                    sg = storage.deletegame();
                    sg.name = save12;
                    sg.lives = shipCount;
                    sg.date = DateTime.Now;
                    sg.level = GameLevel;
                    sg.score = Score;
                    sg.laserupgrade = laserup;
                    sg.armorupgrade = armorup;
                    sg.armorleft = armor;
                    sg.nukelevel = nukelevel;
                    sg.nukesleft = nukesleft;
                    sg.alien_movementdelay = m_AlienMovementDelay;
                    sg.currentmovedelay = m_CurrentMovemenDelay;
                    sg.enemyshotdelay = enemyshot_Delay;
                    sg.tshipspeed = topShip.Speed;
                    sg.lifeup = lifeup;
                    sg.levelmulti = levelmulti;
                    sg.levelmulti2 = levelmulti2;
                    sg.levelmulti3 = levelmulti3;
                    sg.money = money;
                    sg.savenum = loadnum;
                    foreach (Shield sh in shields)
                    {
                        sh.savesheild(sg);
                    }
                    storage.save(sg);
                    Shop = false;
                    MainMenu = true;
                    gun.Location = origkillerlocation;
                }
            }
            if (continue1)
            {
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    if (fullshop)
                    {
                        graphics.ToggleFullScreen();
                        graphics.ApplyChanges();
                        fullshop = false;
                    }
                    if (levelmulti2 == levelfive * levelmulti / 5)
                    {
                        if (levelmulti == 10 || levelmulti == 20 || levelmulti == 30 || levelmulti == 40 || levelmulti == 50 || levelmulti == 60 || levelmulti == 70 || levelmulti == 80 || levelmulti == 90 || levelmulti == 100)
                        {
                            foreach (Shield sh in shields)
                            {
                                sh.sheildregen(50);
                            }
                        }
                        else
                        {
                            foreach (Shield sh in shields)
                            {
                                sh.sheildregen(10);
                            }
                        }
                        Shop = false;
                        Play = true;
                        levelmulti2++;
                        levelmulti2++;
                        InitializeLevel(1.0);
                        m_AlienMovementDelay = 1;
                        m_CurrentMovemenDelay = m_AlienMovementDelay;
                        topShip.Speed = 6;
                        if (levelmulti3 == levelfive * levelmulti /5 * levelmulti2 / 14)
                        {
                            m_AlienMovementDelay = m_AlienMovementDelay * 2;
                            m_CurrentMovemenDelay = m_AlienMovementDelay;
                        }
                    }
                    else
                    {
                        Shop = false;
                        Play = true;
                        gun.Location = origkillerlocation;
                        levelmulti++;
                    }
                }
            }
            if (quit1)
            {
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    this.Exit();
                }
            }
            #endregion

            #region Highscores
            #region add
            if (addhigh)
            {
                if (high == 1)
                {
                    if (name1.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name1 = vk.keyboard(name1);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 2)
                {
                    if (name2.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name2 = vk.keyboard(name2);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 3)
                {
                    if (name3.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name3 = vk.keyboard(name3);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 4)
                {
                    if (name4.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name4 = vk.keyboard(name4);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 5)
                {
                    if (name5.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name5 = vk.keyboard(name5);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 6)
                {
                    if (name6.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name6 = vk.keyboard(name6);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 7)
                {
                    if (name7.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name7 = vk.keyboard(name7);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 8)
                {
                    if (name8.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name8 = vk.keyboard(name8);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 9)
                {
                    if (name9.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name9 = vk.keyboard(name9);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (high == 10)
                {
                    if (name10.Length != 10)
                    {
                        if (!keypressed)
                        {
                            name10 = vk.keyboard(name10);
                            keypressed = true;
                        }
                    }
                    else
                    {

                    }
                }
                if (keyboardState.GetPressedKeys().Count() == 0)
                {
                    keypressed = false;
                }
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    addhigh = false;
                    Highscores = true;
                }
            }
            #endregion
            #region Show
            if (Highscores)
            {
                hss = storage3.deletegame();
                hss.Highscore1 = highscore1;
                hss.Highscore2 = highscore2;
                hss.Highscore3 = highscore3;
                hss.Highscore4 = highscore4;
                hss.Highscore5 = highscore5;
                hss.Highscore6 = highscore6;
                hss.Highscore7 = highscore7;
                hss.Highscore8 = highscore8;
                hss.Highscore9 = highscore9;
                hss.Highscore10 = highscore10;
                storage3.save(hss);
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    Highscores = false;
                    MainMenu = true;
                }
            }
            #endregion
            #endregion

            #region about us
            if (Aus)
            {
                if (keyboardState.IsKeyDown(Keys.Space))
                {
                    Aus = false;
                    MainMenu = true;
                }
            }
            #endregion

            base.Update(gameTime);
        }
        #endregion
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        #region Draw
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _locationplaybutton.X = 350;
            _locationplaybutton.Y = 200;
            _locationoptionsbutton.X = 291;
            _locationoptionsbutton.Y = 300;
            _locationquitbutton.X = 300;
            _locationquitbutton.Y = 400;
            _pauseexitlocate.X = 230;
            _pauseexitlocate.Y = 210;
            _pauseoptionslocate.X = 230;
            _pauseoptionslocate.Y = 130;
            _pauseresumelocate.X = 230;
            _pauseresumelocate.Y = 50;
            //Double ElapsedSeconds;
            spriteBatch.Begin();
            #region Start
            if (Start)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                if (cakepic)
                {
                    spriteBatch.Draw(cake, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                }
                else
                {
                    if (screeninuse == 1)
                    {
                        Screen1();
                    }
                    if (screeninuse == 2)
                    {
                        Screen2();
                    }
                    if (screeninuse == 3)
                    {
                        Screen3();
                    }
                    if (screeninuse == 4)
                    {
                        Screen4();
                    }
                    if (screeninuse == 5)
                    {
                        Screen5();
                    }
                    if (screeninuse == 6)
                    {
                        Screen6();
                    }
                    if (screeninuse == 7)
                    {
                        Screen7();
                    }
                    if (screeninuse == 8)
                    {
                        Screen8();
                    }
                    if (screeninuse == 9)
                    {
                        Screen9();
                    }
                    if (screeninuse == 10)
                    {
                        Screen10();
                    }
                    if (screeninuse == 11)
                    {
                        Screen11();
                    }
                    if (screeninuse == 12)
                    {
                        Screen12();
                    }
                    if (screeninuse == 13)
                    {
                        Screen13();
                    }
                    if (screeninuse == 14)
                    {
                        Screen14();
                    }
                    if (screeninuse == 15)
                    {
                        Screen15();

                    }
                    if (screeninuse == 16)
                    {
                        Screen16();
                    }
                    if (screeninuse == 17)
                    {
                        Screen17();
                    }
                    if (screeninuse == 18)
                    {
                        Screen18();
                    }
                    if (screeninuse == 19)
                    {
                        Screen19();
                    }
                }
            }
            #endregion

            #region Game Play

            if (Play || LevelEnd || playerHit || LevelFailed || InvaderShipHit || Pause)
            {
                nuky = nukesleft.ToString();
                spriteBatch.DrawString(comicsans2, "Nukes :", nukinglocate, Color.White);
                spriteBatch.DrawString(comicsans2, nuky, nukelocate, Color.White);
                bankmoney = bank.ToString();
                spriteBatch.DrawString(comicsans2, "Bank $", moneylocate, Color.White);
                spriteBatch.DrawString(comicsans2, bankmoney, banklocate, Color.White);
                bob = armor.ToString();
                spriteBatch.DrawString(comicsans2, "Armor :", wordlocate, Color.White);
                spriteBatch.DrawString(comicsans2, bob, armorlocate, Color.White);
                if (hitview != null)
                {
                    drawHitScore(spriteBatch, hitview.Location, hitview.Score);
                }
                if (topShip.Active)
                {
                    spriteBatch.Draw(_skin[(int)topShip.Type], topShip.Location,Color.White);
                }
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        if (army.soldier[x, y].Type != Invader.type.dead)
                        {
                            army.soldier[x, y].FrameCount = DrawAnimatedSprite(army.getTexture(ref army.soldier[x, y]), spriteBatch, army.soldier[x, y].Location, army.soldier[x, y].FrameCount, m_AnimFrameElapsed);
                        }
                    }
                }
                Rectangle rect = new Rectangle(0, 0, gun.gunTexture.Width, gun.gunTexture.Height);
                spriteBatch.Draw(gun.gunTexture, gun.Location, rect, Color.White);

                foreach (Laser las in Bullet)
                {
                    rect = new Rectangle(0, 0, las.LaserTexture.Width, las.LaserTexture.Height);
                    spriteBatch.Draw(las.LaserTexture, las.Location, rect, Color.White);
                }

                foreach (Enemyshot las in enemyShot)
                {
                    las.FrameCount = DrawAnimatedSprite(las.shotTexture, spriteBatch, las.Location, las.FrameCount, las.ElapsedSeconds);
                }

                foreach (Explosion explode in explosion)
                {
                    explode.FrameCount = DrawAnimatedSprite(explosionTex, spriteBatch, explode.Location, explode.FrameCount, explode.ElapsedSeconds);
                }

                foreach (Explosion explode in ShieldHit)
                {
                    explode.FrameCount = DrawAnimatedSprite(playerExplosion, spriteBatch, explode.Location, explode.FrameCount, explode.ElapsedSeconds);
                }

                DrawScore(spriteBatch,new Vector2(630,5));
                DrawLevel(spriteBatch, new Vector2(20, 5));

                spriteBatch.Draw(line, new Vector2(10,560), new Rectangle(0,0,780,3), Color.White);

                for (int x = 0; x < shipCount; x++)
                {
                    spriteBatch.Draw(gun.gunTexture, new Vector2(770 - (x * 30), 570), Color.White);
                }

                if (PlayerHit != null)
                {
                    PlayerHit.FrameCount = DrawAnimatedSprite(playerExplosion, spriteBatch, PlayerHit.Location, PlayerHit.FrameCount, PlayerHit.ElapsedSeconds);
                }

                // need figure sprite alpha channel

                foreach(Shield sh in shields)
                {
                    int calWidth = (trashLidShield.Width / 7);
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X, sh.Location.Y), new Rectangle(0, 0, trashLidShield.Width / 7, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, sh.FarLeft)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 1), sh.Location.Y), new Rectangle(calWidth * 1, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.Left/100)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 2), sh.Location.Y), new Rectangle(calWidth * 2, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.LeftCenter/100)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 3), sh.Location.Y), new Rectangle(calWidth * 3, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.Center/100)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 4), sh.Location.Y), new Rectangle(calWidth * 4, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.RightCenter/100)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 5), sh.Location.Y), new Rectangle(calWidth * 5, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.Right/100)));
                    spriteBatch.Draw(trashLidShield, new Vector2(sh.Location.X + (calWidth * 6), sh.Location.Y), new Rectangle(calWidth * 6, 0, calWidth, trashLidShield.Height), new Color(new Vector4(1.0f, 1.0f, 1.0f, (float)sh.FarRight/100)));
                }
                 
            }
            #endregion

            #region Level End

            if (LevelEnd)
            {
                Vector2 loc = new Vector2((SCREEN_WIDTH - 500) / 2,(SCREEN_HEIGHT - 100) / 2);
                
                //draw level end graphics
                if (m_AnimFrameElapsed >= 0.5)
                {
                    if (LevelCompletedFrame == 1)
                    {
                        currentlevelCompleted = levelCompleted1;
                    }
                    if (LevelCompletedFrame == 2)
                    {
                        currentlevelCompleted = levelCompleted2;
                    }
                    if (LevelCompletedFrame == 3)
                    {
                        currentlevelCompleted = levelCompleted3;
                    }

                    LevelCompletedFrame++;

                    if (LevelCompletedFrame > 3)
                    {
                        LevelCompletedFrame = 1;
                    }
                    
                    m_AnimFrameElapsed = 0;
                }
                spriteBatch.Draw(currentlevelCompleted, loc, Color.White);
                
            }

            #endregion

            #region Level Failed

            if (LevelFailed)
            {
                Vector2 loc = new Vector2((SCREEN_WIDTH - 400) / 2, (SCREEN_HEIGHT - 100) / 2);

                //draw level end graphics
                if (m_AnimFrameElapsed >= 0.5)
                {
                    if (LevelCompletedFrame == 1)
                    {
                        currentlevelCompleted = levelFailed1;
                    }
                    if (LevelCompletedFrame == 2)
                    {
                        currentlevelCompleted = levelFailed2;
                    }
                    if (LevelCompletedFrame == 3)
                    {
                        currentlevelCompleted = levelFailed3;
                    }

                    LevelCompletedFrame++;

                    if (LevelCompletedFrame > 3)
                    {
                        LevelCompletedFrame = 1;
                    }

                    m_AnimFrameElapsed = 0;
                }
                spriteBatch.Draw(currentlevelCompleted, loc, Color.White);
            }

            #endregion

            #region mm
            if (MainMenu)
            {
                
                Rectangle rect3 = new Rectangle(0, 0, 800, 600);
                Rectangle rect2 = new Rectangle(0, 0, 82, 50);
                spriteBatch.Draw(mmback, rect3, rect3, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                spriteBatch.Draw(mmplay, _locationplaybutton, Color.White);
                spriteBatch.Draw(mmoptions, _locationoptionsbutton, Color.White);
                spriteBatch.Draw(mmquit, _locationquitbutton, Color.White);
                if (playbutton)
                {
                    spriteBatch.Draw(mmplayselect, _locationplaybutton, Color.White);
                    quitactive = false;
                    optionsactive = false;
                    playactive = true;
                    aboutactive = false;
                }
                if (optionsbutton)
                {
                    spriteBatch.Draw(mmoptionsselect, _locationoptionsbutton, Color.White);
                    quitactive = false;
                    optionsactive = true;
                    playactive = false;
                    aboutactive = false;
                }
                if (quitbutton)
                {
                    spriteBatch.Draw(mmquitselect, _locationquitbutton, Color.White);
                    quitactive = true;
                    optionsactive = false;
                    playactive = false;
                    aboutactive = false;
                }
                if (aboutuss)
                {
                    spriteBatch.DrawString(comicsans, "About", logolocate, Color.White);
                    spriteBatch.DrawString(comicsans, "Us", us, Color.White);
                    quitactive = false;
                    optionsactive = false;
                    playactive = false;
                    aboutactive = true;
                }
                else
                {
                    spriteBatch.Draw(logo, logolocate, Color.White);
                }
                Rectangle rect = new Rectangle(0, 0, gun.gunTexture.Width, gun.gunTexture.Height);
                spriteBatch.Draw(gun.gunTexture, gun.Location, rect, Color.White);
            }
            #endregion

            #region GameEnd
            if(GameEnd)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(lies, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
            }
            #endregion

            #region Pause
            if (Pause)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(pauseback, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                spriteBatch.Draw(pauseresume, _pauseresumelocate, Color.White);
                spriteBatch.Draw(pauseoptions, _pauseoptionslocate, Color.White);
                spriteBatch.Draw(pauseexit, _pauseexitlocate, Color.White);
                if (resumeactive)
                {
                    spriteBatch.Draw(pauseresumeselect, _pauseresumelocate, Color.White);
                }
                if (poptionsactive)
                {
                    spriteBatch.Draw(pauseoptionsselect, _pauseoptionslocate, Color.White);
                }
                if (exitactive)
                {
                    spriteBatch.Draw(pauseexitselect, _pauseexitlocate, Color.White);
                }
                Rectangle rect = new Rectangle(0, 0, gun.gunTexture.Width, gun.gunTexture.Height);
                spriteBatch.Draw(gun.gunTexture, gun.Location, rect, Color.White);
            }
            #endregion

            #region options
            if (Options)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(opback, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                if (opchoice1)
                {
                    if (option1)
                    {
                        spriteBatch.DrawString(comicsans, "Fullscreen: ON", test, Color.Wheat);
                    }
                    else
                    {
                        spriteBatch.DrawString(comicsans, "Fullscreen: OFF", test, Color.Wheat);
                    }
                }
                else
                {
                    if (option1)
                    {
                        spriteBatch.DrawString(comicsans, "Fullscreen: ON", test, Color.White);
                    }
                    else
                    {
                        spriteBatch.DrawString(comicsans, "Fullscreen: OFF", test, Color.White);
                    }
                }
                if (opchoice2)
                {
                    spriteBatch.DrawString(comicsans, "ClearGameData", op2, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans, "ClearGameData", op2, Color.White);
                }
                if (opchoice4)
                {
                    spriteBatch.DrawString(comicsans, "load", op4, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans, "load", op4, Color.White);
                }
                if (opchoice6)
                {
                    spriteBatch.DrawString(comicsans, "back", opbackb, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans, "back", opbackb, Color.White);
                }
                spriteBatch.DrawString(comicsans, ",", op5, Color.SlateGray);
                Rectangle rect = new Rectangle(0, 0, gun.gunTexture.Width, gun.gunTexture.Height);
                spriteBatch.Draw(gun.gunTexture, gun.Location, rect, Color.White);
                if (badsave)
                {
                    spriteBatch.DrawString(comicsans, "SaveGame Corrupt", op2, Color.Gold);
                }
            }
            #endregion

            #region shop
            if (Shop)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(shopback, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                if (lasershop)
                {
                    if (laserup == 0)
                    {
                        spriteBatch.Draw(x10, laserlocateshop, Color.White);
                    }
                    if (laserup == 1)
                    {
                        spriteBatch.Draw(x20, laserlocateshop, Color.White);
                    }
                    if (laserup == 2)
                    {
                        spriteBatch.Draw(x2s, laserlocateshop, Color.White);
                    }
                    if (laserup == 3)
                    {
                        spriteBatch.Draw(x40, laserlocateshop, Color.White);
                    }
                    if (laserup == 4)
                    {
                        spriteBatch.Draw(x80, laserlocateshop, Color.White);
                    }
                    if (laserup == 5)
                    {
                        spriteBatch.Draw(x2s2, laserlocateshop, Color.White);
                    }
                    if (laserup == 6)
                    {
                        spriteBatch.Draw(hose, laserlocateshop, Color.White);
                    }
                    if (laserup == 7)
                    {
                        spriteBatch.Draw(outof, laserlocateshop, Color.White);
                    }
                }
                else
                {
                    if (laserup == 0)
                    {
                        spriteBatch.Draw(x10, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 1)
                    {
                        spriteBatch.Draw(x20, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 2)
                    {
                        spriteBatch.Draw(x2s, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 3)
                    {
                        spriteBatch.Draw(x40, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 4)
                    {
                        spriteBatch.Draw(x80, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 5)
                    {
                        spriteBatch.Draw(x2s2, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 6)
                    {
                        spriteBatch.Draw(hose, laserlocateshop, Color.Gray);
                    }
                    if (laserup == 7)
                    {
                        spriteBatch.Draw(outof, laserlocateshop, Color.Gray);
                    }
                }
                if (nukeshop)
                {
                    if (nukelevel == 0)
                    {
                        spriteBatch.Draw(n1, nukelocateshop, Color.White);
                    }
                    if (nukelevel == 1)
                    {
                        spriteBatch.Draw(n2, nukelocateshop, Color.White);
                    }
                    if (nukelevel == 2)
                    {
                        spriteBatch.Draw(n3, nukelocateshop, Color.White);
                    }
                    if (nukelevel == 3)
                    {
                        spriteBatch.Draw(n4, nukelocateshop, Color.White);
                    }
                    if (nukelevel == 4)
                    {
                        spriteBatch.Draw(n5, nukelocateshop, Color.White);
                    }
                    if (nukelevel == 5)
                    {
                        spriteBatch.Draw(outof, nukelocateshop, Color.White);
                    }

                }
                else
                {
                    if (nukelevel == 0)
                    {
                        spriteBatch.Draw(n1, nukelocateshop, Color.Gray);
                    }
                    if (nukelevel == 1)
                    {
                        spriteBatch.Draw(n2, nukelocateshop, Color.Gray);
                    }
                    if (nukelevel == 2)
                    {
                        spriteBatch.Draw(n3, nukelocateshop, Color.Gray);
                    }
                    if (nukelevel == 3)
                    {
                        spriteBatch.Draw(n4, nukelocateshop, Color.Gray);
                    }
                    if (nukelevel == 4)
                    {
                        spriteBatch.Draw(n5, nukelocateshop, Color.Gray);
                    }
                    if (nukelevel == 5)
                    {
                        spriteBatch.Draw(outof, nukelocateshop, Color.Gray);
                    }

                }
                if (armorshop)
                {
                    if (armorup == 0)
                    {
                        spriteBatch.Draw(a1, armorlocateshop, Color.White);
                    }
                    if (armorup == 1)
                    {
                        spriteBatch.Draw(a2, armorlocateshop, Color.White);
                    }
                    if (armorup == 2)
                    {
                        spriteBatch.Draw(a3, armorlocateshop, Color.White);
                    }
                    if (armorup == 3)
                    {
                        spriteBatch.Draw(a4, armorlocateshop, Color.White);
                    }
                    if (armorup == 4)
                    {
                        spriteBatch.Draw(a5, armorlocateshop, Color.White);
                    }
                    if (armorup == 5)
                    {
                        spriteBatch.Draw(a7, armorlocateshop, Color.White);
                    }
                    if (armorup == 6)
                    {
                        spriteBatch.Draw(a10, armorlocateshop, Color.White);
                    }
                    if (armorup == 7)
                    {
                        spriteBatch.Draw(outof, armorlocateshop, Color.White);
                    }
                }
                else
                {
                    if (armorup == 0)
                    {
                        spriteBatch.Draw(a1, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 1)
                    {
                        spriteBatch.Draw(a2, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 2)
                    {
                        spriteBatch.Draw(a3, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 3)
                    {
                        spriteBatch.Draw(a4, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 4)
                    {
                        spriteBatch.Draw(a5, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 5)
                    {
                        spriteBatch.Draw(a7, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 6)
                    {
                        spriteBatch.Draw(a10, armorlocateshop, Color.Gray);
                    }
                    if (armorup == 7)
                    {
                        spriteBatch.Draw(outof, armorlocateshop, Color.Gray);
                    }
                }
                if (save)
                {
                    spriteBatch.DrawString(comicsans2, "Save", savebutton, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans2, "Save", savebutton, Color.White);
                }
                if (continue1)
                {
                    spriteBatch.DrawString(comicsans2, "Continue", contineuebutton, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans2, "Continue", contineuebutton, Color.White);
                }
                if (quit1)
                {
                    spriteBatch.DrawString(comicsans2, "Quit", quitbuttonshop, Color.Wheat);
                }
                else
                {
                    spriteBatch.DrawString(comicsans2, "Quit", quitbuttonshop, Color.White);
                }
                if (life1)
                {
                    if (lifeup == 0)
                    {
                        spriteBatch.Draw(l1, lifelocateshop, Color.White);
                    }
                    if (lifeup == 1)
                    {
                        spriteBatch.Draw(l2, lifelocateshop, Color.White);
                    }
                    if (lifeup == 2)
                    {
                        spriteBatch.Draw(l3, lifelocateshop, Color.White);
                    }
                    if (lifeup == 3)
                    {
                        spriteBatch.Draw(l4, lifelocateshop, Color.White);
                    }
                    if (lifeup == 4)
                    {
                        spriteBatch.Draw(l7, lifelocateshop, Color.White);
                    }
                    if (lifeup == 5)
                    {
                        spriteBatch.Draw(outof, lifelocateshop, Color.White);
                    }
                }
                else
                {
                    if (lifeup == 0)
                    {
                        spriteBatch.Draw(l1, lifelocateshop, Color.Gray);
                    }
                    if (lifeup == 1)
                    {
                        spriteBatch.Draw(l2, lifelocateshop, Color.Gray);
                    }
                    if (lifeup == 2)
                    {
                        spriteBatch.Draw(l3, lifelocateshop, Color.Gray);
                    }
                    if (lifeup == 3)
                    {
                        spriteBatch.Draw(l4, lifelocateshop, Color.Gray);
                    }
                    if (lifeup == 4)
                    {
                        spriteBatch.Draw(l7, lifelocateshop, Color.Gray);
                    }
                    if (lifeup == 5)
                    {
                        spriteBatch.Draw(outof, lifelocateshop, Color.Gray);
                    }
                }
                bankmoney = bank.ToString();
                spriteBatch.DrawString(comicsans2, "Bank $", moneylocate, Color.White);
                spriteBatch.DrawString(comicsans2, bankmoney, banklocate, Color.White);
                nuky = nukesleft.ToString();
                spriteBatch.DrawString(comicsans2, "Nukes :", nukinglocate, Color.White);
                spriteBatch.DrawString(comicsans2, nuky, nukelocate, Color.White);
                bob = armor.ToString();
                spriteBatch.DrawString(comicsans2, "Armor :", wordlocate, Color.White);
                spriteBatch.DrawString(comicsans2, bob, armorlocate, Color.White);
                Rectangle rect = new Rectangle(0, 0, gun.gunTexture.Width, gun.gunTexture.Height);
                spriteBatch.Draw(gun.gunTexture, gun.Location, rect, Color.White);
            }
            #endregion

            #region Highscore
            #region addnewScore
            if (addhigh)
            {
                string scor = "Your Score :" + Score.ToString();
                string levels = "Level : " + GameLevel.ToString();
                string highs = "#" + high.ToString();
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(addhighback, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
                spriteBatch.DrawString(comichigh, highs, highscor, Color.White);
                if (high == 1)
                {
                    spriteBatch.DrawString(comichigh, name1, name, Color.White);
                }
                if (high == 2)
                {
                    spriteBatch.DrawString(comichigh, name2, name, Color.White);
                }
                if (high == 3)
                {
                    spriteBatch.DrawString(comichigh, name3, name, Color.White);
                }
                if (high == 4)
                {
                    spriteBatch.DrawString(comichigh, name4, name, Color.White);
                }
                if (high == 5)
                {
                    spriteBatch.DrawString(comichigh, name5, name, Color.White);
                }
                if (high == 6)
                {
                    spriteBatch.DrawString(comichigh, name6, name, Color.White);
                }
                if (high == 7)
                {
                    spriteBatch.DrawString(comichigh, name7, name, Color.White);
                }
                if (high == 8)
                {
                    spriteBatch.DrawString(comichigh, name8, name, Color.White);
                }
                if (high == 9)
                {
                    spriteBatch.DrawString(comichigh, name9, name, Color.White);
                }
                if (high == 10)
                {
                    spriteBatch.DrawString(comichigh, name10, name, Color.White);
                }

                spriteBatch.DrawString(comichigh, scor, score, Color.White);
                spriteBatch.DrawString(comichigh, levels, level, Color.White);
            }
            #endregion
            #region Highscores
            if (Highscores)
            {
                string hs1 = "1." + name1 + highscore1.ToString();
                string hs2 = "2." + name2 + highscore2.ToString();
                string hs3 = "3." + name3 + highscore3.ToString();
                string hs4 = "4." + name4 + highscore4.ToString();
                string hs5 = "5." + name5 + highscore5.ToString();
                string hs6 = "6." + name6 + highscore6.ToString();
                string hs7 = "7." + name7 + highscore7.ToString();
                string hs8 = "8." + name8 + highscore8.ToString();
                string hs9 = "9." + name9 + highscore9.ToString();
                string hs10 = "10." + name10 + highscore10.ToString();
                spriteBatch.DrawString(comicsans, hs1, h1, Color.White);
                spriteBatch.DrawString(comicsans, hs2, h2, Color.White);
                spriteBatch.DrawString(comicsans, hs3, h3, Color.White);
                spriteBatch.DrawString(comicsans, hs4, h4, Color.White);
                spriteBatch.DrawString(comicsans, hs5, h5, Color.White);
                spriteBatch.DrawString(comicsans, hs6, h6, Color.White);
                spriteBatch.DrawString(comicsans, hs7, h7, Color.White);
                spriteBatch.DrawString(comicsans, hs8, h8, Color.White);
                spriteBatch.DrawString(comicsans, hs9, h9, Color.White);
                spriteBatch.DrawString(comicsans, hs10, h10, Color.White);
            }
            #endregion
            #endregion

            #region aboutus
            if (Aus)
            {
                Rectangle rect10 = new Rectangle(0, 0, 800, 600);
                spriteBatch.Draw(aboutus, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
        #endregion
        #region Methods
        public int DrawAnimatedSprite(Texture2D tex, SpriteBatch batch, Vector2 loc, int currentFrame, double AnimationElapsed)
        {
            int frameCount = tex.Width / tex.Height;

            if (AnimationElapsed == 0)
            {   
                currentFrame = (currentFrame + 1) % frameCount;
            }
            Rectangle rect = new Rectangle(currentFrame * tex.Height, 0, tex.Height, tex.Height);

            batch.Draw(tex, loc, rect, Color.White);

            if (currentFrame == frameCount)
            {
                currentFrame = 0;
            }

            return currentFrame;
        }

        public void mattt()
        {
            if (topShip.Type == InvaderShip.type.Matt && lasttype == InvaderShip.type.Matt || topShip.Type == InvaderShip.type.Matt1 && lasttype == InvaderShip.type.Matt1)
            {
                topShip.Type = (InvaderShip.type)(Math.Round(((float)rand.Next(6, 108) / 6) - 1));
                mattt();
            }
        }

        public void DrawScore(SpriteBatch batch, Vector2 loc)
        {
            batch.Draw(wordScore, loc, Color.White);
            loc.X += 50;
            string number = Score.ToString();
            int tempx = 0;
            for (int x = 0; x < 10; x++)
            {
                tempx = 10 - number.Length;
                if (x < tempx)
                {
                    DrawNumber(0, batch, new Vector2(loc.X + (x * scoreFont.Height), loc.Y), print);
                }
                else
                {
                    DrawNumber(Convert.ToInt32(number[x - tempx]) - 48, batch, new Vector2(loc.X + (x * scoreFont.Height), loc.Y), print);
                }
            }
        }

        public void DrawLevel(SpriteBatch batch, Vector2 loc)
        {
            batch.Draw(wordLevel, loc, Color.White);
            loc.X += 50;
            string number = GameLevel.ToString();
            int tempx = 0;
            for (int x = 0; x < 3; x++)
            {
                tempx = 3 - number.Length;
                if (x < tempx)
                {
                    DrawNumber(0, batch, new Vector2(loc.X + (x * scoreFont.Height), loc.Y), print);
                }
                else
                {
                    DrawNumber(Convert.ToInt32(number[x - tempx]) - 48, batch, new Vector2(loc.X + (x * scoreFont.Height), loc.Y), print);
                }
            }
        }

        public void DrawNumber(int number, SpriteBatch batch, Vector2 loc)
        {
            DrawNumber(number, batch, loc, Color.White);
        }

        public void topshipnottimorjeff()
        {
            if (topShip.Type == InvaderShip.type.Tim && GameLevel <= 10)
            {
                topShip.Type = (InvaderShip.type)(Math.Round(((float)rand.Next(6, 18) / 6) - 1));
                topshipnottimorjeff();
            }
            if (topShip.Type == InvaderShip.type.Jeff && GameLevel <= 5)
            {
                topShip.Type = (InvaderShip.type)(Math.Round(((float)rand.Next(6, 18) / 6) - 1));
                topshipnottimorjeff();
            }
        }

        public void DrawNumber(int number, SpriteBatch batch, Vector2 loc, Color color)
        {
            Rectangle rect = new Rectangle(number * scoreFont.Height, 0, scoreFont.Height, scoreFont.Height);
            batch.Draw(scoreFont, loc, rect, color);
        }

        public void InitializeLevel(double mod)
        {
            if (levelmulti3 == levelfive * levelmulti / 5 * levelmulti2 / 14)
            {
                levelmulti2 = 1;
                levelmulti3++;
            }
            if (levelmulti2 == 2)
            {
                army.resetArmy(GameLevel, type1, type2, type3, type4, type5, type5);
            }
            else
            {
                if (levelmulti2 == 2)
                {
                    army.resetArmy(GameLevel, type1, type2, type3, type4, type4, type5);
                }
                if (levelmulti2 == 4)
                {
                    army.resetArmy(GameLevel, type1, type2, type3, type4, type4, type4);
                }
                if (levelmulti2 == 6)
                {
                    army.resetArmy(GameLevel, type1, type2, type3, type3, type4, type4);
                }
                if (levelmulti2 == 8)
                {
                    army.resetArmy(GameLevel, type1, type2, type3, type3, type3, type4);
                }
                if (levelmulti2 == 10)
                {
                    army.resetArmy(GameLevel, type1, type2, type3, type3, type3, type3);
                }
                if (levelmulti2 == 12)
                {
                    army.resetArmy(GameLevel, type1, type2, type2, type3, type3, type3);
                }
                if (levelmulti2 == 14)
                {
                    army.resetArmy(GameLevel, type1, type2, type2, type2, type3, type3);
                }
                if (levelmulti2 == 16)
                {
                    army.resetArmy(GameLevel, type1, type2, type2, type2, type2, type3);
                }
                if (levelmulti2 == 18)
                {
                    army.resetArmy(GameLevel, type1, type2, type2, type2, type2, type2);
                }
                if (levelmulti2 == 20)
                {
                    army.resetArmy(GameLevel, type1, type1, type2, type2, type2, type2);
                }
                if (levelmulti2 == 22)
                {
                    army.resetArmy(GameLevel, type1, type1, type1, type2, type2, type2);
                }
                if (levelmulti2 == 24)
                {
                    army.resetArmy(GameLevel, type1, type1, type1, type1, type2, type2);
                }
                if (levelmulti2 == 26)
                {
                    army.resetArmy(GameLevel, type1, type1, type1, type1, type1, type2);
                }
                if (levelmulti2 == 28)
                {
                    army.resetArmy(GameLevel, type1, type1, type1, type1, type1, type1);
                }
                if (levelmulti2 == 15)
                {
                    army.resetArmy(GameLevel, type1, type1, type1, type1, type1, type1);
                }
            }
            Bullet.Clear();
            enemyShot.Clear();
            m_AlienMovementDelay *= mod;
            m_CurrentMovemenDelay = m_AlienMovementDelay;
        
        }

        public void drawHitScore(SpriteBatch batch, Vector2 loc, int score)
        {

            string number = score.ToString();
            int tempx = 0;
            for (int x = 0; x < number.Length; x++)
            {
                DrawNumber(Convert.ToInt32(number[x - tempx]) - 48, batch, new Vector2(loc.X + (x * scoreFont.Height), loc.Y),new Color(new Vector3(1.0f,0,0)));
            }
        }
        #endregion
        #region Collision
        public void collisiondetection()
        {
            Rectangle rect4 = new Rectangle((int)gun.Location.X, (int)gun.Location.Y, 30, 30);
            Rectangle rect5 = new Rectangle((int)_locationplaybutton.X, (int)_locationplaybutton.Y, 82, 50);
            Rectangle rect6 = new Rectangle((int)_locationoptionsbutton.X, (int)_locationoptionsbutton.Y, 200, 50);
            Rectangle rect7 = new Rectangle((int)_locationquitbutton.X, (int)_locationquitbutton.Y, 200, 50);
            rect4.Intersects(ref rect5, out collision);
            rect4.Intersects(ref rect6, out collision2);
            rect4.Intersects(ref rect7, out collision3);
            if (collision)
            {
                playbutton = true;
                quitbutton = false;
                optionsbutton = false;
                aboutuss = false;
            }
            if (collision2)
            {
                optionsbutton = true;
                playbutton = false;
                quitbutton = false;
                aboutuss = false;
            }
            if (collision3)
            {
                quitbutton = true;
                optionsbutton = false;
                playbutton = false;
                aboutuss = false;
            }
        }
        public void collisionaboutus()
        {
            Rectangle rect = new Rectangle((int)gun.Location.X, (int)gun.Location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)logolocate.X, (int)logolocate.Y, 193, 183);
            rect.Intersects(ref rect2, out aboutuscoll);
            if (aboutuscoll)
            {
                optionsbutton = false;
                playbutton = false;
                quitbutton = false;
                aboutuss = true;
            }
        }
        public void collisiondetect2()
        {
            Rectangle rect = new Rectangle((int)gun.Location.X, (int)gun.Location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)_pauseresumelocate.X, (int)_pauseresumelocate.Y, 150, 50);
            Rectangle rect3 = new Rectangle((int)_pauseoptionslocate.X, (int)_pauseoptionslocate.Y, 150, 50);
            Rectangle rect4 = new Rectangle((int)_pauseexitlocate.X, (int)_pauseexitlocate.Y, 150 , 50);
            rect.Intersects(ref rect2, out pcollision);
            rect.Intersects(ref rect3, out pcollision2);
            rect.Intersects(ref rect4, out pcollision3);
            if (pcollision)
            {
                resumeactive = true;
                poptionsactive = false;
                exitactive = false;
            }
            if (pcollision2)
            {
                resumeactive = false;
                poptionsactive = true;
                exitactive = false;
            }
            if (pcollision3)
            {
                resumeactive = false;
                poptionsactive = false;
                exitactive = true;
            }
        }
        public void collisionoptions()
        {
            Rectangle rect = new Rectangle((int)gun.Location.X, (int)gun.Location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)test.X, (int)test.Y, 300, 50);
            Rectangle rect3 = new Rectangle((int)op2.X, (int)op2.Y, 300, 50);
            //Rectangle rect4 = new Rectangle((int)op3.X, (int)op3.Y, 50, 300);
            Rectangle rect5 = new Rectangle((int)op4.X, (int)op4.Y, 300, 50);
            Rectangle rect6 = new Rectangle((int)op5.X, (int)op5.Y, 300, 50);
            Rectangle rect7 = new Rectangle((int)opbackb.X, (int)opbackb.Y, 200, 50);
            rect.Intersects(ref rect2, out opcollision);
            rect.Intersects(ref rect3, out opcollision2);
            //rect.Intersects(ref rect4, out opcollision3);
            rect.Intersects(ref rect5, out opcollision4);
            rect.Intersects(ref rect6, out opcollision5);
            rect.Intersects(ref rect7, out opcollision6);
            if (opcollision)
            {
                opchoice1 = true;
                opchoice2 = false;
                opchoice3 = false;
                opchoice4 = false;
                opchoice5 = false;
                opchoice6 = false;
            }
            if (opcollision2)
            {
                opchoice1 = false;
                opchoice2 = true;
                opchoice3 = false;
                opchoice4 = false;
                opchoice5 = false;
                opchoice6 = false;
            }
            /*if (opcollision3)
            {
                opchoice1 = false;
                opchoice2 = false;
                opchoice3 = true;
                opchoice4 = false;
                opchoice5 = false;
                opchoice6 = false;
            }*/
            if (opcollision4)
            {
                opchoice1 = false;
                opchoice2 = false;
                opchoice3 = false;
                opchoice4 = true;
                opchoice5 = false;
                opchoice6 = false;
            }
            if (opcollision5)
            {
                opchoice1 = false;
                opchoice2 = false;
                opchoice3 = false;
                opchoice4 = false;
                opchoice5 = true;
                opchoice6 = false;
            }
            if (opcollision6)
            {
                opchoice1 = false;
                opchoice2 = false;
                opchoice3 = false;
                opchoice4 = false;
                opchoice5 = false;
                opchoice6 = true;
            }
        }
        public void collisionshop()
        {
            Rectangle rect = new Rectangle((int)gun.Location.X, (int)gun.Location.Y, 30, 30);
            Rectangle rect2 = new Rectangle((int)laserlocateshop.X, (int)laserlocateshop.Y, 100, 150);
            Rectangle rect3 = new Rectangle((int)nukelocateshop.X, (int)nukelocateshop.Y, 100, 150);
            Rectangle rect4 = new Rectangle((int)armorlocateshop.X, (int)armorlocateshop.Y, 100, 150);
            Rectangle rect5 = new Rectangle((int)savebutton.X, (int)savebutton.Y, 150, 50);
            Rectangle rect6 = new Rectangle((int)quitbuttonshop.X, (int)quitbuttonshop.Y, 150, 50);
            Rectangle rect7 = new Rectangle((int)contineuebutton.X, (int)contineuebutton.Y, 150, 50);
            Rectangle rect8 = new Rectangle((int)lifelocateshop.X, (int)lifelocateshop.Y, 100, 150);
            rect.Intersects(ref rect2, out collisionshop1);
            rect.Intersects(ref rect3, out collisionshop2);
            rect.Intersects(ref rect4, out collisionshop3);
            rect.Intersects(ref rect5, out collisionshop4);
            rect.Intersects(ref rect6, out collisionshop5);
            rect.Intersects(ref rect7, out collisionshop6);
            rect.Intersects(ref rect8, out collisionshop7);
            if (collisionshop1)
            {
                lasershop = true;
                nukeshop = false;
                armorshop = false;
                save = false;
                continue1 = false;
                quit1 = false;
                life1 = false;
            }
            if (collisionshop2)
            {
                lasershop = false;
                nukeshop = true;
                armorshop = false;
                save = false;
                continue1 = false;
                quit1 = false;
                life1 = false;
            }
            if (collisionshop3)
            {
                lasershop = false;
                nukeshop = false;
                armorshop = true;
                save = false;
                continue1 = false;
                quit1 = false;
                life1 = false;
            }
            if (collisionshop4)
            {
                lasershop = false;
                nukeshop = false;
                armorshop = false;
                save = true;
                continue1 = false;
                quit1 = false;
                life1 = false;
            }
            if (collisionshop5)
            {
                lasershop = false;
                nukeshop = false;
                armorshop = false;
                save = false;
                continue1 = false;
                quit1 = true;
                life1 = false;
            }
            if (collisionshop6)
            {
                lasershop = false;
                nukeshop = false;
                armorshop = false;
                save = false;
                continue1 = true;
                quit1 = false;
                life1 = false;
            }
            if (collisionshop7)
            {
                lasershop = false;
                nukeshop = false;
                armorshop = false;
                save = false;
                continue1 = false;
                quit1 = false;
                life1 = true;
            }
        }
        #endregion
        #region screens
        public void Screen1()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen1, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen2()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen2, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen3()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen3, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen4()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen4, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen5()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen5, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen6()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen6, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen7()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen7, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen8()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen8, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen9()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen9, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen10()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen10, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen11()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen11, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen12()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen12, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen13()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen13, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen14()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen14, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen15()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen15, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen16()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen16, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen17()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen17, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen18()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen18, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        public void Screen19()
        {
            Rectangle rect10 = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(screen19, rect10, rect10, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 0);
        }
        #endregion
    }
}
#endregion
#region Savegame
#region SaveGame Struct
[Serializable]
public struct Savegame
{
    public string name;
    public int score;
    public int level;
    public int lives;
    public int lifeup;
    public int armorupgrade;
    public int laserupgrade;
    public DateTime date;
    public int damageFL;
    public int damageL;
    public int damageLC;
    public int damageC;
    public int damageRC;
    public int damageR;
    public int damageFR;
    public int nukelevel;
    public int nukesleft;
    public int armorleft;
    public double alien_movementdelay;
    public double enemyshotdelay;
    public double tshipspeed;
    public double currentmovedelay;
    public int levelmulti;
    public int levelmulti2;
    public int levelmulti3;
    public int money;
    public int savenum;
}
#endregion
#region Save load and Delete Savegame
public class savegamestorage
{
    public void save(Savegame sg)
    {
        IAsyncResult result;
        //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
        //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
        //StorageContainer container = device.OpenContainer("HoboStorage");
        //string filename = Path.Combine(container.Path, "savegame.xml");
        //FileStream stream = File.Open(filename, FileMode.OpenOrCreate);
        //XmlSerializer serializer = new XmlSerializer(typeof(Savegame));
        //serializer.Serialize(stream, sg);
        //stream.Close();
        //container.Dispose();

    }
     public Savegame Load()
        {
            Savegame ret = new Savegame();

            IAsyncResult result;
            //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
            //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);


           // Open a storage container
           // StorageContainer container = device.OpenContainer("HoboStorage");

            // Get the path of the save game
            //string filename = Path.Combine(container.Path, "savegame.xml");

            // Check to see if the save exists
            //if (!File.Exists(filename))
                // Notify the user there is no save           
            //    return ret;

            // Open the file
            //FileStream stream = File.Open(filename, FileMode.OpenOrCreate,
            //FileAccess.Read);

            // Read the data from the file
            //XmlSerializer serializer = new XmlSerializer(typeof(Savegame));
            //ret = (Savegame)serializer.Deserialize(stream);

            // Close the file
            //stream.Close();

            // Dispose the container
            //container.Dispose();

            return ret;
        }
     public Savegame deletegame()
     {
         Savegame ret = new Savegame();
         IAsyncResult result;
         //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
         //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
         //StorageContainer container =
         //        device.OpenContainer("HoboStorage");

         // Add the container path to our file name.
         //string filename = Path.Combine(container.Path, "savegame.xml");

         // Delete the new file.
         //if (File.Exists(filename))
         //    File.Delete(filename);

         // Dispose the container, to commit the change.
         //container.Dispose();
         return ret;
     }
}
#endregion
#endregion
#region othersave files
[Serializable]
public struct savenumfile
{
    public int savenum;
}
public class savefilenumst
{
    public void save(savenumfile snf)
    {
        IAsyncResult result;
        //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
        //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
        //StorageContainer container = device.OpenContainer("ImportatntStuff");
        //string filename = Path.Combine(container.Path, "Graphics.xml");
        //FileStream stream = File.Open(filename, FileMode.OpenOrCreate);
        //XmlSerializer serializer = new XmlSerializer(typeof(savenumfile));
        //serializer.Serialize(stream, snf);
        //stream.Close();
        //container.Dispose();

    }
    public savenumfile Load()
    {
        savenumfile ret = new savenumfile();

        IAsyncResult result;
        //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
        //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);

        // Open a storage container
        //StorageContainer container = device.OpenContainer("ImportatntStuff");

        // Get the path of the save game
        //string filename = Path.Combine(container.Path, "Graphics.xml");

        // Check to see if the save exists
        //if (!File.Exists(filename))
            // Notify the user there is no save           
            return ret;

        // Open the file
        //FileStream stream = File.Open(filename, FileMode.OpenOrCreate,
        //FileAccess.Read);

        // Read the data from the file
        //XmlSerializer serializer = new XmlSerializer(typeof(savenumfile));
        //ret = (savenumfile)serializer.Deserialize(stream);

        // Close the file
        //stream.Close();

        // Dispose the container
        //container.Dispose();

        return ret;
    }
    public savenumfile deletegame()
    {
        savenumfile ret = new savenumfile();
        //IAsyncResult result;
        //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
        //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
        //StorageContainer container = device.OpenContainer("ImportatntStuff");

        //// Add the container path to our file name.
        //string filename = Path.Combine(container.Path, "Graphics.xml");

        //// Delete the new file.
        //if (File.Exists(filename))
        //    File.Delete(filename);

        //// Dispose the container, to commit the change.
        //container.Dispose();
        return ret;
    }
}
[Serializable]
public struct Highscoressave
{
    public int Highscore1;
    public int Highscore2;
    public int Highscore3;
    public int Highscore4;
    public int Highscore5;
    public int Highscore6;
    public int Highscore7;
    public int Highscore8;
    public int Highscore9;
    public int Highscore10;
    public string name1;
    public string name2;
    public string name3; 
    public string name4;
    public string name5;
    public string name6;
    public string name7;
    public string name8;
    public string name9;
    public string name10;
}
public class savehighscores
{
    public void save(Highscoressave sg)
    {
        //IAsyncResult result;
        //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
        //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
        //StorageContainer container = device.OpenContainer("HoboStorage");
        //string filename = Path.Combine(container.Path, "Highscores.xml");
        //FileStream stream = File.Open(filename, FileMode.OpenOrCreate);
        //XmlSerializer serializer = new XmlSerializer(typeof(Savegame));
        //serializer.Serialize(stream, sg);
        //stream.Close();
        //container.Dispose();

    }
     public Highscoressave Load()
        {
            Highscoressave ret = new Highscoressave();

           // IAsyncResult result;
           // result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
           // StorageDevice device = Guide.EndShowStorageDeviceSelector(result);


           //// Open a storage container
           // StorageContainer container = device.OpenContainer("HoboStorage");

           // // Get the path of the save game
           // string filename = Path.Combine(container.Path, "Highscorese.xml");

           // // Check to see if the save exists
           // if (!File.Exists(filename))
           //     // Notify the user there is no save           
           //     return ret;

           // // Open the file
           // FileStream stream = File.Open(filename, FileMode.OpenOrCreate,
           // FileAccess.Read);

           // // Read the data from the file
           // XmlSerializer serializer = new XmlSerializer(typeof(Savegame));
           // ret = (Highscoressave)serializer.Deserialize(stream);

           // // Close the file
           // stream.Close();

           // // Dispose the container
           // container.Dispose();

            return ret;
        }
     public Highscoressave deletegame()
     {
         Highscoressave ret = new Highscoressave();
         //IAsyncResult result;
         //result = Guide.BeginShowStorageDeviceSelector(PlayerIndex.One, null, null);
         //StorageDevice device = Guide.EndShowStorageDeviceSelector(result);
         //StorageContainer container =
         //        device.OpenContainer("HoboStorage");

         //// Add the container path to our file name.
         //string filename = Path.Combine(container.Path, "Highscores.xml");

         //// Delete the new file.
         //if (File.Exists(filename))
         //    File.Delete(filename);

         //// Dispose the container, to commit the change.
         //container.Dispose();
         return ret;
     }

}
#endregion