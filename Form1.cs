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

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //block Form resizing
            this.MaximizeBox = false; 
            this.MinimizeBox = false;
        }

        string password;
        string specialChar = "@#$!"; // <= Special char used in the password can be customized

        List<char> listChar = new List<char>();

        Random random = new Random();

        private void Form_Load(object sender, EventArgs e)
        {
            //trackBar settings, can be customized
            trackBar_nbChar.Maximum = 15; //maximum number of char included in your password
            trackBar_nbChar.Minimum = 5; //minimum number of char included in your password

            textBox_PasswordDisplay.Text = passwordGeneration();
            label_nbChar.Text = trackBar_nbChar.Value.ToString();
        }

        private char randomCharGeneration() //function used to generate a random character
        {
            char randomChar;
            int randomNumber;

            randomNumber = random.Next(0, 62 + specialChar.Length); )

            if (randomNumber < 10)
            {
                randomChar = (char)('0' + randomNumber);

            }
            else if (randomNumber < 36)
            {
                randomChar = (char)('A' + randomNumber - 10); 
            }
            else if (randomNumber < 62)
            {
                randomChar = (char)('a' + randomNumber - 36); 
            }
            else
            {
                randomChar = specialChar[randomNumber - 62];
            }

            return randomChar;
        }

        private string passwordGeneration() //function used to generate a random password by adding the number of char wanted in a List <char>
        {
            listChar.Clear(); //Clear the List before generating

            for (int i = 0; i < trackBar_nbChar.Value; i++)
            {
                listChar.Add(randomCharGeneration());
            }
             
            password = string.Join("", listChar); //concatenate all the char of the List

            return password;
        }

        private void trackBar_nbChar_Scroll(object sender, EventArgs e) //Event to catch the value of the trackBar at each move
        {
            textBox_PasswordDisplay.Text = passwordGeneration();
            label_nbChar.Text = trackBar_nbChar.Value.ToString(); 
        }

        private void button_copyPassword_Click(object sender, EventArgs e) //Copy into clipboard Method
        {
            System.Windows.Forms.Clipboard.SetText(textBox_PasswordDisplay.Text);
        }

        private void trackBar_nbChar_MouseDown(object sender, MouseEventArgs e) //Event to regenerate a password by just clicking on the trackBar cursor
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox_PasswordDisplay.Text = passwordGeneration();
                label_nbChar.Text = trackBar_nbChar.Value.ToString();
            }
        }
    }
}
