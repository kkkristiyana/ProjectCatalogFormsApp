using ProjectCatalogFormsApp.Services;
using ProjectCatalogFormsApp.Models;

namespace ProjectCatalogFormsApp
{
    public partial class Catalog : Form
    {
        private MovieService movieService = new MovieService();
        public Catalog()
        {
            InitializeComponent();
            LoadMovies();
            LoadDirectors();
            LoadGenres();
            LoadRatings();
            LoadMoviesWithoutRatingAndReview();
        }
        private void LoadMovies()
        {
            List<Movie> movies = movieService.GetAllMovies();

            updateMoviecomboBox1.Items.Clear();

            foreach (Movie movie in movies)
            {
                updateMoviecomboBox1.Items.Add(movie.Title);
                deleteMoviecomboBox1.Items.Add(movie.Title);
                opinionMoviecomboBox1.Items.Add(movie.Title);
            }

            if (updateMoviecomboBox1.Items.Count > 0)
            {
                updateMoviecomboBox1.SelectedIndex = 0;
            }
            if (deleteMoviecomboBox1.Items.Count > 0)
            {
                deleteMoviecomboBox1.SelectedIndex = 0;
            }
            if (opinionMoviecomboBox1.Items.Count > 0)
            {
                opinionMoviecomboBox1.SelectedIndex = 0;
            }

        }
        private void LoadMoviesWithoutRatingAndReview()
        {
            List<Movie> movies = movieService.GetAllMovies();

            opinionMoviecomboBox1.Items.Clear();

            foreach (Movie movie in movies)
            {
                if (movie.Rating == null && movie.Review == null)
                {
                    opinionMoviecomboBox1.Items.Add(movie.Title);
                }                
            }
            if (opinionMoviecomboBox1.Items.Count > 0)
            {
                opinionMoviecomboBox1.SelectedIndex = 0;
            }
        }
        private void LoadDirectors()
        {
            List<Director> directors = movieService.GetAllDirectors();

            directorComboBox.Items.Clear();
            foreach (Director director in directors)
            {
                directorComboBox.Items.Add($"{director.FirstName} {director.LastName}");
                updateDirectorcomboBox2.Items.Add($"{director.FirstName} {director.LastName}");
            }

            if (directorComboBox.Items.Count > 0)
            {
                directorComboBox.SelectedIndex = 0;
            }
            if (updateDirectorcomboBox2.Items.Count > 0)
            {
                updateDirectorcomboBox2.SelectedIndex = 0;
            }

        }
        private void LoadGenres()
        {
            List<Genre> genres = movieService.GetAllGenres();

            genreComboBox.Items.Clear();
            foreach (Genre genre in genres)
            {
                genreComboBox.Items.Add(genre.GenreName);
                genreUpdatecomboBox3.Items.Add(genre.GenreName);
            }

            if (genreComboBox.Items.Count > 0)
            {
                genreComboBox.SelectedIndex = 0;
            }
            if (genreUpdatecomboBox3.Items.Count > 0)
            {
                genreUpdatecomboBox3.SelectedIndex = 0;
            }
        }
        private void LoadRatings()
        {
            ratingComboBox.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                ratingComboBox.Items.Add(i);
                updateRatingcomboBox4.Items.Add(i);
                opinionAddRatingcomboBox2.Items.Add(i);
            }

            ratingComboBox.SelectedIndex = 0;
            updateRatingcomboBox4.SelectedIndex = 0;
            opinionAddRatingcomboBox2.SelectedIndex = 0;
        }

