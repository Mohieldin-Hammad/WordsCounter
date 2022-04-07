namespace WordsCounter
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        public MyForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // A fter the first 5 seconds the header and the WLabel will disapear and the main view 
            // will be shown in the form

            System.Windows.Forms.Timer t_five = new System.Windows.Forms.Timer();
            t_five.Interval = 5000;
            t_five.Tick += new System.EventHandler(this.FiveSecTimer_Tick);
            t_five.Enabled = true;
            t_five.Start();
            

        }

        private void FiveSecTimer_Tick(object sender, EventArgs e)
        {
            // The objects that will be Enabled and disabled after the first five seconds
            HeaderLabel.Enabled = false;
            WLabel.Enabled = false;
            Typing_Label.Enabled = true;
            Typing_Label.Visible = true;
            TextBox.Enabled = true;
            TextBox.Visible = true;
            words_label.Visible = true;
            chars_label.Visible = true;
        }
        
        private void Typing_Label_Click(object sender, EventArgs e)
        {
            // if the user click the label "type anything" the program will check if it's first typing
            // Then it will start focus in the textbox
            if (TextBox.Text == first_msg) TextBox.Clear();
            TextBox.Focus();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            // if the user click the textbox "type anything" the program will check if it's first typing
            // Then it will start focus in the textbox
            if (TextBox.Text == first_msg) TextBox.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // after each typing or deleting the textbox will count the number of words and the number of characters
            string[] text_splited = TextBox.Text.Split();
            calc_count(text_splited);
            
        }

        
        private void calc_count(string[] txt)
        {
            // words and and chars counters have been identified in form1.Designer.cs
            words_counter = 0;
            chars_counter = 0;

            foreach(string s in txt)
            {
                // words_counter will be skiped if the character is one of the following {',', ';', '.', ':', '(', ')'}
                if (!checkingUncount(s)) words_counter++;
                foreach(char c in s)
                {
                    chars_counter++;
                }
            }
            // print the words and character counts that have been calculated 
            words_label.Text = "Words count: " + Convert.ToString(words_counter);
            chars_label.Text = "Characters count: " + Convert.ToString(chars_counter);

        }
        // checking if the string s (char or word) is matching char from the array not_counted in form1.Designer.cs
        private bool checkingUncount(string s)
        {
            if (s.Length != 1 && s != "") return false;
            foreach(char c in not_counted)
            {
                if (c.ToString() == s || s == "") return true;
            }
            return false;
        }
        /*
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exiting =  MessageBox.Show("You are closing the form!", "Exit", MessageBoxButtons.YesNo);
           
            if (exiting == DialogResult.Yes)
            {
                this.Close();
            }
            else if (exiting == DialogResult.No)
            {
                              
            }
        }
        */
    }
}