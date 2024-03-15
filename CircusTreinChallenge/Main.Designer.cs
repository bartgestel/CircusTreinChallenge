namespace CircusTreinChallenge
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbxAnimals = new ListBox();
            gbxAddAnimal = new GroupBox();
            btnAddAnimal = new Button();
            lblSize = new Label();
            lblDiet = new Label();
            cbxSize = new ComboBox();
            lblAnimalName = new Label();
            cbxDiet = new ComboBox();
            tbxAnimalName = new TextBox();
            btnSort = new Button();
            lbxCarts = new ListBox();
            btnScen1 = new Button();
            btnScen2 = new Button();
            btnScen3 = new Button();
            btnScen4 = new Button();
            btnScen5 = new Button();
            lblTrainSize = new Label();
            gbxAddAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // lbxAnimals
            // 
            lbxAnimals.FormattingEnabled = true;
            lbxAnimals.Location = new Point(12, 12);
            lbxAnimals.Name = "lbxAnimals";
            lbxAnimals.Size = new Size(623, 184);
            lbxAnimals.TabIndex = 0;
            // 
            // gbxAddAnimal
            // 
            gbxAddAnimal.Controls.Add(btnAddAnimal);
            gbxAddAnimal.Controls.Add(lblSize);
            gbxAddAnimal.Controls.Add(lblDiet);
            gbxAddAnimal.Controls.Add(cbxSize);
            gbxAddAnimal.Controls.Add(lblAnimalName);
            gbxAddAnimal.Controls.Add(cbxDiet);
            gbxAddAnimal.Controls.Add(tbxAnimalName);
            gbxAddAnimal.Location = new Point(12, 202);
            gbxAddAnimal.Name = "gbxAddAnimal";
            gbxAddAnimal.Size = new Size(623, 100);
            gbxAddAnimal.TabIndex = 1;
            gbxAddAnimal.TabStop = false;
            gbxAddAnimal.Text = "Add Animal";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(486, 32);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(121, 52);
            btnAddAnimal.TabIndex = 3;
            btnAddAnimal.Text = "Add";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(315, 32);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size:";
            // 
            // lblDiet
            // 
            lblDiet.AutoSize = true;
            lblDiet.Location = new Point(149, 32);
            lblDiet.Name = "lblDiet";
            lblDiet.Size = new Size(40, 20);
            lblDiet.TabIndex = 2;
            lblDiet.Text = "Diet:";
            // 
            // cbxSize
            // 
            cbxSize.FormattingEnabled = true;
            cbxSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cbxSize.Location = new Point(316, 55);
            cbxSize.Name = "cbxSize";
            cbxSize.Size = new Size(151, 28);
            cbxSize.TabIndex = 1;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(6, 32);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(103, 20);
            lblAnimalName.TabIndex = 2;
            lblAnimalName.Text = "Animal Name:";
            // 
            // cbxDiet
            // 
            cbxDiet.FormattingEnabled = true;
            cbxDiet.Items.AddRange(new object[] { "Carnivore", "Herbivore" });
            cbxDiet.Location = new Point(149, 55);
            cbxDiet.Name = "cbxDiet";
            cbxDiet.Size = new Size(151, 28);
            cbxDiet.TabIndex = 1;
            // 
            // tbxAnimalName
            // 
            tbxAnimalName.Location = new Point(6, 55);
            tbxAnimalName.Name = "tbxAnimalName";
            tbxAnimalName.Size = new Size(125, 27);
            tbxAnimalName.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(12, 331);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(131, 72);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort Animals";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lbxCarts
            // 
            lbxCarts.FormattingEnabled = true;
            lbxCarts.Location = new Point(161, 339);
            lbxCarts.Name = "lbxCarts";
            lbxCarts.Size = new Size(474, 64);
            lbxCarts.TabIndex = 3;
            // 
            // btnScen1
            // 
            btnScen1.Location = new Point(653, 12);
            btnScen1.Name = "btnScen1";
            btnScen1.Size = new Size(136, 29);
            btnScen1.TabIndex = 4;
            btnScen1.Text = "Scenario 1";
            btnScen1.UseVisualStyleBackColor = true;
            btnScen1.Click += btnScen1_Click;
            // 
            // btnScen2
            // 
            btnScen2.Location = new Point(653, 47);
            btnScen2.Name = "btnScen2";
            btnScen2.Size = new Size(136, 29);
            btnScen2.TabIndex = 4;
            btnScen2.Text = "Scenario 2";
            btnScen2.UseVisualStyleBackColor = true;
            btnScen2.Click += btnScen2_Click;
            // 
            // btnScen3
            // 
            btnScen3.Location = new Point(653, 82);
            btnScen3.Name = "btnScen3";
            btnScen3.Size = new Size(136, 29);
            btnScen3.TabIndex = 4;
            btnScen3.Text = "Scenario 3";
            btnScen3.UseVisualStyleBackColor = true;
            btnScen3.Click += btnScen3_Click;
            // 
            // btnScen4
            // 
            btnScen4.Location = new Point(653, 117);
            btnScen4.Name = "btnScen4";
            btnScen4.Size = new Size(136, 29);
            btnScen4.TabIndex = 4;
            btnScen4.Text = "Scenario 4";
            btnScen4.UseVisualStyleBackColor = true;
            btnScen4.Click += btnScen4_Click;
            // 
            // btnScen5
            // 
            btnScen5.Location = new Point(653, 152);
            btnScen5.Name = "btnScen5";
            btnScen5.Size = new Size(136, 29);
            btnScen5.TabIndex = 4;
            btnScen5.Text = "Scenario 5";
            btnScen5.UseVisualStyleBackColor = true;
            btnScen5.Click += btnScen5_Click;
            // 
            // lblTrainSize
            // 
            lblTrainSize.AutoSize = true;
            lblTrainSize.Location = new Point(18, 406);
            lblTrainSize.Name = "lblTrainSize";
            lblTrainSize.Size = new Size(17, 20);
            lblTrainSize.TabIndex = 5;
            lblTrainSize.Text = "0";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(lblTrainSize);
            Controls.Add(btnScen5);
            Controls.Add(btnScen4);
            Controls.Add(btnScen3);
            Controls.Add(btnScen2);
            Controls.Add(btnScen1);
            Controls.Add(lbxCarts);
            Controls.Add(btnSort);
            Controls.Add(gbxAddAnimal);
            Controls.Add(lbxAnimals);
            Name = "Main";
            Text = "Form1";
            gbxAddAnimal.ResumeLayout(false);
            gbxAddAnimal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxAnimals;
        private GroupBox gbxAddAnimal;
        private TextBox tbxAnimalName;
        private ComboBox cbxDiet;
        private Label lblDiet;
        private Label lblAnimalName;
        private Label lblSize;
        private ComboBox cbxSize;
        private Button btnAddAnimal;
        private Button btnSort;
        private ListBox lbxCarts;
        private Button btnScen1;
        private Button btnScen2;
        private Button btnScen3;
        private Button btnScen4;
        private Button btnScen5;
        private Label lblTrainSize;
    }
}