        private void addMoviebutton_Click(object sender, EventArgs e)
        {
            string title = titleBoxtextBox1.Text;

            string directorFullName = directorComboBox.SelectedItem.ToString();
            string[] fullNameSeparated = directorFullName.Split(' ');
            string firstName = fullNameSeparated[0];
            string lastName = fullNameSeparated[1];
            int directorId = movieService.GetDirectorId(firstName, lastName);

            string genreName = genreComboBox.SelectedItem.ToString();
            int genreId = movieService.GetGenreId(genreName);

            string description = descriptionRichTextBox.Text;
            string review = reviewRichTextBox.Text;
            int rating = int.Parse(ratingComboBox.SelectedItem.ToString());

            if (movieService.InsertMovie(title, directorId, genreId, description, review, rating) == true)
            {
                MessageBox.Show("Successfully added!");
            }
            else
            {
                MessageBox.Show("Successfully NOT added!!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string title = updateMoviecomboBox1.SelectedItem.ToString();

            string directorFullName = updateDirectorcomboBox2.SelectedItem.ToString();
            string[] fullNameSeparated = directorFullName.Split(' ');
            string firstName = fullNameSeparated[0];
            string lastName = fullNameSeparated[1];
            int directorId = movieService.GetDirectorId(firstName, lastName);

            string genreName = genreUpdatecomboBox3.SelectedItem.ToString();
            int genreId = movieService.GetGenreId(genreName);

            string description = updateDescriptionrichTextBox1.Text;
            string review = updateReviewrichTextBox2.Text;

            int rating = int.Parse(updateRatingcomboBox4.SelectedItem.ToString());

            if (movieService.UpdateMovie(title, directorId, genreId, description, review, rating) == true)
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Successfully NOT updated!!");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string title = deleteMoviecomboBox1.SelectedItem.ToString();
            if (movieService.DeleteMovieByName(title) == true)
            {
                MessageBox.Show("Successfully deleted!");
            }
            else
            {
                MessageBox.Show("Successfully NOT deleted!!");
            }

        }

        private void opinionAddReviewbutton_Click(object sender, EventArgs e)
        {
            string title = opinionMoviecomboBox1.SelectedItem.ToString();
            string review = opinionAddReviewrichTextBox1.Text;
            if (movieService.InsertMovieReview(title, review) == true)
            {
                MessageBox.Show("Successfully review added!");
            }
            else
            {
                MessageBox.Show("Successfully review NOT added!");
            }
        }

        private void opinionAddRatingbutton_Click(object sender, EventArgs e)
        {
            string title = opinionMoviecomboBox1.SelectedItem.ToString();
            int rating = int.Parse(opinionAddRatingcomboBox2.SelectedItem.ToString());
            if (movieService.InsertMovieRating(title, rating) == true)
            {
                MessageBox.Show("Successfully rating added!");
            }
            else
            {
                MessageBox.Show("Successfully rating NOT added!");
            }
        }

        private void sortbutton1_Click(object sender, EventArgs e)
        {
            List<Movie> movies = movieService.GetMoviesAlphabetically();
            sortlistBox1.Items.Clear();
            foreach (Movie movie in movies)
            {
                sortlistBox1.Items.Add(movie.Title);
            }
        }

        private void searchMoviebutton1_Click(object sender, EventArgs e)
        {
            searchMovielistBox1.Items.Clear();
            string description = searchRichTextBox1.Text;
            List<Movie> movies = movieService.MatchMovieByDescription(description);
            foreach (Movie movie in movies)
            {
                searchMovielistBox1.Items.Add(movie.Title);
            }
        }

        private void printAllMoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovieInfolistBox1.Items.Clear();
            string movieTitle = printAllMoviesList.SelectedItem.ToString();
            Movie movie = movieService.GetMovieByName(movieTitle);
            selectedMovieInfolistBox1.Items.Add(movieService.GetGenreName(movie.GenreId.Value));
            selectedMovieInfolistBox1.Items.Add(movieService.GetDirectorName(movie.DirectorId.Value));
            selectedMovieInfolistBox1.Items.Add(movie.Description);
            selectedMovieInfolistBox1.Items.Add(movie.Review);
            selectedMovieInfolistBox1.Items.Add(movie.Rating);
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            List<Movie> movies = movieService.GetAllMovies();
            printAllMoviesList.Items.Clear();
            foreach (Movie movie in movies)
            {
                printAllMoviesList.Items.Add(movie.Title);
            }
        }

        private void updateMoviecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMovieInfoUpdatelistBox1.Items.Clear();
            string movieTitle = updateMoviecomboBox1.SelectedItem.ToString();
            Movie movie = movieService.GetMovieByName(movieTitle);
            showMovieInfoUpdatelistBox1.Items.Add(movieService.GetGenreName(movie.GenreId.Value));
            showMovieInfoUpdatelistBox1.Items.Add(movieService.GetDirectorName(movie.DirectorId.Value));
            showMovieInfoUpdatelistBox1.Items.Add(movie.Description);
            showMovieInfoUpdatelistBox1.Items.Add(movie.Review);
            showMovieInfoUpdatelistBox1.Items.Add(movie.Rating);
        }
    }
}
