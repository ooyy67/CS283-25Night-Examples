using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Examples02
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;

        public Form1()
        {
            InitializeComponent();
            pokemon = new Pokemon()
            {
                Name = "妙娃種子",
                CurrentHp = 60,
                Hp = 60,
                Weight = 5.94f,
                Types = new string[] { "草", "毒" },
                Height = 0.76f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };

            NameLabel.Text = pokemon.Name;
            Hplabel.Text = pokemon.CurrentHp.ToString() + "/" +
                pokemon.Hp + "HP";
            HeigthLabel.Text = pokemon.Height.ToString();
            TypesLabel.Text = pokemon.Types[0] + "/" + pokemon.Types
                [1];
            WeightLabel.Text = pokemon.Weight.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text =
                pokemon.PowerUpStardust.ToString();
            EvoleCandyLabel.Text = pokemon.EvolveCandy.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}