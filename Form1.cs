using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form : System.Windows.Forms.Form  
    {
        public Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        string password;
        string specialChar = "@#$!"; 

        List<char> listChar = new List<char>();

        Random random = new Random();

        private void Form_Load(object sender, EventArgs e)
        {
            //Nombre de valeurs possible utilisée par le trackbar
            trackBar_nbChar.Maximum = 15;
            trackBar_nbChar.Minimum = 5;

            textBox_PasswordDisplay.Text = passwordGeneration();
            label_nbChar.Text = trackBar_nbChar.Value.ToString();
        }

        private char randomCharGeneration()
        {
            char randomChar;
            int randomNumber;

            randomNumber = random.Next(0, 62 + specialChar.Length); // 26 minuscules + 26 majuscules + 9 chiffres + nombre de caractères spéciaux (4 ici)

            if (randomNumber < 10)
            {
                randomChar = (char)('0' + randomNumber);

            }
            else if (randomNumber < 36)
            {
                randomChar = (char)('A' + randomNumber - 10); // -10 pour qu'on a un nb aléatoire entre 1 et 26 pour toutes les lettres de l'alphabet 36 - 10 = 26 lettres
            }
            else if (randomNumber < 62)
            {
                randomChar = (char)('a' + randomNumber - 36); // même principe ici 62 - 36 = 26
            }
            else
            {
                randomChar = specialChar[randomNumber - 62];
            }

            return randomChar;
        }

        private string passwordGeneration()
        {
            listChar.Clear(); //vider la List avant génération

            for (int i = 0; i < trackBar_nbChar.Value; i++)
            {
                listChar.Add(randomCharGeneration());
            }
             
            password = string.Join("", listChar); //assemblage de tout les caractères de la List

            return password;
        }

        private void trackBar_nbChar_Scroll(object sender, EventArgs e) //Event pour récupérer la valeur de de la trackbar à chaque changement de valeurs
        {
            textBox_PasswordDisplay.Text = passwordGeneration();
            label_nbChar.Text = trackBar_nbChar.Value.ToString();
            
            /* 
             foreach (char c in listChar) //TEST dump de la liste dans la console
             {
                 Console.WriteLine(c);
             }
             Console.WriteLine("----------------");//TEST sépare le contenu du dump
             */
        }

        private void button_copyPassword_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox_PasswordDisplay.Text);
        }

        private void trackBar_nbChar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox_PasswordDisplay.Text = passwordGeneration();
                label_nbChar.Text = trackBar_nbChar.Value.ToString();
            }
        }
    }
}
