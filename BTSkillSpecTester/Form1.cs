using System;
using System.IO;
using System.Windows.Forms;

namespace BTSkillSpecTester
{
    

    public partial class BTSkillSpecTester : Form
    {
        private readonly int[] FortMaxSP = {20, 20, 10, 10, 10, 20, 15, 25, 15, 20, 15, 20, 20, 25, 10, 15, 10};
        private readonly int[] LaiMaxSP = {20, 10, 15, 20, 15, 20, 20, 15, 20, 15, 20, 20, 20, 15, 15, 10, 10};
        private readonly int[] EkaMaxSP = {10, 5, 10, 10, 30, 15, 15, 30, 1, 15, 10, 15, 30, 15, 30, 15, 15, 10};
        private readonly int[] ArbyMaxSP = {10, 10, 15, 15, 10, 20, 20, 20, 10, 15, 20, 15, 20, 20, 15, 15, 20, 10};
        private readonly int[] FortInvestmentReq = {0, 7, 15, 24, 39, 47, 62, 73, 93, 105, 120, 130, 140, 155, 175, 183, 190};
        private readonly int[] LaiInvestmentReq = {0, 9, 18, 27, 39, 48, 60, 72, 87, 96, 107, 116, 123, 129, 138, 149, 190};
        private readonly int[] EkaInvestmentReq = {0, 0, 8, 14, 20, 27, 40, 50, 70, 71, 81, 82, 103, 126, 137, 145, 150, 170};
        private readonly int[] ArbyInvestmentReq = {0, 0, 8, 15, 27, 39, 51, 60, 70, 83, 95, 104, 113, 125, 137, 147, 160, 170};
        private int FortSP = 0;
        private int LaiSP = 0;
        private int EkaSP = 0;
        private int ArbySP = 0;
        private int SP;
        private int CurrentAllSkill = 0;
        private readonly string filepath = System.IO.Directory.GetCurrentDirectory();

        public BTSkillSpecTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on load attempt to initialize all dinamic elements
            int i;

