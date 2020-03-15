using System;
using System.Windows.Forms;

namespace WinFormsObjectListBinding
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ObjectBindingDisplayMember();
            this.ObjectBindingOverrideToString();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((City)this.listBox1.SelectedItem).Country);
        }

        #endregion

        #region Methods

        private void ObjectBindingDisplayMember()
        {
            City[] cityChoices = {new City("Seattle", "U.S.A."),
                                  new City("New York", "U.S.A."),
                                  new City("Tokyo", "Japan"),
                                  new City("Montreal", "Canada")};

            this.listBox1.DataSource = cityChoices;
            this.listBox1.DisplayMember = "Name";
        }

        private void ObjectBindingOverrideToString()
        {
            City[] cityChoices = {new City("Seattle", "U.S.A."),
                                  new City("New York", "U.S.A."),
                                  new City("Tokyo", "Japan"),
                                  new City("Montreal", "Canada")};

            this.listBox2.DataSource = cityChoices;
        }

        #endregion
    }
}
