using ProjectCatalogFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectCatalogFormsApp.Services
{
    public class MovieService
    {
        /// <summary>
        /// Retrieves all movies from the database.
        /// </summary>
        /// <returns>List of all movies.</returns>
        public List<Movie> GetAllMovies()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Movie> movies = catalogContext.Movies.ToList();
                return movies;
            }
        }

        /// <summary>
        /// Retrieves all directors from the database.
        /// </summary>
        /// <returns>List of all directors.</returns>
        public List<Director> GetAllDirectors()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Director> directors = catalogContext.Directors.ToList();
                return directors;
            }
        }

        /// <summary>
        /// Retrieves all genres from the database.
        /// </summary>
        /// <returns>List of all genres.</returns>
        public List<Genre> GetAllGenres()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Genre> genres = catalogContext.Genres.ToList();
                return genres;
            }
        }

        /// <summary>
        /// Filters and returns movies by the specified genre name.
        /// </summary>
        /// <param name="genreName">The name of the genre to filter by.</param>
        /// <returns>List of movies in the specified genre.</returns>
        public List<Movie> FilterMoviesByGenre(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Movies.Include(m => m.Genre).Where(m => m.Genre.GenreName == genreName).ToList();
                return genre;
            }
        }

        /// <summary>
        /// Deletes a movie from the database by its title.
        /// </summary>
        /// <param name="movieTitle">The title of the movie to delete.</param>
        /// <returns>True if the movie was deleted; otherwise, false.</returns>
        public bool DeleteMovieByName(string movieTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie != null)
                {
                    catalogContext.Movies.Remove(movie);
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Retrieves a movie by its title.
        /// </summary>
        /// <param name="movieTitle">The title of the movie to retrieve.</param>
        /// <returns>The movie with the specified title, or null if not found.</returns>
        public Movie GetMovieByName(string movieTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie != null)
                {
                    return movie;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Inserts a new movie into the database.
        /// </summary>
        /// <returns>True if the movie was inserted; false if it already exists.</returns>
        public bool InsertMovie(string title, int directorId, int genreId, string description, string review, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var existingMovie = catalogContext.Movies.FirstOrDefault(m => m.Title == title);
                if (existingMovie != null)
                {
                    return false;
                }
                var newMovie = new Movie
                {
                    Title = title,
                    DirectorId = directorId,
                    GenreId = genreId,
                    Description = description,
                    Review = review,
                    Rating = rating
                };
                catalogContext.Movies.Add(newMovie);
                catalogContext.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Updates an existing movie with new information.
        /// </summary>
        /// <returns>True if the movie was updated; false if not found.</returns>
        public bool UpdateMovie(string title, int directorId, int genreId, string description, string review, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var existingMovie = catalogContext.Movies.FirstOrDefault(m => m.Title == title);
                if (existingMovie == null)
                {
                    return false;
                }
                existingMovie.DirectorId = directorId;
                existingMovie.GenreId = genreId;
                existingMovie.Description = description;
                existingMovie.Review = review;
                existingMovie.Rating = rating;

                catalogContext.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Retrieves the ID of a director based on first and last name.
        /// </summary>
        /// <returns>The ID of the matching director.</returns>
        public int GetDirectorId(string firstName, string lastName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var director = catalogContext.Directors
                    .FirstOrDefault(d => d.FirstName == firstName && d.LastName == lastName);
                return director.Id;
            }
        }

        /// <summary>
        /// Retrieves the full name of a director by their ID.
        /// </summary>
        /// <returns>Full name of the director as a string.</returns>
        public string GetDirectorName(int directorId)
        {
            using (var catalogContext = new CatalogContext())
            {
                var director = catalogContext.Directors
                    .FirstOrDefault(d => d.Id == directorId);

                return $"{director.FirstName} {director.LastName}";
            }
        }

        /// <summary>
        /// Retrieves the ID of a genre by its name.
        /// </summary>
        /// <returns>ID of the matching genre.</returns>
        public int GetGenreId(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Genres
                    .FirstOrDefault(g => g.GenreName == genreName);

                return genre.Id;
            }
        }

        /// <summary>
        /// Retrieves the name of a genre by its ID.
        /// </summary>
        /// <returns>The genre name as a string.</returns>
        public string GetGenreName(int genreId)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Genres
                    .FirstOrDefault(g => g.Id == genreId);

                return genre.GenreName;
            }
        }

        /// <summary>
        /// Adds a review to a movie if it does not already have one.
        /// </summary>
        /// <returns>True if the review was added; false otherwise.</returns>
        public bool InsertMovieReview(string movieTitle, string review)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie.Review == null)
                {
                    movie.Review = review;
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Adds a rating to a movie if it does not already have one.
        /// </summary>
        /// <returns>True if the rating was added; false otherwise.</returns>
        public bool InsertMovieRating(string movieTitle, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie.Rating == null)
                {
                    movie.Rating = rating;
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Searches movies whose descriptions match any of the given keywords.
        /// </summary>
        /// <returns>List of movies with descriptions matching the keywords.</returns>
        public List<Movie> MatchMovieByDescription(string description)
        {
            using (var catalogContext = new CatalogContext())
            {
                var lowerDescription = description.ToLower();
                var keywords = lowerDescription.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var movies = catalogContext.Movies
                    .AsEnumerable()
                    .Where(m => m.Description != null &&
                                keywords.Any(kw => m.Description.ToLower().Contains(kw)))
                    .ToList();

                return movies;
            }
        }

        /// <summary>
        /// Retrieves all movies sorted alphabetically by title.
        /// </summary>
        /// <returns>List of movies sorted alphabetically.</returns>
        public List<Movie> GetMoviesAlphabetically()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Movie> movies = catalogContext.Movies
                    .OrderBy(m => m.Title)
                    .ToList();
                return movies;
            }
        }
    }
}
