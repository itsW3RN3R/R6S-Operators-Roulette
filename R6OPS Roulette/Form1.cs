using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6OPS_Roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List Of All Operators in The Game 
        string DefaultOP = "Recruit";

        
        string[] Atts = { "Twitch" , "Nokk" , "Gridlock" , "Amaru" , "Kali", "Iana" , "Maverick" ,
                            "Thatcher" , "Blitz" , "Dokkaebi" , "Flores" , "Fuze" , "BlackBeard" , "Montagne" ,
                               "Sledge" , "Ying" , "IQ" , "Lion" , "Ace" , "Capitao" , "Sens" , "Jackal" , "Ash",
                                  "Glaz" , "Thermite" , "Buck" , "Finka" , "Zero" , "Zofia" , "Hibana" , "Osa" , 
                                    "Nomad" };

        string[] Defn = { "Smoke" , "Mute" , "Castle" , "Pulse" , "Doc" , "Rook" , "Tachanka" , "Kapkan" ,
                            "Jager" , "Bandit" , "Frost" , "Valkyrie" , "Caveira" , "Echo" , "Mira" , "Lesion" , "Ela" ,
                                "Vigil" , "Maestro" , "Alibi" ,  "Clash" , "Kaid" , "Mozzie" , "Warden" , "Goyo" , "Wamai",
                                    "Oryx" , "Melusi" , "Aruni" , "Thunderbird" , "Thorn" , "Azami" };

        // The reason This list small because These Ops Are Kinda Hard or so they say 
        string[] HardAtts = { "Montagne", "Fuze", "Glaz", "Blitz", "Dokkaebi", "Kali", "Osa" };
        string[] HardDefn = { "Smoke" , "Mute" , "Pulse" , "Tachanka" , "Caveira" , "Echo" , "Mira" , "Ela" ,
                              "Alibi" ,  "Clash" };
       
        private void btnRandom_Click(object sender, EventArgs e)
        {
            // This Piece of code to keep shuffling the lists And Pick A String Everytime button Randomize is clicked
            Random random = new Random();
            int funAtt = random.Next(Atts.Length);
            int funDef = random.Next(Defn.Length);
            int HardAtt = random.Next(HardAtts.Length);
            int HardDef = random.Next(HardDefn.Length);

            // if conditions For The Modes 
            if (cbMode.SelectedIndex is 0) 
            { 
                pbAtt.Image = Image.FromFile(@".\icons\" + Atts[funAtt]+".png");
                pbDeff.Image = Image.FromFile(@".\icons\" + Defn[funDef]+".png");
                lbAttName.Text = Atts[funAtt];
                lbDefName.Text = Defn[funDef];
            }
            
            
            else if (cbMode.SelectedIndex is 1)
            {
                pbAtt.Image = Image.FromFile(@".\icons\" + HardAtts[HardAtt] + ".png");
                pbDeff.Image = Image.FromFile(@".\icons\" + HardDefn[HardDef] + ".png");
                lbAttName.Text = HardAtts[HardAtt];
                lbDefName.Text = HardDefn[HardDef];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets everything to default when app loads 
            pbAtt.Image = Image.FromFile(@".\icons\" + DefaultOP + ".png");
            pbDeff.Image = Image.FromFile(@".\icons\" + DefaultOP + ".png");
            lbAttName.Text = DefaultOP;
            lbDefName.Text = DefaultOP;
            cbMode.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // This To Roll Attackers Only Or Vice Versa
        Random random = new Random();
        private void btnRollAtt_Click(object sender, EventArgs e)
        {
            
            int funAtt = random.Next(Atts.Length);
            int HardAtt = random.Next(HardAtts.Length);
            if (cbMode.SelectedIndex == 0)
            {
                pbAtt.Image = Image.FromFile(@".\icons\" + Atts[funAtt] + ".png");
                lbAttName.Text = Atts[funAtt];
            }
            else if (cbMode.SelectedIndex == 1)
            {
                pbAtt.Image = Image.FromFile(@".\icons\" + HardAtts[HardAtt] + ".png");
                lbAttName.Text = HardAtts[HardAtt];
            }
        }

        private void btnRollDef_Click(object sender, EventArgs e)
        {
            int funDef = random.Next(Defn.Length);
            int HardDef = random.Next(HardDefn.Length);
            if (cbMode.SelectedIndex == 0)
            {
                pbDeff.Image = Image.FromFile(@".\icons\" + Defn[funDef] + ".png");
                lbDefName.Text = Defn[funDef];
            }
            else if (cbMode.SelectedIndex == 1)
            {
                pbDeff.Image = Image.FromFile(@".\icons\" + HardDefn[HardDef] + ".png");
                lbDefName.Text = HardDefn[HardDef];
            }
        }

        private void Picturebox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey there. \nI am the The Author of R6S Roulette if you like it and you want to check on some of " +
                "my future projects you can follow my Github Page or if you have an issue or a suggestion. \n\n Github :" + @" https://github.com/itsW3RN3R");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Discord Tag : .Werner.#6677");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Steam Profile let's be friends i could use some right now :D:D\n\n" +
               "https://steamcommunity.com/id/SGOUM/");
        }
    }
}