            try
            {
                //configure bear elements
                for (i = 1; i < 17; i++)
                {
                    BTSBear[i] = new PictureBox();
                    LblFortNames[i] = new Label();
                    BTSBear[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    BTSBear[i].Location = new System.Drawing.Point(BTSBear[i - 1].Location.X, BTSBear[i - 1].Location.Y + 35);
                    LblFortNames[i].Location = new System.Drawing.Point(BTSBear[i].Location.X + 35, BTSBear[i].Location.Y);
                    LblFortNames[i].AutoSize = true;
                    PnlFort.Controls.Add(BTSBear[i]);
                    PnlFort.Controls.Add(this.LblFortNames[i]);

                    FortSPSelectors[i] = new NumericUpDown();
                    FortSPSelectors[i].Value = 0;
                    FortSPSelectors[i].Maximum = FortMaxSP[i];
                    FortSPSelectors[i].Minimum = 0;
                    FortSPSelectors[i].ValueChanged += new EventHandler(this.NumericUpDown_ValueChanged);
                    FortSPSelectors[i].Width = 50;
                    FortSPSelectors[i].Location = new System.Drawing.Point(BTSBear[i].Location.X + 35, BTSBear[i].Location.Y + 14);
                    FortSPSelectors[i].ReadOnly = true;
                    FortSPSelectors[i].Enabled = false;
                    PnlFort.Controls.Add(this.FortSPSelectors[i]);

                    FortAdjSP[i] = new Label();
                    FortAdjSP[i].Text = "0/" + FortMaxSP[i];
                    FortAdjSP[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    FortAdjSP[i].Location = new System.Drawing.Point(FortSPSelectors[i].Location.X + 50, FortSPSelectors[i].Location.Y);
                    PnlFort.Controls.Add(FortAdjSP[i]);
                }
                //add bear context
                BTSBear[0].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\PawSwipe.png");
                LblFortNames[0].Text = "Paw Swipe";
                BTSBear[1].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\Trumpet.png");
                LblFortNames[1].Text = "Majestic Trumpet";
                BTSBear[2].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\WellFed.png");
                LblFortNames[2].Text = "Well Fed";
                BTSBear[3].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\DumbLuck.png");
                LblFortNames[3].Text = "Dumb Luck";
                BTSBear[4].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\DeepBreath.png");
                LblFortNames[4].Text = "Deep Breath";
                BTSBear[5].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\FortFollowUp.png");
                LblFortNames[5].Text = "Fort Follow-Up";
                BTSBear[6].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\DefenseIgnorance.png");
                LblFortNames[6].Text = "Defense Ignorance";
                BTSBear[7].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\FuriousStrikes.png");
                LblFortNames[7].Text = "Furious Strikes";
                BTSBear[8].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\BearStrength.png");
                LblFortNames[8].Text = "Bear Strength";
                BTSBear[9].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\ReallyDeepBreath.png");
                LblFortNames[9].Text = "Really Deep Breath";
                BTSBear[10].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\LilFort.png");
                LblFortNames[10].Text = "Lil Fort";
                BTSBear[11].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\FortTheBrave.png");
                LblFortNames[11].Text = "Fort the Brave";
                BTSBear[12].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\BearAssault.png");
                LblFortNames[12].Text = "Bear Assault";
                BTSBear[13].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\FishySlap.png");
                LblFortNames[13].Text = "Fishy Slap";
                BTSBear[14].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\BearReborn.png");
                LblFortNames[14].Text = "Bear Reborn";
                BTSBear[15].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\BillowingTrumpet.png");
                LblFortNames[15].Text = "Billowing Trumpet";
                BTSBear[16].Image = System.Drawing.Image.FromFile(filepath + @"\images\Fort\TableFlip.png");
                LblFortNames[16].Text = "Table Flip";

                //configure leopard elements
                for (i = 1; i < 17; i++)
                {
                    BTSLeopard[i] = new PictureBox();
                    LblLaiNames[i] = new Label();
                    BTSLeopard[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    BTSLeopard[i].Location = new System.Drawing.Point(BTSLeopard[i - 1].Location.X, BTSLeopard[i - 1].Location.Y + 35);
                    LblLaiNames[i].Location = new System.Drawing.Point(BTSLeopard[i].Location.X + 35, BTSLeopard[i].Location.Y);
                    LblLaiNames[i].AutoSize = true;
                    PnlLai.Controls.Add(BTSLeopard[i]);
                    PnlLai.Controls.Add(this.LblLaiNames[i]);

                    LaiSPSelectors[i] = new NumericUpDown();
                    LaiSPSelectors[i].Value = 0;
                    LaiSPSelectors[i].Maximum = LaiMaxSP[i];
                    LaiSPSelectors[i].Minimum = 0;
                    LaiSPSelectors[i].ValueChanged += new EventHandler(this.NumericUpDown_ValueChanged);
                    LaiSPSelectors[i].Width = 50;
                    LaiSPSelectors[i].Location = new System.Drawing.Point(BTSLeopard[i].Location.X + 35, BTSLeopard[i].Location.Y + 14);
                    LaiSPSelectors[i].ReadOnly = true;
                    LaiSPSelectors[i].Enabled = false;
                    PnlLai.Controls.Add(this.LaiSPSelectors[i]);

                    LaiAdjSP[i] = new Label();
                    LaiAdjSP[i].Text = "0/" + LaiMaxSP[i];
                    LaiAdjSP[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    LaiAdjSP[i].Location = new System.Drawing.Point(LaiSPSelectors[i].Location.X + 50, LaiSPSelectors[i].Location.Y);
                    PnlLai.Controls.Add(LaiAdjSP[i]);
                }
                //add leopard context
                BTSLeopard[0].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LeopardsPaw.png");
                LblLaiNames[0].Text = "Leopard's Paw";
                BTSLeopard[1].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\ThunderDash.png");
                LblLaiNames[1].Text = "Thunder Dash";
                BTSLeopard[2].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LeopardHide.png");
                LblLaiNames[2].Text = "Leopard Hide";
                BTSLeopard[3].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LeopardsPounce.png");
                LblLaiNames[3].Text = "Leopard's Pounce";
                BTSLeopard[4].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\RipplingFelineMuscles.png");
                LblLaiNames[4].Text = "Rippling Feline Muscles";
                BTSLeopard[5].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\MachoDance.png");
                LblLaiNames[5].Text = "Macho Dance";
                BTSLeopard[6].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\MachoSlam.png");
                LblLaiNames[6].Text = "Macho Slam";
                BTSLeopard[7].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\BroAttack.png");
                LblLaiNames[7].Text = "Bro Attack";
                BTSLeopard[8].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LeopardsRoar.png");
                LblLaiNames[8].Text = "Leopard's Roar";
                BTSLeopard[9].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\ThunderTrail.png");
                LblLaiNames[9].Text = "Thunder Trail";
                BTSLeopard[10].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\MachoIncarnate.png");
                LblLaiNames[10].Text = "Macho Incarnate";
                BTSLeopard[11].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\ThreePointPounce.png");
                LblLaiNames[11].Text = "Three-Point Pounce";
                BTSLeopard[12].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\AdvancedThunderDash.png");
                LblLaiNames[12].Text = "Advanced Thunder Dash";
                BTSLeopard[13].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\DeadlyFangs.png");
                LblLaiNames[13].Text = "Deadly Fangs";
                BTSLeopard[14].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LethalLai.png");
                LblLaiNames[14].Text = "Lethal Lai";
                BTSLeopard[15].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\LeopardReflexes.png");
                LblLaiNames[15].Text = "Leopard Reflexes";
                BTSLeopard[16].Image = System.Drawing.Image.FromFile(filepath + @"\images\Lai\PartyTime.png");
                LblLaiNames[16].Text = "Party Time";

                //configure hawk elements
                for (i = 1; i < 18; i++)
                {
                    BTSHawk[i] = new PictureBox();
                    LblEkaNames[i] = new Label();
                    BTSHawk[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    BTSHawk[i].Location = new System.Drawing.Point(BTSHawk[i - 1].Location.X, BTSHawk[i - 1].Location.Y + 35);
                    LblEkaNames[i].Location = new System.Drawing.Point(BTSHawk[i].Location.X + 35, BTSHawk[i].Location.Y);
                    LblEkaNames[i].AutoSize = true;
                    PnlEka.Controls.Add(BTSHawk[i]);
                    PnlEka.Controls.Add(LblEkaNames[i]);

                    EkaSPSelectors[i] = new NumericUpDown();
                    EkaSPSelectors[i].Value = 0;
                    EkaSPSelectors[i].Maximum = EkaMaxSP[i];
                    EkaSPSelectors[i].Minimum = 0;
                    EkaSPSelectors[i].ValueChanged += new EventHandler(this.NumericUpDown_ValueChanged);
                    EkaSPSelectors[i].Width = 50;
                    EkaSPSelectors[i].Location = new System.Drawing.Point(BTSHawk[i].Location.X + 35, BTSHawk[i].Location.Y + 14);
                    EkaSPSelectors[i].ReadOnly = true;
                    EkaSPSelectors[i].Enabled = false;
                    PnlEka.Controls.Add(this.EkaSPSelectors[i]);

                    EkaAdjSP[i] = new Label();
                    EkaAdjSP[i].Text = "0/" + EkaMaxSP[i];
                    EkaAdjSP[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    EkaAdjSP[i].Location = new System.Drawing.Point(EkaSPSelectors[i].Location.X + 50, EkaSPSelectors[i].Location.Y);
                    PnlEka.Controls.Add(EkaAdjSP[i]);
                }
                EkaSPSelectors[1].Enabled = true;
                //add hawk context
                BTSHawk[0].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\FormationAttack.png");
                LblEkaNames[0].Text = "Formation Attack";
                BTSHawk[1].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\SkyWalk.png");
                LblEkaNames[1].Text = "Sky Walk";
                BTSHawk[2].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\VerticalDraft.png");
                LblEkaNames[2].Text = "Vertical Draft";
                BTSHawk[3].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\EkaExpress.png");
                LblEkaNames[3].Text = "Eka Express";
                BTSHawk[4].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\Fly.png");
                LblEkaNames[4].Text = "Fly";
                BTSHawk[5].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\HawkFlock.png");
                LblEkaNames[5].Text = "Hawk Flock";
                BTSHawk[6].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\MaxMobility.png");
                LblEkaNames[6].Text = "Max Mobility";
                BTSHawk[7].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\DefensiveFormation.png");
                LblEkaNames[7].Text = "Defensive Formation";
                BTSHawk[8].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\EkaGlider.png");
                LblEkaNames[8].Text = "Eka Glider";
                BTSHawk[9].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\FeatherCloak.png");
                LblEkaNames[9].Text = "Feather Cloak";
                BTSHawk[10].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\Regroup.png");
                LblEkaNames[10].Text = "Regroup";
                BTSHawk[11].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\RaptorTalons.png");
                LblEkaNames[11].Text = "Raptor Talons";
                BTSHawk[12].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\BabyBombers.png");
                LblEkaNames[12].Text = "Baby Bombers";
                BTSHawk[13].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\BirdsEyeView.png");
                LblEkaNames[13].Text = "Bird's Eye View";
                BTSHawk[14].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\VeteranFormation.png");
                LblEkaNames[14].Text = "Veteran Formation";
                BTSHawk[15].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\RazorBeak.png");
                LblEkaNames[15].Text = "Razor Beak";
                BTSHawk[16].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\FeatherBoots.png");
                LblEkaNames[16].Text = "Feather Boots";
                BTSHawk[17].Image = System.Drawing.Image.FromFile(filepath + @"\images\Eka\TornadoFlight.png");
                LblEkaNames[17].Text = "Tornado Flight";

                //configure cat elements
                for (i = 1; i < 18; i++)
                {
                    BTSCat[i] = new PictureBox();
                    LblArbyNames[i] = new Label();
                    BTSCat[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    BTSCat[i].Location = new System.Drawing.Point(BTSCat[i - 1].Location.X, BTSCat[i - 1].Location.Y + 35);
                    LblArbyNames[i].Location = new System.Drawing.Point(BTSCat[i].Location.X + 35, BTSCat[i].Location.Y);
                    LblArbyNames[i].AutoSize = true;
                    PnlArby.Controls.Add(BTSCat[i]);
                    PnlArby.Controls.Add(LblArbyNames[i]);

                    ArbySPSelectors[i] = new NumericUpDown();
                    ArbySPSelectors[i].Value = 0;
                    ArbySPSelectors[i].Maximum = ArbyMaxSP[i];
                    ArbySPSelectors[i].Minimum = 0;
                    ArbySPSelectors[i].ValueChanged += new EventHandler(this.NumericUpDown_ValueChanged);
                    ArbySPSelectors[i].Width = 50;
                    ArbySPSelectors[i].Location = new System.Drawing.Point(BTSCat[i].Location.X + 35, BTSCat[i].Location.Y + 14);
                    ArbySPSelectors[i].ReadOnly = true;
                    ArbySPSelectors[i].Enabled = false;
                    PnlArby.Controls.Add(this.ArbySPSelectors[i]);

                    ArbyAdjSP[i] = new Label();
                    ArbyAdjSP[i].Text = "0/" + ArbyMaxSP[i];
                    ArbyAdjSP[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    ArbyAdjSP[i].Location = new System.Drawing.Point(ArbySPSelectors[i].Location.X + 50, ArbySPSelectors[i].Location.Y);
                    PnlArby.Controls.Add(ArbyAdjSP[i]);
                }
                ArbySPSelectors[1].Enabled = true;
                //add cat context
                BTSCat[0].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\FriendLauncher.png");
                LblArbyNames[0].Text = "Friend Launcher";
                BTSCat[1].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\CatWit.png");
                LblArbyNames[1].Text = "Cat Wit";
                BTSCat[2].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\KittyBattleSquad.png");
                LblArbyNames[2].Text = "Kitty Battle Squad";
                BTSCat[3].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\KittyTreats.png");
                LblArbyNames[3].Text = "Kitty Treats";
                BTSCat[4].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\PurrPowered.png");
                LblArbyNames[4].Text = "Purr Powered";
                BTSCat[5].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\StickyPaws.png");
                LblArbyNames[5].Text = "Sticky Paws";
                BTSCat[6].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MeowHeal.png");
                LblArbyNames[6].Text = "Meow Heal";
                BTSCat[7].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\CatsClaws.png");
                LblArbyNames[7].Text = "Cat's Claws";
                BTSCat[8].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MeowCure.png");
                LblArbyNames[8].Text = "MeowCure";
                BTSCat[9].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\PurrZone.png");
                LblArbyNames[9].Text = "Purr Zone";
                BTSCat[10].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MeowCard.png");
                LblArbyNames[10].Text = "MeowCard";
                BTSCat[11].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\FriendLauncherEnhance.png");
                LblArbyNames[11].Text = "Friend Launcher-Enhance";
                BTSCat[12].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MousersInsight.png");
                LblArbyNames[12].Text = "Mouser's Insight";
                BTSCat[13].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\FireKitty.png");
                LblArbyNames[13].Text = "Fire Kitty!";
                BTSCat[14].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MeowRevive.png");
                LblArbyNames[14].Text = "Meow Revive";
                BTSCat[15].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\MeowGoldCard.png");
                LblArbyNames[15].Text = "Meow Gold Card";
                BTSCat[16].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\FriendsOfArby.png");
                LblArbyNames[16].Text = "Friends of Arby";
                BTSCat[17].Image = System.Drawing.Image.FromFile(filepath + @"\images\Arby\CatsCradleBlitzkrieg.png");
                LblArbyNames[17].Text = "Cat's Cradle Blitzkrieg";
            }
            catch(Exception exc)
            {

            }
            finally
            {

            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < 17; i++)
            {
                if(FortSPSelectors[i].Equals(sender))
                {
                    if (FortSPSelectors[i].Value > 0)
                    {
                        if (FortSPSelectors[i].Value + CurrentAllSkill <= FortMaxSP[i])
                        {
                            FortAdjSP[i].Text = "" + (FortSPSelectors[i].Value + CurrentAllSkill) + "/" + FortMaxSP[i];
                        }
                        else
                        {
                            FortAdjSP[i].Text = "" + FortMaxSP[i] + "/" + FortMaxSP[i];
                        }
                    }
                    else
                    {
                        FortAdjSP[i].Text = "0/" + FortMaxSP[i];
                    }
                }
                if(LaiSPSelectors[i].Equals(sender))
                {
                    if (LaiSPSelectors[i].Value > 0)
                    {
                        if (LaiSPSelectors[i].Value + CurrentAllSkill <= LaiMaxSP[i])
                        {
                            LaiAdjSP[i].Text = "" + (LaiSPSelectors[i].Value + CurrentAllSkill) + "/" + LaiMaxSP[i];
                        }
                        else
                        {
                            LaiAdjSP[i].Text = "" + LaiMaxSP[i] + "/" + LaiMaxSP[i];
                        }
                    }
                    else
                    {
                        LaiAdjSP[i].Text = "0/" + LaiMaxSP[i];
                    }
                }
                if(EkaSPSelectors[i].Equals(sender))
                {
                    if (EkaSPSelectors[i].Value > 0)
                    {
                        if (EkaSPSelectors[i].Value + CurrentAllSkill <= EkaMaxSP[i])
                        {
                            EkaAdjSP[i].Text = "" + (EkaSPSelectors[i].Value + CurrentAllSkill) + "/" + EkaMaxSP[i];
                        }
                        else
                        {
                            EkaAdjSP[i].Text = "" + EkaMaxSP[i] + "/" + EkaMaxSP[i];
                        }
                    }
                    else
                    {
                        EkaAdjSP[i].Text = "0/" + EkaMaxSP[i];
                    }
                }
                if(ArbySPSelectors[i].Equals(sender))
                {
                    if (ArbySPSelectors[i].Value > 0)
                    {
                        if (ArbySPSelectors[i].Value + CurrentAllSkill <= ArbyMaxSP[i])
                        {
                            ArbyAdjSP[i].Text = "" + (ArbySPSelectors[i].Value + CurrentAllSkill) + "/" + ArbyMaxSP[i];
                        }
                        else
                        {
                            ArbyAdjSP[i].Text = "" + ArbyMaxSP[i] + "/" + ArbyMaxSP[i];
                        }
                    }
                    else
                    {
                        ArbyAdjSP[i].Text = "0/" + ArbyMaxSP[i];
                    }
                }
            }
            if (EkaSPSelectors[i].Equals(sender))
            {
                if (EkaSPSelectors[i].Value > 0)
                {
                    if (EkaSPSelectors[i].Value + CurrentAllSkill <= EkaMaxSP[i])
                    {
                        EkaAdjSP[i].Text = "" + (EkaSPSelectors[i].Value + CurrentAllSkill) + "/" + EkaMaxSP[i];
                    }
                    else
                    {
                        EkaAdjSP[i].Text = "" + EkaMaxSP[i] + "/" + EkaMaxSP[i];
                    }
                }
                else
                {
                    EkaAdjSP[i].Text = "0/" + EkaMaxSP[i];
                }
            }
            if (ArbySPSelectors[i].Equals(sender))
            {
                if (ArbySPSelectors[i].Value > 0)
                {
                    if (ArbySPSelectors[i].Value + CurrentAllSkill <= ArbyMaxSP[i])
                    {
                        ArbyAdjSP[i].Text = "" + (ArbySPSelectors[i].Value + CurrentAllSkill) + "/" + ArbyMaxSP[i];
                    }
                    else
                    {
                        ArbyAdjSP[i].Text = "" + ArbyMaxSP[i] + "/" + ArbyMaxSP[i];
                    }
                }
                else
                {
                    ArbyAdjSP[i].Text = "0/" + ArbyMaxSP[i];
                }
            }

            AdjustInvestmnts();
            AdjustSP();
        }

        private void AllSkill_ValueChanged(object sender, EventArgs e)
        {
            int temp;
            int i;

            try
            {
                temp = Int32.Parse(AllSkill.Text);
                if(temp >= 0)
                {
                    CurrentAllSkill = temp;
                    for (i = 0; i < 17; i++)
                    {
                        if(FortSPSelectors[i].Value > 0)
                        {
                            if(FortSPSelectors[i].Value + temp <= FortMaxSP[i])
                            {
                                FortAdjSP[i].Text = "" + (FortSPSelectors[i].Value + temp) + "/" + FortMaxSP[i];
                            }
                            else
                            {
                                FortAdjSP[i].Text = "" + FortMaxSP[i] + "/" + FortMaxSP[i];
                            }
                        }
                        else
                        {
                            FortAdjSP[i].Text = "0/" + FortMaxSP[i];
                        }
                    }
                    for (i = 0; i < 17; i++)
                    {
                        if(LaiSPSelectors[i].Value > 0)
                        {
                            if (LaiSPSelectors[i].Value + temp <= LaiMaxSP[i])
                            {
                                LaiAdjSP[i].Text = "" + (LaiSPSelectors[i].Value + temp) + "/" + LaiMaxSP[i];
                            }
                            else
                            {
                                LaiAdjSP[i].Text = "" + LaiMaxSP[i] + "/" + LaiMaxSP[i];
                            }
                        }
                        else
                        {
                            LaiAdjSP[i].Text = "0/" + LaiMaxSP[i];
                        }
                    }
                    for (i = 0; i < 18; i++)
                    {
                        if(EkaSPSelectors[i].Value > 0)
                        {
                            if (EkaSPSelectors[i].Value + temp <= EkaMaxSP[i])
                            {
                                EkaAdjSP[i].Text = "" + (EkaSPSelectors[i].Value + temp) + "/" + EkaMaxSP[i];
                            }
                            else
                            {
                                EkaAdjSP[i].Text = "" + EkaMaxSP[i] + "/" + EkaMaxSP[i];
                            }
                        }
                        else
                        {
                            EkaAdjSP[i].Text = "0/" + EkaMaxSP[i];
                        }
                    }
                    for (i = 0; i < 18; i++)
                    {
                        if(ArbySPSelectors[i].Value > 0)
                        {
                            if (ArbySPSelectors[i].Value + temp <= ArbyMaxSP[i])
                            {
                                ArbyAdjSP[i].Text = "" + (ArbySPSelectors[i].Value + temp) + "/" + ArbyMaxSP[i];
                            }
                            else
                            {
                                ArbyAdjSP[i].Text = "" + ArbyMaxSP[i] + "/" + ArbyMaxSP[i];
                            }
                        }
                        else
                        {
                            ArbyAdjSP[i].Text = "0/" + ArbyMaxSP[i];
                        }
                    }
                }
            }
            catch(Exception exc)
            {

            }
            finally
            {

            }
        }

        private void Level_ValueChanged(object sender, EventArgs e)
        {
            int temp;

            try
            {
                temp = Int32.Parse(Level.Text);
                if(temp > 199 && temp < 300)
                {
                    if (temp <= 250)
                    {
                        SP = 593 + ((temp - 200) * 3);
                    }
                    else
                    {
                        SP = 743;
                    }
                    CurrentSP.Text = "" + (SP - (FortSP + LaiSP + EkaSP + ArbySP));
                }
            }
            catch(Exception exc)
            {

            }
            finally
            {

            }
        }

        private void Export_Clicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            StreamWriter fs;
            int i;

            //if save was selected
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new StreamWriter(saveFileDialog.FileName);
                    fs.WriteLine(AllSkill.Text);
                    fs.WriteLine(Level.Text);
                    for (i = 0; i < 17; i++)
                    {
                        fs.WriteLine(FortSPSelectors[i].Value.ToString());
                        fs.WriteLine(LaiSPSelectors[i].Value.ToString());
                        fs.WriteLine(EkaSPSelectors[i].Value.ToString());
                        fs.WriteLine(ArbySPSelectors[i].Value.ToString());
                    }
                    fs.WriteLine(EkaSPSelectors[i].Value.ToString());
                    fs.WriteLine(ArbySPSelectors[i].Value.ToString());
                    fs.Close();
                }
                catch(Exception exc)
                {

                }
                finally
                {

                }
            }
        }

        private void Import_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            StreamReader fs;
            int i;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new StreamReader(openFileDialog.FileName);
                    AllSkill.Text = fs.ReadLine().Trim();
                    Level.Text = fs.ReadLine().Trim();
                    for(i = 0; i < 17; i++)
                    {
                        FortSPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                        LaiSPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                        EkaSPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                        ArbySPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                    }
                    EkaSPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                    ArbySPSelectors[i].Value = Int32.Parse(fs.ReadLine().Trim());
                    fs.Close();
                }
                catch(Exception exc)
                {

                }
                finally
                {

                }
            }
        }

        private void AdjustInvestmnts()
        {
            int i;
            FortSP = 0;
            LaiSP = 0;
            EkaSP = 0;
            ArbySP = 0;

            ResetSelectors();
            for (i = 0; i < 17; i++)
            {
                try
                {
                    FortSP += (int)FortSPSelectors[i].Value;
                    if (FortSP >= FortInvestmentReq[i + 1])
                    {
                        FortSPSelectors[i + 1].Enabled = true;
                    }
                }
                catch(Exception exc)
                {

                }
                finally
                {

                }
                try
                {
                    LaiSP += (int)LaiSPSelectors[i].Value;
                    if (LaiSP >= LaiInvestmentReq[i + 1])
                    {
                        LaiSPSelectors[i + 1].Enabled = true;
                    }
                }
                catch (Exception exc)
                {

                }
                finally
                {

                }
                try
                {
                    EkaSP += (int)EkaSPSelectors[i].Value;
                    if (EkaSP >= EkaInvestmentReq[i + 1])
                    {
                        EkaSPSelectors[i + 1].Enabled = true;
                    }
                }
                catch (Exception exc)
                {

                }
                finally
                {

                }
                try
                {
                    ArbySP += (int)ArbySPSelectors[i].Value;
                    if (ArbySP >= ArbyInvestmentReq[i + 1])
                    {
                        ArbySPSelectors[i + 1].Enabled = true;
                    }
                }
                catch (Exception exc)
                {

                }
                finally
                {

                }
            }
        }

        private void ResetSelectors()
        {
            int i;

            for(i = 1; i < 17; i++)
            {
                FortSPSelectors[i].Enabled = false;
                LaiSPSelectors[i].Enabled = false;
                EkaSPSelectors[i].Enabled = false;
                ArbySPSelectors[i].Enabled = false;
            }
            EkaSPSelectors[i].Enabled = false;
            ArbySPSelectors[i].Enabled = false;
            EkaSPSelectors[1].Enabled = true;
            ArbySPSelectors[1].Enabled = true;
        }

        private void AdjustSP()
        {
            int temp;

            try
            {
                temp = Int32.Parse(Level.Text);
                if (temp > 199 && temp < 300)
                {
                    SP = 593 + ((temp - 200) * 3);
                    CurrentSP.Text = "" + (SP - (FortSP + LaiSP + EkaSP + ArbySP));
                }
            }
            catch (Exception exc)
            {

            }
            finally
            {

            }
        }
    }
}
