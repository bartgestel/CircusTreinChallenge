namespace CircusTreinChallenge
{
    public partial class Main : Form
    {

        CircusTrein trein = new CircusTrein();
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxAnimalName.Text;
                int size = 1;
                bool diet;
                if (cbxSize.SelectedItem == null || cbxDiet.SelectedItem == null)
                {
                    throw new Exception("Please fill in all fields");
                }
                else
                {
                    if (cbxDiet.SelectedItem.ToString() == "Carnivore")
                    {
                        diet = true;
                    }
                    else
                    {
                        diet = false;
                    }
                    switch (cbxSize.SelectedItem.ToString())
                    {
                        case "Small":
                            size = 1;
                            break;
                        case "Medium":
                            size = 3;
                            break;
                        case "Large":
                            size = 5;
                            break;
                    }

                    Animals animal = new Animals(name, size, diet);
                    trein.AddAnimal(animal);
                    lbxAnimals.Items.Clear();
                    foreach (Animals a in trein.Animals)
                    {
                        lbxAnimals.Items.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            trein.SortAnimals();
            lblTrainSize.Text = trein.Carts.Count.ToString();
        }

        #region Scenarios
        private void btnScen1_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            trein.Animals.Clear();
            Animals animal1 = new Animals("1", 1, true);
            Animals animal2 = new Animals("2", 5, false);
            Animals animal3 = new Animals("3", 5, false);
            Animals animal4 = new Animals("4", 3, false);
            Animals animal5 = new Animals("5", 3, false);
            Animals animal6 = new Animals("6", 3, false);

            foreach (Animals a in new List<Animals> { animal1, animal2, animal3, animal4, animal5, animal6 })
            {
                trein.AddAnimal(a);
                lbxAnimals.Items.Add(a);
            }

        }

        private void btnScen2_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            trein.Animals.Clear();
            Animals animal1 = new Animals("1", 1, true);
            Animals animal2 = new Animals("2", 5, false);
            Animals animal3 = new Animals("3", 3, false);
            Animals animal4 = new Animals("4", 3, false);
            Animals animal5 = new Animals("5", 1, false);
            Animals animal6 = new Animals("6", 1, false);
            Animals animal7 = new Animals("7", 1, false);
            Animals animal8 = new Animals("8", 1, false);
            Animals animal9 = new Animals("9", 1, false);

            foreach (Animals a in new List<Animals> { animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9 })
            {
                trein.AddAnimal(a);
                lbxAnimals.Items.Add(a);
            }
        }

        private void btnScen3_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            trein.Animals.Clear();
            Animals animal1 = new Animals("1", 1, true);
            Animals animal2 = new Animals("2", 3, true);
            Animals animal3 = new Animals("3", 5, true);
            Animals animal4 = new Animals("4", 5, false);
            Animals animal5 = new Animals("5", 3, false);
            Animals animal6 = new Animals("6", 1, false);

            foreach(Animals a in new List<Animals> { animal1, animal2, animal3, animal4, animal5, animal6 })
            {
                trein.AddAnimal(a);
                lbxAnimals.Items.Add(a);
            }
        }

        private void btnScen4_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            trein.Animals.Clear();
            Animals animal1 = new Animals("1", 5, true);
            Animals animal2 = new Animals("2", 5, true);
            Animals animal3 = new Animals("3", 3, true);
            Animals animal4 = new Animals("4", 1, true);
            Animals animal5 = new Animals("5", 5, false);
            Animals animal6 = new Animals("6", 3, false);
            Animals animal7 = new Animals("7", 3, false);
            Animals animal8 = new Animals("8", 3, false);
            Animals animal9 = new Animals("9", 3, false);
            Animals animal10 = new Animals("10", 3, false);
            Animals animal11 = new Animals("11", 1, false);

            foreach (Animals a in new List<Animals> { animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11 })
            {
                trein.AddAnimal(a);
                lbxAnimals.Items.Add(a);
            }
        }

        private void btnScen5_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            trein.Animals.Clear();

            Animals animal1 = new Animals("1", 1, true);
            Animals animal2 = new Animals("2", 5, false);
            Animals animal3 = new Animals("3", 5, false);
            Animals animal4 = new Animals("4", 3, false);
            Animals animal5 = new Animals("5", 1, false);

            foreach (Animals a in new List<Animals> { animal1, animal2, animal3, animal4, animal5 })
            {
                trein.AddAnimal(a);
                lbxAnimals.Items.Add(a);
            }
        }
        #endregion
    }
}
