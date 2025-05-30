namespace ProjectCatalogFormsApp
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            printAllMoviesList = new ListBox();
            showAllMoviesButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            titleBoxtextBox1 = new TextBox();
            directorComboBox = new ComboBox();
            genreComboBox = new ComboBox();
            descriptionRichTextBox = new RichTextBox();
            reviewRichTextBox = new RichTextBox();
            ratingComboBox = new ComboBox();
            addMoviebutton = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            updateRatingcomboBox4 = new ComboBox();
            updateReviewrichTextBox2 = new RichTextBox();
            updateDescriptionrichTextBox1 = new RichTextBox();
            genreUpdatecomboBox3 = new ComboBox();
            updateDirectorcomboBox2 = new ComboBox();
            updateMoviecomboBox1 = new ComboBox();
            updateButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Font = new Font("Script MT Bold", 18F, FontStyle.Bold);
            tabControl1.Location = new Point(1, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1236, 691);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(showAllMoviesButton);
            tabPage1.Controls.Add(printAllMoviesList);
            tabPage1.Location = new Point(4, 55);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1228, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movies";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(addMoviebutton);
            tabPage2.Controls.Add(ratingComboBox);
            tabPage2.Controls.Add(reviewRichTextBox);
            tabPage2.Controls.Add(descriptionRichTextBox);
            tabPage2.Controls.Add(genreComboBox);
            tabPage2.Controls.Add(directorComboBox);
            tabPage2.Controls.Add(titleBoxtextBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 55);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1228, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(updateButton);
            tabPage3.Controls.Add(updateMoviecomboBox1);
            tabPage3.Controls.Add(updateRatingcomboBox4);
            tabPage3.Controls.Add(updateReviewrichTextBox2);
            tabPage3.Controls.Add(updateDescriptionrichTextBox1);
            tabPage3.Controls.Add(genreUpdatecomboBox3);
            tabPage3.Controls.Add(updateDirectorcomboBox2);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Location = new Point(4, 55);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1228, 632);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Location = new Point(4, 55);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1228, 632);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage5.Location = new Point(4, 55);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1228, 632);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Opinion";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage6.Location = new Point(4, 55);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1228, 632);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Sort";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = (Image)resources.GetObject("tabPage7.BackgroundImage");
            tabPage7.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage7.Location = new Point(4, 55);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1228, 632);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Search";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // printAllMoviesList
            // 
            printAllMoviesList.FormattingEnabled = true;
            printAllMoviesList.ItemHeight = 43;
            printAllMoviesList.Location = new Point(26, 24);
            printAllMoviesList.Name = "printAllMoviesList";
            printAllMoviesList.Size = new Size(662, 563);
            printAllMoviesList.TabIndex = 0;
            // 
            // showAllMoviesButton
            // 
            showAllMoviesButton.BackgroundImage = (Image)resources.GetObject("showAllMoviesButton.BackgroundImage");
            showAllMoviesButton.BackgroundImageLayout = ImageLayout.Stretch;
            showAllMoviesButton.Location = new Point(746, 483);
            showAllMoviesButton.Name = "showAllMoviesButton";
            showAllMoviesButton.Size = new Size(444, 104);
            showAllMoviesButton.TabIndex = 1;
            showAllMoviesButton.Text = "Show all";
            showAllMoviesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 188, 201);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(746, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 275);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 43);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(43, 129);
            label2.Name = "label2";
            label2.Size = new Size(227, 43);
            label2.TabIndex = 1;
            label2.Text = "Director name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 208);
            label3.Name = "label3";
            label3.Size = new Size(108, 43);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(43, 285);
            label4.Name = "label4";
            label4.Size = new Size(191, 43);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 411);
            label5.Name = "label5";
            label5.Size = new Size(133, 43);
            label5.TabIndex = 4;
            label5.Text = "Review:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(43, 537);
            label6.Name = "label6";
            label6.Size = new Size(130, 43);
            label6.TabIndex = 5;
            label6.Text = "Rating:";
            // 
            // titleBoxtextBox1
            // 
            titleBoxtextBox1.Location = new Point(199, 43);
            titleBoxtextBox1.Name = "titleBoxtextBox1";
            titleBoxtextBox1.Size = new Size(643, 51);
            titleBoxtextBox1.TabIndex = 6;
            // 
            // directorComboBox
            // 
            directorComboBox.FormattingEnabled = true;
            directorComboBox.Location = new Point(336, 126);
            directorComboBox.Name = "directorComboBox";
            directorComboBox.Size = new Size(506, 51);
            directorComboBox.TabIndex = 7;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(222, 205);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(620, 51);
            genreComboBox.TabIndex = 8;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(297, 270);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(545, 100);
            descriptionRichTextBox.TabIndex = 9;
            descriptionRichTextBox.Text = "";
            // 
            // reviewRichTextBox
            // 
            reviewRichTextBox.Location = new Point(242, 408);
            reviewRichTextBox.Name = "reviewRichTextBox";
            reviewRichTextBox.Size = new Size(600, 76);
            reviewRichTextBox.TabIndex = 10;
            reviewRichTextBox.Text = "";
            // 
            // ratingComboBox
            // 
            ratingComboBox.FormattingEnabled = true;
            ratingComboBox.Location = new Point(252, 534);
            ratingComboBox.Name = "ratingComboBox";
            ratingComboBox.Size = new Size(590, 51);
            ratingComboBox.TabIndex = 11;
            // 
            // addMoviebutton
            // 
            addMoviebutton.BackgroundImage = (Image)resources.GetObject("addMoviebutton.BackgroundImage");
            addMoviebutton.Location = new Point(943, 60);
            addMoviebutton.Name = "addMoviebutton";
            addMoviebutton.Size = new Size(223, 525);
            addMoviebutton.TabIndex = 12;
            addMoviebutton.Text = "Add movie";
            addMoviebutton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(53, 540);
            label7.Name = "label7";
            label7.Size = new Size(249, 43);
            label7.TabIndex = 11;
            label7.Text = "Pick new rating:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(54, 414);
            label8.Name = "label8";
            label8.Size = new Size(268, 43);
            label8.TabIndex = 10;
            label8.Text = "Write new review:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(53, 288);
            label9.Name = "label9";
            label9.Size = new Size(334, 43);
            label9.TabIndex = 9;
            label9.Text = "Write new description:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(54, 211);
            label10.Name = "label10";
            label10.Size = new Size(202, 43);
            label10.TabIndex = 8;
            label10.Text = "Pick a genre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(53, 132);
            label11.Name = "label11";
            label11.Size = new Size(325, 43);
            label11.TabIndex = 7;
            label11.Text = "Choose director name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(54, 49);
            label12.Name = "label12";
            label12.Size = new Size(215, 43);
            label12.TabIndex = 6;
            label12.Text = "Choose movie:";
            // 
            // updateRatingcomboBox4
            // 
            updateRatingcomboBox4.FormattingEnabled = true;
            updateRatingcomboBox4.Location = new Point(360, 537);
            updateRatingcomboBox4.Name = "updateRatingcomboBox4";
            updateRatingcomboBox4.Size = new Size(490, 51);
            updateRatingcomboBox4.TabIndex = 18;
            // 
            // updateReviewrichTextBox2
            // 
            updateReviewrichTextBox2.Location = new Point(381, 414);
            updateReviewrichTextBox2.Name = "updateReviewrichTextBox2";
            updateReviewrichTextBox2.Size = new Size(469, 93);
            updateReviewrichTextBox2.TabIndex = 17;
            updateReviewrichTextBox2.Text = "";
            // 
            // updateDescriptionrichTextBox1
            // 
            updateDescriptionrichTextBox1.Location = new Point(444, 276);
            updateDescriptionrichTextBox1.Name = "updateDescriptionrichTextBox1";
            updateDescriptionrichTextBox1.Size = new Size(406, 114);
            updateDescriptionrichTextBox1.TabIndex = 16;
            updateDescriptionrichTextBox1.Text = "";
            // 
            // genreUpdatecomboBox3
            // 
            genreUpdatecomboBox3.FormattingEnabled = true;
            genreUpdatecomboBox3.Location = new Point(324, 208);
            genreUpdatecomboBox3.Name = "genreUpdatecomboBox3";
            genreUpdatecomboBox3.Size = new Size(526, 51);
            genreUpdatecomboBox3.TabIndex = 15;
            // 
            // updateDirectorcomboBox2
            // 
            updateDirectorcomboBox2.FormattingEnabled = true;
            updateDirectorcomboBox2.Location = new Point(444, 129);
            updateDirectorcomboBox2.Name = "updateDirectorcomboBox2";
            updateDirectorcomboBox2.Size = new Size(406, 51);
            updateDirectorcomboBox2.TabIndex = 14;
            // 
            // updateMoviecomboBox1
            // 
            updateMoviecomboBox1.FormattingEnabled = true;
            updateMoviecomboBox1.Location = new Point(338, 46);
            updateMoviecomboBox1.Name = "updateMoviecomboBox1";
            updateMoviecomboBox1.Size = new Size(512, 51);
            updateMoviecomboBox1.TabIndex = 19;
            // 
            // updateButton
            // 
            updateButton.BackgroundImage = (Image)resources.GetObject("updateButton.BackgroundImage");
            updateButton.Location = new Point(933, 49);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(234, 534);
            updateButton.TabIndex = 20;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 679);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Catalog";
            Text = "Catalog";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Button showAllMoviesButton;
        private ListBox printAllMoviesList;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox reviewRichTextBox;
        private RichTextBox descriptionRichTextBox;
        private ComboBox genreComboBox;
        private ComboBox directorComboBox;
        private TextBox titleBoxtextBox1;
        private Button addMoviebutton;
        private ComboBox ratingComboBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox updateMoviecomboBox1;
        private ComboBox updateRatingcomboBox4;
        private RichTextBox updateReviewrichTextBox2;
        private RichTextBox updateDescriptionrichTextBox1;
        private ComboBox genreUpdatecomboBox3;
        private ComboBox updateDirectorcomboBox2;
        private Button updateButton;
    }
}
